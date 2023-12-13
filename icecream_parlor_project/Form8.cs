using Business_Layer;
using Guna.UI2.WinForms;
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
    public partial class Form8 : Form
    {
        List<String> customers = new List<String>();

        public Form8()
        {
            InitializeComponent();
            int j = 1;
            //guna2DataGridView1.DataSource = receivedList;
            //foreach (var item in receivedList)
            //{
            //    customers.Add(item);
            //}
            guna2DataGridView1.DataSource = null;
            guna2DataGridView1.DataSource = customers;

            for (int i = 0; i < guna2DataGridView1.RowCount; i++)
            {
                guna2DataGridView1.Rows[i].Cells[0].Value = j.ToString();
                j++;
                guna2DataGridView1.Rows[i].Cells[1].Value = customers[i].ToString();
            }
        }
    }
}
