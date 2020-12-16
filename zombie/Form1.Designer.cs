namespace zombie
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.AmmoTxt = new System.Windows.Forms.Label();
            this.KilsTxt = new System.Windows.Forms.Label();
            this.HealthTxt = new System.Windows.Forms.Label();
            this.HealthBar = new System.Windows.Forms.ProgressBar();
            this.Player = new System.Windows.Forms.PictureBox();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            this.SuspendLayout();
            // 
            // AmmoTxt
            // 
            this.AmmoTxt.AutoSize = true;
            this.AmmoTxt.ForeColor = System.Drawing.Color.Cyan;
            this.AmmoTxt.Location = new System.Drawing.Point(15, 9);
            this.AmmoTxt.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.AmmoTxt.Name = "AmmoTxt";
            this.AmmoTxt.Size = new System.Drawing.Size(81, 24);
            this.AmmoTxt.TabIndex = 0;
            this.AmmoTxt.Text = "Ammo:0";
            // 
            // KilsTxt
            // 
            this.KilsTxt.AutoSize = true;
            this.KilsTxt.BackColor = System.Drawing.Color.White;
            this.KilsTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KilsTxt.Location = new System.Drawing.Point(204, 9);
            this.KilsTxt.Name = "KilsTxt";
            this.KilsTxt.Size = new System.Drawing.Size(68, 24);
            this.KilsTxt.TabIndex = 1;
            this.KilsTxt.Text = "Kills : 0";
            // 
            // HealthTxt
            // 
            this.HealthTxt.AutoSize = true;
            this.HealthTxt.BackColor = System.Drawing.Color.White;
            this.HealthTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HealthTxt.Location = new System.Drawing.Point(403, 9);
            this.HealthTxt.Name = "HealthTxt";
            this.HealthTxt.Size = new System.Drawing.Size(64, 24);
            this.HealthTxt.TabIndex = 2;
            this.HealthTxt.Text = "Health";
            // 
            // HealthBar
            // 
            this.HealthBar.Location = new System.Drawing.Point(508, 9);
            this.HealthBar.Name = "HealthBar";
            this.HealthBar.Size = new System.Drawing.Size(198, 23);
            this.HealthBar.TabIndex = 3;
            this.HealthBar.Value = 100;
            // 
            // Player
            // 
            this.Player.Image = global::zombie.Properties.Resources.up;
            this.Player.Location = new System.Drawing.Point(257, 122);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(71, 100);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Player.TabIndex = 4;
            this.Player.TabStop = false;
            this.Player.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimerEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(684, 398);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.HealthBar);
            this.Controls.Add(this.HealthTxt);
            this.Controls.Add(this.KilsTxt);
            this.Controls.Add(this.AmmoTxt);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Zombie";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AmmoTxt;
        private System.Windows.Forms.Label KilsTxt;
        private System.Windows.Forms.Label HealthTxt;
        private System.Windows.Forms.ProgressBar HealthBar;
        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.Timer GameTimer;
    }
}

