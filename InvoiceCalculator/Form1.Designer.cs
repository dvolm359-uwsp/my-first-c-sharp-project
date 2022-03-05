
namespace InvoiceCalculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.discountPercentText = new System.Windows.Forms.TextBox();
            this.discountPercentLabel = new System.Windows.Forms.Label();
            this.subtotalText = new System.Windows.Forms.TextBox();
            this.discountAmountLabel = new System.Windows.Forms.Label();
            this.discountAmountText = new System.Windows.Forms.TextBox();
            this.totalLabel = new System.Windows.Forms.Label();
            this.totalText = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.subtotalLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // discountPercentText
            // 
            this.discountPercentText.Location = new System.Drawing.Point(151, 68);
            this.discountPercentText.Name = "discountPercentText";
            this.discountPercentText.ReadOnly = true;
            this.discountPercentText.Size = new System.Drawing.Size(100, 23);
            this.discountPercentText.TabIndex = 10;
            this.discountPercentText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // discountPercentLabel
            // 
            this.discountPercentLabel.AutoSize = true;
            this.discountPercentLabel.Location = new System.Drawing.Point(24, 76);
            this.discountPercentLabel.Name = "discountPercentLabel";
            this.discountPercentLabel.Size = new System.Drawing.Size(100, 15);
            this.discountPercentLabel.TabIndex = 3;
            this.discountPercentLabel.Text = "Discount Percent:";
            this.discountPercentLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // subtotalText
            // 
            this.subtotalText.Location = new System.Drawing.Point(151, 37);
            this.subtotalText.Name = "subtotalText";
            this.subtotalText.Size = new System.Drawing.Size(100, 23);
            this.subtotalText.TabIndex = 1;
            this.subtotalText.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // discountAmountLabel
            // 
            this.discountAmountLabel.AutoSize = true;
            this.discountAmountLabel.Location = new System.Drawing.Point(24, 110);
            this.discountAmountLabel.Name = "discountAmountLabel";
            this.discountAmountLabel.Size = new System.Drawing.Size(104, 15);
            this.discountAmountLabel.TabIndex = 5;
            this.discountAmountLabel.Text = "Discount Amount:";
            this.discountAmountLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // discountAmountText
            // 
            this.discountAmountText.Location = new System.Drawing.Point(151, 107);
            this.discountAmountText.Name = "discountAmountText";
            this.discountAmountText.ReadOnly = true;
            this.discountAmountText.Size = new System.Drawing.Size(100, 23);
            this.discountAmountText.TabIndex = 4;
            this.discountAmountText.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(24, 156);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(35, 15);
            this.totalLabel.TabIndex = 7;
            this.totalLabel.Text = "Total:";
            this.totalLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // totalText
            // 
            this.totalText.Location = new System.Drawing.Point(151, 153);
            this.totalText.Name = "totalText";
            this.totalText.ReadOnly = true;
            this.totalText.Size = new System.Drawing.Size(100, 23);
            this.totalText.TabIndex = 6;
            this.totalText.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(106, 207);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 8;
            this.calculateButton.Text = "&Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(212, 207);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 9;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // subtotalLabel
            // 
            this.subtotalLabel.AutoSize = true;
            this.subtotalLabel.Location = new System.Drawing.Point(24, 40);
            this.subtotalLabel.Name = "subtotalLabel";
            this.subtotalLabel.Size = new System.Drawing.Size(54, 15);
            this.subtotalLabel.TabIndex = 0;
            this.subtotalLabel.Text = "&Subtotal:";
            this.subtotalLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 263);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.totalText);
            this.Controls.Add(this.discountAmountLabel);
            this.Controls.Add(this.discountAmountText);
            this.Controls.Add(this.discountPercentLabel);
            this.Controls.Add(this.subtotalText);
            this.Controls.Add(this.subtotalLabel);
            this.Controls.Add(this.discountPercentText);
            this.Name = "Form1";
            this.Text = "Invoice Total";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox discountPercentText;
        private System.Windows.Forms.Label discountPercentLabel;
        private System.Windows.Forms.TextBox subtotalText;
        private System.Windows.Forms.Label discountAmountLabel;
        private System.Windows.Forms.TextBox discountAmountText;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.TextBox totalText;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label subtotalLabel;
    }
}

