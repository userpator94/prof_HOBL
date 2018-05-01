using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            antiPirat();
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

        //private void checkBox1_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (checkBox1.Checked == false) panel1.Enabled = false;
        //    else panel1.Enabled = true;
        //}

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
            test.StartPosition = FormStartPosition.CenterParent;
            test.Location = this.Location;
            test.Show(this);
            if (test.StartPosition == FormStartPosition.CenterParent)
            {
                var x = Location.X + (Width - test.Width) / 2;
                var y = Location.Y + (Height - test.Height) / 2;
                test.Location = new System.Drawing.Point(Math.Max(x, 0), Math.Max(y, 0));
            }
        }

        //private void checkBox2_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (checkBox2.Checked == false) butt_Test.Enabled = false;
        //    else butt_Test.Enabled = true;
        //}

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
                        
            string DS1 = "— Профессиональный контакт с промышленными аэрозолями.\n" +
                "  Отсутствуют признаки поражения лёгких.\n" +
                "  Нуждается в динамическом наблюдении";
            string DS2 = "— Профессиональная хроническая обструктивная болезнь лёгких:\n" ;
            string DS3 = "— Хроническая обструктивная болезнь лёгких." +
                "Профессиональный контакт с промышленными аэрозолями отсутствует" + 
                "Заболевание общее";

            //ЛЕЧЕНИЕ
            string cure_light = "1) Прекращение действия экзогенного этиопатогенетического фактора;\n" +
                "2) Отказ от курения;\n" + "3) Противогриппозная и антипневмококковая вакцинация;\n" +
                "4) Коротокодействующие бронходилататоры \"по требованию\": \n" +
                "    • м-Холиномиметики: ипратропия бромид 20мкг х 2 дозы;\n    • β-агонисты: фенотерол 100-200мкг х 1 доза;\n" +
                "5) Санаторно-курортное лечение.";
            string cure_medium = "1) Прекращение действия экзогенного этиопатогенетического фактора;\n" +
                "2) Отказ от курения;\n" + "3) Противогриппозная и антипневмококковая вакцинация;\n" +
                "4) Длительнодействующие бронхолитики\n" +
                "    • м-Холиномиметики: тиотропия бромид 18мг х 1 раз/сут\n" +
                "    • формотерол: ипратропия бромид 12мкг х 2 раз/сут;\n" +
                "5) Дополнительно при вязкой мокроте муколитики: N-АЦЦб амброксол\n" +
                "                 при обострениях: антибактериальные препараты: азитромицин, кларитромицин;\n" +
                "6) Санаторно-курортное лечение.";
            string cure_heavy = "1) Прекращение действия экзогенного этиопатогенетического фактора;\n" +
                "2) Отказ от курения;\n" + "3) Противогриппозная и антипневмококковая вакцинация;\n" +
                "4) Длительнодействующие бронхолитики;\n" +
                "    • м-Холиномиметики: тиотропия бромид 18мг х 1 раз/сут\n" +
                "    • формотерол: ипратропия бромид 12мкг х 2 раз/сут;\n" +
                "5) Пролонгированные теофиллины (теопек 300мкг х 1 раз; теотард 200мкг х 2 раз);\n" +
                "6) иГКС будесонид 200мкг х 1-2 раз/сут;\n" +
                "7) Дополнительно: муколитики: N-АЦЦб амброксол\n" +
                "                  антибиотики: азитромицин, кларитромицин 500мг х 2 раза\n" +
                "                  оксигенотерапия.";
            string cure_supa_heavy = "1) Прекращение действия экзогенного этиопатогенетического фактора;\n" +
                "2) Отказ от курения;\n" + "3) Противогриппозная и антипневмококковая вакцинация;\n" +
                "4) Длительнодействующие бронходилататоры через небулайзер\n" +
                "    • м-Холиномиметики: тиотропия бромид 18мг х 1 раз/сут\n" +
                "    • формотерол: ипратропия бромид 12мкг х 2 раз/сут\n" +
                "    • комбинированные препараты, длительные β-агонисты + иГКС\n" +
                "5)  иГКС будесонид 200мкг х 1-2 раз/сут;\n" +
                "6) Пролонгированные теофеллины;\n" +
                "7) Оксигенотерапия: 18г монопоточная 2-5 л/мин, гелиево-кислородные смеси;\n" +
                "8) Дополнительно: муколитики, антибактериальные препараты" +
                "9) Тренировка дыхательной мускулатуры;";


            //DS1
            if (checkedListBox1.CheckedItems.Count == 12 && radioButton1.Checked &&
                test.CAT<10 && radioButton10.Checked && comboBox4.SelectedIndex == 0 &&
                comboBox5.SelectedIndex == 0 && comboBox6.SelectedIndex == 0)
            {
                label52.Text = DS1;
            }

            //DS2   
            if (checkedListBox1.CheckedItems.Count == 12 && comboBox1.SelectedIndex != -1)
            {
                label52.Text = DS2;
                //light
                if (radioButton2.Checked && test.CAT < 10 && radioButton6.Checked &&
                    radioButton10.Checked && comboBox4.SelectedIndex == 1 &&
                    comboBox5.SelectedIndex == 1 && comboBox6.SelectedIndex == 0)
                {
                    label52.Text += "    лёгкой степени тяжести";
                    label54.Text = cure_light;
                }
                //medium
                if (radioButton3.Checked && test.CAT >= 10 && radioButton7.Checked &&
                    comboBox4.SelectedIndex == 1 && comboBox5.SelectedIndex == 1)
                {
                    label52.Text += "    среднетяжёлое течение";
                    label54.Text = cure_medium;
                }
                //heavy
                if (radioButton4.Checked && test.CAT >= 10)
                {
                    label52.Text += "    тяжёлое течение";
                    label54.Text = cure_heavy;
                }
                //super heavy
                if (radioButton5.Checked && test.CAT >= 10 && radioButton9.Checked && 
                    comboBox4.SelectedIndex == 1 && comboBox5.SelectedIndex == 1)
                {
                    label52.Text += "    крайне тяжёлое течение";
                    label54.Text = cure_supa_heavy;
                }
            }

            //DS3                  пожилой возраст
            if (checkedListBox2.CheckedItems.Count >=3 && comboBox3.SelectedIndex == 1)
            {
                label52.Text = DS3;
                //light
                if (radioButton2.Checked && test.CAT < 10 && radioButton6.Checked && radioButton10.Checked &&
                    comboBox4.SelectedIndex == 1 && comboBox5.SelectedIndex == 1 && comboBox6.SelectedIndex == 0)
                {
                    label52.Text += "    лёгкое течение";                    
                }
                //medium
                if (radioButton3.Checked && test.CAT >= 10 && radioButton7.Checked && comboBox5.SelectedIndex == 1)
                {
                    label52.Text += "    среднетяжёлое течение";
                }
                //heavy
                if (radioButton4.Checked && test.CAT >= 10 && radioButton8.Checked && comboBox4.SelectedIndex == 1 
                    && comboBox5.SelectedIndex == 1)
                {
                    label52.Text += "    тяжёлое течение";
                }
                //super heavy
                if (radioButton5.Checked && test.CAT >= 10 && radioButton9.Checked &&
                    comboBox4.SelectedIndex == 1 && comboBox5.SelectedIndex == 1)
                {
                    label52.Text += "    крайне тяжёлое течение";
                }
            }

            LOG();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages["tabPage4"];
        }

        private void button8_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages["tabPage1"];
        }
        
        private void antiPirat()
        {
            DateTime today = DateTime.Today;
            DateTime endDate = Convert.ToDateTime("4.05.2018");

            //string Gdate = "1.05.2018";
            //DateTime.TryParse(Gdate, out date2);
            TimeSpan ts = today - endDate;
            if (ts.Days >= 0)
            {
                MessageBox.Show("Неоплаченный период истёк", "Внимание",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
                Timer timer = new Timer() { Interval = 3000, Enabled = true };
                timer.Tick += new EventHandler(timer_Tick);
            }
        }
        static void timer_Tick(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            (sender as Timer).Enabled = false;
            System.Windows.Forms.Application.Exit();
        }

        private void LOG()
        {
            string dir = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            //получить доступ к  существующему либо создать новый
            StreamWriter file = new StreamWriter(dir + @"\log.txt", true);

            file.WriteLine(Convert.ToString(DateTime.Now) + "\n");        
            if (checkBox3.Checked) file.WriteLine("CheckBox: " + checkBox3.Text + "  Namr: " + checkBox3.Name + "\n\r");           
            if (checkBox4.Checked) file.WriteLine("CheckBox: " + checkBox4.Text + "  Namr: " + checkBox4.Name + "\n\r");
            if (checkBox5.Checked) file.WriteLine("CheckBox: " + checkBox5.Text + "  Namr: " + checkBox5.Name + "\n\r");
            if (checkBox6.Checked) file.WriteLine("CheckBox: " + checkBox6.Text + "  Namr: " + checkBox6.Name + "\n\r");
            if (checkBox7.Checked) file.WriteLine("CheckBox: " + checkBox7.Text + "  Namr: " + checkBox7.Name + "\n\r");
            if (comboBox1.SelectedIndex != -1) file.WriteLine("comboBox: " + comboBox1.SelectedItem.ToString()
                    + "  Name: " + comboBox1.Name + "\n\r");
            if (comboBox2.SelectedIndex != -1) file.WriteLine("comboBox: " + comboBox2.SelectedItem.ToString()
                    + "  Name: " + comboBox2.Name + "\n\r");
            if (comboBox3.SelectedIndex != -1) file.WriteLine("comboBox: " + comboBox3.SelectedItem.ToString()
                    + "  Name: " + comboBox3.Name + "\n\r");
            if (comboBox4.SelectedIndex != -1) file.WriteLine("comboBox: " + comboBox4.SelectedItem.ToString()
                    + "  Name: " + comboBox4.Name + "\n\r");
            if (comboBox5.SelectedIndex != -1) file.WriteLine("comboBox: " + comboBox5.SelectedItem.ToString()
                    + "  Name: " + comboBox5.Name + "\n\r");
            if (comboBox6.SelectedIndex != -1) file.WriteLine("comboBox: " + comboBox6.SelectedItem.ToString()
                    + "  Name: " + comboBox6.Name + "\n\r");

            foreach (RadioButton rb in panel2.Controls)
            {
                if (rb.Checked) 
                    file.WriteLine(rb.Text + " (" + rb.Name + ") " + "\n\r");
            }
            foreach (RadioButton rb in panel3.Controls)
            {
                if (rb.Checked) file.WriteLine(rb.Text + " (" + rb.Name + ") " + "\n\r"); 
            }
            foreach (RadioButton rb in panel4.Controls)
            {
                if (rb.Checked) 
                    file.WriteLine(rb.Text + " (" + rb.Name + ") " + "\n\r"); 
            }



            //TabPage tp;
            //for (int i = 1; i <= 6; i++)
            //{
            //    string tabPag = "tabPage" + i.ToString();
            //    tp = tabControl1.TabPages[tabPag];
            //    log += tabPag + "\n";

            //    for (int j = 1; j <= 6; j++)
            //    {
            //        if ((tp.Controls["comboBox" + j.ToString()] as ComboBox).SelectedIndex != -1)
            //        {
            //            log += "ComboBoxes\n";
            //            log += tp.Controls["comboBox" + j.ToString()].Text + 
            //                " (" + tp.Controls["comboBox" + j.ToString()].Name + ") " + "\n";
            //        }
            //    }
            //    for (int j = 1; j <= 6; j++)
            //    {
            //        if ((tp.Controls["checkBox" + j.ToString()] as CheckBox).Checked)
            //        {
            //            log += "CheckBoxes\n";
            //            log += tp.Controls["checkBox" + j.ToString()].Text +
            //                " (" + tp.Controls["checkBox" + j.ToString()].Name + ") " + "\n";
            //        }
            //    }
            //    //foreach (CheckBox cb in tp.Controls)
            //    //{
            //    //    log += "CheckBoxes\n";
            //    //    if (cb.Checked) log += cb.Text + " (" + cb.Name + ") " + "\n";
            //    //}  // as CheckBox
            //    //foreach (ComboBox cb in tp.Controls)
            //    //{
            //    //    log += "ComboBoxes\n";
            //    //    if (cb.SelectedIndex != -1) log += cb.Text + " (" + cb.Name + ") " + "\n";
            //    //}
            //    //foreach (RadioButton rb in tp.Controls)
            //    //{
            //    //    log += "RadioButton\n";
            //    //    if (rb.Checked) log += rb.Text + " (" + rb.Name + ") " + "\n";
            //    //}
            //}

            if(test!=null)
            file.WriteLine ("CAT score " + test.CAT + "\n");

            //file.WriteLine("checkedListBox1: " + checkedListBox1.SelectedItems.ToString() + "\n   " );
            //file.WriteLine("checkedListBox2: " + checkedListBox2.SelectedItems.ToString() + "\n   ");

            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (checkedListBox1.GetItemChecked(i))
                {
                    file.WriteLine("checkedListBox1: " + checkedListBox1.Items[i].ToString());
                }
            }
            for (int i = 0; i < checkedListBox2.Items.Count; i++)
            {
                if (checkedListBox2.GetItemChecked(i))
                {
                    file.WriteLine("checkedListBox2: "+checkedListBox1.Items[i].ToString());
                }
            }

            // Next show the object title and check state for each item selected.
            //foreach (var itemChecked in checkedListBox1.CheckedItems)
            //{
            //    // Use the IndexOf method to get the index of an item.
            //    log += checkedListBox1.Text + "\n   " + itemChecked.ToString() + "\", is checked. Checked state is: " +
            //        checkedListBox1.GetItemCheckState(checkedListBox1.Items.IndexOf(itemChecked)).ToString() + ".\n";
            //}
            //foreach (object itemChecked in checkedListBox2.CheckedItems)
            //{
            //    // Use the IndexOf method to get the index of an item.
            //    log += checkedListBox2.Text + "\n   " + itemChecked.ToString() + "\", is checked. Checked state is: " +
            //        checkedListBox2.GetItemCheckState(checkedListBox2.Items.IndexOf(itemChecked)).ToString() + ".\n";
            //}

            //закрыть для сохранения данных
            file.Close();

        }
    }
}
