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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int ID=int.Parse(textBox1.Text);
            string Name=textBox1.Text;
            int Quantity=int.Parse(textBox2.Text);
            int Price=int.Parse(textBox3.Text); 

            string query3=$"T*FROM good WHERE ID={ID};

            SqlCommand cmd2 = new SqlCommand(query2, con1);

            try
            {
                con1.Open();
                SqlDataReader data = cmd2.ExecuteReader();
                if(data.HasRows)
                {
                    data.Read();
                    textBox1.Text = data["Name"].ToString();
                    textBox2.Text = data["Quantity"].ToString();
                    textBox3.Text = data["Price"].ToString();

                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
          int ID=int.Parse(textBox1.Text);
            string query4 = $"DELETE good WHERE ID={ID}";
            SqlCommand cmd3 = new SqlCommand(query4, con1);
            try
            {
                con1.Open();
                cmd3.ExecuteNonQuery();
                
            }
        }
    }
}
