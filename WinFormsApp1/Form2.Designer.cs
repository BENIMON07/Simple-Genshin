namespace WinFormsApp1
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            panelKatalog = new FlowLayoutPanel();
            buttonclear1 = new Button();
            buttonclear2 = new Button();
            buttonclear3 = new Button();
            buttonclear4 = new Button();
            buttonstart = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(434, 19);
            label1.Name = "label1";
            label1.Size = new Size(419, 54);
            label1.TabIndex = 0;
            label1.Text = "CREATE YOUR PARTY";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(97, 226);
            button1.Name = "button1";
            button1.Size = new Size(194, 215);
            button1.TabIndex = 1;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(399, 226);
            button2.Name = "button2";
            button2.Size = new Size(194, 215);
            button2.TabIndex = 2;
            button2.Text = "+";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(694, 226);
            button3.Name = "button3";
            button3.Size = new Size(194, 215);
            button3.TabIndex = 3;
            button3.Text = "+";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(988, 226);
            button4.Name = "button4";
            button4.Size = new Size(194, 215);
            button4.TabIndex = 4;
            button4.Text = "+";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // panelKatalog
            // 
            panelKatalog.AutoScroll = true;
            panelKatalog.BackColor = Color.DimGray;
            panelKatalog.Location = new Point(370, 76);
            panelKatalog.Name = "panelKatalog";
            panelKatalog.Size = new Size(561, 558);
            panelKatalog.TabIndex = 5;
            panelKatalog.Visible = false;
            // 
            // buttonclear1
            // 
            buttonclear1.Location = new Point(144, 176);
            buttonclear1.Name = "buttonclear1";
            buttonclear1.Size = new Size(94, 29);
            buttonclear1.TabIndex = 6;
            buttonclear1.Text = "CLEAR";
            buttonclear1.UseVisualStyleBackColor = true;
            buttonclear1.Click += buttonclear1_Click;
            // 
            // buttonclear2
            // 
            buttonclear2.Location = new Point(449, 176);
            buttonclear2.Name = "buttonclear2";
            buttonclear2.Size = new Size(94, 29);
            buttonclear2.TabIndex = 7;
            buttonclear2.Text = "CLEAR";
            buttonclear2.UseVisualStyleBackColor = true;
            buttonclear2.Click += buttonclear2_Click;
            // 
            // buttonclear3
            // 
            buttonclear3.Location = new Point(735, 176);
            buttonclear3.Name = "buttonclear3";
            buttonclear3.Size = new Size(94, 29);
            buttonclear3.TabIndex = 8;
            buttonclear3.Text = "CLEAR";
            buttonclear3.UseVisualStyleBackColor = true;
            buttonclear3.Click += buttonclear3_Click;
            // 
            // buttonclear4
            // 
            buttonclear4.Location = new Point(1037, 176);
            buttonclear4.Name = "buttonclear4";
            buttonclear4.Size = new Size(94, 29);
            buttonclear4.TabIndex = 9;
            buttonclear4.Text = "CLEAR";
            buttonclear4.UseVisualStyleBackColor = true;
            buttonclear4.Click += buttonclear4_Click;
            // 
            // buttonstart
            // 
            buttonstart.BackColor = Color.YellowGreen;
            buttonstart.FlatStyle = FlatStyle.Popup;
            buttonstart.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonstart.ForeColor = Color.White;
            buttonstart.Location = new Point(1017, 553);
            buttonstart.Name = "buttonstart";
            buttonstart.Size = new Size(143, 69);
            buttonstart.TabIndex = 10;
            buttonstart.Text = "START";
            buttonstart.UseVisualStyleBackColor = false;
            buttonstart.Click += buttonstart_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1262, 673);
            Controls.Add(buttonstart);
            Controls.Add(buttonclear4);
            Controls.Add(buttonclear1);
            Controls.Add(panelKatalog);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(buttonclear2);
            Controls.Add(buttonclear3);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private FlowLayoutPanel panelKatalog;
        private Button buttonclear1;
        private Button buttonclear2;
        private Button buttonclear3;
        private Button buttonclear4;
        private Button buttonstart;
    }
}