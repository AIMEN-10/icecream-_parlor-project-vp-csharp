
using Business_layer;
using Business_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace icecream_parlor_project
{
    public partial class Form4 : Form
    {
        
        public Form4()
        {
            InitializeComponent();
            textBox1.Focus();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
           
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            try
            {
                Logic obj = new Logic();
                
                Admin a = new Admin
                {
                    email = textBox1.Text,
                    username=textBox3.Text,
                    password=textBox2.Text,

                };
                
                obj.SaveAdmin(a);
                MessageBox.Show("WELCOME");
                this.Hide();
                Form5 f=new Form5();
                f.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Form7 f = new Form7();
            f.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
