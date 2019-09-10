namespace ShootGameWith_Instruction
{
    partial class Plateform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Plateform));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Start = new System.Windows.Forms.Button();
            this.Load = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Shoot = new System.Windows.Forms.Button();
            this.ShtAway = new System.Windows.Forms.Button();
            this.again = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(160, 60);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(540, 360);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // Start
            // 
            this.Start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Start.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start.Location = new System.Drawing.Point(16, 446);
            this.Start.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(127, 46);
            this.Start.TabIndex = 8;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Load
            // 
            this.Load.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Load.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Load.Location = new System.Drawing.Point(175, 446);
            this.Load.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Load.Name = "Load";
            this.Load.Size = new System.Drawing.Size(127, 46);
            this.Load.TabIndex = 9;
            this.Load.Text = "Load";
            this.Load.UseVisualStyleBackColor = true;
            this.Load.Click += new System.EventHandler(this.Load_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(327, 446);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 46);
            this.button1.TabIndex = 10;
            this.button1.Text = "Spin";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Shoot
            // 
            this.Shoot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Shoot.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Shoot.Location = new System.Drawing.Point(476, 446);
            this.Shoot.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Shoot.Name = "Shoot";
            this.Shoot.Size = new System.Drawing.Size(127, 46);
            this.Shoot.TabIndex = 11;
            this.Shoot.Text = "Shoot";
            this.Shoot.UseVisualStyleBackColor = true;
            this.Shoot.Click += new System.EventHandler(this.Shoot_Click);
            // 
            // ShtAway
            // 
            this.ShtAway.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ShtAway.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShtAway.Location = new System.Drawing.Point(625, 446);
            this.ShtAway.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ShtAway.Name = "ShtAway";
            this.ShtAway.Size = new System.Drawing.Size(187, 46);
            this.ShtAway.TabIndex = 12;
            this.ShtAway.Text = "Shoot Away";
            this.ShtAway.UseVisualStyleBackColor = true;
            this.ShtAway.Click += new System.EventHandler(this.ShtAway_Click);
            // 
            // again
            // 
            this.again.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.again.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.again.Location = new System.Drawing.Point(835, 494);
            this.again.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.again.Name = "again";
            this.again.Size = new System.Drawing.Size(187, 46);
            this.again.TabIndex = 13;
            this.again.Text = "Play Again";
            this.again.UseVisualStyleBackColor = true;
            this.again.Visible = false;
            this.again.Click += new System.EventHandler(this.again_Click);
            // 
            // Plateform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.again);
            this.Controls.Add(this.ShtAway);
            this.Controls.Add(this.Shoot);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Load);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Plateform";
            this.Text = "Plateform";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Load;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Shoot;
        private System.Windows.Forms.Button ShtAway;
        private System.Windows.Forms.Button again;
    }
}