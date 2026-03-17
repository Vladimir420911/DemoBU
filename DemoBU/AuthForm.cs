using System;
using System.Windows.Forms;
using ClassLib;

namespace DemoBU
{
    public partial class AuthForm : Form
    {
        MySqlModel model;
        User user;
        public AuthForm()
        {
            InitializeComponent();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            try
            {
                user = model.Authorize(LoginTextBox.Text, PasswordTextBox.Text);
                if (user == null)
                {
                    MessageBox.Show("Неверный логин или пароль");
                }
                else
                {
                    MainForm mainForm = new MainForm(model, user);
                    this.Hide();
                    mainForm.Show();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AuthForm_Load(object sender, EventArgs e)
        {
            model = new MySqlModel();
        }

        private void GuestButton_Click(object sender, EventArgs e)
        {
            user = null;
            MainForm mainForm = new MainForm(model, user);
            mainForm.Show();
        }
    }
}