using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        BindingList<Character> listchar = new BindingList<Character>();
        int slotaktif = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            loaddatachar();
        }

        void tampilkatalog()
        {
            panelKatalog.Controls.Clear();
            foreach (Character chara in listchar)
            {
                if ((button1.Tag != null && ((Character)button1.Tag).name == chara.name) ||
                    (button2.Tag != null && ((Character)button2.Tag).name == chara.name) ||
                    (button3.Tag != null && ((Character)button3.Tag).name == chara.name) ||
                    (button4.Tag != null && ((Character)button4.Tag).name == chara.name))
                {
                    continue;
                }

                PictureBox pb = new PictureBox();
                pb.Size = new Size(70, 70);
                pb.SizeMode = PictureBoxSizeMode.AutoSize;
                pb.Image = chara.Avatar;
                pb.Tag = chara;
                pb.Click += gambar_klik;
                panelKatalog.Controls.Add(pb);
            }
            panelKatalog.Visible = true;
        }


        private void gambar_klik(object sender, EventArgs e)
        {
            PictureBox gambardiklik = (PictureBox)sender;
            Character charadipilih = (Character)gambardiklik.Tag;

            if (slotaktif == 1)
            {
                button1.Image = charadipilih.Avatar;
                button1.Tag = charadipilih;
            }
            else if (slotaktif == 2)
            {
                button2.Image = charadipilih.Avatar;
                button2.Tag = charadipilih;
            }
            else if (slotaktif == 3)
            {
                button3.Image = charadipilih.Avatar;
                button3.Tag = charadipilih;
            }
            else if (slotaktif == 4)
            {
                button4.Image = charadipilih.Avatar;
                button4.Tag = charadipilih;
            }
            panelKatalog.Visible = false;
        }

        private void loaddatachar()
        {
            listchar.Add(new Character
            {
                name = "Amber",
                weapon = "Bow",
                vision = "Pyro",
                role = "Main DPS",
                MaxHP = 1500,
                CurrentHP = 1500,
                BaseATK = 100,
                skilldmg = 500,
                ultidmg = 1000,
                skillcd = 10,
                ulticd = 20,
                Avatar = Properties.Resources.ppamber
            });
            listchar.Add(new Character
            {
                name = "Ayaka",
                weapon = "Sword",
                vision = "Cryo",
                role = "Main DPS",
                MaxHP = 1500,
                CurrentHP = 1500,
                BaseATK = 100,
                skilldmg = 500,
                ultidmg = 1000,
                skillcd = 10,
                ulticd = 20,
                Avatar = Properties.Resources.ppayaka
            });
            listchar.Add(new Character
            {
                name = "Barbara",
                weapon = "Catalyst",
                vision = "Hydro",
                role = "Healer",
                MaxHP = 1500,
                CurrentHP = 1500,
                BaseATK = 50,
                skillheal = 100,
                ultiheal = 500,
                skillcd = 10,
                ulticd = 20,
                Avatar = Properties.Resources.ppbarbara
            });
            listchar.Add(new Character
            {
                name = "Bennet",
                weapon = "Sword",
                vision = "Pyro",
                role = "Buffer",
                MaxHP = 1500,
                CurrentHP = 1500,
                BaseATK = 50,
                skillbuff = 2,
                ultibuff = 3,
                buffduration = 15,
                skillcd = 10,
                ulticd = 20,
                Avatar = Properties.Resources.ppbennett
            });
            listchar.Add(new Character
            {
                name = "Diluc",
                weapon = "Claymore",
                vision = "Pyro",
                role = "Main DPS",
                MaxHP = 1500,
                CurrentHP = 1500,
                BaseATK = 100,
                skilldmg = 500,
                ultidmg = 1000,
                skillcd = 10,
                ulticd = 20,
                Avatar = Properties.Resources.ppdiluc
            });
            listchar.Add(new Character
            {
                name = "Diona",
                weapon = "Bow",
                vision = "Cryo",
                role = "Shielder",
                MaxHP = 1500,
                CurrentHP = 1500,
                BaseATK = 50,
                skillshield = 3,
                ultishield = 5,
                skillcd = 10,
                ulticd = 20,
                Avatar = Properties.Resources.ppdiona
            });
            listchar.Add(new Character
            {
                name = "Fischl",
                weapon = "Bow",
                vision = "Electro",
                role = "Main DPS",
                MaxHP = 1500,
                CurrentHP = 1500,
                BaseATK = 100,
                skilldmg = 500,
                ultidmg = 1000,
                skillcd = 10,
                ulticd = 20,
                Avatar = Properties.Resources.ppfischl
            });
            listchar.Add(new Character
            {
                name = "Furina",
                weapon = "Sword",
                vision = "Cryo",
                role = "Healer",
                MaxHP = 1500,
                CurrentHP = 1500,
                BaseATK = 50,
                skillheal = 100,
                ultiheal = 500,
                skillcd = 10,
                ulticd = 20,
                Avatar = Properties.Resources.ppfurina
            });
            listchar.Add(new Character
            {
                name = "Ganyu",
                weapon = "Bow",
                vision = "Cryo",
                role = "Main DPS",
                MaxHP = 1500,
                CurrentHP = 1500,
                BaseATK = 100,
                skilldmg = 500,
                ultidmg = 1000,
                skillcd = 10,
                ulticd = 20,
                Avatar = Properties.Resources.ppganyu
            });
            listchar.Add(new Character
            {
                name = "Hutao",
                weapon = "Polearm",
                vision = "Pyro",
                role = "Main DPS",
                MaxHP = 1500,
                CurrentHP = 1500,
                BaseATK = 100,
                skilldmg = 500,
                ultidmg = 1000,
                skillcd = 10,
                ulticd = 20,
                Avatar = Properties.Resources.pphutao
            });
            listchar.Add(new Character
            {
                name = "Jean",
                weapon = "Bow",
                vision = "Anemo",
                role = "Healer",
                MaxHP = 1500,
                CurrentHP = 1500,
                BaseATK = 50,
                skillheal = 100,
                ultiheal = 500,
                skillcd = 10,
                ulticd = 20,
                Avatar = Properties.Resources.ppjean
            });
            listchar.Add(new Character
            {
                name = "Kaeya",
                weapon = "Sword",
                vision = "Cryo",
                role = "Main DPS",
                MaxHP = 1500,
                CurrentHP = 1500,
                BaseATK = 100,
                skilldmg = 500,
                ultidmg = 1000,
                skillcd = 10,
                ulticd = 20,
                Avatar = Properties.Resources.ppkaeya
            });
            listchar.Add(new Character
            {
                name = "Kaveh",
                weapon = "Claymore",
                vision = "Dendro",
                role = "Main DPS",
                MaxHP = 1500,
                CurrentHP = 1500,
                BaseATK = 100,
                skilldmg = 500,
                ultidmg = 1000,
                skillcd = 10,
                ulticd = 20,
                Avatar = Properties.Resources.ppkaveh
            });
            listchar.Add(new Character
            {
                name = "Keqing",
                weapon = "Sword",
                vision = "Electro",
                role = "Main DPS",
                MaxHP = 1500,
                CurrentHP = 1500,
                BaseATK = 100,
                skilldmg = 500,
                ultidmg = 1000,
                skillcd = 10,
                ulticd = 20,
                Avatar = Properties.Resources.ppkeqing
            });
            listchar.Add(new Character
            {
                name = "Klee",
                weapon = "Catalyst",
                vision = "Pyro",
                role = "Main DPS",
                MaxHP = 1500,
                CurrentHP = 1500,
                BaseATK = 100,
                skilldmg = 500,
                ultidmg = 1000,
                skillcd = 10,
                ulticd = 20,
                Avatar = Properties.Resources.ppklee
            });
            listchar.Add(new Character
            {
                name = "Kokomi",
                weapon = "Catalyst",
                vision = "Hydro",
                role = "Healer",
                MaxHP = 1500,
                CurrentHP = 1500,
                BaseATK = 50,
                skillheal = 100,
                ultiheal = 500,
                skillcd = 10,
                ulticd = 20,
                Avatar = Properties.Resources.ppkokomi
            });
            listchar.Add(new Character
            {
                name = "Lisa",
                weapon = "Catalyst",
                vision = "Electro",
                role = "Main DPS",
                MaxHP = 1500,
                CurrentHP = 1500,
                BaseATK = 100,
                skilldmg = 500,
                ultidmg = 1000,
                skillcd = 10,
                ulticd = 20,
                Avatar = Properties.Resources.pplisa
            });
            listchar.Add(new Character
            {
                name = "Mona",
                weapon = "Catalyst",
                vision = "Hydro",
                role = "Main DPS",
                MaxHP = 1500,
                CurrentHP = 1500,
                BaseATK = 100,
                skilldmg = 500,
                ultidmg = 1000,
                skillcd = 10,
                ulticd = 20,
                Avatar = Properties.Resources.ppmona
            });
            listchar.Add(new Character
            {
                name = "Nahida",
                weapon = "Catalyst",
                vision = "Dendro",
                role = "Main DPS",
                MaxHP = 1500,
                CurrentHP = 1500,
                BaseATK = 100,
                skilldmg = 500,
                ultidmg = 1000,
                skillcd = 10,
                ulticd = 20,
                Avatar = Properties.Resources.ppnahida
            });
            listchar.Add(new Character
            {
                name = "Noelle",
                weapon = "Claymore",
                vision = "Geo",
                role = "Shielder",
                MaxHP = 1500,
                CurrentHP = 1500,
                BaseATK = 50,
                skillshield = 3,
                ultishield = 5,
                skillcd = 10,
                ulticd = 20,
                Avatar = Properties.Resources.ppnoel
            });

        }

        private void button1_Click(object sender, EventArgs e)
        {
            slotaktif = 1;
            tampilkatalog();
            button1.Text = "";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            slotaktif = 2;
            tampilkatalog();
            button2.Text = "";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            slotaktif = 3;
            tampilkatalog();
            button3.Text = "";
        }
        private void button4_Click(object sender, EventArgs e)
        {
            slotaktif = 4;
            tampilkatalog();
            button4.Text = "";
        }

        private void buttonclear1_Click(object sender, EventArgs e)
        {
            button1.Image = null;
            button1.Tag = null;
            if (panelKatalog.Visible == true)
            {
                tampilkatalog();
            }
        }

        private void buttonclear2_Click(object sender, EventArgs e)
        {
            button2.Image = null;
            button2.Tag = null;
            if (panelKatalog.Visible == true)
            {
                tampilkatalog();
            }
        }

        private void buttonclear3_Click(object sender, EventArgs e)
        {
            button3.Image = null;
            button3.Tag = null;
            if (panelKatalog.Visible == true)
            {
                tampilkatalog();
            }
        }

        private void buttonclear4_Click(object sender, EventArgs e)
        {
            button4.Image = null;
            button4.Tag = null;
            if (panelKatalog.Visible == true)
            {
                tampilkatalog();
            }
        }

        private void buttonstart_Click(object sender, EventArgs e)
        {
            BindingList<Character> partydipilih = new BindingList<Character>();

            if (button1.Tag != null)
            {
                partydipilih.Add((Character)button1.Tag);
            }
            if (button2.Tag != null)
            {
                partydipilih.Add((Character)button2.Tag);
            }
            if (button3.Tag != null)
            {
                partydipilih.Add((Character)button3.Tag);
            }
            if (button4.Tag != null)
            {
                partydipilih.Add((Character)button4.Tag);
            }

            if (button1.Image == null && button2.Image == null && button3.Image == null && button4.Image == null)
            {
                MessageBox.Show("PILIH MINIMAL 1 CHARACTER");
            }
            else if(button1.Image == null || button2.Image == null || button3.Image == null || button4.Image == null)
            {
                DialogResult pesan = MessageBox.Show("Yakin tidak mengisi semua slot?", "CONFIRM", MessageBoxButtons.YesNo);
                if (pesan == DialogResult.Yes)
                {
                    Form3 pilihmusuh = new Form3(partydipilih);
                    pilihmusuh.Show();
                    this.Hide();
                }
            }
            else
            {
                Form3 pilihmusuh = new Form3(partydipilih);
                pilihmusuh.Show();
                this.Hide();
            }
            
        }

    }
}
