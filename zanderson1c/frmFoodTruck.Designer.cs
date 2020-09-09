namespace zanderson1c
{
    partial class frmFoodTruck
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtOkra = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOkraSubtotal = new System.Windows.Forms.TextBox();
            this.txtCorndogSubtotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCorndog = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.txtPretax = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fried Okra";
            // 
            // txtOkra
            // 
            this.txtOkra.Location = new System.Drawing.Point(142, 42);
            this.txtOkra.Name = "txtOkra";
            this.txtOkra.Size = new System.Drawing.Size(73, 22);
            this.txtOkra.TabIndex = 1;
            this.txtOkra.Text = "0";
            this.txtOkra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "x $5.00 =";
            // 
            // txtOkraSubtotal
            // 
            this.txtOkraSubtotal.Location = new System.Drawing.Point(341, 42);
            this.txtOkraSubtotal.Name = "txtOkraSubtotal";
            this.txtOkraSubtotal.ReadOnly = true;
            this.txtOkraSubtotal.Size = new System.Drawing.Size(100, 22);
            this.txtOkraSubtotal.TabIndex = 3;
            this.txtOkraSubtotal.TabStop = false;
            this.txtOkraSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtOkraSubtotal.TextChanged += new System.EventHandler(this.txtOkraSubtotal_TextChanged);
            // 
            // txtCorndogSubtotal
            // 
            this.txtCorndogSubtotal.Location = new System.Drawing.Point(341, 92);
            this.txtCorndogSubtotal.Name = "txtCorndogSubtotal";
            this.txtCorndogSubtotal.ReadOnly = true;
            this.txtCorndogSubtotal.Size = new System.Drawing.Size(100, 22);
            this.txtCorndogSubtotal.TabIndex = 7;
            this.txtCorndogSubtotal.TabStop = false;
            this.txtCorndogSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCorndogSubtotal.TextChanged += new System.EventHandler(this.txtCorndogSubtotal_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(247, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "x $6.00 =";
            // 
            // txtCorndog
            // 
            this.txtCorndog.Location = new System.Drawing.Point(142, 92);
            this.txtCorndog.Name = "txtCorndog";
            this.txtCorndog.Size = new System.Drawing.Size(73, 22);
            this.txtCorndog.TabIndex = 5;
            this.txtCorndog.Text = "0";
            this.txtCorndog.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Corndog";
            // 
            // btnCalculate
            // 
            this.btnCalculate.AutoSize = true;
            this.btnCalculate.Location = new System.Drawing.Point(77, 324);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(76, 27);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(341, 229);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 22);
            this.txtTotal.TabIndex = 9;
            this.txtTotal.TabStop = false;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotal.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtTax
            // 
            this.txtTax.Location = new System.Drawing.Point(341, 180);
            this.txtTax.Name = "txtTax";
            this.txtTax.ReadOnly = true;
            this.txtTax.Size = new System.Drawing.Size(100, 22);
            this.txtTax.TabIndex = 10;
            this.txtTax.TabStop = false;
            this.txtTax.Text = ".06875";
            this.txtTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTax.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtPretax
            // 
            this.txtPretax.Location = new System.Drawing.Point(341, 137);
            this.txtPretax.Name = "txtPretax";
            this.txtPretax.ReadOnly = true;
            this.txtPretax.Size = new System.Drawing.Size(100, 22);
            this.txtPretax.TabIndex = 11;
            this.txtPretax.TabStop = false;
            this.txtPretax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPretax.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(247, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Pretax Total:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(247, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Tax:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(250, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Total:";
            // 
            // btnClear
            // 
            this.btnClear.AutoSize = true;
            this.btnClear.Location = new System.Drawing.Point(207, 324);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 27);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "C&lear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.Location = new System.Drawing.Point(330, 324);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 27);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmFoodTruck
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(506, 383);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPretax);
            this.Controls.Add(this.txtTax);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtCorndogSubtotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCorndog);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtOkraSubtotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOkra);
            this.Controls.Add(this.label1);
            this.Name = "frmFoodTruck";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "1730zanderson1c Food Truck";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOkra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOkraSubtotal;
        private System.Windows.Forms.TextBox txtCorndogSubtotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCorndog;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.TextBox txtPretax;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

