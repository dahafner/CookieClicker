namespace AutoClicker
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    using InputManager;

    public partial class Form1 : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Form1"/> class.
        /// </summary>
        public Form1()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// The total clicks
        /// </summary>
        private long totalClicks = 0;

        /// <summary>
        /// Handles the Click event of the BtnGo1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private async void BtnGo1_Click(object sender, EventArgs e)
        {
            await Task.Delay((int)this.nudInitialDelay.Value * 1000);
            var datetime = DateTime.Now.AddSeconds((double)this.nudDuration.Value);
            this.totalClicks = 0;

            while (DateTime.Now < datetime)
            {
                Mouse.PressButton(Mouse.MouseKeys.Left);
                Thread.Sleep((int)this.nudPause1.Value);
                this.totalClicks++;
            }

            this.lblClicks1.Text = this.totalClicks.ToString();
        }

        private async void BtnGo2_Click(object sender, EventArgs e)
        {
            await Task.Delay((int)this.nudInitialDelay.Value * 1000);
            this.totalClicks = 0;

            while (this.totalClicks < this.nudClickCount.Value)
            {
                Mouse.PressButton(Mouse.MouseKeys.Left);
                Thread.Sleep((int)this.nudPause1.Value);
                this.totalClicks++;
            }

            this.lblClicks2.Text = this.totalClicks.ToString();
        }
    }
}
