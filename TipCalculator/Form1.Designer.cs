
namespace TipCalculator
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
            this.enterTotalBill = new System.Windows.Forms.Label();
            this.computeTip = new System.Windows.Forms.Button();
            this.enterTotalBillTextBox = new System.Windows.Forms.TextBox();
            this.computeTipTextBox = new System.Windows.Forms.TextBox();
            this.tipPercentage = new System.Windows.Forms.Label();
            this.TipPercentageTextBox = new System.Windows.Forms.TextBox();
            this.total = new System.Windows.Forms.Label();
            this.TotalTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // enterTotalBill
            // 
            this.enterTotalBill.AutoSize = true;
            this.enterTotalBill.Location = new System.Drawing.Point(282, 140);
            this.enterTotalBill.Name = "enterTotalBill";
            this.enterTotalBill.Size = new System.Drawing.Size(100, 17);
            this.enterTotalBill.TabIndex = 0;
            this.enterTotalBill.Text = "Enter Total Bill";
            // 
            // computeTip
            // 
            this.computeTip.Location = new System.Drawing.Point(270, 225);
            this.computeTip.Name = "computeTip";
            this.computeTip.Size = new System.Drawing.Size(142, 58);
            this.computeTip.TabIndex = 1;
            this.computeTip.Text = "Compute Tip";
            this.computeTip.UseVisualStyleBackColor = true;
            this.computeTip.Click += new System.EventHandler(this.computeTip_Click);
            // 
            // enterTotalBillTextBox
            // 
            this.enterTotalBillTextBox.Location = new System.Drawing.Point(433, 140);
            this.enterTotalBillTextBox.Name = "enterTotalBillTextBox";
            this.enterTotalBillTextBox.Size = new System.Drawing.Size(100, 22);
            this.enterTotalBillTextBox.TabIndex = 2;
            this.enterTotalBillTextBox.TextChanged += new System.EventHandler(this.enterTotalBillTextBox_TextChanged);
            // 
            // computeTipTextBox
            // 
            this.computeTipTextBox.Location = new System.Drawing.Point(433, 225);
            this.computeTipTextBox.Name = "computeTipTextBox";
            this.computeTipTextBox.Size = new System.Drawing.Size(100, 22);
            this.computeTipTextBox.TabIndex = 3;
            // 
            // tipPercentage
            // 
            this.tipPercentage.AutoSize = true;
            this.tipPercentage.Location = new System.Drawing.Point(285, 183);
            this.tipPercentage.Name = "tipPercentage";
            this.tipPercentage.Size = new System.Drawing.Size(105, 17);
            this.tipPercentage.TabIndex = 4;
            this.tipPercentage.Text = "Tip Percentage";
            // 
            // TipPercentageTextBox
            // 
            this.TipPercentageTextBox.Location = new System.Drawing.Point(433, 183);
            this.TipPercentageTextBox.Name = "TipPercentageTextBox";
            this.TipPercentageTextBox.Size = new System.Drawing.Size(100, 22);
            this.TipPercentageTextBox.TabIndex = 5;
            this.TipPercentageTextBox.TextChanged += new System.EventHandler(this.TipPercentageTextBox_TextChanged);
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Location = new System.Drawing.Point(578, 378);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(40, 17);
            this.total.TabIndex = 6;
            this.total.Text = "Total";
            // 
            // TotalTextBox
            // 
            this.TotalTextBox.Location = new System.Drawing.Point(667, 378);
            this.TotalTextBox.Name = "TotalTextBox";
            this.TotalTextBox.Size = new System.Drawing.Size(100, 22);
            this.TotalTextBox.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TotalTextBox);
            this.Controls.Add(this.total);
            this.Controls.Add(this.TipPercentageTextBox);
            this.Controls.Add(this.tipPercentage);
            this.Controls.Add(this.computeTipTextBox);
            this.Controls.Add(this.enterTotalBillTextBox);
            this.Controls.Add(this.computeTip);
            this.Controls.Add(this.enterTotalBill);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label enterTotalBill;
        private System.Windows.Forms.Button computeTip;
        private System.Windows.Forms.TextBox enterTotalBillTextBox;
        private System.Windows.Forms.TextBox computeTipTextBox;
        private System.Windows.Forms.Label tipPercentage;
        private System.Windows.Forms.TextBox TipPercentageTextBox;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.TextBox TotalTextBox;
    }
}

