using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form3 : Form
    {
        BindingList<Character> partyPemain;
        public Form3(BindingList<Character> party)
        {
            InitializeComponent();
            this.partyPemain = party;
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 ingame = new Form4(partyPemain, 0);
            ingame.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 ingame = new Form4(partyPemain, 1);
            ingame.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 ingame = new Form4(partyPemain, 2);
            ingame.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 ingame = new Form4(partyPemain, 3);
            ingame.Show();
            this.Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
