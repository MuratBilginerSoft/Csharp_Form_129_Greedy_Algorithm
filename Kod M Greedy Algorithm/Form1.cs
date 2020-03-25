using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace Kod_M_Greedy_Algorithm
{
    public partial class Form1 : Form
    {
        #region Tanımlamalar

        ArrayList banknot2 = new ArrayList();
        ArrayList banknot3 = new ArrayList();
        public static int[] banknot1 = new int[m];

        #endregion

        #region Değişkenler

        public static int m = 0;
        public static int para;
        public static int n = 0;
        public static int t = 0;

        #endregion


        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Array.Resize(ref banknot1, Convert.ToInt32(numericUpDown1.Value));
            
            label3.Text = "Banknot Sayısı Gönderildi";
            numericUpDown1.Value = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                banknot1[m] = Convert.ToInt32(numericUpDown2.Value);
                listView1.Items.Add(banknot1[m].ToString());
                numericUpDown2.Value = 0;
                m++;
                panel1.BackColor = Color.DeepSkyBlue;
                label3.Text = "Banknot Eklendi";
            }
            catch (Exception)
            {
                panel1.BackColor = Color.Red;
                label3.Text = "Farklı Banknot Değerini Aşamassınız";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Array.Sort(banknot1);
            Array.Reverse(banknot1);

            para = int.Parse(textBox1.Text);
            int m1 = 0;

            for (int i = 0; i < banknot1.Length; i++)
            {
                if (para / Convert.ToInt32(banknot1[i]) >= 1)
                {

                    n = para / Convert.ToInt32(banknot1[i]);
                    banknot2.Add(banknot1[i]);
                    banknot3.Add(n);
                    listView1.Items[m1].SubItems.Add(banknot1[i].ToString());
                    listView1.Items[m1].SubItems.Add(n.ToString());
                    para = para % Convert.ToInt32(banknot1[i]);
                    m1++;
                }
            }
            panel1.BackColor = Color.DeepSkyBlue;
            label3.Text = "Para Verildi";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            m = 0;
            n = 0;
            t = 0;
            textBox1.Clear();
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            label3.Text = "Durum";
            banknot1 = new int[0];
            listView1.Items.Clear();
        }
    }
}
