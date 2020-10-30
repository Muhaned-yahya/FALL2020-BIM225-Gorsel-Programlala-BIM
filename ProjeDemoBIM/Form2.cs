using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjeDemoBIM
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblAnaYemek.Text = "";
            if (checkBox1.Checked == true)
            {
                lblAnaYemek.Text += checkBox1.Text + ",";
            }
            if (checkBox2.Checked == true)
            {
                lblAnaYemek.Text += checkBox2.Text + ",";
            }
            if (checkBox3.Checked == true)
            {
                lblAnaYemek.Text += checkBox3.Text + ",";
            }

            lblAnaYemek.Text = ReplaceCommawithDot(lblAnaYemek.Text);

            //string str = lblAnaYemek.Text;

            //if (str.Length > 0)
            //{
            //    str = str.Substring(0, lblAnaYemek.Text.Length - 1);
            //    lblAnaYemek.Text = str + ".";
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                lblDrinks.Text = radioButton1.Text;
            }
            else
            {
                if (radioButton2.Checked)
                {
                    lblDrinks.Text = radioButton2.Text;
                }
                else
                {
                    if (radioButton3.Checked)
                    {
                        lblDrinks.Text = radioButton3.Text;
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (checkedListBox1.GetItemChecked(i))
                {
                    label1.Text += checkedListBox1.Items[i].ToString()+ ", ";
                }
            }

            label1.Text = ReplaceCommawithDot(label1.Text);

            
        }

        private string ReplaceCommawithDot(string str)
        {
            if (str.Length > 0)
            {
                str = str.Substring(0, str.Length - 2);
                str = str + ".";
            }
            return str;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lblGender.Text = "";
            lblGender.ForeColor = Color.Black;

            if (cbGender.SelectedIndex==0)
            {
                lblGender.Text = cbGender.SelectedItem.ToString();
            }
            else
            {
                if (cbGender.SelectedIndex == 1)
                {
                    lblGender.Text = cbGender.SelectedItem.ToString();
                }
                else
                {
                    lblGender.Text = "Please select gender.";
                    lblGender.ForeColor = Color.Red;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //label4.Text = dateTimePicker1.Value.ToLongDateString();
            //label4.Text = dateTimePicker1.Value.ToShortDateString();
            label4.Text = dateTimePicker2.Value.ToLongTimeString();
            //label4.Text = dateTimePicker2.Value.ToShortTimeString();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count>0)
            {
                foreach (var item in listBox1.SelectedItems)
                {
                    listBox2.Items.Add(item);
                }

                while (listBox1.SelectedItems.Count>0)
                {
                    listBox1.Items.Remove(listBox1.SelectedItems[0]);
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count>0)
            {
                listBox2.Items.AddRange(listBox1.Items);
                listBox1.Items.Clear();
            }
        }
    }
}
