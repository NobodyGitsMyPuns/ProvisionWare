using proCart;
using System.Collections.Generic;

namespace ProvisionwareClient
{
    partial class FormCli
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.iptxtbx = new System.Windows.Forms.TextBox();
            this.porttxtbx = new System.Windows.Forms.TextBox();
            this.logtxtbx = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.requestCatalog = new System.Windows.Forms.Button();
            this.listBoxCatalogViewer = new System.Windows.Forms.ListBox();
            this.listBoxCartViewer = new System.Windows.Forms.ListBox();
            this.buttonAddToCart = new System.Windows.Forms.Button();
            this.textBoxQuantityInput = new System.Windows.Forms.TextBox();
            this.pictureBoxItemPhoto = new System.Windows.Forms.PictureBox();
            this.textBoxItemDescription = new System.Windows.Forms.TextBox();
            this.labelCatalogLabel = new System.Windows.Forms.Label();
            this.labelCartLabel = new System.Windows.Forms.Label();
            this.buttonSubmitRequest = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxItemPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(891, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.connectToolStripMenuItem.Text = "Connect";
            this.connectToolStripMenuItem.Click += new System.EventHandler(this.connectToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Destination Server IP ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(303, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Destination Server Port";
            // 
            // iptxtbx
            // 
            this.iptxtbx.BackColor = System.Drawing.Color.Gray;
            this.iptxtbx.Location = new System.Drawing.Point(167, 38);
            this.iptxtbx.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.iptxtbx.Name = "iptxtbx";
            this.iptxtbx.Size = new System.Drawing.Size(116, 22);
            this.iptxtbx.TabIndex = 3;
            // 
            // porttxtbx
            // 
            this.porttxtbx.BackColor = System.Drawing.Color.Gray;
            this.porttxtbx.Location = new System.Drawing.Point(447, 38);
            this.porttxtbx.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.porttxtbx.Name = "porttxtbx";
            this.porttxtbx.Size = new System.Drawing.Size(116, 22);
            this.porttxtbx.TabIndex = 4;
            // 
            // logtxtbx
            // 
            this.logtxtbx.BackColor = System.Drawing.SystemColors.ControlText;
            this.logtxtbx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logtxtbx.ForeColor = System.Drawing.Color.Green;
            this.logtxtbx.Location = new System.Drawing.Point(657, 364);
            this.logtxtbx.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.logtxtbx.Multiline = true;
            this.logtxtbx.Name = "logtxtbx";
            this.logtxtbx.ReadOnly = true;
            this.logtxtbx.Size = new System.Drawing.Size(215, 147);
            this.logtxtbx.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.Location = new System.Drawing.Point(606, 38);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 28);
            this.button1.TabIndex = 6;
            this.button1.Text = "Accept Settings";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // requestCatalog
            // 
            this.requestCatalog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.requestCatalog.Location = new System.Drawing.Point(749, 38);
            this.requestCatalog.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.requestCatalog.Name = "requestCatalog";
            this.requestCatalog.Size = new System.Drawing.Size(114, 28);
            this.requestCatalog.TabIndex = 7;
            this.requestCatalog.Text = "Request Catalog";
            this.requestCatalog.UseVisualStyleBackColor = false;
            // 
            // listBoxCatalogViewer
            // 
            this.listBoxCatalogViewer.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.listBoxCatalogViewer.FormattingEnabled = true;
            this.listBoxCatalogViewer.ItemHeight = 16;

            /*
            Item item1 = new Item("Batteries, AA, 4 pack", "A 4 pack of AA batteries");
            Item item2 = new Item("Pen, Ballpoint, Black Ink", "A ballpoitn pen, made by Skillcraft.  Black ink.");
            itemList.Add(item1);
            itemList.Add(item2);
            this.listBoxCatalogViewer.Items.AddRange(new object[] {
            itemList[0].getName(),
            itemList[1].getName()});
            */
    
            this.listBoxCatalogViewer.Location = new System.Drawing.Point(31, 102);
            this.listBoxCatalogViewer.Name = "listBoxCatalogViewer";
            this.listBoxCatalogViewer.Size = new System.Drawing.Size(206, 308);
            this.listBoxCatalogViewer.Sorted = true;
            this.listBoxCatalogViewer.TabIndex = 8;
            // 
            // listBoxCartViewer
            // 
            this.listBoxCartViewer.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.listBoxCartViewer.FormattingEnabled = true;
            this.listBoxCartViewer.ItemHeight = 16;
            this.listBoxCartViewer.Location = new System.Drawing.Point(657, 102);
            this.listBoxCartViewer.Name = "listBoxCartViewer";
            this.listBoxCartViewer.Size = new System.Drawing.Size(206, 196);
            this.listBoxCartViewer.Sorted = true;
            this.listBoxCartViewer.TabIndex = 9;
            // 
            // buttonAddToCart
            // 
            this.buttonAddToCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonAddToCart.Location = new System.Drawing.Point(123, 437);
            this.buttonAddToCart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAddToCart.Name = "buttonAddToCart";
            this.buttonAddToCart.Size = new System.Drawing.Size(114, 28);
            this.buttonAddToCart.TabIndex = 10;
            this.buttonAddToCart.Text = "Add to Cart";
            this.buttonAddToCart.UseVisualStyleBackColor = false;
            this.buttonAddToCart.Click += new System.EventHandler(this.buttonAddToCart_Click);
            // 
            // textBoxQuantityInput
            // 
            this.textBoxQuantityInput.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxQuantityInput.Location = new System.Drawing.Point(74, 440);
            this.textBoxQuantityInput.Name = "textBoxQuantityInput";
            this.textBoxQuantityInput.Size = new System.Drawing.Size(43, 22);
            this.textBoxQuantityInput.TabIndex = 11;
            this.textBoxQuantityInput.Text = "1";
            this.textBoxQuantityInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxQuantityInput.Enter += new System.EventHandler(this.textBoxQuantityInput_Enter);
            // 
            // pictureBoxItemPhoto
            // 
            this.pictureBoxItemPhoto.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxItemPhoto.Location = new System.Drawing.Point(328, 102);
            this.pictureBoxItemPhoto.Name = "pictureBoxItemPhoto";
            this.pictureBoxItemPhoto.Size = new System.Drawing.Size(248, 123);
            this.pictureBoxItemPhoto.TabIndex = 12;
            this.pictureBoxItemPhoto.TabStop = false;
            // 
            // textBoxItemDescription
            // 
            this.textBoxItemDescription.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBoxItemDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxItemDescription.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.textBoxItemDescription.Location = new System.Drawing.Point(243, 247);
            this.textBoxItemDescription.Multiline = true;
            this.textBoxItemDescription.Name = "textBoxItemDescription";
            this.textBoxItemDescription.ReadOnly = true;
            this.textBoxItemDescription.Size = new System.Drawing.Size(408, 163);
            this.textBoxItemDescription.TabIndex = 13;
            // 
            // labelCatalogLabel
            // 
            this.labelCatalogLabel.AutoSize = true;
            this.labelCatalogLabel.BackColor = System.Drawing.Color.Transparent;
            this.labelCatalogLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCatalogLabel.Location = new System.Drawing.Point(27, 77);
            this.labelCatalogLabel.Name = "labelCatalogLabel";
            this.labelCatalogLabel.Size = new System.Drawing.Size(76, 22);
            this.labelCatalogLabel.TabIndex = 14;
            this.labelCatalogLabel.Text = "Catelog";
            // 
            // labelCartLabel
            // 
            this.labelCartLabel.AutoSize = true;
            this.labelCartLabel.BackColor = System.Drawing.Color.Transparent;
            this.labelCartLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCartLabel.Location = new System.Drawing.Point(653, 77);
            this.labelCartLabel.Name = "labelCartLabel";
            this.labelCartLabel.Size = new System.Drawing.Size(45, 22);
            this.labelCartLabel.TabIndex = 15;
            this.labelCartLabel.Text = "Cart";
            // 
            // buttonSubmitRequest
            // 
            this.buttonSubmitRequest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonSubmitRequest.Location = new System.Drawing.Point(749, 317);
            this.buttonSubmitRequest.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSubmitRequest.Name = "buttonSubmitRequest";
            this.buttonSubmitRequest.Size = new System.Drawing.Size(114, 28);
            this.buttonSubmitRequest.TabIndex = 16;
            this.buttonSubmitRequest.Text = "Submit Request";
            this.buttonSubmitRequest.UseVisualStyleBackColor = false;
            this.buttonSubmitRequest.Click += new System.EventHandler(this.buttonSubmitRequest_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 440);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 22);
            this.label3.TabIndex = 17;
            this.label3.Text = "Qty";
            // 
            // FormCli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = global::ProvisionwareClient.Properties.Resources.Backgroung_Dark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(891, 519);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonSubmitRequest);
            this.Controls.Add(this.labelCartLabel);
            this.Controls.Add(this.labelCatalogLabel);
            this.Controls.Add(this.textBoxItemDescription);
            this.Controls.Add(this.pictureBoxItemPhoto);
            this.Controls.Add(this.textBoxQuantityInput);
            this.Controls.Add(this.buttonAddToCart);
            this.Controls.Add(this.listBoxCartViewer);
            this.Controls.Add(this.listBoxCatalogViewer);
            this.Controls.Add(this.requestCatalog);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.logtxtbx);
            this.Controls.Add(this.porttxtbx);
            this.Controls.Add(this.iptxtbx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormCli";
            this.Text = "Provisionware-Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxItemPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox iptxtbx;
        private System.Windows.Forms.TextBox porttxtbx;
        private System.Windows.Forms.TextBox logtxtbx;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button requestCatalog;
        private System.Windows.Forms.ListBox listBoxCatalogViewer;
        private System.Windows.Forms.ListBox listBoxCartViewer;
        private System.Windows.Forms.Button buttonAddToCart;
        private System.Windows.Forms.TextBox textBoxQuantityInput;
        private System.Windows.Forms.PictureBox pictureBoxItemPhoto;
        private System.Windows.Forms.TextBox textBoxItemDescription;
        private System.Windows.Forms.Label labelCatalogLabel;
        private System.Windows.Forms.Label labelCartLabel;
        private System.Windows.Forms.Button buttonSubmitRequest;
        private System.Windows.Forms.Label label3;
    }
}

