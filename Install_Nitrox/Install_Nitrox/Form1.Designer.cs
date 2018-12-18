namespace Install_Nitrox
{
    partial class Subnautica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Subnautica));
            this.debugInstructionsLabel = new System.Windows.Forms.Label();
            this.NextBTN = new System.Windows.Forms.Button();
            this.Hello = new System.Windows.Forms.Label();
            this.GameDir = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ServerDir = new System.Windows.Forms.TextBox();
            this.GameDialog = new System.Windows.Forms.Button();
            this.ServerDialog = new System.Windows.Forms.Button();
            this.ServerCB = new System.Windows.Forms.CheckBox();
            this.GameDirFBD = new System.Windows.Forms.FolderBrowserDialog();
            this.ServerDirFBD = new System.Windows.Forms.FolderBrowserDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // debugInstructionsLabel
            // 
            this.debugInstructionsLabel.AutoSize = true;
            this.debugInstructionsLabel.Location = new System.Drawing.Point(114, 178);
            this.debugInstructionsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.debugInstructionsLabel.Name = "debugInstructionsLabel";
            this.debugInstructionsLabel.Size = new System.Drawing.Size(67, 13);
            this.debugInstructionsLabel.TabIndex = 1;
            this.debugInstructionsLabel.Text = "Game Folder";
            // 
            // NextBTN
            // 
            this.NextBTN.Location = new System.Drawing.Point(222, 295);
            this.NextBTN.Margin = new System.Windows.Forms.Padding(2);
            this.NextBTN.Name = "NextBTN";
            this.NextBTN.Size = new System.Drawing.Size(97, 28);
            this.NextBTN.TabIndex = 2;
            this.NextBTN.Text = "Next Step";
            this.NextBTN.UseVisualStyleBackColor = true;
            this.NextBTN.Click += new System.EventHandler(this.button1_Click);
            // 
            // Hello
            // 
            this.Hello.AutoSize = true;
            this.Hello.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hello.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Hello.Location = new System.Drawing.Point(120, 10);
            this.Hello.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Hello.Name = "Hello";
            this.Hello.Size = new System.Drawing.Size(330, 26);
            this.Hello.TabIndex = 3;
            this.Hello.Text = "NITROX Installer by BeamPoints";
            // 
            // GameDir
            // 
            this.GameDir.Location = new System.Drawing.Point(160, 195);
            this.GameDir.Name = "GameDir";
            this.GameDir.Size = new System.Drawing.Size(257, 20);
            this.GameDir.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 218);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Server Folder";
            // 
            // ServerDir
            // 
            this.ServerDir.Location = new System.Drawing.Point(160, 234);
            this.ServerDir.Name = "ServerDir";
            this.ServerDir.Size = new System.Drawing.Size(257, 20);
            this.ServerDir.TabIndex = 6;
            // 
            // GameDialog
            // 
            this.GameDialog.Location = new System.Drawing.Point(126, 195);
            this.GameDialog.Name = "GameDialog";
            this.GameDialog.Size = new System.Drawing.Size(28, 20);
            this.GameDialog.TabIndex = 7;
            this.GameDialog.Text = "...";
            this.GameDialog.UseVisualStyleBackColor = true;
            this.GameDialog.Click += new System.EventHandler(this.GameDialog_Click);
            // 
            // ServerDialog
            // 
            this.ServerDialog.Location = new System.Drawing.Point(126, 234);
            this.ServerDialog.Name = "ServerDialog";
            this.ServerDialog.Size = new System.Drawing.Size(28, 20);
            this.ServerDialog.TabIndex = 8;
            this.ServerDialog.Text = "...";
            this.ServerDialog.UseVisualStyleBackColor = true;
            this.ServerDialog.Click += new System.EventHandler(this.ServerDialog_Click);
            // 
            // ServerCB
            // 
            this.ServerCB.AccessibleName = "ServerCB";
            this.ServerCB.AutoSize = true;
            this.ServerCB.Location = new System.Drawing.Point(94, 218);
            this.ServerCB.Name = "ServerCB";
            this.ServerCB.Size = new System.Drawing.Size(15, 14);
            this.ServerCB.TabIndex = 9;
            this.ServerCB.UseVisualStyleBackColor = true;
            this.ServerCB.CheckedChanged += new System.EventHandler(this.ServerCB_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(422, 198);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "use Game Directory";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(422, 238);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "use a Clean Directory";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(72, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(187, 39);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(195, 104);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.InitialImage")));
            this.pictureBox3.Location = new System.Drawing.Point(388, 39);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(119, 104);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            // 
            // Subnautica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(569, 337);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ServerCB);
            this.Controls.Add(this.ServerDialog);
            this.Controls.Add(this.GameDialog);
            this.Controls.Add(this.ServerDir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GameDir);
            this.Controls.Add(this.Hello);
            this.Controls.Add(this.NextBTN);
            this.Controls.Add(this.debugInstructionsLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Subnautica";
            this.Text = "Subnautica Nitrox Installer by BeamPoints";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label debugInstructionsLabel;
        private System.Windows.Forms.Button NextBTN;
        private System.Windows.Forms.Label Hello;
        private System.Windows.Forms.TextBox GameDir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ServerDir;
        private System.Windows.Forms.Button GameDialog;
        private System.Windows.Forms.Button ServerDialog;
        private System.Windows.Forms.CheckBox ServerCB;
        private System.Windows.Forms.FolderBrowserDialog GameDirFBD;
        private System.Windows.Forms.FolderBrowserDialog ServerDirFBD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

