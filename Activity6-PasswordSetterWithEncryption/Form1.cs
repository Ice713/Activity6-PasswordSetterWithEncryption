using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity6_PasswordSetterWithEncryption
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonEncryptStore_Click(object sender, EventArgs e)
        {
            try
                {
                if (string.IsNullOrWhiteSpace(textBoxPassword.Text))
                {
                    MessageBox.Show("Please enter a valid password.");
                    return;
                }
                UserAccount userAccount = new UserAccount();

                userAccount.Password = textBoxPassword.Text;

                MessageBox.Show("Password stored successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
            
        }
    }
}
