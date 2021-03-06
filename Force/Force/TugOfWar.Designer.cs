﻿namespace Force
{
    partial class TugOfWar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TugOfWar));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.picCharL = new System.Windows.Forms.PictureBox();
            this.picCharR = new System.Windows.Forms.PictureBox();
            this.picRope = new System.Windows.Forms.PictureBox();
            this.picVoid = new System.Windows.Forms.PictureBox();
            this.lblCPU = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picCharL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCharR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRope)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVoid)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // picCharL
            // 
            this.picCharL.BackColor = System.Drawing.Color.Transparent;
            this.picCharL.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picCharL.BackgroundImage")));
            this.picCharL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picCharL.Location = new System.Drawing.Point(267, 211);
            this.picCharL.Name = "picCharL";
            this.picCharL.Size = new System.Drawing.Size(64, 54);
            this.picCharL.TabIndex = 0;
            this.picCharL.TabStop = false;
            // 
            // picCharR
            // 
            this.picCharR.BackColor = System.Drawing.Color.Transparent;
            this.picCharR.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picCharR.BackgroundImage")));
            this.picCharR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picCharR.Location = new System.Drawing.Point(577, 194);
            this.picCharR.Name = "picCharR";
            this.picCharR.Size = new System.Drawing.Size(74, 71);
            this.picCharR.TabIndex = 1;
            this.picCharR.TabStop = false;
            // 
            // picRope
            // 
            this.picRope.BackColor = System.Drawing.Color.Transparent;
            this.picRope.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picRope.BackgroundImage")));
            this.picRope.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picRope.Location = new System.Drawing.Point(316, 169);
            this.picRope.Name = "picRope";
            this.picRope.Size = new System.Drawing.Size(267, 128);
            this.picRope.TabIndex = 2;
            this.picRope.TabStop = false;
            // 
            // picVoid
            // 
            this.picVoid.BackColor = System.Drawing.Color.Black;
            this.picVoid.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picVoid.BackgroundImage")));
            this.picVoid.Location = new System.Drawing.Point(358, 27);
            this.picVoid.Name = "picVoid";
            this.picVoid.Size = new System.Drawing.Size(14, 406);
            this.picVoid.TabIndex = 3;
            this.picVoid.TabStop = false;
            // 
            // lblCPU
            // 
            this.lblCPU.AutoSize = true;
            this.lblCPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPU.ForeColor = System.Drawing.Color.White;
            this.lblCPU.Location = new System.Drawing.Point(26, 62);
            this.lblCPU.Name = "lblCPU";
            this.lblCPU.Size = new System.Drawing.Size(260, 38);
            this.lblCPU.TabIndex = 4;
            this.lblCPU.Text = "CPU: automatic";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.White;
            this.lblUser.Location = new System.Drawing.Point(467, 62);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(116, 38);
            this.lblUser.TabIndex = 5;
            this.lblUser.Text = "You: J";
            // 
            // TugOfWar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(702, 474);
            this.Controls.Add(this.picCharR);
            this.Controls.Add(this.picCharL);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblCPU);
            this.Controls.Add(this.picVoid);
            this.Controls.Add(this.picRope);
            this.Name = "TugOfWar";
            this.Text = "Tug of War!";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TugOfWar_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.picCharL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCharR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRope)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVoid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox picCharL;
        private System.Windows.Forms.PictureBox picCharR;
        private System.Windows.Forms.PictureBox picRope;
        private System.Windows.Forms.PictureBox picVoid;
        private System.Windows.Forms.Label lblCPU;
        private System.Windows.Forms.Label lblUser;
    }
}