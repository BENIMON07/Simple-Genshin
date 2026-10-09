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
        int cdGantiChar = 0;
        int cdskill = 0;
        int cdulti = 0;
        int bosshitinterval = 0;
        Label labelcdgantichar;
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

        public Form4(BindingList<Character> partyteam, int index)
        {
            InitializeComponent();
            this.partyterpilih = partyteam;
            this.indexbosdipilih = index;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            
            timerbosshit.Start();
            loaddatamusuh();
            bossaktif = listmusuh[indexbosdipilih];
            battleui();
            bosshitinterval = bossaktif.intervalhit;
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
            labelnyawaboss.Text = $"{healthbarboss.Value}/{bossaktif.MaxHPmusuh}";
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
            for (int i = 0; i < partyterpilih.Count; i++)
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
                fotoparty.BackColor = Color.White;
                fotoparty.Location = new Point(1180, startY + (i * 60));
                fotoparty.SizeMode = PictureBoxSizeMode.Zoom;
                fotoparty.Image = c.Avatar;
                fotoparty.Tag = c;
                fotoparty.Cursor = Cursors.Hand;

                fotoparty.Click += fotoparty_Click;
                this.Controls.Add(fotoparty);
                listfotocharkanan.Add(fotoparty);
            }
            labelcdgantichar = new Label();
            labelcdgantichar.Text = $"CD: {cdGantiChar}";
            labelcdgantichar.Location = new Point(1146, 20);
            labelcdgantichar.ForeColor = Color.White;
            labelcdgantichar.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            labelcdgantichar.Visible = false;
            this.Controls.Add(labelcdgantichar);

        }
        private void lblHpMusuhAktif_TextUpdate()
        {
            labelnyawaboss.Text = $"{healthbarboss.Value} / {bossaktif.MaxHPmusuh}";
        }
        private void lblHpHpCharAktif_TextUpdate()
        {
            lblHpCharAktif.Text = $"{charAktif.CurrentHP} / {charAktif.MaxHP}";
        }
        private void fotoparty_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            Character charDipilih = (Character)pb.Tag;

            if (cdGantiChar > 0)
            {
                return;
            }
            if (charDipilih != charAktif && charDipilih.CurrentHP > 0)
            {
                charAktif = charDipilih;
                UpdateCharAktifUI();
                cdGantiChar = 2;
                labelcdgantichar.Visible = true;
                labelcdgantichar.Text = $"CD: {cdGantiChar}";
                timercdgantichar.Start();
            }

        }
        private void UpdateCharAktifUI()
        {
            if (charAktif == null) return;
            namacharaktif.Text = charAktif.name;
            healthbarcharaktif.Maximum = charAktif.MaxHP;
            int hpTampil = Math.Max(0, charAktif.CurrentHP);
            healthbarcharaktif.Value = hpTampil;
            lblHpCharAktif.Text = $"{hpTampil} / {charAktif.MaxHP}";
            UpdateSkillButtonUI();
            UpdateUltiButtonUI();
        }
        private void UpdateSkillButtonUI()
        {
            if (charAktif == null) return;

            if (charAktif.currentskillcd > 0)
            {
                buttonskill.Text = $"Skill\n{charAktif.currentskillcd}s";
                buttonskill.Enabled = false;
            }
            else
            {
                buttonskill.Text = "Skill";
                buttonskill.Enabled = true;
            }
        }
        private void UpdateUltiButtonUI()
        {
            if (charAktif == null) return;

            if (charAktif.currentulticd > 0)
            {
                buttonulti.Text = $"Ulti\n{charAktif.currentulticd}s";
                buttonulti.Enabled = false;
            }
            else
            {
                buttonulti.Text = "Ulti";
                buttonulti.Enabled = true;
            }
        }

        private void buttonbasicatk_Click(object sender, EventArgs e)
        {
            healthbarboss.Value -= charAktif.BaseATK;
            lblHpMusuhAktif_TextUpdate();
        }

        private void timercdgantichar_Tick(object sender, EventArgs e)
        {

            if (cdGantiChar > 0)
            {
                cdGantiChar--;
                labelcdgantichar.Text = $"CD: {cdGantiChar}";

            }
            if (cdGantiChar == 0)
            {
                labelcdgantichar.Visible = false;
                timercdgantichar.Stop();
            }
        }

        private void buttonskill_Click(object sender, EventArgs e)
        {
            if (charAktif.currentskillcd > 0)
            {
                return;
            }
            charAktif.currentskillcd = charAktif.skillcd;
            buttonskill.Text = $"Skill \n {cdskill}";
            timercdskillorulti.Start();

            if (charAktif.role == "Main DPS")
            {
                healthbarboss.Value -= charAktif.skilldmg;
            }
            if (charAktif.role == "Healer")
            {
                foreach(Character c in partyterpilih)
                {
                    if(c.CurrentHP < c.MaxHP)
                    {
                        if (c.CurrentHP == 0)
                        {
                            continue;
                        }
                        else
                        {
                            c.CurrentHP += charAktif.skillheal;
                            if(c.CurrentHP >= c.MaxHP)
                            {
                                c.CurrentHP = c.MaxHP;
                            }
                        }
                    }
                    
                }
            }
            UpdateSkillButtonUI();
            lblHpMusuhAktif_TextUpdate();
            UpdateCharAktifUI();
        }

        private void timercdskillorulti_Tick(object sender, EventArgs e)
        {
            bool adaYangMasihCD = false;
            foreach (Character c in partyterpilih)
            {
                if (c.currentskillcd > 0)
                {
                    c.currentskillcd--;
                    adaYangMasihCD = true;
                }
            }
            foreach (Character c in partyterpilih)
            {
                if (c.currentulticd > 0)
                {
                    c.currentulticd--;
                    adaYangMasihCD = true;
                }
            }
            UpdateSkillButtonUI();
            UpdateUltiButtonUI();
            if (!adaYangMasihCD)
            {
                timercdskillorulti.Stop();
            }
        }

        private void buttonulti_Click(object sender, EventArgs e)
        {
            if (charAktif.currentulticd > 0)
            {
                return;
            }
            charAktif.currentulticd = charAktif.ulticd;
            buttonulti.Text = $"Ulti \n {cdskill}";
            timercdskillorulti.Start();

            if (charAktif.role == "Main DPS")
            {
                healthbarboss.Value -= charAktif.ultidmg;
            }

            UpdateUltiButtonUI();
            lblHpMusuhAktif_TextUpdate();
        }
        

        private void timerbosshit_Tick(object sender, EventArgs e)
        {
            
            if(bosshitinterval>0)
            {
                bosshitinterval--;        
            }
            if(bosshitinterval == 0)
            {
                charAktif.CurrentHP -= bossaktif.dmg;
                bosshitinterval = bossaktif.intervalhit;
                if (charAktif.CurrentHP < 0)
                {
                    charAktif.CurrentHP = 0;
                }
            }
            UpdateCharAktifUI();
        }
    }
}
