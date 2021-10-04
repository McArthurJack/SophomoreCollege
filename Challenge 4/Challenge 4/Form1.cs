using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Challenge_4
{
    public partial class Form1 : Form
    {
        private string key = "FIRE";

        public Form1()
        {
            InitializeComponent();
        }

        private void fireButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (Double.Parse(latitudeTextBox.Text) > 0 && Double.Parse(longitudeTextBox.Text) > 0 && authorizationTextbox.Text == key)
                {
                    onSuccessfulFireEventHandler();
                }
            }
            catch
            {

            }
        }
        public async void onSuccessfulFireEventHandler()
        {
            for (int i = 5; i >= 0; i--)
            {
                countdownTimerLabel.Text = i.ToString();
                await Task.Delay(1000);
            }
        }

        private void abortButton_Click(object sender, EventArgs e)
        {

        }
    }
}
