namespace WinFormsApp1
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            buttonskill = new Button();
            buttonulti = new Button();
            buttonbasicatk = new Button();
            timercdgantichar = new System.Windows.Forms.Timer(components);
            timercdskillorulti = new System.Windows.Forms.Timer(components);
            timerbosshit = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // buttonskill
            // 
            buttonskill.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonskill.Location = new Point(947, 568);
            buttonskill.Name = "buttonskill";
            buttonskill.Size = new Size(85, 81);
            buttonskill.TabIndex = 0;
            buttonskill.Text = "SKILL";
            buttonskill.UseVisualStyleBackColor = true;
            buttonskill.Click += buttonskill_Click;
            // 
            // buttonulti
            // 
            buttonulti.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonulti.Location = new Point(1111, 405);
            buttonulti.Name = "buttonulti";
            buttonulti.Size = new Size(85, 81);
            buttonulti.TabIndex = 1;
            buttonulti.Text = "ULTI";
            buttonulti.UseVisualStyleBackColor = true;
            buttonulti.Click += buttonulti_Click;
            // 
            // buttonbasicatk
            // 
            buttonbasicatk.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonbasicatk.Location = new Point(1070, 527);
            buttonbasicatk.Name = "buttonbasicatk";
            buttonbasicatk.Size = new Size(126, 122);
            buttonbasicatk.TabIndex = 2;
            buttonbasicatk.Text = "BASIC ATTACK";
            buttonbasicatk.UseVisualStyleBackColor = true;
            buttonbasicatk.Click += buttonbasicatk_Click;
            // 
            // timercdgantichar
            // 
            timercdgantichar.Interval = 1000;
            timercdgantichar.Tick += timercdgantichar_Tick;
            // 
            // timercdskillorulti
            // 
            timercdskillorulti.Interval = 1000;
            timercdskillorulti.Tick += timercdskillorulti_Tick;
            // 
            // timerbosshit
            // 
            timerbosshit.Interval = 1000;
            timerbosshit.Tick += timerbosshit_Tick;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1262, 673);
            Controls.Add(buttonbasicatk);
            Controls.Add(buttonulti);
            Controls.Add(buttonskill);
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button buttonskill;
        private Button buttonulti;
        private Button buttonbasicatk;
        private System.Windows.Forms.Timer timercdgantichar;
        private System.Windows.Forms.Timer timercdskillorulti;
        private System.Windows.Forms.Timer timerbosshit;
    }
}