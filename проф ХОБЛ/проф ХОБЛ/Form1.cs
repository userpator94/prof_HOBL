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
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages["tabPage4"];
        }
    }
}
