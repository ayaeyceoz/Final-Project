namespace Force
{
    partial class Hallway
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hallway));
            this.btnmainmenu = new System.Windows.Forms.Button();
            this.btn1player = new System.Windows.Forms.Button();
            this.btn2player = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnmainmenu
            // 
            this.btnmainmenu.Location = new System.Drawing.Point(249, 391);
            this.btnmainmenu.Name = "btnmainmenu";
            this.btnmainmenu.Size = new System.Drawing.Size(174, 56);
            this.btnmainmenu.TabIndex = 0;
            this.btnmainmenu.Text = "Return to Force Freeway!";
            this.btnmainmenu.UseVisualStyleBackColor = true;
            this.btnmainmenu.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn1player
            // 
            this.btn1player.Location = new System.Drawing.Point(29, 183);
            this.btn1player.Name = "btn1player";
            this.btn1player.Size = new System.Drawing.Size(85, 37);
            this.btn1player.TabIndex = 1;
            this.btn1player.Text = "1 Player";
            this.btn1player.UseVisualStyleBackColor = true;
            this.btn1player.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn2player
            // 
            this.btn2player.Location = new System.Drawing.Point(542, 183);
            this.btn2player.Name = "btn2player";
            this.btn2player.Size = new System.Drawing.Size(85, 37);
            this.btn2player.TabIndex = 2;
            this.btn2player.Text = "2 Player";
            this.btn2player.UseVisualStyleBackColor = true;
            this.btn2player.Click += new System.EventHandler(this.button3_Click);
            // 
            // Hallway
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(657, 458);
            this.Controls.Add(this.btn2player);
            this.Controls.Add(this.btn1player);
            this.Controls.Add(this.btnmainmenu);
            this.Name = "Hallway";
            this.Text = "Hallway";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnmainmenu;
        private System.Windows.Forms.Button btn1player;
        private System.Windows.Forms.Button btn2player;
    }
}