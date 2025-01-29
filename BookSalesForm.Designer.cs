namespace BookSales
{
    partial class BookSalesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookSalesForm));
            this.discountedPriceLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.clearSaleButton = new System.Windows.Forms.Button();
            this.calculateButton = new System.Windows.Forms.Button();
            this.printFormButton = new System.Windows.Forms.Button();
            this.discountedPriceTextBox = new System.Windows.Forms.TextBox();
            this.saleGroupBox = new System.Windows.Forms.GroupBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.invoiceGroupBox = new System.Windows.Forms.GroupBox();
            this.discountTextBox = new System.Windows.Forms.TextBox();
            this.discountLabel = new System.Windows.Forms.Label();
            this.extendedPriceTextBox = new System.Windows.Forms.TextBox();
            this.extendedPriceLabel = new System.Windows.Forms.Label();
            this.bookSalesLabel = new System.Windows.Forms.Label();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.timeDayLabel = new System.Windows.Forms.Label();
            this.summaryButton = new System.Windows.Forms.Button();
            this.saleGroupBox.SuspendLayout();
            this.invoiceGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // discountedPriceLabel
            // 
            this.discountedPriceLabel.AutoSize = true;
            this.discountedPriceLabel.Location = new System.Drawing.Point(10, 102);
            this.discountedPriceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.discountedPriceLabel.Name = "discountedPriceLabel";
            this.discountedPriceLabel.Size = new System.Drawing.Size(106, 16);
            this.discountedPriceLabel.TabIndex = 4;
            this.discountedPriceLabel.Text = "Prix avec rabais:";
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(416, 365);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(128, 43);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "&Quitter";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // clearSaleButton
            // 
            this.clearSaleButton.Location = new System.Drawing.Point(282, 365);
            this.clearSaleButton.Margin = new System.Windows.Forms.Padding(4);
            this.clearSaleButton.Name = "clearSaleButton";
            this.clearSaleButton.Size = new System.Drawing.Size(128, 43);
            this.clearSaleButton.TabIndex = 5;
            this.clearSaleButton.Text = "&Réinitialiser";
            this.clearSaleButton.UseVisualStyleBackColor = true;
            this.clearSaleButton.Click += new System.EventHandler(this.clearSaleButton_Click);
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(150, 365);
            this.calculateButton.Margin = new System.Windows.Forms.Padding(4);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(128, 43);
            this.calculateButton.TabIndex = 4;
            this.calculateButton.Text = "&Calculer";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // printFormButton
            // 
            this.printFormButton.Location = new System.Drawing.Point(16, 365);
            this.printFormButton.Margin = new System.Windows.Forms.Padding(4);
            this.printFormButton.Name = "printFormButton";
            this.printFormButton.Size = new System.Drawing.Size(128, 43);
            this.printFormButton.TabIndex = 3;
            this.printFormButton.Text = "&Imprimer";
            this.printFormButton.UseVisualStyleBackColor = true;
            this.printFormButton.Click += new System.EventHandler(this.printFormButton_Click);
            // 
            // discountedPriceTextBox
            // 
            this.discountedPriceTextBox.Location = new System.Drawing.Point(146, 99);
            this.discountedPriceTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.discountedPriceTextBox.Name = "discountedPriceTextBox";
            this.discountedPriceTextBox.ReadOnly = true;
            this.discountedPriceTextBox.Size = new System.Drawing.Size(372, 22);
            this.discountedPriceTextBox.TabIndex = 5;
            this.discountedPriceTextBox.TabStop = false;
            this.discountedPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // saleGroupBox
            // 
            this.saleGroupBox.Controls.Add(this.priceTextBox);
            this.saleGroupBox.Controls.Add(this.priceLabel);
            this.saleGroupBox.Controls.Add(this.titleTextBox);
            this.saleGroupBox.Controls.Add(this.titleLabel);
            this.saleGroupBox.Controls.Add(this.quantityTextBox);
            this.saleGroupBox.Controls.Add(this.quantityLabel);
            this.saleGroupBox.Location = new System.Drawing.Point(16, 61);
            this.saleGroupBox.Margin = new System.Windows.Forms.Padding(6);
            this.saleGroupBox.Name = "saleGroupBox";
            this.saleGroupBox.Padding = new System.Windows.Forms.Padding(6);
            this.saleGroupBox.Size = new System.Drawing.Size(530, 147);
            this.saleGroupBox.TabIndex = 1;
            this.saleGroupBox.TabStop = false;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(146, 102);
            this.priceTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(98, 22);
            this.priceTextBox.TabIndex = 2;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(10, 102);
            this.priceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(32, 16);
            this.priceLabel.TabIndex = 4;
            this.priceLabel.Text = "Pr&ix:";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(146, 42);
            this.titleTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(374, 22);
            this.titleTextBox.TabIndex = 0;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(10, 42);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(37, 16);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "&Titre:";
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(146, 72);
            this.quantityTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(98, 22);
            this.quantityTextBox.TabIndex = 1;
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(10, 72);
            this.quantityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(59, 16);
            this.quantityLabel.TabIndex = 0;
            this.quantityLabel.Text = "&Quantité:";
            // 
            // invoiceGroupBox
            // 
            this.invoiceGroupBox.Controls.Add(this.discountedPriceTextBox);
            this.invoiceGroupBox.Controls.Add(this.discountedPriceLabel);
            this.invoiceGroupBox.Controls.Add(this.discountTextBox);
            this.invoiceGroupBox.Controls.Add(this.discountLabel);
            this.invoiceGroupBox.Controls.Add(this.extendedPriceTextBox);
            this.invoiceGroupBox.Controls.Add(this.extendedPriceLabel);
            this.invoiceGroupBox.Location = new System.Drawing.Point(16, 217);
            this.invoiceGroupBox.Margin = new System.Windows.Forms.Padding(6);
            this.invoiceGroupBox.Name = "invoiceGroupBox";
            this.invoiceGroupBox.Padding = new System.Windows.Forms.Padding(6);
            this.invoiceGroupBox.Size = new System.Drawing.Size(530, 138);
            this.invoiceGroupBox.TabIndex = 2;
            this.invoiceGroupBox.TabStop = false;
            // 
            // discountTextBox
            // 
            this.discountTextBox.Location = new System.Drawing.Point(146, 63);
            this.discountTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.discountTextBox.Name = "discountTextBox";
            this.discountTextBox.ReadOnly = true;
            this.discountTextBox.Size = new System.Drawing.Size(372, 22);
            this.discountTextBox.TabIndex = 3;
            this.discountTextBox.TabStop = false;
            this.discountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // discountLabel
            // 
            this.discountLabel.AutoSize = true;
            this.discountLabel.Location = new System.Drawing.Point(10, 67);
            this.discountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.discountLabel.Name = "discountLabel";
            this.discountLabel.Size = new System.Drawing.Size(83, 16);
            this.discountLabel.TabIndex = 2;
            this.discountLabel.Text = "Rabais 15%:";
            // 
            // extendedPriceTextBox
            // 
            this.extendedPriceTextBox.Location = new System.Drawing.Point(146, 28);
            this.extendedPriceTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.extendedPriceTextBox.Name = "extendedPriceTextBox";
            this.extendedPriceTextBox.ReadOnly = true;
            this.extendedPriceTextBox.Size = new System.Drawing.Size(372, 22);
            this.extendedPriceTextBox.TabIndex = 1;
            this.extendedPriceTextBox.TabStop = false;
            this.extendedPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // extendedPriceLabel
            // 
            this.extendedPriceLabel.AutoSize = true;
            this.extendedPriceLabel.Location = new System.Drawing.Point(10, 31);
            this.extendedPriceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.extendedPriceLabel.Name = "extendedPriceLabel";
            this.extendedPriceLabel.Size = new System.Drawing.Size(76, 16);
            this.extendedPriceLabel.TabIndex = 0;
            this.extendedPriceLabel.Text = "Prix étendu:";
            // 
            // bookSalesLabel
            // 
            this.bookSalesLabel.AutoSize = true;
            this.bookSalesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookSalesLabel.Location = new System.Drawing.Point(144, 0);
            this.bookSalesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bookSalesLabel.Name = "bookSalesLabel";
            this.bookSalesLabel.Size = new System.Drawing.Size(227, 36);
            this.bookSalesLabel.TabIndex = 0;
            this.bookSalesLabel.Text = "Vente de livres";
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // timeDayLabel
            // 
            this.timeDayLabel.AutoSize = true;
            this.timeDayLabel.Location = new System.Drawing.Point(159, 47);
            this.timeDayLabel.Name = "timeDayLabel";
            this.timeDayLabel.Size = new System.Drawing.Size(0, 16);
            this.timeDayLabel.TabIndex = 7;
            // 
            // summaryButton
            // 
            this.summaryButton.Location = new System.Drawing.Point(16, 415);
            this.summaryButton.Name = "summaryButton";
            this.summaryButton.Size = new System.Drawing.Size(262, 39);
            this.summaryButton.TabIndex = 8;
            this.summaryButton.Text = "&Sommaire de ventes";
            this.summaryButton.UseVisualStyleBackColor = true;
            this.summaryButton.Click += new System.EventHandler(this.summaryButton_Click);
            // 
            // BookSalesForm
            // 
            this.AcceptButton = this.calculateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(554, 456);
            this.Controls.Add(this.summaryButton);
            this.Controls.Add(this.timeDayLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearSaleButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.printFormButton);
            this.Controls.Add(this.saleGroupBox);
            this.Controls.Add(this.invoiceGroupBox);
            this.Controls.Add(this.bookSalesLabel);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "BookSalesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Divertissement en lecture";
            this.Load += new System.EventHandler(this.BookSalesForm_Load);
            this.saleGroupBox.ResumeLayout(false);
            this.saleGroupBox.PerformLayout();
            this.invoiceGroupBox.ResumeLayout(false);
            this.invoiceGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label discountedPriceLabel;
        internal System.Windows.Forms.Button exitButton;
        internal System.Windows.Forms.Button clearSaleButton;
        internal System.Windows.Forms.Button calculateButton;
        internal System.Windows.Forms.Button printFormButton;
        internal System.Windows.Forms.TextBox discountedPriceTextBox;
        internal System.Windows.Forms.GroupBox saleGroupBox;
        internal System.Windows.Forms.TextBox priceTextBox;
        internal System.Windows.Forms.Label priceLabel;
        internal System.Windows.Forms.TextBox titleTextBox;
        internal System.Windows.Forms.Label titleLabel;
        internal System.Windows.Forms.TextBox quantityTextBox;
        internal System.Windows.Forms.Label quantityLabel;
        internal System.Windows.Forms.GroupBox invoiceGroupBox;
        internal System.Windows.Forms.TextBox discountTextBox;
        internal System.Windows.Forms.Label discountLabel;
        internal System.Windows.Forms.TextBox extendedPriceTextBox;
        internal System.Windows.Forms.Label extendedPriceLabel;
        internal System.Windows.Forms.Label bookSalesLabel;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Label timeDayLabel;
        private System.Windows.Forms.Button summaryButton;
    }
}

