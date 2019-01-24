namespace ProvisionwareClient
{
    partial class NameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NameForm));
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.buttonSubmitName = new System.Windows.Forms.Button();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.labelNamePrompt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBoxFirstName.Location = new System.Drawing.Point(111, 139);
            this.textBoxFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(230, 25);
            this.textBoxFirstName.TabIndex = 0;
            this.textBoxFirstName.TextChanged += new System.EventHandler(this.textBoxFirstName_TextChanged);
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBoxLastName.Location = new System.Drawing.Point(111, 194);
            this.textBoxLastName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(230, 25);
            this.textBoxLastName.TabIndex = 1;
            this.textBoxLastName.TextChanged += new System.EventHandler(this.textBoxLastName_TextChanged);
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.BackColor = System.Drawing.Color.Transparent;
            this.labelFirstName.Location = new System.Drawing.Point(16, 139);
            this.labelFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(87, 17);
            this.labelFirstName.TabIndex = 2;
            this.labelFirstName.Text = "First Name";
            this.labelFirstName.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.BackColor = System.Drawing.Color.Transparent;
            this.labelLastName.Location = new System.Drawing.Point(16, 194);
            this.labelLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(85, 17);
            this.labelLastName.TabIndex = 3;
            this.labelLastName.Text = "Last Name";
            // 
            // buttonSubmitName
            // 
            this.buttonSubmitName.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonSubmitName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSubmitName.Location = new System.Drawing.Point(153, 255);
            this.buttonSubmitName.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSubmitName.Name = "buttonSubmitName";
            this.buttonSubmitName.Size = new System.Drawing.Size(112, 30);
            this.buttonSubmitName.TabIndex = 4;
            this.buttonSubmitName.Text = "Submit";
            this.buttonSubmitName.UseVisualStyleBackColor = false;
            this.buttonSubmitName.Click += new System.EventHandler(this.Button1_Click);
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.BackColor = System.Drawing.Color.Transparent;
            this.labelWelcome.Font = new System.Drawing.Font("Bauhaus 93", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.Location = new System.Drawing.Point(26, 9);
            this.labelWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(361, 33);
            this.labelWelcome.TabIndex = 5;
            this.labelWelcome.Text = "Welcome to Provisionware!";
            this.labelWelcome.Click += new System.EventHandler(this.label3_Click);
            // 
            // labelNamePrompt
            // 
            this.labelNamePrompt.AutoSize = true;
            this.labelNamePrompt.BackColor = System.Drawing.Color.Transparent;
            this.labelNamePrompt.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNamePrompt.Location = new System.Drawing.Point(66, 53);
            this.labelNamePrompt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNamePrompt.Name = "labelNamePrompt";
            this.labelNamePrompt.Size = new System.Drawing.Size(275, 27);
            this.labelNamePrompt.TabIndex = 6;
            this.labelNamePrompt.Text = "Please enter your name.";
            // 
            // NameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(399, 327);
            this.Controls.Add(this.labelNamePrompt);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.buttonSubmitName);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NameForm";
            this.Text = "NameForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Button buttonSubmitName;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Label labelNamePrompt;
    }
}