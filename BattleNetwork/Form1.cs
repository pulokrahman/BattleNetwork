using ImageProcessing.Utilities;
using WindowsInput;

namespace BattleNetwork
{
    public partial class Form1 : Form
    {
        public Window window { get; set; }
        public Form1()
        {
            InitializeComponent();
            window= new Window();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            IInputSimulator simulator = new InputSimulator();
            simulator.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.VK_A).Sleep(1000).KeyUp(WindowsInput.Native.VirtualKeyCode.VK_A);
            SendKeys.Send("{j}");
            simulator.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.VK_D).Sleep(500).KeyUp(WindowsInput.Native.VirtualKeyCode.VK_D);


           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

      

        private void StopRoundCircle_Click(object sender, EventArgs e)
        {
                timer1.Enabled = false;
           
        }

        private void CommandSpamA_Click(object sender, EventArgs e)
        {
            SpamA.Enabled = true;
        }

        private void StopSpammingA_Click(object sender, EventArgs e)
        {
            SpamA.Enabled = false;
        }

        private void SpamA_Tick(object sender, EventArgs e)
        {
            SendKeys.Send("{J}");
        }

        private void SpamBTimer_Tick(object sender, EventArgs e)
        {
            SendKeys.Send("{K}");
            SendKeys.Send("{K}");
            SendKeys.Send("{K}");
            SendKeys.Send("{K}");
            SendKeys.Send("{K}");
            SendKeys.Send("{K}");
            SendKeys.Send("{K}");
            SendKeys.Send("{K}");
            SendKeys.Send("{K}");
        }

        private void SpamB_Click(object sender, EventArgs e)
        {
            SpamBTimer.Enabled = true;
        }

        private void StopSpammingB_Click(object sender, EventArgs e)
        {
            SpamBTimer.Enabled = false;
        }

        private void SaveScreen_Click(object sender, EventArgs e)
        {
            window.takeScreenShot();
        }

        private void Bot_Tick(object sender, EventArgs e)
        {
            IInputSimulator simulator = new InputSimulator();

            window.takeScreenShot();
            // Create single instance of sample data from first line of dataset for model input
            var imageBytes = File.ReadAllBytes("screenshot.png");
            MLBattleNetwork.ModelInput sampleData = new MLBattleNetwork.ModelInput()
            {
                ImageSource = imageBytes,
            };

            // Make a single prediction on the sample data and print results.
            var sortedScoresWithLabel = MLBattleNetwork.Predict(sampleData).PredictedLabel;
            if (sortedScoresWithLabel.Equals("Battle"))
            {
              
                simulator.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.VK_K).Sleep(100).KeyUp(WindowsInput.Native.VirtualKeyCode.VK_K).Sleep(200);
           
                simulator.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.VK_S).Sleep(100).KeyUp(WindowsInput.Native.VirtualKeyCode.VK_S).Sleep(200);

                simulator.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.VK_K).Sleep(100).KeyUp(WindowsInput.Native.VirtualKeyCode.VK_K).Sleep(200);

                simulator.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.VK_W).Sleep(100).KeyUp(WindowsInput.Native.VirtualKeyCode.VK_W).Sleep(200);



            }
            if (sortedScoresWithLabel.Equals("HubWorld"))
            {
            
                simulator.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.VK_K);
                simulator.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.VK_A).Sleep(500).KeyUp(WindowsInput.Native.VirtualKeyCode.VK_A);

                simulator.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.VK_D).Sleep(500).KeyUp(WindowsInput.Native.VirtualKeyCode.VK_D);
                simulator.Keyboard.KeyUp(WindowsInput.Native.VirtualKeyCode.VK_K);
            }
            if (sortedScoresWithLabel.Equals("Custom"))
            {

                simulator.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.VK_A).Sleep(100).KeyUp(WindowsInput.Native.VirtualKeyCode.VK_A).Sleep(100);


                simulator.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.VK_J).Sleep(100).KeyUp(WindowsInput.Native.VirtualKeyCode.VK_J).Sleep(100);


            }
            if (sortedScoresWithLabel.Equals("Results"))
            {

                simulator.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.VK_J).Sleep(100).KeyUp(WindowsInput.Native.VirtualKeyCode.VK_J).Sleep(2000);


                simulator.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.VK_J).Sleep(100).KeyUp(WindowsInput.Native.VirtualKeyCode.VK_J);
            }
        }

        private void ActivateBot_Click(object sender, EventArgs e)
        {
            Bot.Enabled = true;
        }

        private void DisableBot_Click(object sender, EventArgs e)
        {
            Bot.Enabled = false;
        }

        private void process1_Exited(object sender, EventArgs e)
        {

        }
    }
}