using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form4 : Form
    {
        BindingList<Musuh> listmusuh = new BindingList<Musuh>();
        BindingList<Character> partyterpilih = new BindingList<Character>();
        Musuh bossaktif;
        int indexbosdipilih = 0;
        Character charAktif;

        Label labelnamaboss;
        ProgressBar healthbarboss;
        PictureBox gambarbos;
        Label labelnyawaboss;

        Label namacharaktif;
        ProgressBar healthbarcharaktif;
        Label lblHpCharAktif;

        BindingList<PictureBox> fotocharkanan = new BindingList<PictureBox>();
        BindingList<Label> labelnamacharkanan = new BindingList<Label>();

        public Form4(BindingList<Character>partyteam,int index)
        {
            InitializeComponent();
            this.partyterpilih = partyteam;
            this.indexbosdipilih = index;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            loaddatamusuh();
            bossaktif = listmusuh[indexbosdipilih];
            battleui();
        }
        private void loaddatamusuh()
        {
            listmusuh.Add(new Musuh
            {
                name = "STORM TERROR",
                dmg = 50,
                MaxHPmusuh = 30000,
                CurrentHPmusuh = 30000,
                intervalhit = 5,
                reward = 1,
                Avatarmusuh = Properties.Resources.stormterroricon
            });
            listmusuh.Add(new Musuh
            {
                name = "ANDRIUS",
                dmg = 70,
                MaxHPmusuh = 35000,
                CurrentHPmusuh = 35000,
                intervalhit = 4,
                reward = 2,
                Avatarmusuh = Properties.Resources.andriusicon
            });
            listmusuh.Add(new Musuh
            {
                name = "AZHDAHA",
                dmg = 30,
                MaxHPmusuh = 100000,
                CurrentHPmusuh = 100000,
                intervalhit = 8,
                reward = 3,
                Avatarmusuh = Properties.Resources.azhdahaicon
            });
            listmusuh.Add(new Musuh
            {
                name = "ARLECHINO",
                dmg = 400,
                MaxHPmusuh = 25000,
                CurrentHPmusuh = 25000,
                intervalhit = 5,
                reward = 5,
                Avatarmusuh = Properties.Resources.theknaveicon
            });

        }

        public void battleui()
        {
            charAktif = partyterpilih[0];

            //Bagian Dynamic Component Boss
            labelnamaboss = new Label();
            labelnamaboss.Text = bossaktif.name;
            labelnamaboss.ForeColor = Color.White;
            labelnamaboss.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            labelnamaboss.Location = new Point(591, 20);
            labelnamaboss.AutoSize = true;
            this.Controls.Add(labelnamaboss);

            healthbarboss = new ProgressBar();
            healthbarboss.Maximum = bossaktif.MaxHPmusuh;
            healthbarboss.Value = bossaktif.CurrentHPmusuh;
            healthbarboss.Minimum = 0;
            healthbarboss.Location = new Point(330, 65);
            healthbarboss.Size = new Size(600, 14);
            this.Controls.Add(healthbarboss);

            gambarbos = new PictureBox();
            gambarbos.Image = bossaktif.Avatarmusuh;
            gambarbos.SizeMode = PictureBoxSizeMode.StretchImage;
            gambarbos.Size = new Size(207, 207);
            gambarbos.Location = new Point(535, 99);
            this.Controls.Add(gambarbos);

            labelnyawaboss = new Label();
            labelnyawaboss.ForeColor = Color.White;
            labelnyawaboss.Text = $"{bossaktif.CurrentHPmusuh}/{bossaktif.MaxHPmusuh}";
            labelnyawaboss.Font = new Font("Segoe UI", 13, FontStyle.Bold);
            labelnyawaboss.Location = new Point(770, 80);
            labelnyawaboss.AutoSize = true;
            this.Controls.Add(labelnyawaboss);

            

        }

    }
}
