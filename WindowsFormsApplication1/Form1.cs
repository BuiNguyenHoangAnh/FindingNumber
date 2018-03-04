using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] a = new int[30];
        int k, diem, tg;

        private void bt_exit_Click(object sender, EventArgs e)
        {
            DialogResult rp;
            rp = MessageBox.Show("Are you sure?", "message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rp == DialogResult.Yes)
                Application.Exit();
        }

        private void bt_start_Click(object sender, EventArgs e)
        {
            tg = 30;
            diem = 0;
            this.lb_score.Text = diem.ToString();
            this.timer1.Interval = 1000;
            this.timer1.Enabled = true;
            this.lb_timeout.Visible = false;
            this.pictureBox1.Visible = false;
            k = 0;
            int n = 30;
            int[] b = new int[30];
            for (int i = 0; i < n; i++)
                b[i] = i + 1;
            Random r = new Random();
            for (int i = 0; i < 30;i++ )
            {
                int temp = r.Next(0, n);
                a[i] = b[temp];
                for (int j = temp; j < n - 1; j++)
                    b[j] = b[j + 1];
                n--;
            }
                //while(j>=0)
                //{
                //    if (a[i] == a[j])
                //    {
                //        Random t = new Random();
                //        a[i] = t.Next(0, 30);
                //        j = i;
                //    }
                //    else
                //        j--;
                //}
                this.label1.Visible = true;
            this.label10.Visible = true;
            this.label11.Visible = true;
            this.label12.Visible = true;
            this.label13.Visible = true;
            this.label14.Visible = true;
            this.label15.Visible = true;
            this.label16.Visible = true;
            this.label17.Visible = true;
            this.label18.Visible = true;
            this.label19.Visible = true;
            this.label2.Visible = true;
            this.label20.Visible = true;
            this.label21.Visible = true;
            this.label22.Visible = true;
            this.label23.Visible = true;
            this.label24.Visible = true;
            this.label25.Visible = true;
            this.label26.Visible = true;
            this.label27.Visible = true;
            this.label28.Visible = true;
            this.label29.Visible = true;
            this.label3.Visible = true;
            this.label30.Visible = true;
            this.label4.Visible = true;
            this.label5.Visible = true;
            this.label6.Visible = true;
            this.label7.Visible = true;
            this.label8.Visible = true;
            this.label9.Visible = true;
            this.label1.Text = Convert.ToString(a[1]);
            this.label2.Text = Convert.ToString(a[2]);
            this.label3.Text = Convert.ToString(a[3]);
            this.label4.Text = Convert.ToString(a[4]);
            this.label5.Text = Convert.ToString(a[5]);
            this.label6.Text = Convert.ToString(a[6]);
            this.label7.Text = Convert.ToString(a[7]);
            this.label8.Text = Convert.ToString(a[8]);
            this.label9.Text = Convert.ToString(a[9]);
            this.label10.Text = Convert.ToString(a[10]);
            this.label11.Text = Convert.ToString(a[11]);
            this.label12.Text = Convert.ToString(a[12]);
            this.label13.Text = Convert.ToString(a[13]);
            this.label14.Text = Convert.ToString(a[14]);
            this.label15.Text = Convert.ToString(a[15]);
            this.label16.Text = Convert.ToString(a[16]);
            this.label17.Text = Convert.ToString(a[17]);
            this.label18.Text = Convert.ToString(a[18]);
            this.label19.Text = Convert.ToString(a[19]);
            this.label20.Text = Convert.ToString(a[20]);
            this.label21.Text = Convert.ToString(a[21]);
            this.label22.Text = Convert.ToString(a[22]);
            this.label23.Text = Convert.ToString(a[23]);
            this.label24.Text = Convert.ToString(a[24]);
            this.label25.Text = Convert.ToString(a[25]);
            this.label26.Text = Convert.ToString(a[26]);
            this.label27.Text = Convert.ToString(a[27]);
            this.label28.Text = Convert.ToString(a[28]);
            this.label29.Text = Convert.ToString(a[29]);
            this.label30.Text = Convert.ToString(a[0]);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            int temp = Convert.ToInt32(this.label5.Text);
            if (temp == k + 1)
            {
                this.label5.Visible = false;
                k++;
                int s = Convert.ToInt32(this.lb_score.Text);
                s += 10;
                this.lb_score.Text = s.ToString();
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            int temp = Convert.ToInt32(this.label1.Text);
            if (temp == k + 1)
            {
                this.label1.Visible = false;
                k++;
                int s = Convert.ToInt32(this.lb_score.Text);
                s += 10;
                diem = s;
                this.lb_score.Text = s.ToString();
                if (tg >= 0 && diem == 300)
                {
                    this.pictureBox1.Visible = true;
                    this.timer1.Enabled = false;
                }
            }
        }

        private void label30_Click_1(object sender, EventArgs e)
        {
            int temp = Convert.ToInt32(this.label30.Text);
            if (temp == k + 1)
            {
                this.label30.Visible = false;
                k++;
                int s = Convert.ToInt32(this.lb_score.Text);
                s += 10;
                diem = s;
                this.lb_score.Text = s.ToString();
                if (tg >= 0 && diem == 300)
                {
                    this.pictureBox1.Visible = true;
                    this.timer1.Enabled = false;
                }
            }
        }

        private void label29_Click(object sender, EventArgs e)
        {
            int temp = Convert.ToInt32(this.label29.Text);
            if (temp == k + 1)
            {
                this.label29.Visible = false;
                k++;
                int s = Convert.ToInt32(this.lb_score.Text);
                s += 10;
                diem = s;
                this.lb_score.Text = s.ToString();
                if (tg >= 0 && diem == 300)
                {
                    this.pictureBox1.Visible = true;
                    this.timer1.Enabled = false;
                }
            }
        }

        private void label28_Click(object sender, EventArgs e)
        {
            int temp = Convert.ToInt32(this.label28.Text);
            if (temp == k + 1)
            {
                this.label28.Visible = false;
                k++;
                int s = Convert.ToInt32(this.lb_score.Text);
                s += 10;
                diem = s;
                this.lb_score.Text = s.ToString();
                if (tg >= 0 && diem == 300)
                {
                    this.pictureBox1.Visible = true;
                    this.timer1.Enabled = false;
                }
            }
        }

        private void label27_Click(object sender, EventArgs e)
        {
            int temp = Convert.ToInt32(this.label27.Text);
            if (temp == k + 1)
            {
                this.label27.Visible = false;
                k++;
                int s = Convert.ToInt32(this.lb_score.Text);
                s += 10;
                diem = s;
                this.lb_score.Text = s.ToString();
                if (tg >= 0 && diem == 300)
                {
                    this.pictureBox1.Visible = true;
                    this.timer1.Enabled = false;
                }
            }
        }

        private void label26_Click(object sender, EventArgs e)
        {
            int temp = Convert.ToInt32(this.label26.Text);
            if (temp == k + 1)
            {
                this.label26.Visible = false;
                k++;
                int s = Convert.ToInt32(this.lb_score.Text);
                s += 10;
                diem = s;
                this.lb_score.Text = s.ToString();
                if (tg >= 0 && diem == 300)
                {
                    this.pictureBox1.Visible = true;
                    this.timer1.Enabled = false;
                }
            }
        }

        private void label25_Click(object sender, EventArgs e)
        {
            int temp = Convert.ToInt32(this.label25.Text);
            if (temp == k + 1)
            {
                this.label25.Visible = false;
                k++;
                int s = Convert.ToInt32(this.lb_score.Text);
                s += 10;
                diem = s;
                this.lb_score.Text = s.ToString();
                if (tg >= 0 && diem == 300)
                {
                    this.pictureBox1.Visible = true;
                    this.timer1.Enabled = false;
                }
            }
        }

        private void label24_Click(object sender, EventArgs e)
        {
            int temp = Convert.ToInt32(this.label24.Text);
            if (temp == k + 1)
            {
                this.label24.Visible = false;
                k++;
                int s = Convert.ToInt32(this.lb_score.Text);
                s += 10;
                diem = s;
                this.lb_score.Text = s.ToString();
                if (tg >= 0 && diem == 300)
                {
                    this.pictureBox1.Visible = true;
                    this.timer1.Enabled = false;
                }
            }
        }

        private void label23_Click(object sender, EventArgs e)
        {
            int temp = Convert.ToInt32(this.label23.Text);
            if (temp == k + 1)
            {
                this.label23.Visible = false;
                k++;
                int s = Convert.ToInt32(this.lb_score.Text);
                s += 10;
                this.lb_score.Text = s.ToString();
                if (tg >= 0 && diem == 300)
                {
                    this.pictureBox1.Visible = true;
                    this.timer1.Enabled = false;
                }
            }
        }

        private void label22_Click(object sender, EventArgs e)
        {
            int temp = Convert.ToInt32(this.label22.Text);
            if (temp == k + 1)
            {
                this.label22.Visible = false;
                k++;
                int s = Convert.ToInt32(this.lb_score.Text);
                s += 10;
                diem = s;
                this.lb_score.Text = s.ToString();
                if (tg >= 0 && diem == 300)
                {
                    this.pictureBox1.Visible = true;
                    this.timer1.Enabled = false;
                }
            }
        }

        private void label21_Click(object sender, EventArgs e)
        {
            int temp = Convert.ToInt32(this.label21.Text);
            if (temp == k + 1)
            {
                this.label21.Visible = false;
                k++;
                int s = Convert.ToInt32(this.lb_score.Text);
                s += 10;
                diem = s;
                this.lb_score.Text = s.ToString();
                if (tg >= 0 && diem == 300)
                {
                    this.pictureBox1.Visible = true;
                    this.timer1.Enabled = false;
                }
            }
        }

        private void label20_Click(object sender, EventArgs e)
        {
            int temp = Convert.ToInt32(this.label20.Text);
            if (temp == k + 1)
            {
                this.label20.Visible = false;
                k++;
                int s = Convert.ToInt32(this.lb_score.Text);
                s += 10;
                diem = s;
                this.lb_score.Text = s.ToString();
                if (tg >= 0 && diem == 300)
                {
                    this.pictureBox1.Visible = true;
                    this.timer1.Enabled = false;
                }
            }
        }

        private void label19_Click(object sender, EventArgs e)
        {
            int temp = Convert.ToInt32(this.label19.Text);
            if (temp == k + 1)
            {
                this.label19.Visible = false;
                k++;
                int s = Convert.ToInt32(this.lb_score.Text);
                s += 10;
                diem = s;
                this.lb_score.Text = s.ToString();
                if (tg >= 0 && diem == 300)
                {
                    this.pictureBox1.Visible = true;
                    this.timer1.Enabled = false;
                }
            }
        }

        private void label18_Click(object sender, EventArgs e)
        {
            int temp = Convert.ToInt32(this.label18.Text);
            if (temp == k + 1)
            {
                this.label18.Visible = false;
                k++;
                int s = Convert.ToInt32(this.lb_score.Text);
                s += 10;
                diem = s;
                this.lb_score.Text = s.ToString();
                if (tg >= 0 && diem == 300)
                {
                    this.pictureBox1.Visible = true;
                    this.timer1.Enabled = false;
                }
            }
        }

        private void label17_Click(object sender, EventArgs e)
        {
            int temp = Convert.ToInt32(this.label17.Text);
            if (temp == k + 1)
            {
                this.label17.Visible = false;
                k++;
                int s = Convert.ToInt32(this.lb_score.Text);
                s += 10;
                diem = s;
                this.lb_score.Text = s.ToString();
                if (tg >= 0 && diem == 300)
                {
                    this.pictureBox1.Visible = true;
                    this.timer1.Enabled = false;
                }
            }
        }

        private void label16_Click(object sender, EventArgs e)
        {
            int temp = Convert.ToInt32(this.label16.Text);
            if (temp == k + 1)
            {
                this.label16.Visible = false;
                k++;
                int s = Convert.ToInt32(this.lb_score.Text);
                s += 10;
                diem = s;
                this.lb_score.Text = s.ToString();
                if (tg >= 0 && diem == 300)
                {
                    this.pictureBox1.Visible = true;
                    this.timer1.Enabled = false;
                }
            }
        }

        private void label15_Click(object sender, EventArgs e)
        {
            int temp = Convert.ToInt32(this.label15.Text);
            if (temp == k + 1)
            {
                this.label15.Visible = false;
                k++;
                int s = Convert.ToInt32(this.lb_score.Text);
                s += 10;
                diem = s;
                this.lb_score.Text = s.ToString();
                if (tg >= 0 && diem == 300)
                {
                    this.pictureBox1.Visible = true;
                    this.timer1.Enabled = false;
                }
            }
        }

        private void label14_Click(object sender, EventArgs e)
        {
            int temp = Convert.ToInt32(this.label14.Text);
            this.label14.Visible = false;
            if (temp == k + 1)
            {
                this.label14.Visible = false;
                k++;
                int s = Convert.ToInt32(this.lb_score.Text);
                s += 10;
                diem = s;
                this.lb_score.Text = s.ToString();
                if (tg >= 0 && diem == 300)
                {
                    this.pictureBox1.Visible = true;
                    this.timer1.Enabled = false;
                }
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {
            int temp = Convert.ToInt32(this.label13.Text);
            if (temp == k + 1)
            {
                this.label13.Visible = false;
                k++;
                int s = Convert.ToInt32(this.lb_score.Text);
                s += 10;
                diem = s;
                this.lb_score.Text = s.ToString();
                if (tg >= 0 && diem == 300)
                {
                    this.pictureBox1.Visible = true;
                    this.timer1.Enabled = false;
                }
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {
            int temp = Convert.ToInt32(this.label12.Text);
            if (temp == k + 1)
            {
                this.label12.Visible = false;
                k++;
                int s = Convert.ToInt32(this.lb_score.Text);
                s += 10;
                diem = s;
                this.lb_score.Text = s.ToString();
                if (tg >= 0 && diem == 300)
                {
                    this.pictureBox1.Visible = true;
                    this.timer1.Enabled = false;
                }
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {
            int temp = Convert.ToInt32(this.label11.Text);
            if (temp == k + 1)
            {
                this.label11.Visible = false;
                k++;
                int s = Convert.ToInt32(this.lb_score.Text);
                s += 10;
                diem = s;
                this.lb_score.Text = s.ToString();
                if (tg >= 0 && diem == 300)
                {
                    this.pictureBox1.Visible = true;
                    this.timer1.Enabled = false;
                }
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {
            int temp = Convert.ToInt32(this.label10.Text);
            if (temp == k + 1)
            {
                this.label10.Visible = false;
                k++;
                int s = Convert.ToInt32(this.lb_score.Text);
                s += 10;
                diem = s;
                this.lb_score.Text = s.ToString();
                if (tg >= 0 && diem == 300)
                {
                    this.pictureBox1.Visible = true;
                    this.timer1.Enabled = false;
                }
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            int temp = Convert.ToInt32(this.label9.Text);
            if (temp == k + 1)
            {
                this.label9.Visible = false;
                k++;
                int s = Convert.ToInt32(this.lb_score.Text);
                s += 10;
                diem = s;
                this.lb_score.Text = s.ToString();
                if (tg >= 0 && diem == 300)
                {
                    this.pictureBox1.Visible = true;
                    this.timer1.Enabled = false;
                }
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            int temp = Convert.ToInt32(this.label8.Text);
            if (temp == k + 1)
            {
                this.label8.Visible = false;
                k++;
                int s = Convert.ToInt32(this.lb_score.Text);
                s += 10;
                diem = s;
                this.lb_score.Text = s.ToString();
                if (tg >= 0 && diem == 300)
                {
                    this.pictureBox1.Visible = true;
                    this.timer1.Enabled = false;
                }
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            int temp = Convert.ToInt32(this.label7.Text);
            if (temp == k + 1)
            {
                this.label7.Visible = false;
                k++;
                int s = Convert.ToInt32(this.lb_score.Text);
                s += 10;
                diem = s;
                this.lb_score.Text = s.ToString();
                if (tg >= 0 && diem == 300)
                {
                    this.pictureBox1.Visible = true;
                    this.timer1.Enabled = false;
                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            int temp = Convert.ToInt32(this.label6.Text);
            if (temp == k + 1)
            {
                this.label6.Visible = false;
                k++;
                int s = Convert.ToInt32(this.lb_score.Text);
                s += 10;
                diem = s;
                this.lb_score.Text = s.ToString();
                if (tg >= 0 && diem == 300)
                {
                    this.pictureBox1.Visible = true;
                    this.timer1.Enabled = false;
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            int temp = Convert.ToInt32(this.label4.Text);
            if (temp == k + 1)
            {
                this.label4.Visible = false;
                k++;
                int s = Convert.ToInt32(this.lb_score.Text);
                s += 10;
                diem = s;
                this.lb_score.Text = s.ToString();
                if (tg >= 0 && diem == 300)
                {
                    this.pictureBox1.Visible = true;
                    this.timer1.Enabled = false;
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            int temp = Convert.ToInt32(this.label3.Text);
            if (temp == k + 1)
            {
                this.label3.Visible = false;
                k++;
                int s = Convert.ToInt32(this.lb_score.Text);
                s += 10;
                diem = s;
                this.lb_score.Text = s.ToString();
                if (tg >= 0 && diem == 300)
                {
                    this.pictureBox1.Visible = true;
                    this.timer1.Enabled = false;
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            int temp = Convert.ToInt32(this.label2.Text);
            if (temp == k + 1)
            {
                this.label2.Visible = false;
                k++;
                int s = Convert.ToInt32(this.lb_score.Text);
                s += 10;
                diem = s;
                this.lb_score.Text = s.ToString();
                if (tg >= 0 && diem == 300)
                {
                    this.pictureBox1.Visible = true;
                    this.timer1.Enabled = false;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tg--;
            if(tg==0 && diem<300)
            {
                this.lb_time.Text = tg.ToString();
                this.timer1.Enabled = false;
                this.lb_timeout.Visible = true;
            }
            else
            {
                this.lb_time.Text = tg.ToString();
            }
        }
    }
}
