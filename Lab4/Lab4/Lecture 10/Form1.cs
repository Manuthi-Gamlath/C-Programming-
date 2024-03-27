using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con1 = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = D:\Yr1 Sem3\C#\Lab Sheets\Lab4\Lecture 10\Database1.mdf; Integrated Security = True");

            int ID = int.Parse(textID.Text);
            string Name=textName.Text;
            int Quantity=int.Parse(textQuantity.Text);
            int Price=int.Parse(textPrice.Text);

            string query = $"INSERT INTO good(ID,Name,Quantity,Price) VALUES {ID},'{Name},'{Quantity},'{Price}";

            SqlCommand cmd=new SqlCommand(query, con1);

            try
            {
                con1.Open();
                cmd.ExecuteNonQuery();
                con1.Close();
                MessageBox.Show("Value inserted");
            }
            catch 
            {
                MessageBox.Show(Exception.Message);
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
