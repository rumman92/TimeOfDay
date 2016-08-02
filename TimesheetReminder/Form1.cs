using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimesheetReminder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Check directory
            if (!(System.IO.Directory.Exists(Environment.CurrentDirectory + "//TimeOfDay")))
            {
                System.IO.Directory.CreateDirectory(Environment.CurrentDirectory + "//TimeOfDay");
            }

            // Monday
            if (comboBox1.Text == "")
            {
                System.IO.File.WriteAllText(Environment.CurrentDirectory + "//TimeOfDay//Monday.txt", "0");
            }
            else
            {
                System.IO.File.WriteAllText(Environment.CurrentDirectory + "//TimeOfDay//Monday.txt", comboBox1.Text);
            }

            // Tuesday
            if (comboBox2.Text == "")
            {
                System.IO.File.WriteAllText(Environment.CurrentDirectory + "//TimeOfDay//Tuesday.txt", "0");
            }
            else
            {
                System.IO.File.WriteAllText(Environment.CurrentDirectory + "//TimeOfDay//Tuesday.txt", comboBox2.Text);
            }

            // Wednesday
            if (comboBox3.Text == "")
            {
                System.IO.File.WriteAllText(Environment.CurrentDirectory + "//TimeOfDay//Wednesday.txt", "0");
            }
            else
            {
                System.IO.File.WriteAllText(Environment.CurrentDirectory + "//TimeOfDay//Wednesday.txt", comboBox3.Text);
            }

            // Thursday
            if (comboBox4.Text == "")
            {
                System.IO.File.WriteAllText(Environment.CurrentDirectory + "//TimeOfDay//Thursday.txt", "0");
            }
            else
            {
                System.IO.File.WriteAllText(Environment.CurrentDirectory + "//TimeOfDay//Thursday.txt", comboBox4.Text);
            }

            // Friday
            if (comboBox5.Text == "")
            {
                System.IO.File.WriteAllText(Environment.CurrentDirectory + "//TimeOfDay//Friday.txt", "0");
                System.IO.File.WriteAllText(Environment.CurrentDirectory + "//TimeOfDay//LastTime.txt", DateTime.Now.ToString());
            }
            else
            {
                System.IO.File.WriteAllText(Environment.CurrentDirectory + "//TimeOfDay//Friday.txt", comboBox5.Text);
                System.IO.File.WriteAllText(Environment.CurrentDirectory + "//TimeOfDay//LastTime.txt", DateTime.Now.ToString());
            }

            MessageBox.Show("Done", "Success");

            Form1_Load(null, null);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Text = "0";
            comboBox2.Text = "0";
            comboBox3.Text = "0";
            comboBox4.Text = "0";
            comboBox5.Text = "0";

            if (System.IO.File.Exists(Environment.CurrentDirectory + "//TimeOfDay//Monday.txt"))
            {
                comboBox1.Text = System.IO.File.ReadAllText(Environment.CurrentDirectory + "//TimeOfDay//Monday.txt");
                comboBox2.Text = System.IO.File.ReadAllText(Environment.CurrentDirectory + "//TimeOfDay//Tuesday.txt");
                comboBox3.Text = System.IO.File.ReadAllText(Environment.CurrentDirectory + "//TimeOfDay//Wednesday.txt");
                comboBox4.Text = System.IO.File.ReadAllText(Environment.CurrentDirectory + "//TimeOfDay//Thursday.txt");
                comboBox5.Text = System.IO.File.ReadAllText(Environment.CurrentDirectory + "//TimeOfDay//Friday.txt");
                string time = System.IO.File.ReadAllText(Environment.CurrentDirectory + "//TimeOfDay//LastTime.txt");

                Decimal mon = Convert.ToDecimal(comboBox1.Text);
                Decimal tue = Convert.ToDecimal(comboBox2.Text);
                Decimal wed = Convert.ToDecimal(comboBox3.Text);
                Decimal thu = Convert.ToDecimal(comboBox4.Text);
                Decimal fri = Convert.ToDecimal(comboBox5.Text);

                label8.Text = (mon + tue + wed + thu + fri).ToString();
                label9.Text = "Last file added on: " + time;
            }
        }
    }
}