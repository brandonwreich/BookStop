namespace _BookStop
{
    partial class MainPage
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
            this.enterButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.viewReportButton = new System.Windows.Forms.Button();
            this.inputTextbox = new System.Windows.Forms.TextBox();
            this.ourPriceTextbox = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.vendorLabel = new System.Windows.Forms.Label();
            this.isbnLabel = new System.Windows.Forms.Label();
            this.ourPriceLabel = new System.Windows.Forms.Label();
            this.buybackOfferLabel = new System.Windows.Forms.Label();
            this.titleTextbox = new System.Windows.Forms.Label();
            this.vendorTextbox = new System.Windows.Forms.Label();
            this.buybackOfferTextbox = new System.Windows.Forms.Label();
            this.isbnTextbox = new System.Windows.Forms.Label();
            this.notesTextbox = new System.Windows.Forms.TextBox();
            this.notesLabel = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.downloadButton = new System.Windows.Forms.Button();
            this.printButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // enterButton
            // 
            this.enterButton.AccessibleName = "enterButton";
            this.enterButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.enterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterButton.Location = new System.Drawing.Point(879, 495);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(100, 32);
            this.enterButton.TabIndex = 0;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.EnterButton_ClickAsync);
            // 
            // exitButton
            // 
            this.exitButton.AccessibleDescription = "Closes the program";
            this.exitButton.AccessibleName = "Exit Button";
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(879, 430);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(100, 32);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(879, 392);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(100, 32);
            this.clearButton.TabIndex = 2;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(879, 354);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(100, 32);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // viewReportButton
            // 
            this.viewReportButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.viewReportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewReportButton.Location = new System.Drawing.Point(879, 316);
            this.viewReportButton.Name = "viewReportButton";
            this.viewReportButton.Size = new System.Drawing.Size(100, 32);
            this.viewReportButton.TabIndex = 4;
            this.viewReportButton.Text = "View Report";
            this.viewReportButton.UseVisualStyleBackColor = true;
            this.viewReportButton.Click += new System.EventHandler(this.ViewReportButton_Click);
            // 
            // inputTextbox
            // 
            this.inputTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputTextbox.BackColor = System.Drawing.SystemColors.Window;
            this.inputTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputTextbox.Location = new System.Drawing.Point(35, 495);
            this.inputTextbox.MinimumSize = new System.Drawing.Size(638, 32);
            this.inputTextbox.Name = "inputTextbox";
            this.inputTextbox.Size = new System.Drawing.Size(838, 32);
            this.inputTextbox.TabIndex = 5;
            this.inputTextbox.TextChanged += new System.EventHandler(this.InputTextbox_TextChanged);
            // 
            // ourPriceTextbox
            // 
            this.ourPriceTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ourPriceTextbox.BackColor = System.Drawing.SystemColors.Window;
            this.ourPriceTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ourPriceTextbox.Location = new System.Drawing.Point(840, 25);
            this.ourPriceTextbox.MinimumSize = new System.Drawing.Size(148, 32);
            this.ourPriceTextbox.Name = "ourPriceTextbox";
            this.ourPriceTextbox.Size = new System.Drawing.Size(148, 32);
            this.ourPriceTextbox.TabIndex = 6;
            this.ourPriceTextbox.TextChanged += new System.EventHandler(this.OurPriceTextbox_TextChanged);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.titleLabel.Location = new System.Drawing.Point(49, 26);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(74, 31);
            this.titleLabel.TabIndex = 7;
            this.titleLabel.Text = "Title:";
            // 
            // vendorLabel
            // 
            this.vendorLabel.AutoSize = true;
            this.vendorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.vendorLabel.Location = new System.Drawing.Point(12, 62);
            this.vendorLabel.Name = "vendorLabel";
            this.vendorLabel.Size = new System.Drawing.Size(109, 31);
            this.vendorLabel.TabIndex = 8;
            this.vendorLabel.Text = "Vendor:";
            // 
            // isbnLabel
            // 
            this.isbnLabel.AutoSize = true;
            this.isbnLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.isbnLabel.Location = new System.Drawing.Point(37, 106);
            this.isbnLabel.Name = "isbnLabel";
            this.isbnLabel.Size = new System.Drawing.Size(86, 31);
            this.isbnLabel.TabIndex = 9;
            this.isbnLabel.Text = "ISBN:";
            // 
            // ourPriceLabel
            // 
            this.ourPriceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ourPriceLabel.AutoSize = true;
            this.ourPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.ourPriceLabel.Location = new System.Drawing.Point(679, 26);
            this.ourPriceLabel.Name = "ourPriceLabel";
            this.ourPriceLabel.Size = new System.Drawing.Size(155, 31);
            this.ourPriceLabel.TabIndex = 10;
            this.ourPriceLabel.Text = "Our price: $";
            // 
            // buybackOfferLabel
            // 
            this.buybackOfferLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buybackOfferLabel.AutoSize = true;
            this.buybackOfferLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.buybackOfferLabel.Location = new System.Drawing.Point(617, 66);
            this.buybackOfferLabel.Name = "buybackOfferLabel";
            this.buybackOfferLabel.Size = new System.Drawing.Size(217, 31);
            this.buybackOfferLabel.TabIndex = 11;
            this.buybackOfferLabel.Text = "Buyback Offer: $";
            // 
            // titleTextbox
            // 
            this.titleTextbox.AutoSize = true;
            this.titleTextbox.BackColor = System.Drawing.SystemColors.Window;
            this.titleTextbox.Cursor = System.Windows.Forms.Cursors.No;
            this.titleTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleTextbox.Location = new System.Drawing.Point(127, 25);
            this.titleTextbox.MaximumSize = new System.Drawing.Size(480, 32);
            this.titleTextbox.MinimumSize = new System.Drawing.Size(480, 32);
            this.titleTextbox.Name = "titleTextbox";
            this.titleTextbox.Size = new System.Drawing.Size(480, 32);
            this.titleTextbox.TabIndex = 12;
            // 
            // vendorTextbox
            // 
            this.vendorTextbox.AutoSize = true;
            this.vendorTextbox.BackColor = System.Drawing.SystemColors.Window;
            this.vendorTextbox.Cursor = System.Windows.Forms.Cursors.No;
            this.vendorTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.vendorTextbox.Location = new System.Drawing.Point(127, 65);
            this.vendorTextbox.MaximumSize = new System.Drawing.Size(480, 32);
            this.vendorTextbox.MinimumSize = new System.Drawing.Size(480, 32);
            this.vendorTextbox.Name = "vendorTextbox";
            this.vendorTextbox.Size = new System.Drawing.Size(480, 32);
            this.vendorTextbox.TabIndex = 13;
            // 
            // buybackOfferTextbox
            // 
            this.buybackOfferTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buybackOfferTextbox.AutoSize = true;
            this.buybackOfferTextbox.BackColor = System.Drawing.SystemColors.Window;
            this.buybackOfferTextbox.Cursor = System.Windows.Forms.Cursors.No;
            this.buybackOfferTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.buybackOfferTextbox.Location = new System.Drawing.Point(840, 65);
            this.buybackOfferTextbox.MinimumSize = new System.Drawing.Size(148, 32);
            this.buybackOfferTextbox.Name = "buybackOfferTextbox";
            this.buybackOfferTextbox.Size = new System.Drawing.Size(148, 32);
            this.buybackOfferTextbox.TabIndex = 14;
            // 
            // isbnTextbox
            // 
            this.isbnTextbox.AutoSize = true;
            this.isbnTextbox.BackColor = System.Drawing.SystemColors.Window;
            this.isbnTextbox.Cursor = System.Windows.Forms.Cursors.No;
            this.isbnTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.isbnTextbox.Location = new System.Drawing.Point(127, 106);
            this.isbnTextbox.MaximumSize = new System.Drawing.Size(480, 32);
            this.isbnTextbox.MinimumSize = new System.Drawing.Size(480, 32);
            this.isbnTextbox.Name = "isbnTextbox";
            this.isbnTextbox.Size = new System.Drawing.Size(480, 32);
            this.isbnTextbox.TabIndex = 16;
            // 
            // notesTextbox
            // 
            this.notesTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.notesTextbox.BackColor = System.Drawing.SystemColors.Window;
            this.notesTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.notesTextbox.Location = new System.Drawing.Point(35, 316);
            this.notesTextbox.MinimumSize = new System.Drawing.Size(638, 144);
            this.notesTextbox.Multiline = true;
            this.notesTextbox.Name = "notesTextbox";
            this.notesTextbox.Size = new System.Drawing.Size(838, 144);
            this.notesTextbox.TabIndex = 18;
            // 
            // notesLabel
            // 
            this.notesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.notesLabel.AutoSize = true;
            this.notesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.notesLabel.Location = new System.Drawing.Point(27, 282);
            this.notesLabel.Name = "notesLabel";
            this.notesLabel.Size = new System.Drawing.Size(94, 31);
            this.notesLabel.TabIndex = 19;
            this.notesLabel.Text = "Notes:";
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.deleteButton.Location = new System.Drawing.Point(879, 222);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(100, 32);
            this.deleteButton.TabIndex = 20;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // downloadButton
            // 
            this.downloadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.downloadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.downloadButton.Location = new System.Drawing.Point(879, 184);
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.Size = new System.Drawing.Size(100, 32);
            this.downloadButton.TabIndex = 22;
            this.downloadButton.Text = "Download";
            this.downloadButton.UseVisualStyleBackColor = true;
            this.downloadButton.Click += new System.EventHandler(this.DownloadButton_Click);
            // 
            // printButton
            // 
            this.printButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.printButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.printButton.Location = new System.Drawing.Point(879, 146);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(100, 32);
            this.printButton.TabIndex = 23;
            this.printButton.Text = "Print";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.downloadButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.notesLabel);
            this.Controls.Add(this.notesTextbox);
            this.Controls.Add(this.isbnTextbox);
            this.Controls.Add(this.buybackOfferTextbox);
            this.Controls.Add(this.vendorTextbox);
            this.Controls.Add(this.titleTextbox);
            this.Controls.Add(this.buybackOfferLabel);
            this.Controls.Add(this.ourPriceLabel);
            this.Controls.Add(this.isbnLabel);
            this.Controls.Add(this.vendorLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.ourPriceTextbox);
            this.Controls.Add(this.inputTextbox);
            this.Controls.Add(this.viewReportButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.enterButton);
            this.MaximumSize = new System.Drawing.Size(1016, 589);
            this.MinimumSize = new System.Drawing.Size(1016, 589);
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookStop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button viewReportButton;
        private System.Windows.Forms.TextBox inputTextbox;
        private System.Windows.Forms.TextBox ourPriceTextbox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label vendorLabel;
        private System.Windows.Forms.Label isbnLabel;
        private System.Windows.Forms.Label ourPriceLabel;
        private System.Windows.Forms.Label buybackOfferLabel;
        private System.Windows.Forms.Label titleTextbox;
        private System.Windows.Forms.Label vendorTextbox;
        private System.Windows.Forms.Label buybackOfferTextbox;
        private System.Windows.Forms.Label isbnTextbox;
        private System.Windows.Forms.TextBox notesTextbox;
        private System.Windows.Forms.Label notesLabel;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button downloadButton;
        private System.Windows.Forms.Button printButton;
    }
}