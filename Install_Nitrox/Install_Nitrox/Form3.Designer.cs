using System.Windows.Forms;

namespace Install_Nitrox
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.DLCL = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.DLSV = new System.Windows.Forms.ProgressBar();
            this.UPCL = new System.Windows.Forms.ProgressBar();
            this.UPSV = new System.Windows.Forms.ProgressBar();
            this.ITCL = new System.Windows.Forms.ProgressBar();
            this.ITSV = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.FINISH = new System.Windows.Forms.Button();
            this.DL_CL = new System.Windows.Forms.Label();
            this.DL_SV = new System.Windows.Forms.Label();
            this.UP_CL = new System.Windows.Forms.Label();
            this.UP_SV = new System.Windows.Forms.Label();
            this.IT_CL = new System.Windows.Forms.Label();
            this.IT_SV = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DLCL
            // 
            this.DLCL.Location = new System.Drawing.Point(151, 35);
            this.DLCL.Name = "DLCL";
            this.DLCL.Size = new System.Drawing.Size(506, 23);
            this.DLCL.Step = 1;
            this.DLCL.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label1.Location = new System.Drawing.Point(8, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "DOWNLOAD Client";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // DLSV
            // 
            this.DLSV.Location = new System.Drawing.Point(151, 64);
            this.DLSV.Name = "DLSV";
            this.DLSV.Size = new System.Drawing.Size(506, 23);
            this.DLSV.Step = 1;
            this.DLSV.TabIndex = 2;
            // 
            // UPCL
            // 
            this.UPCL.Location = new System.Drawing.Point(151, 108);
            this.UPCL.Name = "UPCL";
            this.UPCL.Size = new System.Drawing.Size(506, 23);
            this.UPCL.Step = 1;
            this.UPCL.TabIndex = 3;
            // 
            // UPSV
            // 
            this.UPSV.Location = new System.Drawing.Point(151, 137);
            this.UPSV.Name = "UPSV";
            this.UPSV.Size = new System.Drawing.Size(506, 23);
            this.UPSV.Step = 1;
            this.UPSV.TabIndex = 4;
            // 
            // ITCL
            // 
            this.ITCL.Location = new System.Drawing.Point(151, 181);
            this.ITCL.Name = "ITCL";
            this.ITCL.Size = new System.Drawing.Size(506, 23);
            this.ITCL.Step = 1;
            this.ITCL.TabIndex = 5;
            // 
            // ITSV
            // 
            this.ITSV.Location = new System.Drawing.Point(151, 210);
            this.ITSV.Name = "ITSV";
            this.ITSV.Size = new System.Drawing.Size(506, 23);
            this.ITSV.Step = 1;
            this.ITSV.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label2.Location = new System.Drawing.Point(8, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "DOWNLOAD Server";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label3.Location = new System.Drawing.Point(12, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "UNPACK Client";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label4.Location = new System.Drawing.Point(12, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "UNPACK Server";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label5.Location = new System.Drawing.Point(12, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Install Server";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label6.Location = new System.Drawing.Point(12, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Install Client";
            // 
            // FINISH
            // 
            this.FINISH.Location = new System.Drawing.Point(346, 252);
            this.FINISH.Name = "FINISH";
            this.FINISH.Size = new System.Drawing.Size(75, 23);
            this.FINISH.TabIndex = 12;
            this.FINISH.Text = "FINISHED";
            this.FINISH.UseVisualStyleBackColor = true;
            this.FINISH.Click += new System.EventHandler(this.FINISH_Click);
            // 
            // DL_CL
            // 
            this.DL_CL.AutoSize = true;
            this.DL_CL.Location = new System.Drawing.Point(663, 42);
            this.DL_CL.Name = "DL_CL";
            this.DL_CL.Size = new System.Drawing.Size(35, 13);
            this.DL_CL.TabIndex = 13;
            this.DL_CL.Text = "label7";
            // 
            // DL_SV
            // 
            this.DL_SV.AutoSize = true;
            this.DL_SV.Location = new System.Drawing.Point(663, 71);
            this.DL_SV.Name = "DL_SV";
            this.DL_SV.Size = new System.Drawing.Size(35, 13);
            this.DL_SV.TabIndex = 14;
            this.DL_SV.Text = "label8";
            // 
            // UP_CL
            // 
            this.UP_CL.AutoSize = true;
            this.UP_CL.Location = new System.Drawing.Point(663, 115);
            this.UP_CL.Name = "UP_CL";
            this.UP_CL.Size = new System.Drawing.Size(35, 13);
            this.UP_CL.TabIndex = 15;
            this.UP_CL.Text = "label9";
            // 
            // UP_SV
            // 
            this.UP_SV.AutoSize = true;
            this.UP_SV.Location = new System.Drawing.Point(663, 144);
            this.UP_SV.Name = "UP_SV";
            this.UP_SV.Size = new System.Drawing.Size(41, 13);
            this.UP_SV.TabIndex = 16;
            this.UP_SV.Text = "label10";
            // 
            // IT_CL
            // 
            this.IT_CL.AutoSize = true;
            this.IT_CL.Location = new System.Drawing.Point(663, 188);
            this.IT_CL.Name = "IT_CL";
            this.IT_CL.Size = new System.Drawing.Size(41, 13);
            this.IT_CL.TabIndex = 17;
            this.IT_CL.Text = "label11";
            // 
            // IT_SV
            // 
            this.IT_SV.AutoSize = true;
            this.IT_SV.Location = new System.Drawing.Point(663, 217);
            this.IT_SV.Name = "IT_SV";
            this.IT_SV.Size = new System.Drawing.Size(41, 13);
            this.IT_SV.TabIndex = 18;
            this.IT_SV.Text = "label12";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(811, 287);
            this.Controls.Add(this.IT_SV);
            this.Controls.Add(this.IT_CL);
            this.Controls.Add(this.UP_SV);
            this.Controls.Add(this.UP_CL);
            this.Controls.Add(this.DL_SV);
            this.Controls.Add(this.DL_CL);
            this.Controls.Add(this.FINISH);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ITSV);
            this.Controls.Add(this.ITCL);
            this.Controls.Add(this.UPSV);
            this.Controls.Add(this.UPCL);
            this.Controls.Add(this.DLSV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DLCL);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.Text = "Subnautica Nitrox Installer by BeamPoints";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form3_FormClosed);
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ProgressBar DLCL;
        private Label label1;
        private ProgressBar DLSV;
        private ProgressBar UPCL;
        private ProgressBar UPSV;
        private ProgressBar ITCL;
        private ProgressBar ITSV;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button FINISH;
        private Label DL_CL;
        private Label DL_SV;
        private Label UP_CL;
        private Label UP_SV;
        private Label IT_CL;
        private Label IT_SV;
    }
}