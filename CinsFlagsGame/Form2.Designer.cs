namespace CinsFlagsGame
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DownNameLabel = new System.Windows.Forms.Label();
            this.UpNameLabel = new System.Windows.Forms.Label();
            this.DownIndicator = new System.Windows.Forms.Label();
            this.UpIndicator = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(296, 224);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Papyrus", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Location = new System.Drawing.Point(23, 224);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(208, 292);
            this.listBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Papyrus", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(23, 565);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(208, 25);
            this.textBox2.TabIndex = 4;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 537);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Chat";
            // 
            // DownNameLabel
            // 
            this.DownNameLabel.AutoSize = true;
            this.DownNameLabel.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DownNameLabel.Location = new System.Drawing.Point(585, 602);
            this.DownNameLabel.Name = "DownNameLabel";
            this.DownNameLabel.Size = new System.Drawing.Size(105, 25);
            this.DownNameLabel.TabIndex = 9;
            this.DownNameLabel.Text = "DownName";
            this.DownNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UpNameLabel
            // 
            this.UpNameLabel.AutoSize = true;
            this.UpNameLabel.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpNameLabel.Location = new System.Drawing.Point(585, 128);
            this.UpNameLabel.Name = "UpNameLabel";
            this.UpNameLabel.Size = new System.Drawing.Size(85, 25);
            this.UpNameLabel.TabIndex = 10;
            this.UpNameLabel.Text = "UpName";
            this.UpNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DownIndicator
            // 
            this.DownIndicator.AutoSize = true;
            this.DownIndicator.BackColor = System.Drawing.SystemColors.Control;
            this.DownIndicator.Font = new System.Drawing.Font("Papyrus", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DownIndicator.ForeColor = System.Drawing.Color.Green;
            this.DownIndicator.Location = new System.Drawing.Point(250, 681);
            this.DownIndicator.Name = "DownIndicator";
            this.DownIndicator.Size = new System.Drawing.Size(66, 30);
            this.DownIndicator.TabIndex = 11;
            this.DownIndicator.Text = "label2";
            this.DownIndicator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UpIndicator
            // 
            this.UpIndicator.AutoSize = true;
            this.UpIndicator.Font = new System.Drawing.Font("Papyrus", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpIndicator.ForeColor = System.Drawing.Color.Red;
            this.UpIndicator.Location = new System.Drawing.Point(250, 47);
            this.UpIndicator.Name = "UpIndicator";
            this.UpIndicator.Size = new System.Drawing.Size(0, 30);
            this.UpIndicator.TabIndex = 12;
            this.UpIndicator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(579, 475);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 115);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(579, 156);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(23, 735);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 44);
            this.button1.TabIndex = 13;
            this.button1.Text = "?";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 800);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.UpIndicator);
            this.Controls.Add(this.DownIndicator);
            this.Controls.Add(this.UpNameLabel);
            this.Controls.Add(this.DownNameLabel);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.Text = "CinsFlagsGame";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label DownNameLabel;
        private System.Windows.Forms.Label UpNameLabel;
        private System.Windows.Forms.Label DownIndicator;
        private System.Windows.Forms.Label UpIndicator;
        private System.Windows.Forms.Button button1;
    }
}