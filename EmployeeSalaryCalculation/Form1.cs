using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeSalaryCalculation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            List<string> list = new List<string>() { "HR", "Admin", "Development", "Testing", "Sales", "Finance", "Marketing" };
            CmbDept.DataSource = list;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void ClickCalculate_Click(object sender, EventArgs e)
        {
            double bs = Convert.ToDouble(textBasic.Text);
            double hra = bs * 0.40;
            double ta = bs * 0.20;
            double Da = bs * 0.20;
            double pf = bs * 0.12;

            double gs = (bs + hra + ta + Da) - pf;
            textHra.Text=hra.ToString();
            textTa.Text=ta.ToString();
            textDA.Text=Da.ToString();
            textPF.Text=pf.ToString();
            textGS.Text=gs.ToString();

            MessageBox.Show("Calculated");

        }

        private void buttonDisplay_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Employee Details \nEmployeeId:"+textid.Text+"\nEmployee Name:"+textName.Text+"\nDepartmant:"+CmbDept.Text+"\nBasic Salary:"+textBasic.Text+
            "\nGross salary:"+textGS.Text);
            

        }

        private void textid_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
