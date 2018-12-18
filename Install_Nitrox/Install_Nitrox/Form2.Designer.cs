using System.Windows.Forms;

namespace Install_Nitrox
{
    partial class Form2
    {
        string GamePath = null;
        string ServerPath = null;

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

        public void GetPaths(string Game, string Server)
        {
            GamePath = Game;
            if(Server != null)
            {
                ServerPath = Server;

            }
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.weiter = new System.Windows.Forms.Button();
            this.Zurück = new System.Windows.Forms.Button();
            this.mpbtn = new System.Windows.Forms.RadioButton();
            this.bothbtn = new System.Windows.Forms.RadioButton();
            this.serverbtn = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "what do you want to install";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(89, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Muliplayer and Server";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(89, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Only Server";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(89, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Only Multiplayer";
            // 
            // weiter
            // 
            this.weiter.Location = new System.Drawing.Point(148, 195);
            this.weiter.Name = "weiter";
            this.weiter.Size = new System.Drawing.Size(75, 23);
            this.weiter.TabIndex = 7;
            this.weiter.Text = "Continue";
            this.weiter.UseVisualStyleBackColor = true;
            this.weiter.Click += new System.EventHandler(this.weiter_Click);
            // 
            // Zurück
            // 
            this.Zurück.Location = new System.Drawing.Point(59, 195);
            this.Zurück.Name = "Zurück";
            this.Zurück.Size = new System.Drawing.Size(75, 23);
            this.Zurück.TabIndex = 8;
            this.Zurück.Text = "Back";
            this.Zurück.UseVisualStyleBackColor = true;
            this.Zurück.Click += new System.EventHandler(this.Zurück_Click);
            // 
            // mpbtn
            // 
            this.mpbtn.AutoSize = true;
            this.mpbtn.Location = new System.Drawing.Point(69, 84);
            this.mpbtn.Name = "mpbtn";
            this.mpbtn.Size = new System.Drawing.Size(14, 13);
            this.mpbtn.TabIndex = 9;
            this.mpbtn.TabStop = true;
            this.mpbtn.UseVisualStyleBackColor = true;
            this.mpbtn.CheckedChanged += new System.EventHandler(this.mpbtn_CheckedChanged);
            // 
            // bothbtn
            // 
            this.bothbtn.AutoSize = true;
            this.bothbtn.Location = new System.Drawing.Point(69, 108);
            this.bothbtn.Name = "bothbtn";
            this.bothbtn.Size = new System.Drawing.Size(14, 13);
            this.bothbtn.TabIndex = 10;
            this.bothbtn.TabStop = true;
            this.bothbtn.UseVisualStyleBackColor = true;
            this.bothbtn.CheckedChanged += new System.EventHandler(this.bothbtn_CheckedChanged);
            // 
            // serverbtn
            // 
            this.serverbtn.AutoSize = true;
            this.serverbtn.Location = new System.Drawing.Point(69, 132);
            this.serverbtn.Name = "serverbtn";
            this.serverbtn.Size = new System.Drawing.Size(14, 13);
            this.serverbtn.TabIndex = 11;
            this.serverbtn.TabStop = true;
            this.serverbtn.UseVisualStyleBackColor = true;
            this.serverbtn.CheckedChanged += new System.EventHandler(this.serverbtn_CheckedChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(302, 239);
            this.Controls.Add(this.serverbtn);
            this.Controls.Add(this.bothbtn);
            this.Controls.Add(this.mpbtn);
            this.Controls.Add(this.Zurück);
            this.Controls.Add(this.weiter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Subnautica Nitrox Installer by BeamPoints";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button weiter;
        private System.Windows.Forms.Button Zurück;
        private System.Windows.Forms.RadioButton mpbtn;
        private System.Windows.Forms.RadioButton bothbtn;
        private System.Windows.Forms.RadioButton serverbtn;
    }
}