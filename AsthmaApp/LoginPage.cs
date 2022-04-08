using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsthmaApp
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            if  (usernametxt.Text == "admin" && passwordtxt.Text == "1234")
            {
                MainPage frm = new MainPage();
                frm.Show();
                MessageBox.Show("สวัสดี Admin","ยินดีต้อนรับ",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Hide();
            }
            else
            {
                MessageBox.Show("ชื่อผู้ใช้หรือรหัสผ่านของท่านผิด กรุณากรอกใหม่", "คำเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                usernametxt.Clear();
                passwordtxt.Clear();
                usernametxt.Focus();
            }
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
