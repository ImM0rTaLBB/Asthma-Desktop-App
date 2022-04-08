using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AsthmaApp
{
    public partial class MainPage : Form
    {

        MYSQLCONNECTION conn = new MYSQLCONNECTION();

        public MainPage()
        {
            InitializeComponent();
        }

        public void disp_data() //show all data in datagridview
        {
            conn.Connection();
            conn.con.Open();
            MySqlCommand cmd = conn.con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Medicine";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            medicinegridview.DataSource = dt;
            conn.con.Close();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            disp_data();
        }


        private void medicinegridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginPage frm1 = new LoginPage();
            frm1.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "ID")
            {
                MySqlDataAdapter msda = new MySqlDataAdapter("SELECT * FROM Medicine WHERE MedicineID LIKE '" +textBox1.Text+ "%'", conn.con);
                DataTable dt = new DataTable();
                msda.Fill(dt);
                medicinegridview.DataSource = dt;
            }
            else if (comboBox1.Text == "Name")
            {
                MySqlDataAdapter msda = new MySqlDataAdapter("SELECT * FROM Medicine WHERE MedicineName LIKE '" + textBox1.Text + "%'", conn.con);
                DataTable dt = new DataTable();
                msda.Fill(dt);
                medicinegridview.DataSource = dt;
            }
        }

        private void medicinegridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = this.medicinegridview.Rows[e.RowIndex];
                label4.Text = row.Cells[0].Value.ToString();
                textBox3.Text = row.Cells[1].Value.ToString();
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            conn.Connection();
            conn.con.Open();
            MySqlCommand cmd = conn.con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT into Medicine(MedicineName) values('" + textBox3.Text + "')";
            cmd.ExecuteNonQuery();
            conn.con.Close();
            disp_data();
            MessageBox.Show("เพื่มตัวยาใหม่สำเร็จ", "การเพื่มยาใหม่", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Editbtn_Click(object sender, EventArgs e)
        {
            conn.Connection();
            conn.con.Open();
            MySqlCommand cmd = conn.con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE Medicine set MedicineName= '"+textBox3.Text+"' WHERE MedicineID='"+label4.Text+"'";
            cmd.ExecuteNonQuery();
            conn.con.Close();
            disp_data();
            MessageBox.Show("แก้ไขตัวยาสำเร็จ","การแก้ไขตัวยา", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
