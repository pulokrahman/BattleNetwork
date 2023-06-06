﻿
// This file was auto-generated by ML.NET Model Builder. 

using ImageProcessing.Utilities;
using MLModel1_ConsoleApp1;
using System.IO;
using System.Windows.Forms;
using WindowsInput;



IInputSimulator simulator = new InputSimulator();

window.takeScreenShot();
    // Create single instance of sample data from first line of dataset for model input
    var imageBytes = File.ReadAllBytes(@"C:\Users\Pulok Rahman\source\repos\BattleNetwork\MLModel1_ConsoleApp1\bin\Debug\net6.0-windows\screenshot.png");
    MLModel1.ModelInput sampleData = new MLModel1.ModelInput()
    {
        ImageSource = imageBytes,
    };

    // Make a single prediction on the sample data and print results.
    var sortedScoresWithLabel = MLModel1.Predict(sampleData).PredictedLabel;
if (sortedScoresWithLabel.Equals("Battle"))
    {
        simulator.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_K);

    }
if (sortedScoresWithLabel.Equals("HubWorld"))
    {
        simulator.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.VK_A).Sleep(500).KeyUp(WindowsInput.Native.VirtualKeyCode.VK_A);
      
        simulator.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.VK_D).Sleep(500).KeyUp(WindowsInput.Native.VirtualKeyCode.VK_D);
        
    }
if (sortedScoresWithLabel.Equals("Custom"))
    {
        simulator.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_A);
        System.Threading.Thread.Sleep(1000);
        simulator.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_J);
    }
    if (sortedScoresWithLabel.Equals("Results"))
    {
        simulator.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_J);

    }
}
