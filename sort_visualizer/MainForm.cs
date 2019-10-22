using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Diagnostics;

namespace sort_visualizer
{
    /// <summary>
    /// This partial class <c>MainForm</c> acts as the controller between the sorting model and the UI. 
    /// </summary>
    /// <value>Property <c>sorterModel</c> references the Sorter object that processes the sorting.</value>
    /// <value>Property <c>animationQueue</c> contains the sequence of <c>ArrayEventArgs</c> left to be processed and drawn.</value>
    /// <value>Property <c>currentImage</c> represents the current image to be drawn.</value>
    /// <value>Property <c>animationTimer</c> draws from the <c>animationQueue</c> on a set interval.</value>
    /// <value>Property <c>sortLock</c> prevents simultaneous sorting on the same array and keeps the sorting thread-safe.</value>
    /// <value>Property <c>queueLock</c> prevents simultaneous access on the animationQueue.</value>
    /// <value>Property <c>resettingSort</c> prevents threads from resetting the sort after it's already been reset.</value>
    /// <value>Property <c>defaultArraySize, defaultRangeMin, defaultRangeMax, maxSize, lowerBound, upperBound/c>
    /// all apply to the parameters for limits on array initialization.</value>
    /// <value>Property <c>timerInterval</c> is the base timer interval that is operated on when sliding the TrackBar for animation speed.</value>
    public partial class MainForm : Form
    {
        private Sorter sorterModel;
        private Queue<ArrayEventArgs> animationQueue;
        private Image currentImage;
        private System.Windows.Forms.Timer animationTimer;
        private object sortLock;
        private object queueLock;
        private bool resettingSort;
        private int defaultArraySize, defaultRangeMin, defaultRangeMax, maxSize, lowerBound, upperBound, timerInterval;
        private enum Sorts
        {
            Insertion,
            Bubble,
            Selection,
            Quick,
            Merge,
            Radix,
            Counting,
            Heap
        }
        public MainForm()
        {
            InitializeComponent();
            sorterModel = new Sorter();
            sorterModel.ArrayModified += this.OnArrayModified;

            animationTimer = new System.Windows.Forms.Timer();
            timerInterval = 150;
            animationTimer.Interval = timerInterval;
            animationTimer.Tick += new EventHandler(animationTimerTick);
            animationQueue = new Queue<ArrayEventArgs>();
            currentImage = new Bitmap(picBoxVisualizer.Width, picBoxVisualizer.Height);
            sortLock = new object();
            queueLock = new object();
            resettingSort = false;

            defaultArraySize = 50;
            defaultRangeMin = 50;
            defaultRangeMax = 200;
            maxSize = picBoxVisualizer.Width;
            lowerBound = 0;
            upperBound = picBoxVisualizer.Height;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            sorterModel.generateArray(defaultArraySize, defaultRangeMin, defaultRangeMax);
        }

        /// <summary>
        /// When the array is updated, enqueue the data for that update in <c>animationQueue</c>.
        /// </summary>
        /// <param name="src">Object that raised the event.</param>
        /// <param name="args">Contains the array to be drawn, and array indexes being compared.</param>
        public void OnArrayModified(object src, ArrayEventArgs args)
        {
            lock (queueLock)
            {
                animationQueue.Enqueue(args);
            }
        }

        /// <summary>
        /// On a timer tick, dequeue from <c>animationQueue</c> and update current image based on the <c>ArrayEventArgs</c>.
        /// Redraw <c>visualizerPicBox</c>.
        /// </summary>
        /// <param name="src">Object that raised the event.</param>
        /// <param name="args">Additional arguments with the event.</param>
        private void animationTimerTick(Object src, EventArgs args)
        {
            lock (queueLock)
            {
                if (animationQueue.Count > 0)
                {
                    ArrayEventArgs arrayArgs = animationQueue.Dequeue();

                    int[] arrayToDraw = arrayArgs.array;
                    Graphics visualizerGraphics = Graphics.FromImage(currentImage);
                    visualizerGraphics.Clear(Color.Empty);
                    int canvasWidth = currentImage.Width;
                    float barWidth = Math.Max(1, (float) canvasWidth / arrayToDraw.Length);
                    float offset = (canvasWidth - arrayToDraw.Length * barWidth) / 2;

                    Pen pen = new Pen(Color.White, barWidth);
                    for (int i = 0; i < arrayToDraw.Length; i++)
                    {
                        if (i == arrayArgs.currIndex)
                        {
                            pen.Color = Color.Red;
                        }
                        else if (i == arrayArgs.checkedIndex)
                        {
                            pen.Color = Color.Green;
                        }
                        else
                        {
                            pen.Color = Color.White;
                        }
                        visualizerGraphics.DrawLine(pen, offset + i * barWidth, currentImage.Height, offset + i * barWidth, currentImage.Height - arrayToDraw[i]);
                    }

                    visualizerGraphics.Dispose();
                    picBoxVisualizer.Refresh();
                }
            }
             
        }

        private void picBoxVisualizer_Paint(object sender, PaintEventArgs e)
        {
            Graphics picBoxGraphics = e.Graphics;
            picBoxGraphics.DrawImage(currentImage, new Point(0, 0));
        }

        /// <summary>
        /// Begins sorting with a specified method. First attempts to clear the sort, and if that succeeds, proceeds to begin sorting and places a
        /// lock on <c>sortLock</c>.
        /// </summary>
        /// <param name="sortMethod">The desired sorting method.</param>
        private async void runSort(Sorts sortMethod)
        {
            bool hasResetSort = await Task.Run(() =>
            {
                return resetSort();
            });

            if (hasResetSort)
            {
                if (!animationTimer.Enabled)
                {
                    animationTimer.Start();
                }
                await Task.Run(() =>
                {
                    lock (sortLock)
                    {
                        switch (sortMethod)
                        {
                            case Sorts.Insertion:
                                sorterModel.insertionSort();
                                break;
                            case Sorts.Bubble:
                                sorterModel.bubbleSort();
                                break;
                            case Sorts.Selection:
                                sorterModel.selectionSort();
                                break;
                            case Sorts.Quick:
                                sorterModel.quickSort();
                                break;
                            case Sorts.Merge:
                                sorterModel.mergeSort();
                                break;
                            case Sorts.Radix:
                                sorterModel.radixSort();
                                break;
                            case Sorts.Counting:
                                sorterModel.countingSort();
                                break;
                            case Sorts.Heap:
                                sorterModel.heapSort();
                                break;
                            default:
                                break; // Should never get here.
                        }
                    }
                });
            }
        }

        private void tkBarAnimationSpeed_Scroll(object sender, EventArgs e)
        {
            animationTimer.Interval = timerInterval / tkBarAnimationSpeed.Value;
        }

        private void btnQuickSort_Click(object sender, EventArgs e)
        {
            runSort(Sorts.Quick);
        }

        private void btnInsertionSort_Click(object sender, EventArgs e)
        {
            runSort(Sorts.Insertion);
        }

        private void btnMergeSort_Click(object sender, EventArgs e)
        {
            runSort(Sorts.Merge);
        }

        private void btnBubbleSort_Click(object sender, EventArgs e)
        {
            runSort(Sorts.Bubble);
        }

        private void btnSelectionSort_Click(object sender, EventArgs e)
        {
            runSort(Sorts.Selection);
        }

        private void btnRadixSort_Click(object sender, EventArgs e)
        {
            runSort(Sorts.Radix);
        }

        private void btnHeapSort_Click(object sender, EventArgs e)
        {
            runSort(Sorts.Heap);
        }

        private void btnCountingSort_Click(object sender, EventArgs e)
        {
            runSort(Sorts.Counting);
        }

        /// <summary>
        /// Removes all images from <c>animationQueue</c> and resets the array. Will wait for sorting to finish before doing so, and
        /// will stop sorting while it is resetting. Only one reset will be run at a time.
        /// </summary>
        /// <returns>Returns true if successfully reset the array and false otherwise.</returns>
        private bool resetSort()
        {
            // Only reset if there isn't a reset already happening.
            if (!resettingSort)
            {
                resettingSort = true;
                // Wait for sorting to finish before proceeding and block all sort attempts while resetting.
                lock (sortLock)
                {
                    lock (queueLock)
                    {
                        while (animationQueue.Count > 0)
                        {
                            animationQueue.Dequeue();
                        }
                    }
                    sorterModel.resetArray();
                    resettingSort = false;
                }
                return true;
            } else
            {
                return false;
            }
        }

        private void txtBoxArraySize_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtBoxMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtBoxMax_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnSetupArray_Click(object sender, EventArgs e)
        {
            lblArrayError.Visible = false;
            lblRangeError.Visible = false;

            int arraySize = parseInt(txtBoxArraySize.Text);
            int rangeMin = parseInt(txtBoxMin.Text);
            int rangeMax = parseInt(txtBoxMax.Text);

            // If txtBoxArraySize has no contents, set arraySize to default value.
            arraySize = arraySize == -1 ? defaultArraySize : arraySize;

            // If neither of txtBoxMin and txtBoxMax have contents, set them to their default values.
            if (rangeMin == -1 && rangeMax == -1)
            {
                rangeMin = defaultRangeMin;
                rangeMax = defaultRangeMax;
            }

            // Show all needed error messages.
            lblArrayError.Text = "Max Value: " + maxSize;
            lblArrayError.Visible = arraySize > maxSize;
            
            if (rangeMin >= rangeMax)
            {
                lblRangeError.Text = "Min must be less than Max.";
                lblRangeError.Visible = true;
            } else if (rangeMin == -1 ^ rangeMax == -1 || (rangeMin < lowerBound || rangeMax > upperBound))
            {
                lblRangeError.Text = "Max Range is " + lowerBound + " - " + upperBound + ".";
                lblRangeError.Visible = true;
            }

            // If any one of the error messages are visible, do not continue.
            if (lblArrayError.Visible || lblRangeError.Visible)
            {
                return;
            }

            // If there are no errors, generate the array. Make sure to let any sorts finish first before generating the array.
            lock (sortLock)
            {
                if (!animationTimer.Enabled)
                {
                    animationTimer.Start();
                }

                sorterModel.generateArray(arraySize, rangeMin, rangeMax);
                resetSort();
            }

        }

        private int parseInt(String s)
        {
            int result;
            if (!Int32.TryParse(s, out result))
            {
                result = -1;
            }
            return result;
        }
    }
}
