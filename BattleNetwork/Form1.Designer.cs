namespace BattleNetwork
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.StopRoundCircle = new System.Windows.Forms.Button();
            this.CommandSpamA = new System.Windows.Forms.Button();
            this.StopSpammingA = new System.Windows.Forms.Button();
            this.SpamA = new System.Windows.Forms.Timer(this.components);
            this.SpamB = new System.Windows.Forms.Button();
            this.StopSpammingB = new System.Windows.Forms.Button();
            this.SpamBTimer = new System.Windows.Forms.Timer(this.components);
            this.SaveScreen = new System.Windows.Forms.Button();
            this.ActivateBot = new System.Windows.Forms.Button();
            this.DisableBot = new System.Windows.Forms.Button();
            this.Bot = new System.Windows.Forms.Timer(this.components);
            this.process1 = new System.Diagnostics.Process();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "RoundCircle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // StopRoundCircle
            // 
            this.StopRoundCircle.Location = new System.Drawing.Point(9, 85);
            this.StopRoundCircle.Name = "StopRoundCircle";
            this.StopRoundCircle.Size = new System.Drawing.Size(161, 29);
            this.StopRoundCircle.TabIndex = 1;
            this.StopRoundCircle.Text = "StopRunningInCircle";
            this.StopRoundCircle.UseVisualStyleBackColor = true;
            this.StopRoundCircle.Click += new System.EventHandler(this.StopRoundCircle_Click);
            // 
            // CommandSpamA
            // 
            this.CommandSpamA.Location = new System.Drawing.Point(9, 143);
            this.CommandSpamA.Name = "CommandSpamA";
            this.CommandSpamA.Size = new System.Drawing.Size(94, 29);
            this.CommandSpamA.TabIndex = 2;
            this.CommandSpamA.Text = "SpamA";
            this.CommandSpamA.UseVisualStyleBackColor = true;
            this.CommandSpamA.Click += new System.EventHandler(this.CommandSpamA_Click);
            // 
            // StopSpammingA
            // 
            this.StopSpammingA.Location = new System.Drawing.Point(9, 178);
            this.StopSpammingA.Name = "StopSpammingA";
            this.StopSpammingA.Size = new System.Drawing.Size(148, 29);
            this.StopSpammingA.TabIndex = 3;
            this.StopSpammingA.Text = "StopSpammingA";
            this.StopSpammingA.UseVisualStyleBackColor = true;
            this.StopSpammingA.Click += new System.EventHandler(this.StopSpammingA_Click);
            // 
            // SpamA
            // 
            this.SpamA.Tick += new System.EventHandler(this.SpamA_Tick);
            // 
            // SpamB
            // 
            this.SpamB.Location = new System.Drawing.Point(13, 254);
            this.SpamB.Name = "SpamB";
            this.SpamB.Size = new System.Drawing.Size(94, 29);
            this.SpamB.TabIndex = 4;
            this.SpamB.Text = "SpamB";
            this.SpamB.UseVisualStyleBackColor = true;
            this.SpamB.Click += new System.EventHandler(this.SpamB_Click);
            // 
            // StopSpammingB
            // 
            this.StopSpammingB.Location = new System.Drawing.Point(12, 289);
            this.StopSpammingB.Name = "StopSpammingB";
            this.StopSpammingB.Size = new System.Drawing.Size(146, 29);
            this.StopSpammingB.TabIndex = 5;
            this.StopSpammingB.Text = "StopSpammingB";
            this.StopSpammingB.UseVisualStyleBackColor = true;
            this.StopSpammingB.Click += new System.EventHandler(this.StopSpammingB_Click);
            // 
            // SpamBTimer
            // 
            this.SpamBTimer.Tick += new System.EventHandler(this.SpamBTimer_Tick);
            // 
            // SaveScreen
            // 
            this.SaveScreen.Location = new System.Drawing.Point(208, 33);
            this.SaveScreen.Name = "SaveScreen";
            this.SaveScreen.Size = new System.Drawing.Size(94, 29);
            this.SaveScreen.TabIndex = 6;
            this.SaveScreen.Text = "SaveScreen";
            this.SaveScreen.UseVisualStyleBackColor = true;
            this.SaveScreen.Click += new System.EventHandler(this.SaveScreen_Click);
            // 
            // ActivateBot
            // 
            this.ActivateBot.Location = new System.Drawing.Point(228, 121);
            this.ActivateBot.Name = "ActivateBot";
            this.ActivateBot.Size = new System.Drawing.Size(94, 29);
            this.ActivateBot.TabIndex = 7;
            this.ActivateBot.Text = "ActivateBot";
            this.ActivateBot.UseVisualStyleBackColor = true;
            this.ActivateBot.Click += new System.EventHandler(this.ActivateBot_Click);
            // 
            // DisableBot
            // 
            this.DisableBot.Location = new System.Drawing.Point(228, 156);
            this.DisableBot.Name = "DisableBot";
            this.DisableBot.Size = new System.Drawing.Size(94, 29);
            this.DisableBot.TabIndex = 8;
            this.DisableBot.Text = "DisableBot";
            this.DisableBot.UseVisualStyleBackColor = true;
            this.DisableBot.Click += new System.EventHandler(this.DisableBot_Click);
            // 
            // Bot
            // 
            this.Bot.Tick += new System.EventHandler(this.Bot_Tick);
            // 
            // process1
            // 
            this.process1.StartInfo.Domain = "";
            this.process1.StartInfo.LoadUserProfile = false;
            this.process1.StartInfo.Password = null;
            this.process1.StartInfo.StandardErrorEncoding = null;
            this.process1.StartInfo.StandardInputEncoding = null;
            this.process1.StartInfo.StandardOutputEncoding = null;
            this.process1.StartInfo.UserName = "";
            this.process1.SynchronizingObject = this;
            this.process1.Exited += new System.EventHandler(this.process1_Exited);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(334, 349);
            this.Controls.Add(this.DisableBot);
            this.Controls.Add(this.ActivateBot);
            this.Controls.Add(this.SaveScreen);
            this.Controls.Add(this.StopSpammingB);
            this.Controls.Add(this.SpamB);
            this.Controls.Add(this.StopSpammingA);
            this.Controls.Add(this.CommandSpamA);
            this.Controls.Add(this.StopRoundCircle);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }



        #endregion

        private Button button1;
        private System.Windows.Forms.Timer timer1;
        private Button StopRoundCircle;
        private Button CommandSpamA;
        private Button StopSpammingA;
        private System.Windows.Forms.Timer SpamA;
        private Button SpamB;
        private Button StopSpammingB;
        private System.Windows.Forms.Timer SpamBTimer;
        private Button SaveScreen;
        private Button ActivateBot;
        private Button DisableBot;
        private System.Windows.Forms.Timer Bot;
        private System.Diagnostics.Process process1;
    }
}