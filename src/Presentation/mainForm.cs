using System;
using System.Drawing;
using System.IO;
using System.Media;
using System.Reflection;
using System.Windows.Forms;

namespace KingdomHallTimer
{
    public partial class MainForm : Form
    {
        TimeSpan timeSpan;
        readonly Timer theTimer = new Timer();
        Boolean timerStarted;
        
        public MainForm()
        {
            this.InitializeComponent();
        }

        void theTimer_Tick(object sender, EventArgs e)
        {
            this.UpdateTime();
        }

        void UpdateTime()
        {
            var subSecond = TimeSpan.FromSeconds(1);
            if (this.timeSpan < subSecond)
            {
                this.counterLabel.BackColor = Color.Red;
                this.counterLabel.Text = string.Format("-{0}", this.timeSpan.Duration());
            }
            else
            {
                this.counterLabel.Text = this.timeSpan.Duration().ToString();
            }

            //reduce time
            this.timeSpan = this.timeSpan.Subtract(subSecond);
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            this.playLoudSoundButton.Visible = Properties.Settings.Default.BuzzerEnabled;
            this.Icon = Properties.Resources._022_clock;

            this.theTimer.Interval = 1000;
            this.theTimer.Tick += this.theTimer_Tick;

            TimeSpan setupTimeSpan = TimeSpan.Parse(Properties.Settings.Default.InitialCountdown);
            this.timeSpan = setupTimeSpan;
            this.counterLabel.Text = this.timeSpan.Duration().ToString();
        }

        private void switchButton_Click(object sender, EventArgs e)
        {
            if (this.timerStarted != true)
            {
                this.theTimer.Start();
                this.counterLabel.BackColor = Color.DeepSkyBlue;
                this.timerStarted = true;
                this.switchButton.BackgroundImage = Properties.Resources._413_pause;
                this.UpdateTime();
            }
            else
            {
                this.theTimer.Stop();
                this.timerStarted = false;
                this.counterLabel.BackColor = Color.LightSkyBlue;
                this.switchButton.BackgroundImage = Properties.Resources._412_play;
            }
        }

        private void twoMinutesButton_Click(object sender, EventArgs e)
        {
            this.UpdateTimerDisplay(2);
        }
        
        private void threeMinutesButton_Click(object sender, EventArgs e)
        {
            this.UpdateTimerDisplay(3);
        }

        private void fiveMinutesButton_Click(object sender, EventArgs e)
        {
            this.UpdateTimerDisplay(5);
        }

        void UpdateTimerDisplay(int minutes)
        {
            if (!this.timerStarted)
            {
                this.timeSpan = new TimeSpan(0, 0, minutes, 0);
                this.counterLabel.Text = this.timeSpan.Duration().ToString();
                this.counterLabel.BackColor = Color.LightSkyBlue;
            }
        }

        private void dingBellButton_Click(object sender, EventArgs e)
        {
            this.PlaySound("sound1.wav");
        }

        private void playLoudSoundButton_Click(object sender, EventArgs e)
        {
            this.PlaySound("sound2.wav");
        }

        void PlaySound(string soundFile)
        {
            string fileLocation = string.Format("{0}\\{1}", Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), soundFile);
            if (File.Exists(fileLocation))
            {
                var soundPlayer = new SoundPlayer(fileLocation);
                soundPlayer.Play();
            }
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            var form = new AboutBox();
            form.ShowDialog();
        }
    }
}