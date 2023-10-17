namespace prjWinCsFinalProjectPart1
{
    partial class frmChange
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
            this.cboCountry = new System.Windows.Forms.ComboBox();
            this.lblCurrencyRatesFrom = new System.Windows.Forms.Label();
            this.lblCurrencyRatesTo = new System.Windows.Forms.Label();
            this.lblCurrencyFrom = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radBtnValueFromUS = new System.Windows.Forms.RadioButton();
            this.radBtnValueToUS = new System.Windows.Forms.RadioButton();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnQuiter = new System.Windows.Forms.Button();
            this.btnEffacer = new System.Windows.Forms.Button();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(231, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "BUREAU - XCHANGE";
            // 
            // cboCountry
            // 
            this.cboCountry.FormattingEnabled = true;
            this.cboCountry.Location = new System.Drawing.Point(13, 84);
            this.cboCountry.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboCountry.Name = "cboCountry";
            this.cboCountry.Size = new System.Drawing.Size(238, 28);
            this.cboCountry.TabIndex = 1;
            this.cboCountry.SelectedIndexChanged += new System.EventHandler(this.cboCountry_SelectedIndexChanged);
            // 
            // lblCurrencyRatesFrom
            // 
            this.lblCurrencyRatesFrom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCurrencyRatesFrom.Location = new System.Drawing.Point(413, 84);
            this.lblCurrencyRatesFrom.Name = "lblCurrencyRatesFrom";
            this.lblCurrencyRatesFrom.Size = new System.Drawing.Size(245, 28);
            this.lblCurrencyRatesFrom.TabIndex = 2;
            // 
            // lblCurrencyRatesTo
            // 
            this.lblCurrencyRatesTo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCurrencyRatesTo.Location = new System.Drawing.Point(413, 131);
            this.lblCurrencyRatesTo.Name = "lblCurrencyRatesTo";
            this.lblCurrencyRatesTo.Size = new System.Drawing.Size(245, 28);
            this.lblCurrencyRatesTo.TabIndex = 3;
            // 
            // lblCurrencyFrom
            // 
            this.lblCurrencyFrom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCurrencyFrom.Location = new System.Drawing.Point(413, 242);
            this.lblCurrencyFrom.Name = "lblCurrencyFrom";
            this.lblCurrencyFrom.Size = new System.Drawing.Size(144, 28);
            this.lblCurrencyFrom.TabIndex = 4;
            // 
            // lblResult
            // 
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResult.Location = new System.Drawing.Point(13, 410);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(238, 41);
            this.lblResult.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radBtnValueToUS);
            this.groupBox1.Controls.Add(this.radBtnValueFromUS);
            this.groupBox1.Location = new System.Drawing.Point(13, 242);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 124);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Type de conversion";
            // 
            // radBtnValueFromUS
            // 
            this.radBtnValueFromUS.AutoSize = true;
            this.radBtnValueFromUS.Location = new System.Drawing.Point(31, 39);
            this.radBtnValueFromUS.Name = "radBtnValueFromUS";
            this.radBtnValueFromUS.Size = new System.Drawing.Size(14, 13);
            this.radBtnValueFromUS.TabIndex = 0;
            this.radBtnValueFromUS.TabStop = true;
            this.radBtnValueFromUS.UseVisualStyleBackColor = true;
            this.radBtnValueFromUS.CheckedChanged += new System.EventHandler(this.radBtnValueFrom_CheckedChanged);
            // 
            // radBtnValueToUS
            // 
            this.radBtnValueToUS.AutoSize = true;
            this.radBtnValueToUS.Location = new System.Drawing.Point(31, 80);
            this.radBtnValueToUS.Name = "radBtnValueToUS";
            this.radBtnValueToUS.Size = new System.Drawing.Size(14, 13);
            this.radBtnValueToUS.TabIndex = 1;
            this.radBtnValueToUS.TabStop = true;
            this.radBtnValueToUS.UseVisualStyleBackColor = true;
            this.radBtnValueToUS.CheckedChanged += new System.EventHandler(this.radBtnValueTo_CheckedChanged);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(413, 284);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(144, 26);
            this.txtAmount.TabIndex = 7;
            // 
            // btnQuiter
            // 
            this.btnQuiter.Location = new System.Drawing.Point(602, 332);
            this.btnQuiter.Name = "btnQuiter";
            this.btnQuiter.Size = new System.Drawing.Size(111, 34);
            this.btnQuiter.TabIndex = 13;
            this.btnQuiter.Text = "Quiter";
            this.btnQuiter.UseVisualStyleBackColor = true;
            this.btnQuiter.Click += new System.EventHandler(this.btnQuiter_Click);
            // 
            // btnEffacer
            // 
            this.btnEffacer.Location = new System.Drawing.Point(602, 284);
            this.btnEffacer.Name = "btnEffacer";
            this.btnEffacer.Size = new System.Drawing.Size(111, 34);
            this.btnEffacer.TabIndex = 12;
            this.btnEffacer.Text = "Effacer";
            this.btnEffacer.UseVisualStyleBackColor = true;
            this.btnEffacer.Click += new System.EventHandler(this.btnEffacer_Click);
            // 
            // btnConvertir
            // 
            this.btnConvertir.Location = new System.Drawing.Point(602, 236);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(111, 34);
            this.btnConvertir.TabIndex = 11;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // frmChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 488);
            this.Controls.Add(this.btnQuiter);
            this.Controls.Add(this.btnEffacer);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblCurrencyFrom);
            this.Controls.Add(this.lblCurrencyRatesTo);
            this.Controls.Add(this.lblCurrencyRatesFrom);
            this.Controls.Add(this.cboCountry);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmChange";
            this.Text = "frmChange";
            this.Load += new System.EventHandler(this.frmChange_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboCountry;
        private System.Windows.Forms.Label lblCurrencyRatesFrom;
        private System.Windows.Forms.Label lblCurrencyRatesTo;
        private System.Windows.Forms.Label lblCurrencyFrom;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radBtnValueToUS;
        private System.Windows.Forms.RadioButton radBtnValueFromUS;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnQuiter;
        private System.Windows.Forms.Button btnEffacer;
        private System.Windows.Forms.Button btnConvertir;
    }
}