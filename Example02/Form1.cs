using GuyLibray;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example02
{
    public partial class Form1 : Form
    {
        private Guy Joan;
        private Guy Bob;

        public Form1()
        {
            InitializeComponent();
            Joan = new Guy() { Name = "joan", Cash = 3000 };
            Bob = new Guy() { Name = "bob", Cash = 5000 };
            Guy1Name.Text = Joan.Name;
            Guy1Cash.Text = Joan.Cash.ToString();

            Guy2Name.Text = Bob.Name;
            Guy2Cash.Text = Bob.Cash.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void Guy1Givebutton_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            Bob.ReceiveCash(Joan.GiveCash(a));
            UpdataDcreen();
        }

        private void Guy2Givebutton_Click(object sender, EventArgs e)
        {
            int b = int.Parse(textBox2.Text);
            Joan.ReceiveCash(Bob.GiveCash(b));
            UpdataDcreen();
        }

        private void UpdataDcreen()
        {
            this.Guy1Name.Text = Joan.Name;
            this.Guy1Cash.Text = Joan.Cash.ToString();

            this.Guy2Name.Text = Bob.Name;
            this.Guy2Cash.Text = Bob.Cash.ToString();
        }
    }
}