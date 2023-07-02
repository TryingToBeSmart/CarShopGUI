namespace CarShopGUI
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.createCarButton = new System.Windows.Forms.Button();
            this.mileageTextBox = new System.Windows.Forms.TextBox();
            this.engineSizeTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.makeTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.inventoryListBox = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cartListBox = new System.Windows.Forms.ListBox();
            this.addToCartButton = new System.Windows.Forms.Button();
            this.checkoutButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.totalCostLabel = new System.Windows.Forms.Label();
            this.clearCreateCarButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.clearCreateCarButton);
            this.groupBox1.Controls.Add(this.createCarButton);
            this.groupBox1.Controls.Add(this.mileageTextBox);
            this.groupBox1.Controls.Add(this.engineSizeTextBox);
            this.groupBox1.Controls.Add(this.priceTextBox);
            this.groupBox1.Controls.Add(this.modelTextBox);
            this.groupBox1.Controls.Add(this.makeTextBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(17, 17);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(8);
            this.groupBox1.Size = new System.Drawing.Size(572, 335);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create a Car:";
            // 
            // createCarButton
            // 
            this.createCarButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.createCarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createCarButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.createCarButton.FlatAppearance.BorderSize = 5;
            this.createCarButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.createCarButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.createCarButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.createCarButton.Location = new System.Drawing.Point(175, 262);
            this.createCarButton.Name = "createCarButton";
            this.createCarButton.Size = new System.Drawing.Size(182, 51);
            this.createCarButton.TabIndex = 10;
            this.createCarButton.Text = "Create Car";
            this.createCarButton.UseVisualStyleBackColor = false;
            this.createCarButton.Click += new System.EventHandler(this.createCarButton_Click);
            // 
            // mileageTextBox
            // 
            this.mileageTextBox.Location = new System.Drawing.Point(175, 208);
            this.mileageTextBox.Name = "mileageTextBox";
            this.mileageTextBox.Size = new System.Drawing.Size(386, 38);
            this.mileageTextBox.TabIndex = 9;
            // 
            // engineSizeTextBox
            // 
            this.engineSizeTextBox.Location = new System.Drawing.Point(175, 164);
            this.engineSizeTextBox.Name = "engineSizeTextBox";
            this.engineSizeTextBox.Size = new System.Drawing.Size(386, 38);
            this.engineSizeTextBox.TabIndex = 8;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(175, 120);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(386, 38);
            this.priceTextBox.TabIndex = 7;
            // 
            // modelTextBox
            // 
            this.modelTextBox.Location = new System.Drawing.Point(175, 76);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(386, 38);
            this.modelTextBox.TabIndex = 6;
            // 
            // makeTextBox
            // 
            this.makeTextBox.Location = new System.Drawing.Point(175, 32);
            this.makeTextBox.Name = "makeTextBox";
            this.makeTextBox.Size = new System.Drawing.Size(386, 38);
            this.makeTextBox.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 208);
            this.label5.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 31);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mileage";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 164);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 31);
            this.label4.TabIndex = 3;
            this.label4.Text = "Engine Size";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 120);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Model";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Make";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.inventoryListBox);
            this.groupBox2.Location = new System.Drawing.Point(594, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(505, 529);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Car Inventory";
            // 
            // inventoryListBox
            // 
            this.inventoryListBox.FormattingEnabled = true;
            this.inventoryListBox.HorizontalScrollbar = true;
            this.inventoryListBox.ItemHeight = 31;
            this.inventoryListBox.Location = new System.Drawing.Point(6, 37);
            this.inventoryListBox.Name = "inventoryListBox";
            this.inventoryListBox.Size = new System.Drawing.Size(493, 469);
            this.inventoryListBox.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cartListBox);
            this.groupBox3.Location = new System.Drawing.Point(1132, 17);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(505, 529);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cart";
            // 
            // cartListBox
            // 
            this.cartListBox.FormattingEnabled = true;
            this.cartListBox.HorizontalScrollbar = true;
            this.cartListBox.ItemHeight = 31;
            this.cartListBox.Location = new System.Drawing.Point(6, 37);
            this.cartListBox.Name = "cartListBox";
            this.cartListBox.Size = new System.Drawing.Size(493, 469);
            this.cartListBox.TabIndex = 0;
            // 
            // addToCartButton
            // 
            this.addToCartButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.addToCartButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addToCartButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.addToCartButton.FlatAppearance.BorderSize = 5;
            this.addToCartButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addToCartButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addToCartButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addToCartButton.Location = new System.Drawing.Point(600, 594);
            this.addToCartButton.Name = "addToCartButton";
            this.addToCartButton.Size = new System.Drawing.Size(192, 51);
            this.addToCartButton.TabIndex = 11;
            this.addToCartButton.Text = "Add to Cart";
            this.addToCartButton.UseVisualStyleBackColor = false;
            this.addToCartButton.Click += new System.EventHandler(this.addToCartButton_Click);
            // 
            // checkoutButton
            // 
            this.checkoutButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.checkoutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkoutButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.checkoutButton.FlatAppearance.BorderSize = 5;
            this.checkoutButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.checkoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkoutButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkoutButton.Location = new System.Drawing.Point(1138, 594);
            this.checkoutButton.Name = "checkoutButton";
            this.checkoutButton.Size = new System.Drawing.Size(192, 51);
            this.checkoutButton.TabIndex = 12;
            this.checkoutButton.Text = "Checkout";
            this.checkoutButton.UseVisualStyleBackColor = false;
            this.checkoutButton.Click += new System.EventHandler(this.checkoutButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1132, 675);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 31);
            this.label6.TabIndex = 13;
            this.label6.Text = "Total Cost:";
            // 
            // totalCostLabel
            // 
            this.totalCostLabel.AutoSize = true;
            this.totalCostLabel.Location = new System.Drawing.Point(1285, 675);
            this.totalCostLabel.Name = "totalCostLabel";
            this.totalCostLabel.Size = new System.Drawing.Size(0, 31);
            this.totalCostLabel.TabIndex = 14;
            // 
            // clearCreateCarButton
            // 
            this.clearCreateCarButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.clearCreateCarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearCreateCarButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.clearCreateCarButton.FlatAppearance.BorderSize = 5;
            this.clearCreateCarButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.clearCreateCarButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clearCreateCarButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.clearCreateCarButton.Location = new System.Drawing.Point(379, 262);
            this.clearCreateCarButton.Name = "clearCreateCarButton";
            this.clearCreateCarButton.Size = new System.Drawing.Size(182, 51);
            this.clearCreateCarButton.TabIndex = 11;
            this.clearCreateCarButton.Text = "Clear";
            this.clearCreateCarButton.UseVisualStyleBackColor = false;
            this.clearCreateCarButton.Click += new System.EventHandler(this.clearCreateCarButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1648, 783);
            this.Controls.Add(this.totalCostLabel);
            this.Controls.Add(this.addToCartButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.checkoutButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8);
            this.Name = "Form1";
            this.Text = "Car GUI";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button createCarButton;
        private System.Windows.Forms.TextBox mileageTextBox;
        private System.Windows.Forms.TextBox engineSizeTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.TextBox makeTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox inventoryListBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox cartListBox;
        private System.Windows.Forms.Button addToCartButton;
        private System.Windows.Forms.Button checkoutButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label totalCostLabel;
        private System.Windows.Forms.Button clearCreateCarButton;
    }
}
