namespace prjWinCsFinalProjectPart1
{
    partial class frmStandardCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStandardCalculator));
            this.label1 = new System.Windows.Forms.Label();
            this.lblSecondaryDisplay = new System.Windows.Forms.Label();
            this.lblPrimaryDisplay = new System.Windows.Forms.Label();
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
            this.btnCE = new System.Windows.Forms.Button();
            this.btnPercentage = new System.Windows.Forms.Button();
            this.btnSqRoot = new System.Windows.Forms.Button();
            this.btnSquare = new System.Windows.Forms.Button();
            this.btnInverse = new System.Windows.Forms.Button();
            this.btnNum9 = new System.Windows.Forms.Button();
            this.btnNum8 = new System.Windows.Forms.Button();
            this.btnNum7 = new System.Windows.Forms.Button();
            this.btnNum6 = new System.Windows.Forms.Button();
            this.btnNum5 = new System.Windows.Forms.Button();
            this.btnNum4 = new System.Windows.Forms.Button();
            this.btnNum3 = new System.Windows.Forms.Button();
            this.btnNum2 = new System.Windows.Forms.Button();
            this.btnNum1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Standard";
            // 
            // lblSecondaryDisplay
            // 
            this.lblSecondaryDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondaryDisplay.Location = new System.Drawing.Point(270, 28);
            this.lblSecondaryDisplay.Name = "lblSecondaryDisplay";
            this.lblSecondaryDisplay.Size = new System.Drawing.Size(164, 36);
            this.lblSecondaryDisplay.TabIndex = 1;
            this.lblSecondaryDisplay.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lblPrimaryDisplay
            // 
            this.lblPrimaryDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrimaryDisplay.Location = new System.Drawing.Point(12, 64);
            this.lblPrimaryDisplay.Name = "lblPrimaryDisplay";
            this.lblPrimaryDisplay.Size = new System.Drawing.Size(422, 67);
            this.lblPrimaryDisplay.TabIndex = 2;
            this.lblPrimaryDisplay.Text = "0";
            this.lblPrimaryDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnM
            // 
            this.btnM.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnM.FlatAppearance.BorderSize = 0;
            this.btnM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnM.Location = new System.Drawing.Point(370, 160);
            this.btnM.Margin = new System.Windows.Forms.Padding(2);
            this.btnM.Name = "btnM";
            this.btnM.Size = new System.Drawing.Size(67, 33);
            this.btnM.TabIndex = 62;
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
            this.btnMS.Location = new System.Drawing.Point(299, 159);
            this.btnMS.Margin = new System.Windows.Forms.Padding(2);
            this.btnMS.Name = "btnMS";
            this.btnMS.Size = new System.Drawing.Size(67, 34);
            this.btnMS.TabIndex = 61;
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
            this.btnM_Minus.Location = new System.Drawing.Point(227, 159);
            this.btnM_Minus.Margin = new System.Windows.Forms.Padding(2);
            this.btnM_Minus.Name = "btnM_Minus";
            this.btnM_Minus.Size = new System.Drawing.Size(67, 34);
            this.btnM_Minus.TabIndex = 60;
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
            this.btnM_Plus.Location = new System.Drawing.Point(155, 159);
            this.btnM_Plus.Margin = new System.Windows.Forms.Padding(2);
            this.btnM_Plus.Name = "btnM_Plus";
            this.btnM_Plus.Size = new System.Drawing.Size(67, 33);
            this.btnM_Plus.TabIndex = 59;
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
            this.btnMR.Location = new System.Drawing.Point(84, 159);
            this.btnMR.Margin = new System.Windows.Forms.Padding(2);
            this.btnMR.Name = "btnMR";
            this.btnMR.Size = new System.Drawing.Size(67, 33);
            this.btnMR.TabIndex = 58;
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
            this.btnMC.Location = new System.Drawing.Point(13, 159);
            this.btnMC.Margin = new System.Windows.Forms.Padding(2);
            this.btnMC.Name = "btnMC";
            this.btnMC.Size = new System.Drawing.Size(67, 33);
            this.btnMC.TabIndex = 57;
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
            this.btnEqual.Location = new System.Drawing.Point(334, 466);
            this.btnEqual.Margin = new System.Windows.Forms.Padding(2);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(103, 50);
            this.btnEqual.TabIndex = 56;
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
            this.btnFraction.Location = new System.Drawing.Point(227, 465);
            this.btnFraction.Margin = new System.Windows.Forms.Padding(2);
            this.btnFraction.Name = "btnFraction";
            this.btnFraction.Size = new System.Drawing.Size(103, 50);
            this.btnFraction.TabIndex = 55;
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
            this.btnSign.Location = new System.Drawing.Point(12, 465);
            this.btnSign.Margin = new System.Windows.Forms.Padding(2);
            this.btnSign.Name = "btnSign";
            this.btnSign.Size = new System.Drawing.Size(103, 50);
            this.btnSign.TabIndex = 54;
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
            this.btnNum0.Location = new System.Drawing.Point(119, 465);
            this.btnNum0.Margin = new System.Windows.Forms.Padding(2);
            this.btnNum0.Name = "btnNum0";
            this.btnNum0.Size = new System.Drawing.Size(103, 50);
            this.btnNum0.TabIndex = 53;
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
            this.btnAdd.Location = new System.Drawing.Point(334, 413);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(103, 50);
            this.btnAdd.TabIndex = 52;
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
            this.btnSub.Location = new System.Drawing.Point(334, 359);
            this.btnSub.Margin = new System.Windows.Forms.Padding(2);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(103, 50);
            this.btnSub.TabIndex = 51;
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
            this.btnMultiply.Location = new System.Drawing.Point(334, 305);
            this.btnMultiply.Margin = new System.Windows.Forms.Padding(2);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(103, 50);
            this.btnMultiply.TabIndex = 50;
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
            this.btnDivision.Location = new System.Drawing.Point(334, 250);
            this.btnDivision.Margin = new System.Windows.Forms.Padding(2);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(103, 50);
            this.btnDivision.TabIndex = 49;
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
            this.btnBackspace.Location = new System.Drawing.Point(334, 196);
            this.btnBackspace.Margin = new System.Windows.Forms.Padding(2);
            this.btnBackspace.Name = "btnBackspace";
            this.btnBackspace.Size = new System.Drawing.Size(103, 50);
            this.btnBackspace.TabIndex = 48;
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
            this.btnC.Location = new System.Drawing.Point(227, 196);
            this.btnC.Margin = new System.Windows.Forms.Padding(2);
            this.btnC.MaximumSize = new System.Drawing.Size(103, 50);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(103, 50);
            this.btnC.TabIndex = 47;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = false;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnCE
            // 
            this.btnCE.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnCE.FlatAppearance.BorderSize = 0;
            this.btnCE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCE.Location = new System.Drawing.Point(119, 196);
            this.btnCE.Margin = new System.Windows.Forms.Padding(2);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(103, 50);
            this.btnCE.TabIndex = 46;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = false;
            this.btnCE.Click += new System.EventHandler(this.btnCE_Click);
            // 
            // btnPercentage
            // 
            this.btnPercentage.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnPercentage.FlatAppearance.BorderSize = 0;
            this.btnPercentage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPercentage.Location = new System.Drawing.Point(12, 196);
            this.btnPercentage.Margin = new System.Windows.Forms.Padding(2);
            this.btnPercentage.Name = "btnPercentage";
            this.btnPercentage.Size = new System.Drawing.Size(103, 50);
            this.btnPercentage.TabIndex = 45;
            this.btnPercentage.Text = "%";
            this.btnPercentage.UseVisualStyleBackColor = false;
            this.btnPercentage.Click += new System.EventHandler(this.btnPercentage_Click);
            // 
            // btnSqRoot
            // 
            this.btnSqRoot.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSqRoot.FlatAppearance.BorderSize = 0;
            this.btnSqRoot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSqRoot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSqRoot.Location = new System.Drawing.Point(227, 250);
            this.btnSqRoot.Margin = new System.Windows.Forms.Padding(2);
            this.btnSqRoot.Name = "btnSqRoot";
            this.btnSqRoot.Size = new System.Drawing.Size(103, 50);
            this.btnSqRoot.TabIndex = 44;
            this.btnSqRoot.Text = "√x";
            this.btnSqRoot.UseVisualStyleBackColor = false;
            this.btnSqRoot.Click += new System.EventHandler(this.btnRoot_Click);
            // 
            // btnSquare
            // 
            this.btnSquare.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSquare.FlatAppearance.BorderSize = 0;
            this.btnSquare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSquare.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSquare.Location = new System.Drawing.Point(119, 250);
            this.btnSquare.Margin = new System.Windows.Forms.Padding(2);
            this.btnSquare.Name = "btnSquare";
            this.btnSquare.Size = new System.Drawing.Size(103, 50);
            this.btnSquare.TabIndex = 43;
            this.btnSquare.Text = "x²";
            this.btnSquare.UseVisualStyleBackColor = false;
            this.btnSquare.Click += new System.EventHandler(this.btnSquare_Click);
            // 
            // btnInverse
            // 
            this.btnInverse.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnInverse.FlatAppearance.BorderSize = 0;
            this.btnInverse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInverse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInverse.Location = new System.Drawing.Point(12, 250);
            this.btnInverse.Margin = new System.Windows.Forms.Padding(2);
            this.btnInverse.Name = "btnInverse";
            this.btnInverse.Size = new System.Drawing.Size(103, 50);
            this.btnInverse.TabIndex = 42;
            this.btnInverse.Text = "1/x";
            this.btnInverse.UseVisualStyleBackColor = false;
            this.btnInverse.Click += new System.EventHandler(this.btnInverse_Click);
            // 
            // btnNum9
            // 
            this.btnNum9.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNum9.FlatAppearance.BorderSize = 0;
            this.btnNum9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNum9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum9.Location = new System.Drawing.Point(227, 304);
            this.btnNum9.Margin = new System.Windows.Forms.Padding(2);
            this.btnNum9.Name = "btnNum9";
            this.btnNum9.Size = new System.Drawing.Size(103, 50);
            this.btnNum9.TabIndex = 41;
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
            this.btnNum8.Location = new System.Drawing.Point(119, 304);
            this.btnNum8.Margin = new System.Windows.Forms.Padding(2);
            this.btnNum8.Name = "btnNum8";
            this.btnNum8.Size = new System.Drawing.Size(103, 50);
            this.btnNum8.TabIndex = 40;
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
            this.btnNum7.Location = new System.Drawing.Point(12, 304);
            this.btnNum7.Margin = new System.Windows.Forms.Padding(2);
            this.btnNum7.Name = "btnNum7";
            this.btnNum7.Size = new System.Drawing.Size(103, 50);
            this.btnNum7.TabIndex = 39;
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
            this.btnNum6.Location = new System.Drawing.Point(227, 358);
            this.btnNum6.Margin = new System.Windows.Forms.Padding(2);
            this.btnNum6.Name = "btnNum6";
            this.btnNum6.Size = new System.Drawing.Size(103, 50);
            this.btnNum6.TabIndex = 38;
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
            this.btnNum5.Location = new System.Drawing.Point(119, 358);
            this.btnNum5.Margin = new System.Windows.Forms.Padding(2);
            this.btnNum5.Name = "btnNum5";
            this.btnNum5.Size = new System.Drawing.Size(103, 50);
            this.btnNum5.TabIndex = 37;
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
            this.btnNum4.Location = new System.Drawing.Point(12, 358);
            this.btnNum4.Margin = new System.Windows.Forms.Padding(2);
            this.btnNum4.Name = "btnNum4";
            this.btnNum4.Size = new System.Drawing.Size(103, 50);
            this.btnNum4.TabIndex = 36;
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
            this.btnNum3.Location = new System.Drawing.Point(227, 411);
            this.btnNum3.Margin = new System.Windows.Forms.Padding(2);
            this.btnNum3.Name = "btnNum3";
            this.btnNum3.Size = new System.Drawing.Size(103, 50);
            this.btnNum3.TabIndex = 35;
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
            this.btnNum2.Location = new System.Drawing.Point(119, 411);
            this.btnNum2.Margin = new System.Windows.Forms.Padding(2);
            this.btnNum2.Name = "btnNum2";
            this.btnNum2.Size = new System.Drawing.Size(103, 50);
            this.btnNum2.TabIndex = 34;
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
            this.btnNum1.Location = new System.Drawing.Point(12, 411);
            this.btnNum1.Margin = new System.Windows.Forms.Padding(2);
            this.btnNum1.Name = "btnNum1";
            this.btnNum1.Size = new System.Drawing.Size(103, 50);
            this.btnNum1.TabIndex = 33;
            this.btnNum1.Text = "1";
            this.btnNum1.UseVisualStyleBackColor = false;
            this.btnNum1.Click += new System.EventHandler(this.btnNum1_Click);
            // 
            // frmStandardCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 528);
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
            this.Controls.Add(this.btnCE);
            this.Controls.Add(this.btnPercentage);
            this.Controls.Add(this.btnSqRoot);
            this.Controls.Add(this.btnSquare);
            this.Controls.Add(this.btnInverse);
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
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(464, 575);
            this.MinimumSize = new System.Drawing.Size(464, 575);
            this.Name = "frmStandardCalculator";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.frmStandardCalculator_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmStandardCalculator_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmStandardCalculator_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSecondaryDisplay;
        private System.Windows.Forms.Label lblPrimaryDisplay;
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
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Button btnPercentage;
        private System.Windows.Forms.Button btnSqRoot;
        private System.Windows.Forms.Button btnSquare;
        private System.Windows.Forms.Button btnInverse;
        private System.Windows.Forms.Button btnNum9;
        private System.Windows.Forms.Button btnNum8;
        private System.Windows.Forms.Button btnNum7;
        private System.Windows.Forms.Button btnNum6;
        private System.Windows.Forms.Button btnNum5;
        private System.Windows.Forms.Button btnNum4;
        private System.Windows.Forms.Button btnNum3;
        private System.Windows.Forms.Button btnNum2;
        private System.Windows.Forms.Button btnNum1;
    }
}