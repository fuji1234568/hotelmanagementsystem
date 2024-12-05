using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotelmanagement3
{
    public partial class FormDashboard : Form
    {
        public string Username;

        public FormDashboard()
        {
            InitializeComponent();
        }
        private void Movepanel(Control btn)
        {
            panelSlide.Top = btn.Top;
            panelSlide.Height = btn.Height;
        }


        private void linkLabelLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            DialogResult result = MessageBox.Show("Are you want to Log Out?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == result)
            {
                timer1.Stop();
                this.Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelDateTime.Text = DateTime.Now.ToString("dd-MMM-yyyy hh:mm:ss tt");
        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            timer1.Start();
            
        }

        private void buttonDashBoard_Click(object sender, EventArgs e)
        {
            Movepanel(buttonDashBoard);
        }

        private void buttonClient_Click(object sender, EventArgs e)
        {
            Movepanel(buttonClient);
        }

        private void buttonRoom_Click(object sender, EventArgs e)
        {
            Movepanel(buttonRoom);
        }

        private void buttonReservation_Click(object sender, EventArgs e)
        {
            Movepanel(buttonReservation);
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            Movepanel(buttonSettings);
            userControlSetting1.clear();
            userControlSetting1.Show();
        }
    }
}
