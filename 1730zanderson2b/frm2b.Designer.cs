namespace _1730zanderson2b
{
    partial class frm2b
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm2b));
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUSDTotal = new System.Windows.Forms.TextBox();
            this.txtAmountBrazil = new System.Windows.Forms.TextBox();
            this.txtAmountFrance = new System.Windows.Forms.TextBox();
            this.txtAmountMozambique = new System.Windows.Forms.TextBox();
            this.txtRateAustralia = new System.Windows.Forms.TextBox();
            this.txtRateBrazil = new System.Windows.Forms.TextBox();
            this.txtRateFrance = new System.Windows.Forms.TextBox();
            this.txtRateMozambique = new System.Windows.Forms.TextBox();
            this.txtUSDAustralia = new System.Windows.Forms.TextBox();
            this.txtUSDBrazil = new System.Windows.Forms.TextBox();
            this.txtUSDFrance = new System.Windows.Forms.TextBox();
            this.txtUSDMozambique = new System.Windows.Forms.TextBox();
            this.txtAmountAustralia = new System.Windows.Forms.TextBox();
            this.lblUS = new System.Windows.Forms.Label();
            this.lblRate = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFrance = new System.Windows.Forms.Label();
            this.lblBrazil = new System.Windows.Forms.Label();
            this.lblAustralia = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.Location = new System.Drawing.Point(340, 260);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 27);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReset
            // 
            this.btnReset.AutoSize = true;
            this.btnReset.Location = new System.Drawing.Point(213, 260);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 27);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(604, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 25);
            this.label3.TabIndex = 22;
            this.label3.Text = "=";
            // 
            // txtUSDTotal
            // 
            this.txtUSDTotal.Location = new System.Drawing.Point(663, 209);
            this.txtUSDTotal.Name = "txtUSDTotal";
            this.txtUSDTotal.ReadOnly = true;
            this.txtUSDTotal.Size = new System.Drawing.Size(100, 22);
            this.txtUSDTotal.TabIndex = 23;
            this.txtUSDTotal.TabStop = false;
            this.txtUSDTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtAmountBrazil
            // 
            this.txtAmountBrazil.Location = new System.Drawing.Point(213, 136);
            this.txtAmountBrazil.Name = "txtAmountBrazil";
            this.txtAmountBrazil.Size = new System.Drawing.Size(100, 22);
            this.txtAmountBrazil.TabIndex = 2;
            this.txtAmountBrazil.Text = "0.00";
            this.txtAmountBrazil.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAmountBrazil.TextChanged += new System.EventHandler(this.calculate);
            // 
            // txtAmountFrance
            // 
            this.txtAmountFrance.Location = new System.Drawing.Point(340, 136);
            this.txtAmountFrance.Name = "txtAmountFrance";
            this.txtAmountFrance.Size = new System.Drawing.Size(100, 22);
            this.txtAmountFrance.TabIndex = 4;
            this.txtAmountFrance.Text = "0.00";
            this.txtAmountFrance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAmountFrance.TextChanged += new System.EventHandler(this.calculate);
            // 
            // txtAmountMozambique
            // 
            this.txtAmountMozambique.Location = new System.Drawing.Point(469, 136);
            this.txtAmountMozambique.Name = "txtAmountMozambique";
            this.txtAmountMozambique.Size = new System.Drawing.Size(100, 22);
            this.txtAmountMozambique.TabIndex = 6;
            this.txtAmountMozambique.Text = "0.00";
            this.txtAmountMozambique.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAmountMozambique.TextChanged += new System.EventHandler(this.calculate);
            // 
            // txtRateAustralia
            // 
            this.txtRateAustralia.Location = new System.Drawing.Point(85, 174);
            this.txtRateAustralia.Name = "txtRateAustralia";
            this.txtRateAustralia.Size = new System.Drawing.Size(100, 22);
            this.txtRateAustralia.TabIndex = 1;
            this.txtRateAustralia.Text = "0.727701";
            this.txtRateAustralia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRateAustralia.TextChanged += new System.EventHandler(this.calculate);
            // 
            // txtRateBrazil
            // 
            this.txtRateBrazil.Location = new System.Drawing.Point(213, 174);
            this.txtRateBrazil.Name = "txtRateBrazil";
            this.txtRateBrazil.Size = new System.Drawing.Size(100, 22);
            this.txtRateBrazil.TabIndex = 3;
            this.txtRateBrazil.Text = "0.189030";
            this.txtRateBrazil.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRateBrazil.TextChanged += new System.EventHandler(this.calculate);
            // 
            // txtRateFrance
            // 
            this.txtRateFrance.Location = new System.Drawing.Point(340, 171);
            this.txtRateFrance.Name = "txtRateFrance";
            this.txtRateFrance.Size = new System.Drawing.Size(100, 22);
            this.txtRateFrance.TabIndex = 5;
            this.txtRateFrance.Text = "1.18033";
            this.txtRateFrance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRateFrance.TextChanged += new System.EventHandler(this.calculate);
            // 
            // txtRateMozambique
            // 
            this.txtRateMozambique.Location = new System.Drawing.Point(469, 171);
            this.txtRateMozambique.Name = "txtRateMozambique";
            this.txtRateMozambique.Size = new System.Drawing.Size(100, 22);
            this.txtRateMozambique.TabIndex = 7;
            this.txtRateMozambique.Text = "0.0139615";
            this.txtRateMozambique.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRateMozambique.TextChanged += new System.EventHandler(this.calculate);
            // 
            // txtUSDAustralia
            // 
            this.txtUSDAustralia.Location = new System.Drawing.Point(85, 209);
            this.txtUSDAustralia.Name = "txtUSDAustralia";
            this.txtUSDAustralia.ReadOnly = true;
            this.txtUSDAustralia.Size = new System.Drawing.Size(100, 22);
            this.txtUSDAustralia.TabIndex = 18;
            this.txtUSDAustralia.TabStop = false;
            this.txtUSDAustralia.Text = "0.00";
            this.txtUSDAustralia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtUSDBrazil
            // 
            this.txtUSDBrazil.Location = new System.Drawing.Point(213, 209);
            this.txtUSDBrazil.Name = "txtUSDBrazil";
            this.txtUSDBrazil.ReadOnly = true;
            this.txtUSDBrazil.Size = new System.Drawing.Size(100, 22);
            this.txtUSDBrazil.TabIndex = 19;
            this.txtUSDBrazil.TabStop = false;
            this.txtUSDBrazil.Text = "0.00";
            this.txtUSDBrazil.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtUSDFrance
            // 
            this.txtUSDFrance.Location = new System.Drawing.Point(340, 209);
            this.txtUSDFrance.Name = "txtUSDFrance";
            this.txtUSDFrance.ReadOnly = true;
            this.txtUSDFrance.Size = new System.Drawing.Size(100, 22);
            this.txtUSDFrance.TabIndex = 20;
            this.txtUSDFrance.TabStop = false;
            this.txtUSDFrance.Text = "0.00";
            this.txtUSDFrance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtUSDMozambique
            // 
            this.txtUSDMozambique.Location = new System.Drawing.Point(469, 209);
            this.txtUSDMozambique.Name = "txtUSDMozambique";
            this.txtUSDMozambique.ReadOnly = true;
            this.txtUSDMozambique.Size = new System.Drawing.Size(100, 22);
            this.txtUSDMozambique.TabIndex = 21;
            this.txtUSDMozambique.TabStop = false;
            this.txtUSDMozambique.Text = "0.00";
            this.txtUSDMozambique.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtAmountAustralia
            // 
            this.txtAmountAustralia.Location = new System.Drawing.Point(85, 136);
            this.txtAmountAustralia.Name = "txtAmountAustralia";
            this.txtAmountAustralia.Size = new System.Drawing.Size(100, 22);
            this.txtAmountAustralia.TabIndex = 0;
            this.txtAmountAustralia.Text = "0.00";
            this.txtAmountAustralia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAmountAustralia.TextChanged += new System.EventHandler(this.calculate);
            // 
            // lblUS
            // 
            this.lblUS.AutoSize = true;
            this.lblUS.Location = new System.Drawing.Point(9, 212);
            this.lblUS.Name = "lblUS";
            this.lblUS.Size = new System.Drawing.Size(43, 17);
            this.lblUS.TabIndex = 17;
            this.lblUS.Text = "$ US:";
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Location = new System.Drawing.Point(9, 174);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(42, 17);
            this.lblRate.TabIndex = 16;
            this.lblRate.Text = "Rate:";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(9, 136);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(60, 17);
            this.lblAmount.TabIndex = 15;
            this.lblAmount.Text = "Amount:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(686, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "US Dollar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(457, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Mozambique Metical";
            // 
            // lblFrance
            // 
            this.lblFrance.AutoSize = true;
            this.lblFrance.Location = new System.Drawing.Point(349, 102);
            this.lblFrance.Name = "lblFrance";
            this.lblFrance.Size = new System.Drawing.Size(86, 17);
            this.lblFrance.TabIndex = 12;
            this.lblFrance.Text = "French Euro";
            // 
            // lblBrazil
            // 
            this.lblBrazil.AutoSize = true;
            this.lblBrazil.Location = new System.Drawing.Point(218, 102);
            this.lblBrazil.Name = "lblBrazil";
            this.lblBrazil.Size = new System.Drawing.Size(95, 17);
            this.lblBrazil.TabIndex = 11;
            this.lblBrazil.Text = "Brazilian Real";
            // 
            // lblAustralia
            // 
            this.lblAustralia.AutoSize = true;
            this.lblAustralia.Location = new System.Drawing.Point(82, 102);
            this.lblAustralia.Name = "lblAustralia";
            this.lblAustralia.Size = new System.Drawing.Size(112, 17);
            this.lblAustralia.TabIndex = 10;
            this.lblAustralia.Text = "Australian Dollar";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(469, 31);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(112, 77);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 34;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(211, 31);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(112, 77);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 31;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(340, 31);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(112, 77);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 29;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(664, 31);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(112, 77);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(82, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // frm2b
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 355);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUSDTotal);
            this.Controls.Add(this.txtAmountBrazil);
            this.Controls.Add(this.txtAmountFrance);
            this.Controls.Add(this.txtAmountMozambique);
            this.Controls.Add(this.txtRateAustralia);
            this.Controls.Add(this.txtRateBrazil);
            this.Controls.Add(this.txtRateFrance);
            this.Controls.Add(this.txtRateMozambique);
            this.Controls.Add(this.txtUSDAustralia);
            this.Controls.Add(this.txtUSDBrazil);
            this.Controls.Add(this.txtUSDFrance);
            this.Controls.Add(this.txtUSDMozambique);
            this.Controls.Add(this.txtAmountAustralia);
            this.Controls.Add(this.lblUS);
            this.Controls.Add(this.lblRate);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblFrance);
            this.Controls.Add(this.lblBrazil);
            this.Controls.Add(this.lblAustralia);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frm2b";
            this.Text = "2b 1730zanderson";
            this.Load += new System.EventHandler(this.frm2b_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUSDTotal;
        private System.Windows.Forms.TextBox txtAmountBrazil;
        private System.Windows.Forms.TextBox txtAmountFrance;
        private System.Windows.Forms.TextBox txtAmountMozambique;
        private System.Windows.Forms.TextBox txtRateAustralia;
        private System.Windows.Forms.TextBox txtRateBrazil;
        private System.Windows.Forms.TextBox txtRateFrance;
        private System.Windows.Forms.TextBox txtRateMozambique;
        private System.Windows.Forms.TextBox txtUSDAustralia;
        private System.Windows.Forms.TextBox txtUSDBrazil;
        private System.Windows.Forms.TextBox txtUSDFrance;
        private System.Windows.Forms.TextBox txtUSDMozambique;
        private System.Windows.Forms.TextBox txtAmountAustralia;
        private System.Windows.Forms.Label lblUS;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFrance;
        private System.Windows.Forms.Label lblBrazil;
        private System.Windows.Forms.Label lblAustralia;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

