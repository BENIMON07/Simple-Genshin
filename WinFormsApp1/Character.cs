using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace WinFormsApp1
{
    public class Character
    {
        public string name { get; set; }
        public string weapon { get; set; }
        public string vision { get; set; }
        public string role { get; set; }
        public int MaxHP { get; set; }
        public int CurrentHP { get; set; }
        public int BaseATK { get; set; }
        public int skilldmg { get; set; }
        public int ultidmg { get; set; }
        public int skillheal { get; set; }
        public int ultiheal { get; set; }
        public int skillshield { get; set; }
        public int ultishield { get; set; }
        public double skillbuff { get; set; }
        public double ultibuff { get; set; }
        public int buffduration { get; set; }
        public int skillcd { get; set; }
        public int ulticd { get; set; }
        public int currentskillcd { get; set; } = 0;
        public int currentulticd { get; set; } = 0;
        public Image Avatar { get; set; }
    }
}
