namespace CashRegister
{
    partial class pubMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pubMain));
            this.foodLabel1 = new System.Windows.Forms.Label();
            this.foodLabel2 = new System.Windows.Forms.Label();
            this.foodLabel3 = new System.Windows.Forms.Label();
            this.steakNumInput = new System.Windows.Forms.TextBox();
            this.rumHamNumInput = new System.Windows.Forms.TextBox();
            this.fightMilkNumInput = new System.Windows.Forms.TextBox();
            this.totalButton = new System.Windows.Forms.Button();
            this.subTotalLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.tenderedLabel = new System.Windows.Forms.Label();
            this.tenderInput = new System.Windows.Forms.TextBox();
            this.changeButton = new System.Windows.Forms.Button();
            this.changeLabel = new System.Windows.Forms.Label();
            this.receiptButton = new System.Windows.Forms.Button();
            this.stPriceOutput = new System.Windows.Forms.Label();
            this.taPriceOutput = new System.Windows.Forms.Label();
            this.toPriceOutput = new System.Windows.Forms.Label();
            this.newOrder = new System.Windows.Forms.Button();
            this.changeOutput = new System.Windows.Forms.Label();
            this.lineLabel = new System.Windows.Forms.Label();
            this.paddysSign = new System.Windows.Forms.PictureBox();
            this.receiptLabel = new System.Windows.Forms.Label();
            this.menuPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.paddysSign)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // foodLabel1
            // 
            this.foodLabel1.AutoSize = true;
            this.foodLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodLabel1.Location = new System.Drawing.Point(59, 244);
            this.foodLabel1.Name = "foodLabel1";
            this.foodLabel1.Size = new System.Drawing.Size(206, 25);
            this.foodLabel1.TabIndex = 0;
            this.foodLabel1.Text = "Servings of Milk Steak";
            // 
            // foodLabel2
            // 
            this.foodLabel2.AutoSize = true;
            this.foodLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodLabel2.Location = new System.Drawing.Point(58, 290);
            this.foodLabel2.Name = "foodLabel2";
            this.foodLabel2.Size = new System.Drawing.Size(177, 25);
            this.foodLabel2.TabIndex = 2;
            this.foodLabel2.Text = "Slices of Rum Ham";
            // 
            // foodLabel3
            // 
            this.foodLabel3.AutoSize = true;
            this.foodLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodLabel3.Location = new System.Drawing.Point(58, 331);
            this.foodLabel3.Name = "foodLabel3";
            this.foodLabel3.Size = new System.Drawing.Size(168, 25);
            this.foodLabel3.TabIndex = 3;
            this.foodLabel3.Text = "Cups of Fight Milk";
            // 
            // steakNumInput
            // 
            this.steakNumInput.Location = new System.Drawing.Point(288, 246);
            this.steakNumInput.Name = "steakNumInput";
            this.steakNumInput.Size = new System.Drawing.Size(120, 26);
            this.steakNumInput.TabIndex = 4;
            // 
            // rumHamNumInput
            // 
            this.rumHamNumInput.Location = new System.Drawing.Point(288, 291);
            this.rumHamNumInput.Name = "rumHamNumInput";
            this.rumHamNumInput.Size = new System.Drawing.Size(120, 26);
            this.rumHamNumInput.TabIndex = 5;
            // 
            // fightMilkNumInput
            // 
            this.fightMilkNumInput.Location = new System.Drawing.Point(288, 333);
            this.fightMilkNumInput.Name = "fightMilkNumInput";
            this.fightMilkNumInput.Size = new System.Drawing.Size(120, 26);
            this.fightMilkNumInput.TabIndex = 6;
            // 
            // totalButton
            // 
            this.totalButton.BackColor = System.Drawing.Color.Transparent;
            this.totalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalButton.Location = new System.Drawing.Point(63, 391);
            this.totalButton.Name = "totalButton";
            this.totalButton.Size = new System.Drawing.Size(345, 49);
            this.totalButton.TabIndex = 7;
            this.totalButton.Text = "Calculate Total";
            this.totalButton.UseVisualStyleBackColor = false;
            this.totalButton.Click += new System.EventHandler(this.totalButton_Click);
            // 
            // subTotalLabel
            // 
            this.subTotalLabel.AutoSize = true;
            this.subTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTotalLabel.Location = new System.Drawing.Point(59, 474);
            this.subTotalLabel.Name = "subTotalLabel";
            this.subTotalLabel.Size = new System.Drawing.Size(84, 25);
            this.subTotalLabel.TabIndex = 8;
            this.subTotalLabel.Text = "Subtotal";
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxLabel.Location = new System.Drawing.Point(59, 515);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(46, 25);
            this.taxLabel.TabIndex = 9;
            this.taxLabel.Text = "Tax";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(59, 556);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(56, 25);
            this.totalLabel.TabIndex = 10;
            this.totalLabel.Text = "Total";
            // 
            // tenderedLabel
            // 
            this.tenderedLabel.AutoSize = true;
            this.tenderedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenderedLabel.Location = new System.Drawing.Point(59, 643);
            this.tenderedLabel.Name = "tenderedLabel";
            this.tenderedLabel.Size = new System.Drawing.Size(97, 25);
            this.tenderedLabel.TabIndex = 11;
            this.tenderedLabel.Text = "Tendered";
            // 
            // tenderInput
            // 
            this.tenderInput.Location = new System.Drawing.Point(288, 642);
            this.tenderInput.Name = "tenderInput";
            this.tenderInput.Size = new System.Drawing.Size(120, 26);
            this.tenderInput.TabIndex = 12;
            // 
            // changeButton
            // 
            this.changeButton.BackColor = System.Drawing.Color.Transparent;
            this.changeButton.Enabled = false;
            this.changeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeButton.Location = new System.Drawing.Point(63, 698);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(345, 41);
            this.changeButton.TabIndex = 13;
            this.changeButton.Text = "Calculate Change";
            this.changeButton.UseVisualStyleBackColor = false;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // changeLabel
            // 
            this.changeLabel.AutoSize = true;
            this.changeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeLabel.Location = new System.Drawing.Point(59, 762);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(82, 25);
            this.changeLabel.TabIndex = 14;
            this.changeLabel.Text = "Change";
            // 
            // receiptButton
            // 
            this.receiptButton.BackColor = System.Drawing.Color.Transparent;
            this.receiptButton.Enabled = false;
            this.receiptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptButton.Location = new System.Drawing.Point(63, 806);
            this.receiptButton.Name = "receiptButton";
            this.receiptButton.Size = new System.Drawing.Size(345, 41);
            this.receiptButton.TabIndex = 15;
            this.receiptButton.Text = "Print Receipt";
            this.receiptButton.UseVisualStyleBackColor = false;
            this.receiptButton.Click += new System.EventHandler(this.receiptButton_Click);
            // 
            // stPriceOutput
            // 
            this.stPriceOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stPriceOutput.Location = new System.Drawing.Point(288, 474);
            this.stPriceOutput.Name = "stPriceOutput";
            this.stPriceOutput.Size = new System.Drawing.Size(120, 25);
            this.stPriceOutput.TabIndex = 16;
            // 
            // taPriceOutput
            // 
            this.taPriceOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taPriceOutput.Location = new System.Drawing.Point(288, 515);
            this.taPriceOutput.Name = "taPriceOutput";
            this.taPriceOutput.Size = new System.Drawing.Size(120, 25);
            this.taPriceOutput.TabIndex = 17;
            // 
            // toPriceOutput
            // 
            this.toPriceOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toPriceOutput.Location = new System.Drawing.Point(288, 556);
            this.toPriceOutput.Name = "toPriceOutput";
            this.toPriceOutput.Size = new System.Drawing.Size(120, 25);
            this.toPriceOutput.TabIndex = 18;
            // 
            // newOrder
            // 
            this.newOrder.BackColor = System.Drawing.Color.Transparent;
            this.newOrder.BackgroundImage = global::CashRegister.Properties.Resources.paddyssign3;
            this.newOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newOrder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.newOrder.Location = new System.Drawing.Point(737, 793);
            this.newOrder.Name = "newOrder";
            this.newOrder.Size = new System.Drawing.Size(335, 41);
            this.newOrder.TabIndex = 19;
            this.newOrder.Text = "New Order";
            this.newOrder.UseVisualStyleBackColor = false;
            this.newOrder.Click += new System.EventHandler(this.newOrder_Click);
            // 
            // changeOutput
            // 
            this.changeOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeOutput.Location = new System.Drawing.Point(288, 762);
            this.changeOutput.Name = "changeOutput";
            this.changeOutput.Size = new System.Drawing.Size(120, 25);
            this.changeOutput.TabIndex = 21;
            // 
            // lineLabel
            // 
            this.lineLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lineLabel.Location = new System.Drawing.Point(59, 607);
            this.lineLabel.Name = "lineLabel";
            this.lineLabel.Size = new System.Drawing.Size(349, 10);
            this.lineLabel.TabIndex = 22;
            // 
            // paddysSign
            // 
            this.paddysSign.BackgroundImage = global::CashRegister.Properties.Resources.paddyssign3;
            this.paddysSign.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.paddysSign.Dock = System.Windows.Forms.DockStyle.Top;
            this.paddysSign.ImageLocation = "";
            this.paddysSign.Location = new System.Drawing.Point(0, 0);
            this.paddysSign.Name = "paddysSign";
            this.paddysSign.Size = new System.Drawing.Size(1122, 83);
            this.paddysSign.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.paddysSign.TabIndex = 23;
            this.paddysSign.TabStop = false;
            // 
            // receiptLabel
            // 
            this.receiptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptLabel.Image = global::CashRegister.Properties.Resources.paper;
            this.receiptLabel.Location = new System.Drawing.Point(737, 146);
            this.receiptLabel.Name = "receiptLabel";
            this.receiptLabel.Size = new System.Drawing.Size(335, 628);
            this.receiptLabel.TabIndex = 1;
            this.receiptLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // menuPicture
            // 
            this.menuPicture.Image = global::CashRegister.Properties.Resources.menu;
            this.menuPicture.Location = new System.Drawing.Point(28, 146);
            this.menuPicture.Name = "menuPicture";
            this.menuPicture.Size = new System.Drawing.Size(419, 722);
            this.menuPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.menuPicture.TabIndex = 20;
            this.menuPicture.TabStop = false;
            // 
            // pubMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CashRegister.Properties.Resources.paddy3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1122, 882);
            this.Controls.Add(this.paddysSign);
            this.Controls.Add(this.lineLabel);
            this.Controls.Add(this.changeOutput);
            this.Controls.Add(this.newOrder);
            this.Controls.Add(this.toPriceOutput);
            this.Controls.Add(this.taPriceOutput);
            this.Controls.Add(this.stPriceOutput);
            this.Controls.Add(this.receiptButton);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.tenderInput);
            this.Controls.Add(this.tenderedLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.subTotalLabel);
            this.Controls.Add(this.totalButton);
            this.Controls.Add(this.fightMilkNumInput);
            this.Controls.Add(this.rumHamNumInput);
            this.Controls.Add(this.steakNumInput);
            this.Controls.Add(this.foodLabel3);
            this.Controls.Add(this.foodLabel2);
            this.Controls.Add(this.receiptLabel);
            this.Controls.Add(this.foodLabel1);
            this.Controls.Add(this.menuPicture);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "pubMain";
            this.Text = "Paddy\'s Pub";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.paddysSign)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label foodLabel1;
        private System.Windows.Forms.Label receiptLabel;
        private System.Windows.Forms.Label foodLabel2;
        private System.Windows.Forms.Label foodLabel3;
        private System.Windows.Forms.TextBox steakNumInput;
        private System.Windows.Forms.TextBox rumHamNumInput;
        private System.Windows.Forms.TextBox fightMilkNumInput;
        private System.Windows.Forms.Button totalButton;
        private System.Windows.Forms.Label subTotalLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label tenderedLabel;
        private System.Windows.Forms.TextBox tenderInput;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.Button receiptButton;
        private System.Windows.Forms.Label stPriceOutput;
        private System.Windows.Forms.Label taPriceOutput;
        private System.Windows.Forms.Label toPriceOutput;
        private System.Windows.Forms.Button newOrder;
        private System.Windows.Forms.PictureBox menuPicture;
        private System.Windows.Forms.Label changeOutput;
        private System.Windows.Forms.Label lineLabel;
        private System.Windows.Forms.PictureBox paddysSign;
    }
}

