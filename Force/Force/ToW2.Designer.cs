namespace Force
{
    partial class ToW2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToW2));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.picVoid = new System.Windows.Forms.PictureBox();
            this.picRope = new System.Windows.Forms.PictureBox();
            this.picCharR = new System.Windows.Forms.PictureBox();
            this.picCharL = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picVoid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRope)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCharR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCharL)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // picVoid
            // 
            this.picVoid.BackColor = System.Drawing.Color.Black;
            this.picVoid.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picVoid.BackgroundImage")));
            this.picVoid.Location = new System.Drawing.Point(262, 22);
            this.picVoid.Name = "picVoid";
            this.picVoid.Size = new System.Drawing.Size(31, 406);
            this.picVoid.TabIndex = 7;
            this.picVoid.TabStop = false;
            // 
            // picRope
            // 
            this.picRope.BackColor = System.Drawing.Color.Transparent;
            this.picRope.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picRope.BackgroundImage")));
            this.picRope.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picRope.Location = new System.Drawing.Point(159, 186);
            this.picRope.Name = "picRope";
            this.picRope.Size = new System.Drawing.Size(239, 84);
            this.picRope.TabIndex = 6;
            this.picRope.TabStop = false;
            // 
            // picCharR
            // 
            this.picCharR.BackColor = System.Drawing.Color.Transparent;
            this.picCharR.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picCharR.BackgroundImage")));
            this.picCharR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picCharR.Location = new System.Drawing.Point(387, 202);
            this.picCharR.Name = "picCharR";
            this.picCharR.Size = new System.Drawing.Size(61, 56);
            this.picCharR.TabIndex = 5;
            this.picCharR.TabStop = false;
            // 
            // picCharL
            // 
            this.picCharL.BackColor = System.Drawing.Color.Transparent;
            this.picCharL.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picCharL.BackgroundImage")));
            this.picCharL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picCharL.Location = new System.Drawing.Point(107, 224);
            this.picCharL.Name = "picCharL";
            this.picCharL.Size = new System.Drawing.Size(73, 72);
            this.picCharL.TabIndex = 4;
            this.picCharL.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(45, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 38);
            this.label1.TabIndex = 8;
            this.label1.Text = "Player 1: A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(371, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 38);
            this.label2.TabIndex = 9;
            this.label2.Text = "Player 2: L";
            // 
            // ToW2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(652, 451);
            this.Controls.Add(this.picCharR);
            this.Controls.Add(this.picCharL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picVoid);
            this.Controls.Add(this.picRope);
            this.Name = "ToW2";
            this.Text = "ToW2";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ToW2_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.picVoid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRope)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCharR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCharL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox picVoid;
        private System.Windows.Forms.PictureBox picRope;
        private System.Windows.Forms.PictureBox picCharR;
        private System.Windows.Forms.PictureBox picCharL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}