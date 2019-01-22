namespace Provisionware
{
    partial class FormServ
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
            this.logtxtbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.iptxtbx = new System.Windows.Forms.TextBox();
            this.porttxbx = new System.Windows.Forms.TextBox();
            this.setIPPortbtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.currentSettingstxt = new System.Windows.Forms.Label();
            this.listenbtn = new System.Windows.Forms.Button();
            this.stopListening = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // logtxtbx
            // 
            this.logtxtbx.Location = new System.Drawing.Point(12, 145);
            this.logtxtbx.Multiline = true;
            this.logtxtbx.Name = "logtxtbx";
            this.logtxtbx.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.logtxtbx.Size = new System.Drawing.Size(924, 179);
            this.logtxtbx.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Listen on IP Adress";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(268, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Port";
            // 
            // iptxtbx
            // 
            this.iptxtbx.Location = new System.Drawing.Point(140, 22);
            this.iptxtbx.Name = "iptxtbx";
            this.iptxtbx.Size = new System.Drawing.Size(100, 20);
            this.iptxtbx.TabIndex = 3;
            // 
            // porttxbx
            // 
            this.porttxbx.Location = new System.Drawing.Point(300, 22);
            this.porttxbx.Name = "porttxbx";
            this.porttxbx.Size = new System.Drawing.Size(68, 20);
            this.porttxbx.TabIndex = 4;
            // 
            // setIPPortbtn
            // 
            this.setIPPortbtn.Location = new System.Drawing.Point(426, 18);
            this.setIPPortbtn.Name = "setIPPortbtn";
            this.setIPPortbtn.Size = new System.Drawing.Size(103, 23);
            this.setIPPortbtn.TabIndex = 5;
            this.setIPPortbtn.Text = "Accept Settings";
            this.setIPPortbtn.UseVisualStyleBackColor = true;
            this.setIPPortbtn.Click += new System.EventHandler(this.setIPPortbtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label3.Location = new System.Drawing.Point(36, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 6;
            // 
            // currentSettingstxt
            // 
            this.currentSettingstxt.AutoSize = true;
            this.currentSettingstxt.ForeColor = System.Drawing.Color.ForestGreen;
            this.currentSettingstxt.Location = new System.Drawing.Point(137, 53);
            this.currentSettingstxt.Name = "currentSettingstxt";
            this.currentSettingstxt.Size = new System.Drawing.Size(90, 13);
            this.currentSettingstxt.TabIndex = 7;
            this.currentSettingstxt.Text = "<Not Configured>";
            // 
            // listenbtn
            // 
            this.listenbtn.Location = new System.Drawing.Point(649, 18);
            this.listenbtn.Name = "listenbtn";
            this.listenbtn.Size = new System.Drawing.Size(48, 23);
            this.listenbtn.TabIndex = 8;
            this.listenbtn.Text = "Listen";
            this.listenbtn.UseVisualStyleBackColor = true;
            this.listenbtn.Click += new System.EventHandler(this.listenbtn_Click);
            // 
            // stopListening
            // 
            this.stopListening.Location = new System.Drawing.Point(703, 19);
            this.stopListening.Name = "stopListening";
            this.stopListening.Size = new System.Drawing.Size(48, 23);
            this.stopListening.TabIndex = 9;
            this.stopListening.Text = "Stop";
            this.stopListening.UseVisualStyleBackColor = true;
            this.stopListening.Click += new System.EventHandler(this.stopListening_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 336);
            this.Controls.Add(this.stopListening);
            this.Controls.Add(this.listenbtn);
            this.Controls.Add(this.currentSettingstxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.setIPPortbtn);
            this.Controls.Add(this.porttxbx);
            this.Controls.Add(this.iptxtbx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logtxtbx);
            this.Name = "Form1";
            this.Text = "ProvisionWare-Server";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox logtxtbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox iptxtbx;
        private System.Windows.Forms.TextBox porttxbx;
        private System.Windows.Forms.Button setIPPortbtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label currentSettingstxt;
        private System.Windows.Forms.Button listenbtn;
        private System.Windows.Forms.Button stopListening;
    }
}

