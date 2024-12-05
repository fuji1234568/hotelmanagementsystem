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
    public partial class UserControlSetting : UserControl
    {
        private string ID = "";

        public UserControlSetting()
        {
            InitializeComponent();
        }
        public void clear()
        {
            textBoxUsername.Clear();
            textBoxPassword.Clear();
            tabControlUser.SelectedTab = tabPageAddUser;
        }
        private void Clear1()
        {
            textBoxUsername1.Clear();
            textBoxPassword1.Clear();
            ID = "";
        }

        private void tabPageAddUser_Leave(object sender, EventArgs e)
        {
            clear();
        }

        private void tabPageSearchUser_Enter(object sender, EventArgs e)
        {
            //textBoxSearchUsername.Clear();
        }

        private void tabPageSearchUser_Leave(object sender, EventArgs e)
        {
            textBoxSearchUsername.Clear();
        }

        private void tabPageUpdateAndDeleteUser_Leave(object sender, EventArgs e)
        {
            Clear1();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            bool check;
            if (textBoxUsername.Text.Trim() == string.Empty || textBoxPassword.Text.Trim() == string.Empty)
            {

                MessageBox.Show("Please fill out all fields.", "Require all field.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                bool Check = true;
                if (Check)
                {
                    MessageBox.Show("User successfully added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear(); // Clear the input fields
                }
            }
        }

        // Assume this method clears the input fields
        private void Clear()
        {
            textBoxUsername.Clear();
            textBoxPassword.Clear();
        }
    }
}








