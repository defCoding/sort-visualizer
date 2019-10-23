namespace sort_visualizer
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.picBoxVisualizer = new System.Windows.Forms.PictureBox();
            this.btnQuickSort = new System.Windows.Forms.Button();
            this.btnInsertionSort = new System.Windows.Forms.Button();
            this.grpBoxSortingAlgos = new System.Windows.Forms.GroupBox();
            this.btnRadixSort = new System.Windows.Forms.Button();
            this.btnCountingSort = new System.Windows.Forms.Button();
            this.btnHeapSort = new System.Windows.Forms.Button();
            this.btnSelectionSort = new System.Windows.Forms.Button();
            this.btnBubbleSort = new System.Windows.Forms.Button();
            this.btnMergeSort = new System.Windows.Forms.Button();
            this.grpBoxArraySetup = new System.Windows.Forms.GroupBox();
            this.tkBarAnimationSpeed = new System.Windows.Forms.TrackBar();
            this.lblAnimationSpeed = new System.Windows.Forms.Label();
            this.lblRangeError = new System.Windows.Forms.Label();
            this.lblArrayError = new System.Windows.Forms.Label();
            this.btnSetupArray = new System.Windows.Forms.Button();
            this.lblMax = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.txtBoxMax = new System.Windows.Forms.TextBox();
            this.txtBoxMin = new System.Windows.Forms.TextBox();
            this.lblArrayRange = new System.Windows.Forms.Label();
            this.lblArraySize = new System.Windows.Forms.Label();
            this.txtBoxArraySize = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnDummy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxVisualizer)).BeginInit();
            this.grpBoxSortingAlgos.SuspendLayout();
            this.grpBoxArraySetup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tkBarAnimationSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxVisualizer
            // 
            this.picBoxVisualizer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(28)))), ((int)(((byte)(44)))));
            this.picBoxVisualizer.Location = new System.Drawing.Point(12, 20);
            this.picBoxVisualizer.Name = "picBoxVisualizer";
            this.picBoxVisualizer.Size = new System.Drawing.Size(776, 492);
            this.picBoxVisualizer.TabIndex = 0;
            this.picBoxVisualizer.TabStop = false;
            this.picBoxVisualizer.Paint += new System.Windows.Forms.PaintEventHandler(this.picBoxVisualizer_Paint);
            // 
            // btnQuickSort
            // 
            this.btnQuickSort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(180)))), ((int)(((byte)(245)))));
            this.btnQuickSort.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnQuickSort.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnQuickSort.Location = new System.Drawing.Point(6, 136);
            this.btnQuickSort.Name = "btnQuickSort";
            this.btnQuickSort.Size = new System.Drawing.Size(139, 23);
            this.btnQuickSort.TabIndex = 5;
            this.btnQuickSort.Text = "Quick Sort";
            this.btnQuickSort.UseVisualStyleBackColor = false;
            this.btnQuickSort.Click += new System.EventHandler(this.btnQuickSort_Click);
            // 
            // btnInsertionSort
            // 
            this.btnInsertionSort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(180)))), ((int)(((byte)(245)))));
            this.btnInsertionSort.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInsertionSort.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnInsertionSort.Location = new System.Drawing.Point(6, 19);
            this.btnInsertionSort.Name = "btnInsertionSort";
            this.btnInsertionSort.Size = new System.Drawing.Size(139, 23);
            this.btnInsertionSort.TabIndex = 1;
            this.btnInsertionSort.Text = "Insertion Sort";
            this.btnInsertionSort.UseVisualStyleBackColor = false;
            this.btnInsertionSort.Click += new System.EventHandler(this.btnInsertionSort_Click);
            // 
            // grpBoxSortingAlgos
            // 
            this.grpBoxSortingAlgos.Controls.Add(this.btnRadixSort);
            this.grpBoxSortingAlgos.Controls.Add(this.btnCountingSort);
            this.grpBoxSortingAlgos.Controls.Add(this.btnHeapSort);
            this.grpBoxSortingAlgos.Controls.Add(this.btnSelectionSort);
            this.grpBoxSortingAlgos.Controls.Add(this.btnBubbleSort);
            this.grpBoxSortingAlgos.Controls.Add(this.btnMergeSort);
            this.grpBoxSortingAlgos.Controls.Add(this.btnQuickSort);
            this.grpBoxSortingAlgos.Controls.Add(this.btnInsertionSort);
            this.grpBoxSortingAlgos.ForeColor = System.Drawing.Color.White;
            this.grpBoxSortingAlgos.Location = new System.Drawing.Point(794, 261);
            this.grpBoxSortingAlgos.Name = "grpBoxSortingAlgos";
            this.grpBoxSortingAlgos.Size = new System.Drawing.Size(148, 251);
            this.grpBoxSortingAlgos.TabIndex = 2;
            this.grpBoxSortingAlgos.TabStop = false;
            this.grpBoxSortingAlgos.Text = "Sorting Algorithms";
            // 
            // btnRadixSort
            // 
            this.btnRadixSort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(180)))), ((int)(((byte)(245)))));
            this.btnRadixSort.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRadixSort.ForeColor = System.Drawing.Color.Black;
            this.btnRadixSort.Location = new System.Drawing.Point(6, 166);
            this.btnRadixSort.Name = "btnRadixSort";
            this.btnRadixSort.Size = new System.Drawing.Size(139, 23);
            this.btnRadixSort.TabIndex = 6;
            this.btnRadixSort.Text = "MSD Radix Sort";
            this.btnRadixSort.UseVisualStyleBackColor = false;
            this.btnRadixSort.Click += new System.EventHandler(this.btnRadixSort_Click);
            // 
            // btnCountingSort
            // 
            this.btnCountingSort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(180)))), ((int)(((byte)(245)))));
            this.btnCountingSort.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCountingSort.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCountingSort.Location = new System.Drawing.Point(6, 195);
            this.btnCountingSort.Name = "btnCountingSort";
            this.btnCountingSort.Size = new System.Drawing.Size(139, 23);
            this.btnCountingSort.TabIndex = 7;
            this.btnCountingSort.Text = "Counting Sort";
            this.btnCountingSort.UseVisualStyleBackColor = false;
            this.btnCountingSort.Click += new System.EventHandler(this.btnCountingSort_Click);
            // 
            // btnHeapSort
            // 
            this.btnHeapSort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(180)))), ((int)(((byte)(245)))));
            this.btnHeapSort.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHeapSort.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnHeapSort.Location = new System.Drawing.Point(6, 224);
            this.btnHeapSort.Name = "btnHeapSort";
            this.btnHeapSort.Size = new System.Drawing.Size(139, 23);
            this.btnHeapSort.TabIndex = 8;
            this.btnHeapSort.Text = "Heap Sort";
            this.btnHeapSort.UseVisualStyleBackColor = false;
            this.btnHeapSort.Click += new System.EventHandler(this.btnHeapSort_Click);
            // 
            // btnSelectionSort
            // 
            this.btnSelectionSort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(180)))), ((int)(((byte)(245)))));
            this.btnSelectionSort.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSelectionSort.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSelectionSort.Location = new System.Drawing.Point(6, 78);
            this.btnSelectionSort.Name = "btnSelectionSort";
            this.btnSelectionSort.Size = new System.Drawing.Size(139, 23);
            this.btnSelectionSort.TabIndex = 3;
            this.btnSelectionSort.Text = "Selection Sort";
            this.btnSelectionSort.UseVisualStyleBackColor = false;
            this.btnSelectionSort.Click += new System.EventHandler(this.btnSelectionSort_Click);
            // 
            // btnBubbleSort
            // 
            this.btnBubbleSort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(180)))), ((int)(((byte)(245)))));
            this.btnBubbleSort.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBubbleSort.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBubbleSort.Location = new System.Drawing.Point(6, 49);
            this.btnBubbleSort.Name = "btnBubbleSort";
            this.btnBubbleSort.Size = new System.Drawing.Size(139, 23);
            this.btnBubbleSort.TabIndex = 2;
            this.btnBubbleSort.Text = "Bubble Sort";
            this.btnBubbleSort.UseVisualStyleBackColor = false;
            this.btnBubbleSort.Click += new System.EventHandler(this.btnBubbleSort_Click);
            // 
            // btnMergeSort
            // 
            this.btnMergeSort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(180)))), ((int)(((byte)(245)))));
            this.btnMergeSort.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMergeSort.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMergeSort.Location = new System.Drawing.Point(6, 107);
            this.btnMergeSort.Name = "btnMergeSort";
            this.btnMergeSort.Size = new System.Drawing.Size(139, 23);
            this.btnMergeSort.TabIndex = 4;
            this.btnMergeSort.Text = "Merge Sort";
            this.btnMergeSort.UseVisualStyleBackColor = false;
            this.btnMergeSort.Click += new System.EventHandler(this.btnMergeSort_Click);
            // 
            // grpBoxArraySetup
            // 
            this.grpBoxArraySetup.Controls.Add(this.tkBarAnimationSpeed);
            this.grpBoxArraySetup.Controls.Add(this.lblAnimationSpeed);
            this.grpBoxArraySetup.Controls.Add(this.lblRangeError);
            this.grpBoxArraySetup.Controls.Add(this.lblArrayError);
            this.grpBoxArraySetup.Controls.Add(this.btnSetupArray);
            this.grpBoxArraySetup.Controls.Add(this.lblMax);
            this.grpBoxArraySetup.Controls.Add(this.lblMin);
            this.grpBoxArraySetup.Controls.Add(this.txtBoxMax);
            this.grpBoxArraySetup.Controls.Add(this.txtBoxMin);
            this.grpBoxArraySetup.Controls.Add(this.lblArrayRange);
            this.grpBoxArraySetup.Controls.Add(this.lblArraySize);
            this.grpBoxArraySetup.Controls.Add(this.txtBoxArraySize);
            this.grpBoxArraySetup.Cursor = System.Windows.Forms.Cursors.Default;
            this.grpBoxArraySetup.ForeColor = System.Drawing.Color.White;
            this.grpBoxArraySetup.Location = new System.Drawing.Point(794, 20);
            this.grpBoxArraySetup.Name = "grpBoxArraySetup";
            this.grpBoxArraySetup.Size = new System.Drawing.Size(148, 235);
            this.grpBoxArraySetup.TabIndex = 1;
            this.grpBoxArraySetup.TabStop = false;
            this.grpBoxArraySetup.Text = "Parameters";
            // 
            // tkBarAnimationSpeed
            // 
            this.tkBarAnimationSpeed.Cursor = System.Windows.Forms.Cursors.Default;
            this.tkBarAnimationSpeed.Location = new System.Drawing.Point(23, 121);
            this.tkBarAnimationSpeed.Maximum = 50;
            this.tkBarAnimationSpeed.Minimum = 1;
            this.tkBarAnimationSpeed.Name = "tkBarAnimationSpeed";
            this.tkBarAnimationSpeed.Size = new System.Drawing.Size(104, 45);
            this.tkBarAnimationSpeed.TabIndex = 3;
            this.tkBarAnimationSpeed.Value = 10;
            this.tkBarAnimationSpeed.Scroll += new System.EventHandler(this.tkBarAnimationSpeed_Scroll);
            // 
            // lblAnimationSpeed
            // 
            this.lblAnimationSpeed.AutoSize = true;
            this.lblAnimationSpeed.ForeColor = System.Drawing.Color.White;
            this.lblAnimationSpeed.Location = new System.Drawing.Point(31, 105);
            this.lblAnimationSpeed.Name = "lblAnimationSpeed";
            this.lblAnimationSpeed.Size = new System.Drawing.Size(87, 13);
            this.lblAnimationSpeed.TabIndex = 10;
            this.lblAnimationSpeed.Text = "Animation Speed";
            // 
            // lblRangeError
            // 
            this.lblRangeError.AutoSize = true;
            this.lblRangeError.ForeColor = System.Drawing.Color.Cyan;
            this.lblRangeError.Location = new System.Drawing.Point(20, 179);
            this.lblRangeError.Name = "lblRangeError";
            this.lblRangeError.Size = new System.Drawing.Size(65, 13);
            this.lblRangeError.TabIndex = 9;
            this.lblRangeError.Text = "Max Range:";
            this.lblRangeError.Visible = false;
            // 
            // lblArrayError
            // 
            this.lblArrayError.AutoSize = true;
            this.lblArrayError.ForeColor = System.Drawing.Color.Cyan;
            this.lblArrayError.Location = new System.Drawing.Point(20, 166);
            this.lblArrayError.Name = "lblArrayError";
            this.lblArrayError.Size = new System.Drawing.Size(56, 13);
            this.lblArrayError.TabIndex = 8;
            this.lblArrayError.Text = "Max Size: ";
            this.lblArrayError.Visible = false;
            // 
            // btnSetupArray
            // 
            this.btnSetupArray.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(180)))), ((int)(((byte)(245)))));
            this.btnSetupArray.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSetupArray.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSetupArray.Location = new System.Drawing.Point(23, 198);
            this.btnSetupArray.Name = "btnSetupArray";
            this.btnSetupArray.Size = new System.Drawing.Size(104, 27);
            this.btnSetupArray.TabIndex = 4;
            this.btnSetupArray.Text = "Initialize Array";
            this.btnSetupArray.UseVisualStyleBackColor = false;
            this.btnSetupArray.Click += new System.EventHandler(this.btnSetupArray_Click);
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.ForeColor = System.Drawing.Color.White;
            this.lblMax.Location = new System.Drawing.Point(91, 66);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(27, 13);
            this.lblMax.TabIndex = 6;
            this.lblMax.Text = "Max";
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.ForeColor = System.Drawing.Color.White;
            this.lblMin.Location = new System.Drawing.Point(36, 66);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(24, 13);
            this.lblMin.TabIndex = 5;
            this.lblMin.Text = "Min";
            // 
            // txtBoxMax
            // 
            this.txtBoxMax.Location = new System.Drawing.Point(85, 82);
            this.txtBoxMax.Name = "txtBoxMax";
            this.txtBoxMax.Size = new System.Drawing.Size(42, 20);
            this.txtBoxMax.TabIndex = 2;
            this.txtBoxMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxMax_KeyPress);
            // 
            // txtBoxMin
            // 
            this.txtBoxMin.Location = new System.Drawing.Point(27, 82);
            this.txtBoxMin.Name = "txtBoxMin";
            this.txtBoxMin.Size = new System.Drawing.Size(42, 20);
            this.txtBoxMin.TabIndex = 1;
            this.txtBoxMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxMin_KeyPress);
            // 
            // lblArrayRange
            // 
            this.lblArrayRange.AutoSize = true;
            this.lblArrayRange.ForeColor = System.Drawing.Color.White;
            this.lblArrayRange.Location = new System.Drawing.Point(55, 53);
            this.lblArrayRange.Name = "lblArrayRange";
            this.lblArrayRange.Size = new System.Drawing.Size(39, 13);
            this.lblArrayRange.TabIndex = 2;
            this.lblArrayRange.Text = "Range";
            // 
            // lblArraySize
            // 
            this.lblArraySize.AutoSize = true;
            this.lblArraySize.ForeColor = System.Drawing.Color.White;
            this.lblArraySize.Location = new System.Drawing.Point(47, 15);
            this.lblArraySize.Name = "lblArraySize";
            this.lblArraySize.Size = new System.Drawing.Size(54, 13);
            this.lblArraySize.TabIndex = 1;
            this.lblArraySize.Text = "Array Size";
            // 
            // txtBoxArraySize
            // 
            this.txtBoxArraySize.Location = new System.Drawing.Point(53, 31);
            this.txtBoxArraySize.MaxLength = 4;
            this.txtBoxArraySize.Name = "txtBoxArraySize";
            this.txtBoxArraySize.Size = new System.Drawing.Size(42, 20);
            this.txtBoxArraySize.TabIndex = 0;
            this.txtBoxArraySize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxArraySize_KeyPress);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(78)))), ((int)(((byte)(79)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Location = new System.Drawing.Point(918, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(34, 20);
            this.btnExit.TabIndex = 3;
            this.btnExit.TabStop = false;
            this.btnExit.Text = "X";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(165)))), ((int)(((byte)(118)))));
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMinimize.Location = new System.Drawing.Point(879, 2);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(34, 20);
            this.btnMinimize.TabIndex = 4;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Text = "—";
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnDummy
            // 
            this.btnDummy.Location = new System.Drawing.Point(798, 2);
            this.btnDummy.Name = "btnDummy";
            this.btnDummy.Size = new System.Drawing.Size(0, 0);
            this.btnDummy.TabIndex = 5;
            this.btnDummy.Text = "dummyButton";
            this.btnDummy.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(954, 521);
            this.Controls.Add(this.btnDummy);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.grpBoxArraySetup);
            this.Controls.Add(this.grpBoxSortingAlgos);
            this.Controls.Add(this.picBoxVisualizer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxVisualizer)).EndInit();
            this.grpBoxSortingAlgos.ResumeLayout(false);
            this.grpBoxArraySetup.ResumeLayout(false);
            this.grpBoxArraySetup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tkBarAnimationSpeed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxVisualizer;
        private System.Windows.Forms.Button btnQuickSort;
        private System.Windows.Forms.Button btnInsertionSort;
        private System.Windows.Forms.GroupBox grpBoxSortingAlgos;
        private System.Windows.Forms.GroupBox grpBoxArraySetup;
        private System.Windows.Forms.Label lblArraySize;
        private System.Windows.Forms.TextBox txtBoxArraySize;
        private System.Windows.Forms.Button btnSetupArray;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.TextBox txtBoxMax;
        private System.Windows.Forms.TextBox txtBoxMin;
        private System.Windows.Forms.Label lblArrayRange;
        private System.Windows.Forms.Label lblRangeError;
        private System.Windows.Forms.Label lblArrayError;
        private System.Windows.Forms.TrackBar tkBarAnimationSpeed;
        private System.Windows.Forms.Label lblAnimationSpeed;
        private System.Windows.Forms.Button btnMergeSort;
        private System.Windows.Forms.Button btnBubbleSort;
        private System.Windows.Forms.Button btnSelectionSort;
        private System.Windows.Forms.Button btnHeapSort;
        private System.Windows.Forms.Button btnCountingSort;
        private System.Windows.Forms.Button btnRadixSort;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnDummy;
    }
}

