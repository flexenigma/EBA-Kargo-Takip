using System;
using System.Windows.Forms;
using BCrypt.Net;

namespace EBA_Kargo_Takip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string passwordHash = BCrypt.HashPassword(txtPassword.Text);
            bool isValidPassword = BCrypt.Verify(txtPassword.Text, passwordHash);

            if (isValidPassword)
            {
                MessageBox.Show("Login Successful");
            }
            else
            {
                MessageBox.Show("Invalid Password");
            }
        }
    }
}
