using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace игра
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int tek = 1;
        int kol = 0;
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        Game g;
        int vin;
        TextBox tx;
        Button tx2;
        private void Form2_Load(object sender, EventArgs e)
        {

            tx = new TextBox();
            tx.Name = "tx";
            tx.Location = new Point(100, 30);
            tx.Size = new Size(100, 24);

            tx2 = new Button();
            tx2.Name = "tx2";
            tx2.Text = "Начать";
            tx2.Click += new EventHandler(tx2_Click);
            tx2.Location = new Point(100, 60);
            tx2.Size = new Size(100, 30);
            this.Controls.Add(tx);
            this.Controls.Add(tx2);
            
        }
        private void tx2_Click(object sender, EventArgs e)
        {
            kol = Convert.ToInt32(tx.Text);
            this.Controls.Remove(tx);
            this.Controls.Remove(tx2);
            Start();
        }
        public void Start()
        {

            
                g = new Game(kol);
            tek = 1;
            vin = 33*kol;
            Zap();
            

        }
        public void Zap()
        {
            label2.Text = vin.ToString();
            for (int i = 0; i < kol; i++)
            {
                int n = i + 1;
                listBox1.Items.Add("Счет игрока № "+n+" = "+g.I[i].infoIgrok().ToString());
            }
            label20.Text = tek.ToString();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Start();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
      
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        Random rnd = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
          
            Zap();
        }
        public void win(int n)
        {
           
 
        }

        public void abs(int n, int k)
        {
            MessageBox.Show("Выиграл игрок № "+n.ToString()+" выигрыш составил "+k.ToString()+ "\r\n" + "Новая игра?");
            Start();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            TextBox tx = new TextBox();
            tx.Name = "tx";
            tx.Location = new Point(100, 30);
            tx.Size = new Size(100, 24);

            Button tx2 = new Button();
            tx2.Name = "tx2";
            tx2.Location = new Point(100, 60);
            tx2.Size = new Size(100, 24);
            this.Controls.Add(tx);
            this.Controls.Add(tx2);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            if (tek == g.vsego)
                tek = 1;
            else tek += 1;
        }
    }
}
