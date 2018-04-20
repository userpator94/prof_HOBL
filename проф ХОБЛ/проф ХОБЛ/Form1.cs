using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace проф_ХОБЛ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages["tabPage2"];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages["tabPage3"];
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false) panel1.Enabled = false;
            else panel1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages["tabPage1"];
        }

        Form2 test;
        private void butt_Test_Click(object sender, EventArgs e)
        {
            
            if (test == null || test.IsDisposed)
            {
                test = new Form2();                
            }
            test.Show();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == false) butt_Test.Enabled = false;
            else butt_Test.Enabled = true;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                checkBox4.Enabled = false;
                checkBox5.Enabled = false;
            }
            else
            {
                checkBox4.Enabled = true;
                checkBox5.Enabled = true;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked || checkBox5.Checked)
            {
                checkBox3.Checked = false;
                checkBox3.Enabled = false;
            }
            else 
                checkBox3.Enabled = true; 
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked || checkBox5.Checked)
            {
                checkBox3.Checked = false;
                checkBox3.Enabled = false;
            }
            else checkBox3.Enabled = true; 
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages["tabPage4"];
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages["tabPage5"];
        }

        private void button7_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages["tabPage6"];
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages["tabPage4"];
        }
    }
}
