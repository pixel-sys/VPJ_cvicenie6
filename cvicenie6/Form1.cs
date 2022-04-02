/*Xaver Zak*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cvicenie6
{
    public partial class Form1 : Form
    {
        double step;
        double min;
        double max;

        public Form1()
        {
            InitializeComponent();
            radioButton_F.CheckedChanged += new EventHandler(GroupBox_Changed);
            radioButton_C.CheckedChanged += new EventHandler(GroupBox_Changed);
        }

        public double celsius_2_fahrenheit(double input)
        {
            return (input * 1.8 + 32);
        }

        public double fahrenheit_2_celsius(double input)
        {
            return ((input - 32) / 1.8);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_purge_Click(object sender, EventArgs e)
        {
            listView_prevody.Items.Clear();
        }

        private void textBox_step_TextChanged(object sender, EventArgs e)
        {
            try
            { 
                step = Convert.ToDouble(textBox_step.Text.ToString());
                calculate_the_hell_out_of_it();
                errorProvider_step.Clear();
            }
            catch (Exception ex) 
            {
                errorProvider_step.SetError(textBox_step, "invalid input");
                step = 0;
            }
        }

        private void textBox_min_TextChanged(object sender, EventArgs e)
        {
            try
            { 
                min = Convert.ToDouble(textBox_min.Text.ToString());
                calculate_the_hell_out_of_it();  
                errorProvider_min.Clear();  
            }
            catch (Exception ex) 
            {
                errorProvider_min.SetError(textBox_min, "invalid input");
                min = 0;
            }
        }

        private void textBox_max_TextChanged(object sender, EventArgs e)
        {
            try 
            { 
                max = Convert.ToDouble(textBox_max.Text.ToString());
                calculate_the_hell_out_of_it();
                errorProvider_max.Clear();
            }
            catch (Exception ex) 
            {
                errorProvider_max.SetError(textBox_max, "invalid input");
                max = 0;
            }
        }

        private void GroupBox_Changed(object sender, EventArgs e)
        {
            RadioButton radio = sender as RadioButton;

            if (radioButton_F.Checked)
            {
                listView_prevody.Columns[0].Text = "Fahrenheit";
                listView_prevody.Columns[1].Text = "Celsius";
            }else
            {
                listView_prevody.Columns[1].Text = "Fahrenheit";
                listView_prevody.Columns[0].Text = "Celsius";
            }

            calculate_the_hell_out_of_it();

        }

        private bool check_inputs()
        {
            if(min >= max) { return false; }
            if(step <= 0 ) { return false; }

            return true;
        }
        private void calculate_the_hell_out_of_it()
        {
            listView_prevody.Items.Clear();
            if (check_inputs())
            {   
                if (radioButton_F.Checked == true)
                {
                    for (double i = min; i <= max; i += step)
                    {
                        ListViewItem lvi = new ListViewItem(i.ToString());
                        lvi.SubItems.Add(fahrenheit_2_celsius(i).ToString());
                        listView_prevody.Items.Add(lvi);
                    }
                }
                else
                {
                    for (double i = min; i <= max; i += step)
                    {
                        ListViewItem lvi = new ListViewItem(i.ToString());
                        lvi.SubItems.Add(celsius_2_fahrenheit(i).ToString());
                        listView_prevody.Items.Add(lvi);
                    }
                }
                
            }

        }
    }

        
}
