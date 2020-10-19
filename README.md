# Sorting Visualizer

A program that visualizes various sorting algorithms, created using Windows Forms through Visual Studio and C#. A Sorter model class takes care of the sorting, and raises an event to send to the UI whenever a specific occurence needs to be drawn. The user can define the size of the array, the range of values within the array, and the speed at which the sorting animation is run at.

## Context
This was one of the most fun projects I've ever undertook. It was something I wanted to build when I first started, but I did not have the skills necessary. Initially, the project was built using Java's `swing` library, but I was having a lot of difficulty with the buttons freezing up whenever the algorithm was running. I figured out that it was because the EDT (Event Dispatch Thread) was being locked up while drawing the components for the sorting visualization, but was unable to figure out where to go from there.

After taking a course on C# Windows Applications, I decided to try using C# and Visual Studio to build the application. I ran into the same issues with the main thread being locked up, but at this point, I was comfortable enough to try multithreading, and running the sorting visualization on a separate thread, which worked! I did have some issues with the program taking up significant amounts oF RAM, but I was able to fix that by shrinking the size of the data required to draw each frame of the sorting visualization.

## How to Run
Unfortunately, my license for Visual Studio has expired, and I did not push the release `.exe` file to the repository. To run the program, open the project in Visual Studio, and then build the program. I will update this to contain the `.exe` when I can.

## Preview
![Preview](https://i.imgur.com/6im9BDR.gif)
