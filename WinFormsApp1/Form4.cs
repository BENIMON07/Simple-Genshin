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

        BindingList<PictureBox> listfotocharkanan = new BindingList<PictureBox>();
        BindingList<Label> listlabelnamacharkanan = new BindingList<Label>();

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

            //Bagian Dynamic Component bawah
            namacharaktif = new Label();
            namacharaktif.Text = charAktif.name;
            namacharaktif.ForeColor = Color.White;
            namacharaktif.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            namacharaktif.Location = new Point(590, 598);
            namacharaktif.AutoSize = true;
            this.Controls.Add(namacharaktif);

            healthbarcharaktif = new ProgressBar();
            healthbarcharaktif.Maximum = charAktif.MaxHP;
            healthbarcharaktif.Value = charAktif.CurrentHP;
            healthbarcharaktif.Minimum = 0;
            healthbarcharaktif.Location = new Point(402, 632);
            healthbarcharaktif.Size = new Size(465, 17);
            this.Controls.Add(healthbarcharaktif);

            lblHpCharAktif = new Label();
            lblHpCharAktif.ForeColor = Color.White;
            lblHpCharAktif.Text = $"{charAktif.CurrentHP}/{charAktif.MaxHP}";
            lblHpCharAktif.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            lblHpCharAktif.Location = new Point(780, 598);
            lblHpCharAktif.AutoSize = true;
            this.Controls.Add(lblHpCharAktif);

            //pilihan char di kanan
            int startY = 80;
            for(int i=0; i<partyterpilih.Count; i++)
            {
                Character c = partyterpilih[i];
                Label lbparty = new Label();
                lbparty.Text = c.name;
                lbparty.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                lbparty.ForeColor = Color.White;
                lbparty.AutoSize = true;
                lbparty.Location = new Point(1100, startY + (i * 60) + 15);
                this.Controls.Add(lbparty);
                listlabelnamacharkanan.Add(lbparty);

                PictureBox fotoparty = new PictureBox();
                fotoparty.Size = new Size(50, 50);
                fotoparty.Location = new Point(1180, startY + (i * 60));
                fotoparty.SizeMode = PictureBoxSizeMode.Zoom;
                fotoparty.Image = c.Avatar;
                fotoparty.Tag = c;
                fotoparty.Cursor = Cursors.Hand;


                this.Controls.Add(fotoparty);
                listfotocharkanan.Add(fotoparty);
            }

        }

    }
}
