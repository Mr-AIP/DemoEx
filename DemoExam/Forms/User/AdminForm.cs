using DemoExam.Forms;
using System;
using System.Windows.Forms;

namespace DemoExam
{
    public partial class AdminForm : Form
    {
        decimal? _roleID;
        public AdminForm(string userName, decimal? roleID)
        {
            InitializeComponent();
            label1.Text = userName;
            _roleID = roleID;
        }

        private void buttonPerson_Click(object sender, EventArgs e)
        {

        }

        private void buttonOrders_Click(object sender, EventArgs e)
        {
            OrdersForm ordersForm = new OrdersForm(_roleID);
            ordersForm.ShowDialog();
        }

        private void AdminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ExitBtnAdmin(object sender, EventArgs e)
        {
            MainForm exit = new MainForm();
            this.Hide();
            exit.Show();
            
        }
    }
}
