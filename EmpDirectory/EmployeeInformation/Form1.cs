using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmpInfo;

namespace EmployeeInformation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.EmployeeName = textEmpName.Text;
            emp.EmpId = textEmpID.Text;
            emp.Address = textEmpAddress.Text;
            emp.EmpPhone = textEmpPhone.Text;
            try
            {
                emp.EmpTweetID = textEmpTweetId.Text;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
