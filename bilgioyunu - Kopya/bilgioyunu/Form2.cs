using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace bilgioyunu
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        SqlConnection baglan = new SqlConnection("Data Source=RMYS\\SQLEXPRESS;Initial Catalog=DbBilgiYarismasi;Integrated Security=True");


        int sayac = 0;
        int puan = 0;
        int sure = 10;
        private void button5_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            sure = 10;

            button1.BackColor = Color.MistyRose;
            button2.BackColor = Color.MistyRose;
            button3.BackColor = Color.MistyRose;
            button4.BackColor = Color.MistyRose;

            btnbasla.Enabled = false;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            btnbasla.Text = "SONRAKİ";
            sayac++;
            lblsoru.Text = sayac.ToString();

            if (sayac == 1)
            {

                baglan.Open();
                SqlCommand komut = new SqlCommand("select * from bilgiyarismasi1 order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    button1.Text = (oku["a"].ToString());
                    button2.Text = (oku["b"].ToString());
                    button3.Text = (oku["c"].ToString());
                    button4.Text = (oku["d"].ToString());
                    textBox1.Text = (oku["soru"].ToString());
                    lbldogru.Text = (oku["dogru"].ToString());
                }
                baglan.Close();
            }

            if (sayac == 2)
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand("select * from bilgiyarismasi2 order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    button1.Text = (oku["a"].ToString());
                    button2.Text = (oku["b"].ToString());
                    button3.Text = (oku["c"].ToString());
                    button4.Text = (oku["d"].ToString());
                    textBox1.Text = (oku["soru"].ToString());
                    lbldogru.Text = (oku["dogru"].ToString());
                }
                baglan.Close();
            }
            if (sayac == 3)
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand("select * from bilgiyarismasi3 order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    button1.Text = (oku["a"].ToString());
                    button2.Text = (oku["b"].ToString());
                    button3.Text = (oku["c"].ToString());
                    button4.Text = (oku["d"].ToString());
                    textBox1.Text = (oku["soru"].ToString());
                    lbldogru.Text = (oku["dogru"].ToString());
                }
                baglan.Close();
            }
            if (sayac == 4)
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand("select * from bilgiyarismasi4 order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    button1.Text = (oku["a"].ToString());
                    button2.Text = (oku["b"].ToString());
                    button3.Text = (oku["c"].ToString());
                    button4.Text = (oku["d"].ToString());
                    textBox1.Text = (oku["soru"].ToString());
                    lbldogru.Text = (oku["dogru"].ToString());
                }
                baglan.Close();
            }
            if (sayac == 5)
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand("select * from bilgiyarismasi5 order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    button1.Text = (oku["a"].ToString());
                    button2.Text = (oku["b"].ToString());
                    button3.Text = (oku["c"].ToString());
                    button4.Text = (oku["d"].ToString());
                    textBox1.Text = (oku["soru"].ToString());
                    lbldogru.Text = (oku["dogru"].ToString());
                }
                baglan.Close();
            }
            if (sayac == 6)
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand("select * from bilgiyarismasi6 order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    button1.Text = (oku["a"].ToString());
                    button2.Text = (oku["b"].ToString());
                    button3.Text = (oku["c"].ToString());
                    button4.Text = (oku["d"].ToString());
                    textBox1.Text = (oku["soru"].ToString());
                    lbldogru.Text = (oku["dogru"].ToString());
                }
                baglan.Close();
            }
            if (sayac == 7)
            {
                btnbasla.Text = "Oyun Bitti";
                btnbasla.Enabled = false;

                baglan.Open();
                SqlCommand komut = new SqlCommand("select * from bilgiyarismasi7 order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    button1.Text = (oku["a"].ToString());
                    button2.Text = (oku["b"].ToString());
                    button3.Text = (oku["c"].ToString());
                    button4.Text = (oku["d"].ToString());
                    textBox1.Text = (oku["soru"].ToString());
                    lbldogru.Text = (oku["dogru"].ToString());
                }
                baglan.Close();
            }
            if (sayac == 8)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                timer1.Enabled = false;
            }
        }

            private void Form2_Load(object sender, EventArgs e)
            {
                lblsoru.Text = sayac.ToString();
                button1.BackColor = Color.MistyRose;
                button2.BackColor = Color.MistyRose;
                button3.BackColor = Color.MistyRose;
                button4.BackColor = Color.MistyRose;
                lbldogru.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(button1.Text == lbldogru.Text)
            {
                puan = puan + 10;
                lblpuan.Text = puan.ToString();
                button1.BackColor = Color.Green;
             
            }
            else
            {
                button1.BackColor = Color.Red;
                    
            }
            btnbasla.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(button2.Text == lbldogru.Text)
            {
                puan = puan + 10;
                lblpuan.Text = puan.ToString();
                button2.BackColor = Color.Green;

            }
            else
            {
                button2.BackColor = Color.Red;

            }
        
            btnbasla.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == lbldogru.Text)
            {
                puan = puan + 10;
                lblpuan.Text = puan.ToString();
                button3.BackColor = Color.Green;

            }
            else
            {
                button3.BackColor = Color.Red;

            }
        
            btnbasla.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text == lbldogru.Text)
            {
                puan = puan + 10;
                lblpuan.Text = puan.ToString();
                button4.BackColor = Color.Green;

            }
            else
            {
                button4.BackColor = Color.Red;

            }
        
            btnbasla.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sure = sure - 1;
            lblsure.Text = sure.ToString();
            
            if(sure==0)
            {
                timer1.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                btnbasla.Enabled = true;

            }
        }

    }
}

