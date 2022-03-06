/* ================================================
 * @author     David Volm aka VOLMINATOR aka daXXog
 * @date       Sun Mar  6 13:09:22 CST 2022
 * @school     UWSP
 * @class      CIS 340
 * @section    01
 * @assignment 04
 * @professor  Hardeep Kaur Dhalla
 * @licence    MIT
 * ===============================================*/

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
            this.components = new System.ComponentModel.Container();
            this.discountPercentText = new System.Windows.Forms.TextBox();
            this.subtotalLabel = new System.Windows.Forms.Label();
            this.discountPercentLabel = new System.Windows.Forms.Label();
            this.subtotalText = new System.Windows.Forms.TextBox();
            this.discountAmountLabel = new System.Windows.Forms.Label();
            this.discountAmountText = new System.Windows.Forms.TextBox();
            this.totalLabel = new System.Windows.Forms.Label();
            this.totalText = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.subtotalErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.subtotalErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // discountPercentText
            // 
            this.discountPercentText.Location = new System.Drawing.Point(129, 59);
            this.discountPercentText.Name = "discountPercentText";
            this.discountPercentText.ReadOnly = true;
            this.discountPercentText.Size = new System.Drawing.Size(86, 20);
            this.discountPercentText.TabIndex = 3;
            this.discountPercentText.TextChanged += new System.EventHandler(this.discountPercentText_TextChanged);
            // 
            // subtotalLabel
            // 
            this.subtotalLabel.AutoSize = true;
            this.subtotalLabel.Location = new System.Drawing.Point(21, 35);
            this.subtotalLabel.Name = "subtotalLabel";
            this.subtotalLabel.Size = new System.Drawing.Size(49, 13);
            this.subtotalLabel.TabIndex = 0;
            this.subtotalLabel.Text = "&Subtotal:";
            this.subtotalLabel.Click += new System.EventHandler(this.subtotalLabel_Click);
            // 
            // discountPercentLabel
            // 
            this.discountPercentLabel.AutoSize = true;
            this.discountPercentLabel.Location = new System.Drawing.Point(21, 66);
            this.discountPercentLabel.Name = "discountPercentLabel";
            this.discountPercentLabel.Size = new System.Drawing.Size(92, 13);
            this.discountPercentLabel.TabIndex = 2;
            this.discountPercentLabel.Text = "Discount Percent:";
            this.discountPercentLabel.Click += new System.EventHandler(this.discountPercentLabel_Click);
            // 
            // subtotalText
            // 
            this.subtotalText.Location = new System.Drawing.Point(129, 32);
            this.subtotalText.Name = "subtotalText";
            this.subtotalText.Size = new System.Drawing.Size(86, 20);
            this.subtotalText.TabIndex = 1;
            this.subtotalText.TextChanged += new System.EventHandler(this.subtotalText_TextChanged);
            // 
            // discountAmountLabel
            // 
            this.discountAmountLabel.AutoSize = true;
            this.discountAmountLabel.Location = new System.Drawing.Point(21, 95);
            this.discountAmountLabel.Name = "discountAmountLabel";
            this.discountAmountLabel.Size = new System.Drawing.Size(91, 13);
            this.discountAmountLabel.TabIndex = 4;
            this.discountAmountLabel.Text = "Discount Amount:";
            this.discountAmountLabel.Click += new System.EventHandler(this.discountAmountLabel_Click);
            // 
            // discountAmountText
            // 
            this.discountAmountText.Location = new System.Drawing.Point(129, 93);
            this.discountAmountText.Name = "discountAmountText";
            this.discountAmountText.ReadOnly = true;
            this.discountAmountText.Size = new System.Drawing.Size(86, 20);
            this.discountAmountText.TabIndex = 5;
            this.discountAmountText.TextChanged += new System.EventHandler(this.discountAmountText_TextChanged);
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(21, 135);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(34, 13);
            this.totalLabel.TabIndex = 6;
            this.totalLabel.Text = "Total:";
            this.totalLabel.Click += new System.EventHandler(this.totalLabel_Click);
            // 
            // totalText
            // 
            this.totalText.Location = new System.Drawing.Point(129, 133);
            this.totalText.Name = "totalText";
            this.totalText.ReadOnly = true;
            this.totalText.Size = new System.Drawing.Size(86, 20);
            this.totalText.TabIndex = 7;
            this.totalText.TextChanged += new System.EventHandler(this.totalText_TextChanged);
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(91, 179);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(64, 20);
            this.calculateButton.TabIndex = 8;
            this.calculateButton.Text = "&Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(182, 179);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(64, 20);
            this.exitButton.TabIndex = 9;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // subtotalErrorProvider
            // 
            this.subtotalErrorProvider.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 228);
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
            ((System.ComponentModel.ISupportInitialize)(this.subtotalErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox discountPercentText;
        private System.Windows.Forms.Label subtotalLabel;
        private System.Windows.Forms.Label discountPercentLabel;
        private System.Windows.Forms.TextBox subtotalText;
        private System.Windows.Forms.Label discountAmountLabel;
        private System.Windows.Forms.TextBox discountAmountText;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.TextBox totalText;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ErrorProvider subtotalErrorProvider;
    }
}

