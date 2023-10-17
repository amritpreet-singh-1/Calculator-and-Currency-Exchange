namespace prjWinCsFinalProjectPart1
{
    partial class frmScientificCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmScientificCalculator));
            this.lblPrimaryDisplay = new System.Windows.Forms.Label();
            this.lblSecondaryDisplay = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnM = new System.Windows.Forms.Button();
            this.btnMS = new System.Windows.Forms.Button();
            this.btnM_Minus = new System.Windows.Forms.Button();
            this.btnM_Plus = new System.Windows.Forms.Button();
            this.btnMR = new System.Windows.Forms.Button();
            this.btnMC = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btnFraction = new System.Windows.Forms.Button();
            this.btnSign = new System.Windows.Forms.Button();
            this.btnNum0 = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.btnBackspace = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btn_e = new System.Windows.Forms.Button();
            this.btnPI = new System.Windows.Forms.Button();
            this.btnFactorial = new System.Windows.Forms.Button();
            this.btnClosePar = new System.Windows.Forms.Button();
            this.btnOpenPar = new System.Windows.Forms.Button();
            this.btnNum9 = new System.Windows.Forms.Button();
            this.btnNum8 = new System.Windows.Forms.Button();
            this.btnNum7 = new System.Windows.Forms.Button();
            this.btnNum6 = new System.Windows.Forms.Button();
            this.btnNum5 = new System.Windows.Forms.Button();
            this.btnNum4 = new System.Windows.Forms.Button();
            this.btnNum3 = new System.Windows.Forms.Button();
            this.btnNum2 = new System.Windows.Forms.Button();
            this.btnNum1 = new System.Windows.Forms.Button();
            this.btn2nd = new System.Windows.Forms.Button();
            this.btnSqRoot = new System.Windows.Forms.Button();
            this.btnXtoY = new System.Windows.Forms.Button();
            this.btn10toX = new System.Windows.Forms.Button();
            this.btnLog = new System.Windows.Forms.Button();
            this.btnLn = new System.Windows.Forms.Button();
            this.btnSqaure = new System.Windows.Forms.Button();
            this.btnMod = new System.Windows.Forms.Button();
            this.btnExp = new System.Windows.Forms.Button();
            this.btnModX = new System.Windows.Forms.Button();
            this.btnInverse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPrimaryDisplay
            // 
            this.lblPrimaryDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrimaryDisplay.Location = new System.Drawing.Point(8, 101);
            this.lblPrimaryDisplay.Name = "lblPrimaryDisplay";
            this.lblPrimaryDisplay.Size = new System.Drawing.Size(532, 67);
            this.lblPrimaryDisplay.TabIndex = 5;
            this.lblPrimaryDisplay.Text = "0";
            this.lblPrimaryDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSecondaryDisplay
            // 
            this.lblSecondaryDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondaryDisplay.Location = new System.Drawing.Point(285, 65);
            this.lblSecondaryDisplay.Name = "lblSecondaryDisplay";
            this.lblSecondaryDisplay.Size = new System.Drawing.Size(249, 36);
            this.lblSecondaryDisplay.TabIndex = 4;
            this.lblSecondaryDisplay.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Scientific";
            // 
            // btnM
            // 
            this.btnM.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnM.FlatAppearance.BorderSize = 0;
            this.btnM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnM.Location = new System.Drawing.Point(464, 180);
            this.btnM.Margin = new System.Windows.Forms.Padding(2);
            this.btnM.Name = "btnM";
            this.btnM.Size = new System.Drawing.Size(76, 35);
            this.btnM.TabIndex = 92;
            this.btnM.Text = "M";
            this.btnM.UseVisualStyleBackColor = false;
            this.btnM.Click += new System.EventHandler(this.btnM_Click);
            // 
            // btnMS
            // 
            this.btnMS.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMS.FlatAppearance.BorderSize = 0;
            this.btnMS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMS.Location = new System.Drawing.Point(368, 180);
            this.btnMS.Margin = new System.Windows.Forms.Padding(2);
            this.btnMS.Name = "btnMS";
            this.btnMS.Size = new System.Drawing.Size(85, 34);
            this.btnMS.TabIndex = 91;
            this.btnMS.Text = "MS";
            this.btnMS.UseVisualStyleBackColor = false;
            this.btnMS.Click += new System.EventHandler(this.btnMS_Click);
            // 
            // btnM_Minus
            // 
            this.btnM_Minus.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnM_Minus.FlatAppearance.BorderSize = 0;
            this.btnM_Minus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnM_Minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnM_Minus.Location = new System.Drawing.Point(280, 181);
            this.btnM_Minus.Margin = new System.Windows.Forms.Padding(2);
            this.btnM_Minus.Name = "btnM_Minus";
            this.btnM_Minus.Size = new System.Drawing.Size(84, 34);
            this.btnM_Minus.TabIndex = 90;
            this.btnM_Minus.Text = "M-";
            this.btnM_Minus.UseVisualStyleBackColor = false;
            this.btnM_Minus.Click += new System.EventHandler(this.btnM_Minus_Click);
            // 
            // btnM_Plus
            // 
            this.btnM_Plus.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnM_Plus.FlatAppearance.BorderSize = 0;
            this.btnM_Plus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnM_Plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnM_Plus.Location = new System.Drawing.Point(197, 181);
            this.btnM_Plus.Margin = new System.Windows.Forms.Padding(2);
            this.btnM_Plus.Name = "btnM_Plus";
            this.btnM_Plus.Size = new System.Drawing.Size(79, 33);
            this.btnM_Plus.TabIndex = 89;
            this.btnM_Plus.Text = "M+";
            this.btnM_Plus.UseVisualStyleBackColor = false;
            this.btnM_Plus.Click += new System.EventHandler(this.btnM_Plus_Click);
            // 
            // btnMR
            // 
            this.btnMR.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMR.FlatAppearance.BorderSize = 0;
            this.btnMR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMR.Location = new System.Drawing.Point(100, 181);
            this.btnMR.Margin = new System.Windows.Forms.Padding(2);
            this.btnMR.Name = "btnMR";
            this.btnMR.Size = new System.Drawing.Size(93, 33);
            this.btnMR.TabIndex = 88;
            this.btnMR.Text = "MR";
            this.btnMR.UseVisualStyleBackColor = false;
            this.btnMR.Click += new System.EventHandler(this.btnMR_Click);
            // 
            // btnMC
            // 
            this.btnMC.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMC.FlatAppearance.BorderSize = 0;
            this.btnMC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMC.Location = new System.Drawing.Point(10, 182);
            this.btnMC.Margin = new System.Windows.Forms.Padding(2);
            this.btnMC.Name = "btnMC";
            this.btnMC.Size = new System.Drawing.Size(86, 33);
            this.btnMC.TabIndex = 87;
            this.btnMC.Text = "MC";
            this.btnMC.UseVisualStyleBackColor = false;
            this.btnMC.Click += new System.EventHandler(this.btnMC_Click);
            // 
            // btnEqual
            // 
            this.btnEqual.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnEqual.FlatAppearance.BorderSize = 0;
            this.btnEqual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEqual.Location = new System.Drawing.Point(437, 543);
            this.btnEqual.Margin = new System.Windows.Forms.Padding(2);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(103, 50);
            this.btnEqual.TabIndex = 86;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = false;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // btnFraction
            // 
            this.btnFraction.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFraction.FlatAppearance.BorderSize = 0;
            this.btnFraction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFraction.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFraction.Location = new System.Drawing.Point(330, 542);
            this.btnFraction.Margin = new System.Windows.Forms.Padding(2);
            this.btnFraction.Name = "btnFraction";
            this.btnFraction.Size = new System.Drawing.Size(103, 50);
            this.btnFraction.TabIndex = 85;
            this.btnFraction.Text = ".";
            this.btnFraction.UseVisualStyleBackColor = false;
            this.btnFraction.Click += new System.EventHandler(this.btnFraction_Click);
            // 
            // btnSign
            // 
            this.btnSign.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSign.FlatAppearance.BorderSize = 0;
            this.btnSign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSign.Location = new System.Drawing.Point(115, 542);
            this.btnSign.Margin = new System.Windows.Forms.Padding(2);
            this.btnSign.Name = "btnSign";
            this.btnSign.Size = new System.Drawing.Size(103, 50);
            this.btnSign.TabIndex = 84;
            this.btnSign.Text = "+/-";
            this.btnSign.UseVisualStyleBackColor = false;
            this.btnSign.Click += new System.EventHandler(this.btnSign_Click);
            // 
            // btnNum0
            // 
            this.btnNum0.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNum0.FlatAppearance.BorderSize = 0;
            this.btnNum0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNum0.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum0.Location = new System.Drawing.Point(222, 542);
            this.btnNum0.Margin = new System.Windows.Forms.Padding(2);
            this.btnNum0.Name = "btnNum0";
            this.btnNum0.Size = new System.Drawing.Size(103, 50);
            this.btnNum0.TabIndex = 83;
            this.btnNum0.Text = "0";
            this.btnNum0.UseVisualStyleBackColor = false;
            this.btnNum0.Click += new System.EventHandler(this.btnNum0_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(437, 490);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(103, 50);
            this.btnAdd.TabIndex = 82;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSub
            // 
            this.btnSub.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSub.FlatAppearance.BorderSize = 0;
            this.btnSub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSub.Location = new System.Drawing.Point(437, 436);
            this.btnSub.Margin = new System.Windows.Forms.Padding(2);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(103, 50);
            this.btnSub.TabIndex = 81;
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = false;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnMultiply.FlatAppearance.BorderSize = 0;
            this.btnMultiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiply.Location = new System.Drawing.Point(437, 382);
            this.btnMultiply.Margin = new System.Windows.Forms.Padding(2);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(103, 50);
            this.btnMultiply.TabIndex = 80;
            this.btnMultiply.Text = "x";
            this.btnMultiply.UseVisualStyleBackColor = false;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // btnDivision
            // 
            this.btnDivision.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnDivision.FlatAppearance.BorderSize = 0;
            this.btnDivision.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivision.Location = new System.Drawing.Point(437, 327);
            this.btnDivision.Margin = new System.Windows.Forms.Padding(2);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(103, 50);
            this.btnDivision.TabIndex = 79;
            this.btnDivision.Text = "÷";
            this.btnDivision.UseVisualStyleBackColor = false;
            this.btnDivision.Click += new System.EventHandler(this.btnDivision_Click);
            // 
            // btnBackspace
            // 
            this.btnBackspace.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnBackspace.FlatAppearance.BorderSize = 0;
            this.btnBackspace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackspace.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackspace.Location = new System.Drawing.Point(437, 219);
            this.btnBackspace.Margin = new System.Windows.Forms.Padding(2);
            this.btnBackspace.Name = "btnBackspace";
            this.btnBackspace.Size = new System.Drawing.Size(103, 50);
            this.btnBackspace.TabIndex = 78;
            this.btnBackspace.Text = "⌫";
            this.btnBackspace.UseVisualStyleBackColor = false;
            this.btnBackspace.Click += new System.EventHandler(this.btnBackspace_Click);
            // 
            // btnC
            // 
            this.btnC.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnC.FlatAppearance.BorderSize = 0;
            this.btnC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC.Location = new System.Drawing.Point(330, 219);
            this.btnC.Margin = new System.Windows.Forms.Padding(2);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(103, 50);
            this.btnC.TabIndex = 77;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = false;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btn_e
            // 
            this.btn_e.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_e.FlatAppearance.BorderSize = 0;
            this.btn_e.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_e.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_e.Location = new System.Drawing.Point(222, 219);
            this.btn_e.Margin = new System.Windows.Forms.Padding(2);
            this.btn_e.Name = "btn_e";
            this.btn_e.Size = new System.Drawing.Size(103, 50);
            this.btn_e.TabIndex = 76;
            this.btn_e.Text = "℮";
            this.btn_e.UseVisualStyleBackColor = false;
            this.btn_e.Click += new System.EventHandler(this.btn_e_Click);
            // 
            // btnPI
            // 
            this.btnPI.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnPI.FlatAppearance.BorderSize = 0;
            this.btnPI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPI.Location = new System.Drawing.Point(115, 219);
            this.btnPI.Margin = new System.Windows.Forms.Padding(2);
            this.btnPI.Name = "btnPI";
            this.btnPI.Size = new System.Drawing.Size(103, 50);
            this.btnPI.TabIndex = 75;
            this.btnPI.Text = "π";
            this.btnPI.UseVisualStyleBackColor = false;
            this.btnPI.Click += new System.EventHandler(this.btnPI_Click);
            // 
            // btnFactorial
            // 
            this.btnFactorial.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnFactorial.FlatAppearance.BorderSize = 0;
            this.btnFactorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFactorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFactorial.Location = new System.Drawing.Point(330, 327);
            this.btnFactorial.Margin = new System.Windows.Forms.Padding(2);
            this.btnFactorial.Name = "btnFactorial";
            this.btnFactorial.Size = new System.Drawing.Size(103, 50);
            this.btnFactorial.TabIndex = 74;
            this.btnFactorial.Text = "n!";
            this.btnFactorial.UseVisualStyleBackColor = false;
            this.btnFactorial.Click += new System.EventHandler(this.btnFactorial_Click);
            // 
            // btnClosePar
            // 
            this.btnClosePar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnClosePar.Enabled = false;
            this.btnClosePar.FlatAppearance.BorderSize = 0;
            this.btnClosePar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClosePar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClosePar.Location = new System.Drawing.Point(222, 327);
            this.btnClosePar.Margin = new System.Windows.Forms.Padding(2);
            this.btnClosePar.Name = "btnClosePar";
            this.btnClosePar.Size = new System.Drawing.Size(103, 50);
            this.btnClosePar.TabIndex = 73;
            this.btnClosePar.Text = ")";
            this.btnClosePar.UseVisualStyleBackColor = false;
            this.btnClosePar.Click += new System.EventHandler(this.btnClosePar_Click);
            // 
            // btnOpenPar
            // 
            this.btnOpenPar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnOpenPar.Enabled = false;
            this.btnOpenPar.FlatAppearance.BorderSize = 0;
            this.btnOpenPar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenPar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenPar.Location = new System.Drawing.Point(115, 327);
            this.btnOpenPar.Margin = new System.Windows.Forms.Padding(2);
            this.btnOpenPar.Name = "btnOpenPar";
            this.btnOpenPar.Size = new System.Drawing.Size(103, 50);
            this.btnOpenPar.TabIndex = 72;
            this.btnOpenPar.Text = "(";
            this.btnOpenPar.UseVisualStyleBackColor = false;
            this.btnOpenPar.Click += new System.EventHandler(this.btnOpenPar_Click);
            // 
            // btnNum9
            // 
            this.btnNum9.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNum9.FlatAppearance.BorderSize = 0;
            this.btnNum9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNum9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum9.Location = new System.Drawing.Point(330, 381);
            this.btnNum9.Margin = new System.Windows.Forms.Padding(2);
            this.btnNum9.Name = "btnNum9";
            this.btnNum9.Size = new System.Drawing.Size(103, 50);
            this.btnNum9.TabIndex = 71;
            this.btnNum9.Text = "9";
            this.btnNum9.UseVisualStyleBackColor = false;
            this.btnNum9.Click += new System.EventHandler(this.btnNum9_Click);
            // 
            // btnNum8
            // 
            this.btnNum8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNum8.FlatAppearance.BorderSize = 0;
            this.btnNum8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNum8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum8.Location = new System.Drawing.Point(222, 381);
            this.btnNum8.Margin = new System.Windows.Forms.Padding(2);
            this.btnNum8.Name = "btnNum8";
            this.btnNum8.Size = new System.Drawing.Size(103, 50);
            this.btnNum8.TabIndex = 70;
            this.btnNum8.Text = "8";
            this.btnNum8.UseVisualStyleBackColor = false;
            this.btnNum8.Click += new System.EventHandler(this.btnNum8_Click);
            // 
            // btnNum7
            // 
            this.btnNum7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNum7.FlatAppearance.BorderSize = 0;
            this.btnNum7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNum7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum7.Location = new System.Drawing.Point(115, 381);
            this.btnNum7.Margin = new System.Windows.Forms.Padding(2);
            this.btnNum7.Name = "btnNum7";
            this.btnNum7.Size = new System.Drawing.Size(103, 50);
            this.btnNum7.TabIndex = 69;
            this.btnNum7.Text = "7";
            this.btnNum7.UseVisualStyleBackColor = false;
            this.btnNum7.Click += new System.EventHandler(this.btnNum7_Click);
            // 
            // btnNum6
            // 
            this.btnNum6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNum6.FlatAppearance.BorderSize = 0;
            this.btnNum6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNum6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum6.Location = new System.Drawing.Point(330, 435);
            this.btnNum6.Margin = new System.Windows.Forms.Padding(2);
            this.btnNum6.Name = "btnNum6";
            this.btnNum6.Size = new System.Drawing.Size(103, 50);
            this.btnNum6.TabIndex = 68;
            this.btnNum6.Text = "6";
            this.btnNum6.UseVisualStyleBackColor = false;
            this.btnNum6.Click += new System.EventHandler(this.btnNum6_Click);
            // 
            // btnNum5
            // 
            this.btnNum5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNum5.FlatAppearance.BorderSize = 0;
            this.btnNum5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNum5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum5.Location = new System.Drawing.Point(222, 435);
            this.btnNum5.Margin = new System.Windows.Forms.Padding(2);
            this.btnNum5.Name = "btnNum5";
            this.btnNum5.Size = new System.Drawing.Size(103, 50);
            this.btnNum5.TabIndex = 67;
            this.btnNum5.Text = "5";
            this.btnNum5.UseVisualStyleBackColor = false;
            this.btnNum5.Click += new System.EventHandler(this.btnNum5_Click);
            // 
            // btnNum4
            // 
            this.btnNum4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNum4.FlatAppearance.BorderSize = 0;
            this.btnNum4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNum4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum4.Location = new System.Drawing.Point(115, 435);
            this.btnNum4.Margin = new System.Windows.Forms.Padding(2);
            this.btnNum4.Name = "btnNum4";
            this.btnNum4.Size = new System.Drawing.Size(103, 50);
            this.btnNum4.TabIndex = 66;
            this.btnNum4.Text = "4";
            this.btnNum4.UseVisualStyleBackColor = false;
            this.btnNum4.Click += new System.EventHandler(this.btnNum4_Click);
            // 
            // btnNum3
            // 
            this.btnNum3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNum3.FlatAppearance.BorderSize = 0;
            this.btnNum3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNum3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum3.Location = new System.Drawing.Point(330, 488);
            this.btnNum3.Margin = new System.Windows.Forms.Padding(2);
            this.btnNum3.Name = "btnNum3";
            this.btnNum3.Size = new System.Drawing.Size(103, 50);
            this.btnNum3.TabIndex = 65;
            this.btnNum3.Text = "3";
            this.btnNum3.UseVisualStyleBackColor = false;
            this.btnNum3.Click += new System.EventHandler(this.btnNum3_Click);
            // 
            // btnNum2
            // 
            this.btnNum2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNum2.FlatAppearance.BorderSize = 0;
            this.btnNum2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum2.Location = new System.Drawing.Point(222, 488);
            this.btnNum2.Margin = new System.Windows.Forms.Padding(2);
            this.btnNum2.Name = "btnNum2";
            this.btnNum2.Size = new System.Drawing.Size(103, 50);
            this.btnNum2.TabIndex = 64;
            this.btnNum2.Text = "2";
            this.btnNum2.UseVisualStyleBackColor = false;
            this.btnNum2.Click += new System.EventHandler(this.btnNum2_Click);
            // 
            // btnNum1
            // 
            this.btnNum1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNum1.FlatAppearance.BorderSize = 0;
            this.btnNum1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum1.Location = new System.Drawing.Point(115, 488);
            this.btnNum1.Margin = new System.Windows.Forms.Padding(2);
            this.btnNum1.Name = "btnNum1";
            this.btnNum1.Size = new System.Drawing.Size(103, 50);
            this.btnNum1.TabIndex = 63;
            this.btnNum1.Text = "1";
            this.btnNum1.UseVisualStyleBackColor = false;
            this.btnNum1.Click += new System.EventHandler(this.btnNum1_Click);
            // 
            // btn2nd
            // 
            this.btn2nd.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn2nd.Enabled = false;
            this.btn2nd.FlatAppearance.BorderSize = 0;
            this.btn2nd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2nd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2nd.Location = new System.Drawing.Point(8, 219);
            this.btn2nd.Margin = new System.Windows.Forms.Padding(2);
            this.btn2nd.Name = "btn2nd";
            this.btn2nd.Size = new System.Drawing.Size(103, 50);
            this.btn2nd.TabIndex = 94;
            this.btn2nd.Text = "2nd";
            this.btn2nd.UseVisualStyleBackColor = false;
            this.btn2nd.Click += new System.EventHandler(this.btn2nd_Click);
            // 
            // btnSqRoot
            // 
            this.btnSqRoot.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSqRoot.FlatAppearance.BorderSize = 0;
            this.btnSqRoot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSqRoot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSqRoot.Location = new System.Drawing.Point(8, 327);
            this.btnSqRoot.Margin = new System.Windows.Forms.Padding(2);
            this.btnSqRoot.Name = "btnSqRoot";
            this.btnSqRoot.Size = new System.Drawing.Size(103, 50);
            this.btnSqRoot.TabIndex = 93;
            this.btnSqRoot.Text = "²√x";
            this.btnSqRoot.UseVisualStyleBackColor = false;
            this.btnSqRoot.Click += new System.EventHandler(this.btnSqRoot_Click);
            // 
            // btnXtoY
            // 
            this.btnXtoY.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnXtoY.FlatAppearance.BorderSize = 0;
            this.btnXtoY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXtoY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXtoY.Location = new System.Drawing.Point(8, 382);
            this.btnXtoY.Margin = new System.Windows.Forms.Padding(2);
            this.btnXtoY.Name = "btnXtoY";
            this.btnXtoY.Size = new System.Drawing.Size(103, 50);
            this.btnXtoY.TabIndex = 96;
            this.btnXtoY.Text = "x^y";
            this.btnXtoY.UseVisualStyleBackColor = false;
            this.btnXtoY.Click += new System.EventHandler(this.btnXtoY_Click);
            // 
            // btn10toX
            // 
            this.btn10toX.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn10toX.FlatAppearance.BorderSize = 0;
            this.btn10toX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn10toX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn10toX.Location = new System.Drawing.Point(8, 436);
            this.btn10toX.Margin = new System.Windows.Forms.Padding(2);
            this.btn10toX.Name = "btn10toX";
            this.btn10toX.Size = new System.Drawing.Size(103, 50);
            this.btn10toX.TabIndex = 95;
            this.btn10toX.Text = "10^x";
            this.btn10toX.UseVisualStyleBackColor = false;
            this.btn10toX.Click += new System.EventHandler(this.btn10toX_Click);
            // 
            // btnLog
            // 
            this.btnLog.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnLog.FlatAppearance.BorderSize = 0;
            this.btnLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLog.Location = new System.Drawing.Point(8, 490);
            this.btnLog.Margin = new System.Windows.Forms.Padding(2);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(103, 50);
            this.btnLog.TabIndex = 98;
            this.btnLog.Text = "log";
            this.btnLog.UseVisualStyleBackColor = false;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // btnLn
            // 
            this.btnLn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnLn.FlatAppearance.BorderSize = 0;
            this.btnLn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLn.Location = new System.Drawing.Point(8, 544);
            this.btnLn.Margin = new System.Windows.Forms.Padding(2);
            this.btnLn.Name = "btnLn";
            this.btnLn.Size = new System.Drawing.Size(103, 50);
            this.btnLn.TabIndex = 97;
            this.btnLn.Text = "ln";
            this.btnLn.UseVisualStyleBackColor = false;
            this.btnLn.Click += new System.EventHandler(this.btnLn_Click);
            // 
            // btnSqaure
            // 
            this.btnSqaure.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSqaure.FlatAppearance.BorderSize = 0;
            this.btnSqaure.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSqaure.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSqaure.Location = new System.Drawing.Point(8, 273);
            this.btnSqaure.Margin = new System.Windows.Forms.Padding(2);
            this.btnSqaure.Name = "btnSqaure";
            this.btnSqaure.Size = new System.Drawing.Size(103, 50);
            this.btnSqaure.TabIndex = 103;
            this.btnSqaure.Text = "x²";
            this.btnSqaure.UseVisualStyleBackColor = false;
            this.btnSqaure.Click += new System.EventHandler(this.btnSqaure_Click);
            // 
            // btnMod
            // 
            this.btnMod.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnMod.FlatAppearance.BorderSize = 0;
            this.btnMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMod.Location = new System.Drawing.Point(437, 273);
            this.btnMod.Margin = new System.Windows.Forms.Padding(2);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(103, 50);
            this.btnMod.TabIndex = 102;
            this.btnMod.Text = "mod";
            this.btnMod.UseVisualStyleBackColor = false;
            this.btnMod.Click += new System.EventHandler(this.btnMod_Click);
            // 
            // btnExp
            // 
            this.btnExp.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnExp.FlatAppearance.BorderSize = 0;
            this.btnExp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExp.Location = new System.Drawing.Point(330, 273);
            this.btnExp.Margin = new System.Windows.Forms.Padding(2);
            this.btnExp.Name = "btnExp";
            this.btnExp.Size = new System.Drawing.Size(103, 50);
            this.btnExp.TabIndex = 101;
            this.btnExp.Text = "exp";
            this.btnExp.UseVisualStyleBackColor = false;
            this.btnExp.Click += new System.EventHandler(this.btnExp_Click);
            // 
            // btnModX
            // 
            this.btnModX.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnModX.FlatAppearance.BorderSize = 0;
            this.btnModX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModX.Location = new System.Drawing.Point(222, 273);
            this.btnModX.Margin = new System.Windows.Forms.Padding(2);
            this.btnModX.Name = "btnModX";
            this.btnModX.Size = new System.Drawing.Size(103, 50);
            this.btnModX.TabIndex = 100;
            this.btnModX.Text = "|x|";
            this.btnModX.UseVisualStyleBackColor = false;
            this.btnModX.Click += new System.EventHandler(this.btnModX_Click);
            // 
            // btnInverse
            // 
            this.btnInverse.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnInverse.FlatAppearance.BorderSize = 0;
            this.btnInverse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInverse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInverse.Location = new System.Drawing.Point(115, 273);
            this.btnInverse.Margin = new System.Windows.Forms.Padding(2);
            this.btnInverse.Name = "btnInverse";
            this.btnInverse.Size = new System.Drawing.Size(103, 50);
            this.btnInverse.TabIndex = 99;
            this.btnInverse.Text = "1/x";
            this.btnInverse.UseVisualStyleBackColor = false;
            this.btnInverse.Click += new System.EventHandler(this.btnInverse_Click);
            // 
            // frmScientificCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 603);
            this.Controls.Add(this.btnSqaure);
            this.Controls.Add(this.btnMod);
            this.Controls.Add(this.btnExp);
            this.Controls.Add(this.btnModX);
            this.Controls.Add(this.btnInverse);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.btnLn);
            this.Controls.Add(this.btnXtoY);
            this.Controls.Add(this.btn10toX);
            this.Controls.Add(this.btn2nd);
            this.Controls.Add(this.btnSqRoot);
            this.Controls.Add(this.btnM);
            this.Controls.Add(this.btnMS);
            this.Controls.Add(this.btnM_Minus);
            this.Controls.Add(this.btnM_Plus);
            this.Controls.Add(this.btnMR);
            this.Controls.Add(this.btnMC);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.btnFraction);
            this.Controls.Add(this.btnSign);
            this.Controls.Add(this.btnNum0);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnDivision);
            this.Controls.Add(this.btnBackspace);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btn_e);
            this.Controls.Add(this.btnPI);
            this.Controls.Add(this.btnFactorial);
            this.Controls.Add(this.btnClosePar);
            this.Controls.Add(this.btnOpenPar);
            this.Controls.Add(this.btnNum9);
            this.Controls.Add(this.btnNum8);
            this.Controls.Add(this.btnNum7);
            this.Controls.Add(this.btnNum6);
            this.Controls.Add(this.btnNum5);
            this.Controls.Add(this.btnNum4);
            this.Controls.Add(this.btnNum3);
            this.Controls.Add(this.btnNum2);
            this.Controls.Add(this.btnNum1);
            this.Controls.Add(this.lblPrimaryDisplay);
            this.Controls.Add(this.lblSecondaryDisplay);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(564, 650);
            this.MinimumSize = new System.Drawing.Size(564, 650);
            this.Name = "frmScientificCalculator";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.frmScientificCalculator_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmScientificCalculator_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrimaryDisplay;
        private System.Windows.Forms.Label lblSecondaryDisplay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnM;
        private System.Windows.Forms.Button btnMS;
        private System.Windows.Forms.Button btnM_Minus;
        private System.Windows.Forms.Button btnM_Plus;
        private System.Windows.Forms.Button btnMR;
        private System.Windows.Forms.Button btnMC;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btnFraction;
        private System.Windows.Forms.Button btnSign;
        private System.Windows.Forms.Button btnNum0;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.Button btnBackspace;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btn_e;
        private System.Windows.Forms.Button btnPI;
        private System.Windows.Forms.Button btnFactorial;
        private System.Windows.Forms.Button btnClosePar;
        private System.Windows.Forms.Button btnOpenPar;
        private System.Windows.Forms.Button btnNum9;
        private System.Windows.Forms.Button btnNum8;
        private System.Windows.Forms.Button btnNum7;
        private System.Windows.Forms.Button btnNum6;
        private System.Windows.Forms.Button btnNum5;
        private System.Windows.Forms.Button btnNum4;
        private System.Windows.Forms.Button btnNum3;
        private System.Windows.Forms.Button btnNum2;
        private System.Windows.Forms.Button btnNum1;
        private System.Windows.Forms.Button btn2nd;
        private System.Windows.Forms.Button btnSqRoot;
        private System.Windows.Forms.Button btnXtoY;
        private System.Windows.Forms.Button btn10toX;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Button btnLn;
        private System.Windows.Forms.Button btnSqaure;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.Button btnExp;
        private System.Windows.Forms.Button btnModX;
        private System.Windows.Forms.Button btnInverse;
    }
}