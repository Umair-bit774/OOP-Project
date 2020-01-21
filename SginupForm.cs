using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Bakery_Software
{
    public partial class SginupForm : Form
    {
        public SginupForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            name.Clear();
            phone.Clear();
            gmail.Clear();
           address.Clear();
            password.Clear();
            conpass.Clear();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = "C:\Users\ch hassan\Downloads\Bakery_Software\Bakery_Software\Bakery_Software\Database2.accdb");

                
                OleDbCommand cmd = con.CreateCommand();
                con.Open();
            if (password.Text == conpass.Text)
            {
                cmd.CommandText = "Insert into signup(FirstName,LastName)Values('" + name.Text + "','" + phone.Text + "','" + address.Text + "','" + password.Text + "')";
            }

            else
            {
                MessageBox.Show("Enter correct Password");

            }



            cmd.Connection = con;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Submitted", "Congrats");
                con.Close(); 
            


        }
    }
}
