namespace Calculator_Project
{
    partial class Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.TxtbScreen = new System.Windows.Forms.TextBox();
            this.btnNumberSign = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnPoint = new System.Windows.Forms.Button();
            this.btnResult = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnSum = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btnSubs = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnMult = new System.Windows.Forms.Button();
            this.btn1DivByX = new System.Windows.Forms.Button();
            this.btnPower2 = new System.Windows.Forms.Button();
            this.btnSqrt = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.RtxtbHistory = new System.Windows.Forms.RichTextBox();
            this.lbDisign = new System.Windows.Forms.Label();
            this.btnHistory = new System.Windows.Forms.Button();
            this.btnClearHistory = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btn10PowerX = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtbScreen
            // 
            this.TxtbScreen.BackColor = System.Drawing.Color.Black;
            this.TxtbScreen.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtbScreen.ForeColor = System.Drawing.Color.White;
            this.TxtbScreen.Location = new System.Drawing.Point(6, 55);
            this.TxtbScreen.Name = "TxtbScreen";
            this.TxtbScreen.ReadOnly = true;
            this.TxtbScreen.Size = new System.Drawing.Size(312, 40);
            this.TxtbScreen.TabIndex = 0;
            this.TxtbScreen.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnNumberSign
            // 
            this.btnNumberSign.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnNumberSign.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnNumberSign.FlatAppearance.BorderSize = 0;
            this.btnNumberSign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNumberSign.Font = new System.Drawing.Font("Rockwell Extra Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumberSign.ForeColor = System.Drawing.Color.White;
            this.btnNumberSign.Location = new System.Drawing.Point(6, 401);
            this.btnNumberSign.Name = "btnNumberSign";
            this.btnNumberSign.Size = new System.Drawing.Size(75, 50);
            this.btnNumberSign.TabIndex = 1;
            this.btnNumberSign.Text = "+/-";
            this.btnNumberSign.UseVisualStyleBackColor = false;
            this.btnNumberSign.Click += new System.EventHandler(this.btnNumberSign_Click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn0.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn0.FlatAppearance.BorderSize = 0;
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn0.Font = new System.Drawing.Font("Rockwell Extra Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.ForeColor = System.Drawing.Color.White;
            this.btn0.Location = new System.Drawing.Point(85, 401);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(75, 50);
            this.btn0.TabIndex = 1;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.PrintNumbersOnScreen);
            // 
            // btnPoint
            // 
            this.btnPoint.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnPoint.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPoint.FlatAppearance.BorderSize = 0;
            this.btnPoint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPoint.Font = new System.Drawing.Font("Rockwell Extra Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPoint.ForeColor = System.Drawing.Color.White;
            this.btnPoint.Location = new System.Drawing.Point(164, 401);
            this.btnPoint.Name = "btnPoint";
            this.btnPoint.Size = new System.Drawing.Size(75, 50);
            this.btnPoint.TabIndex = 1;
            this.btnPoint.Text = ".";
            this.btnPoint.UseVisualStyleBackColor = false;
            this.btnPoint.Click += new System.EventHandler(this.btnPoint_Click);
            // 
            // btnResult
            // 
            this.btnResult.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnResult.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnResult.FlatAppearance.BorderSize = 0;
            this.btnResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResult.Font = new System.Drawing.Font("Rockwell Extra Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResult.ForeColor = System.Drawing.Color.White;
            this.btnResult.Location = new System.Drawing.Point(243, 401);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(75, 50);
            this.btnResult.TabIndex = 1;
            this.btnResult.Text = "=";
            this.btnResult.UseVisualStyleBackColor = false;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn1.FlatAppearance.BorderSize = 0;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("Rockwell Extra Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.ForeColor = System.Drawing.Color.White;
            this.btn1.Location = new System.Drawing.Point(6, 347);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 50);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.PrintNumbersOnScreen);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn2.FlatAppearance.BorderSize = 0;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("Rockwell Extra Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.ForeColor = System.Drawing.Color.White;
            this.btn2.Location = new System.Drawing.Point(85, 347);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 50);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.PrintNumbersOnScreen);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn3.FlatAppearance.BorderSize = 0;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Font = new System.Drawing.Font("Rockwell Extra Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.ForeColor = System.Drawing.Color.White;
            this.btn3.Location = new System.Drawing.Point(164, 347);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(75, 50);
            this.btn3.TabIndex = 1;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.PrintNumbersOnScreen);
            // 
            // btnSum
            // 
            this.btnSum.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnSum.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSum.FlatAppearance.BorderSize = 0;
            this.btnSum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSum.Font = new System.Drawing.Font("Rockwell Extra Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSum.ForeColor = System.Drawing.Color.White;
            this.btnSum.Location = new System.Drawing.Point(243, 347);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(75, 50);
            this.btnSum.TabIndex = 1;
            this.btnSum.Text = "+";
            this.btnSum.UseVisualStyleBackColor = false;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn4.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn4.FlatAppearance.BorderSize = 0;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Font = new System.Drawing.Font("Rockwell Extra Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.ForeColor = System.Drawing.Color.White;
            this.btn4.Location = new System.Drawing.Point(6, 293);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(75, 50);
            this.btn4.TabIndex = 1;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.PrintNumbersOnScreen);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn5.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn5.FlatAppearance.BorderSize = 0;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Font = new System.Drawing.Font("Rockwell Extra Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.ForeColor = System.Drawing.Color.White;
            this.btn5.Location = new System.Drawing.Point(85, 293);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(75, 50);
            this.btn5.TabIndex = 1;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.PrintNumbersOnScreen);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn6.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn6.FlatAppearance.BorderSize = 0;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Font = new System.Drawing.Font("Rockwell Extra Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.ForeColor = System.Drawing.Color.White;
            this.btn6.Location = new System.Drawing.Point(164, 293);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(75, 50);
            this.btn6.TabIndex = 1;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.PrintNumbersOnScreen);
            // 
            // btnSubs
            // 
            this.btnSubs.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnSubs.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSubs.FlatAppearance.BorderSize = 0;
            this.btnSubs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubs.Font = new System.Drawing.Font("Rockwell Extra Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubs.ForeColor = System.Drawing.Color.White;
            this.btnSubs.Location = new System.Drawing.Point(243, 293);
            this.btnSubs.Name = "btnSubs";
            this.btnSubs.Size = new System.Drawing.Size(75, 50);
            this.btnSubs.TabIndex = 1;
            this.btnSubs.Text = "-";
            this.btnSubs.UseVisualStyleBackColor = false;
            this.btnSubs.Click += new System.EventHandler(this.btnSubs_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn7.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn7.FlatAppearance.BorderSize = 0;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.Font = new System.Drawing.Font("Rockwell Extra Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.ForeColor = System.Drawing.Color.White;
            this.btn7.Location = new System.Drawing.Point(6, 239);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(75, 50);
            this.btn7.TabIndex = 1;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.PrintNumbersOnScreen);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn8.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn8.FlatAppearance.BorderSize = 0;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.Font = new System.Drawing.Font("Rockwell Extra Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.ForeColor = System.Drawing.Color.White;
            this.btn8.Location = new System.Drawing.Point(85, 239);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(75, 50);
            this.btn8.TabIndex = 1;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.PrintNumbersOnScreen);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn9.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn9.FlatAppearance.BorderSize = 0;
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn9.Font = new System.Drawing.Font("Rockwell Extra Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.ForeColor = System.Drawing.Color.White;
            this.btn9.Location = new System.Drawing.Point(164, 239);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(75, 50);
            this.btn9.TabIndex = 1;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.PrintNumbersOnScreen);
            // 
            // btnMult
            // 
            this.btnMult.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnMult.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnMult.FlatAppearance.BorderSize = 0;
            this.btnMult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMult.Font = new System.Drawing.Font("Rockwell Extra Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMult.ForeColor = System.Drawing.Color.White;
            this.btnMult.Location = new System.Drawing.Point(243, 239);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(75, 50);
            this.btnMult.TabIndex = 1;
            this.btnMult.Text = "x";
            this.btnMult.UseVisualStyleBackColor = false;
            this.btnMult.Click += new System.EventHandler(this.btnMult_Click);
            // 
            // btn1DivByX
            // 
            this.btn1DivByX.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn1DivByX.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn1DivByX.FlatAppearance.BorderSize = 0;
            this.btn1DivByX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1DivByX.Font = new System.Drawing.Font("Rockwell Extra Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1DivByX.ForeColor = System.Drawing.Color.White;
            this.btn1DivByX.Location = new System.Drawing.Point(6, 185);
            this.btn1DivByX.Name = "btn1DivByX";
            this.btn1DivByX.Size = new System.Drawing.Size(75, 50);
            this.btn1DivByX.TabIndex = 1;
            this.btn1DivByX.Text = "1/x";
            this.btn1DivByX.UseVisualStyleBackColor = false;
            this.btn1DivByX.Click += new System.EventHandler(this.btn1DivByX_Click);
            // 
            // btnPower2
            // 
            this.btnPower2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnPower2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPower2.FlatAppearance.BorderSize = 0;
            this.btnPower2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPower2.Font = new System.Drawing.Font("Rockwell Extra Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPower2.ForeColor = System.Drawing.Color.White;
            this.btnPower2.Location = new System.Drawing.Point(85, 185);
            this.btnPower2.Name = "btnPower2";
            this.btnPower2.Size = new System.Drawing.Size(75, 50);
            this.btnPower2.TabIndex = 1;
            this.btnPower2.Text = "x²";
            this.btnPower2.UseVisualStyleBackColor = false;
            this.btnPower2.Click += new System.EventHandler(this.btnPower2_Click);
            // 
            // btnSqrt
            // 
            this.btnSqrt.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnSqrt.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSqrt.FlatAppearance.BorderSize = 0;
            this.btnSqrt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSqrt.Font = new System.Drawing.Font("Rockwell Extra Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSqrt.ForeColor = System.Drawing.Color.White;
            this.btnSqrt.Location = new System.Drawing.Point(164, 185);
            this.btnSqrt.Name = "btnSqrt";
            this.btnSqrt.Size = new System.Drawing.Size(75, 50);
            this.btnSqrt.TabIndex = 1;
            this.btnSqrt.Text = "√ ̅x";
            this.btnSqrt.UseVisualStyleBackColor = false;
            this.btnSqrt.Click += new System.EventHandler(this.btnSqrt_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnDiv.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDiv.FlatAppearance.BorderSize = 0;
            this.btnDiv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiv.Font = new System.Drawing.Font("Rockwell Extra Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiv.ForeColor = System.Drawing.Color.White;
            this.btnDiv.Location = new System.Drawing.Point(243, 185);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(75, 50);
            this.btnDiv.TabIndex = 1;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = false;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click_1);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Rockwell Extra Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(164, 131);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 50);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(6, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 121);
            this.label1.TabIndex = 2;
            // 
            // RtxtbHistory
            // 
            this.RtxtbHistory.BackColor = System.Drawing.Color.White;
            this.RtxtbHistory.Font = new System.Drawing.Font("Rockwell Extra Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RtxtbHistory.Location = new System.Drawing.Point(6, 184);
            this.RtxtbHistory.Name = "RtxtbHistory";
            this.RtxtbHistory.ReadOnly = true;
            this.RtxtbHistory.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.RtxtbHistory.Size = new System.Drawing.Size(312, 267);
            this.RtxtbHistory.TabIndex = 3;
            this.RtxtbHistory.Text = "";
            this.RtxtbHistory.Visible = false;
            // 
            // lbDisign
            // 
            this.lbDisign.BackColor = System.Drawing.Color.Lime;
            this.lbDisign.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbDisign.Font = new System.Drawing.Font("Ravie", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDisign.ForeColor = System.Drawing.Color.Black;
            this.lbDisign.Location = new System.Drawing.Point(49, 131);
            this.lbDisign.Name = "lbDisign";
            this.lbDisign.Size = new System.Drawing.Size(269, 50);
            this.lbDisign.TabIndex = 4;
            this.lbDisign.Text = "History";
            this.lbDisign.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbDisign.Visible = false;
            // 
            // btnHistory
            // 
            this.btnHistory.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnHistory.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHistory.BackgroundImage")));
            this.btnHistory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHistory.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnHistory.FlatAppearance.BorderSize = 0;
            this.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistory.Font = new System.Drawing.Font("Rockwell Extra Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistory.ForeColor = System.Drawing.Color.White;
            this.btnHistory.Location = new System.Drawing.Point(6, 131);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(75, 50);
            this.btnHistory.TabIndex = 1;
            this.btnHistory.UseVisualStyleBackColor = false;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnClearHistory
            // 
            this.btnClearHistory.BackColor = System.Drawing.Color.Lime;
            this.btnClearHistory.BackgroundImage = global::Calculator_Project.Properties.Resources.recycle_bin_png;
            this.btnClearHistory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClearHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearHistory.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnClearHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearHistory.Location = new System.Drawing.Point(270, 133);
            this.btnClearHistory.Name = "btnClearHistory";
            this.btnClearHistory.Size = new System.Drawing.Size(40, 41);
            this.btnClearHistory.TabIndex = 5;
            this.btnClearHistory.UseVisualStyleBackColor = false;
            this.btnClearHistory.Visible = false;
            this.btnClearHistory.Click += new System.EventHandler(this.btnClearHistory_Click);
            this.btnClearHistory.MouseEnter += new System.EventHandler(this.btnClearHistory_MouseEnter);
            this.btnClearHistory.MouseLeave += new System.EventHandler(this.btnClearHistory_MouseLeave);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Rockwell Extra Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(243, 131);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 50);
            this.btnBack.TabIndex = 1;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btn10PowerX
            // 
            this.btn10PowerX.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn10PowerX.BackgroundImage = global::Calculator_Project.Properties.Resources._10_x;
            this.btn10PowerX.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn10PowerX.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn10PowerX.FlatAppearance.BorderSize = 0;
            this.btn10PowerX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn10PowerX.Font = new System.Drawing.Font("Rockwell Extra Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn10PowerX.ForeColor = System.Drawing.Color.White;
            this.btn10PowerX.Location = new System.Drawing.Point(85, 131);
            this.btn10PowerX.Name = "btn10PowerX";
            this.btn10PowerX.Size = new System.Drawing.Size(75, 50);
            this.btn10PowerX.TabIndex = 1;
            this.btn10PowerX.UseVisualStyleBackColor = false;
            this.btn10PowerX.Click += new System.EventHandler(this.btn10PowerX_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Font = new System.Drawing.Font("Ravie", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(9, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(309, 44);
            this.label2.TabIndex = 6;
            this.label2.Text = "Calculator";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(323, 455);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClearHistory);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.RtxtbHistory);
            this.Controls.Add(this.lbDisign);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnSqrt);
            this.Controls.Add(this.btnMult);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btnSubs);
            this.Controls.Add(this.btn10PowerX);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btnPower2);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn1DivByX);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnPoint);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnNumberSign);
            this.Controls.Add(this.TxtbScreen);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtbScreen;
        private System.Windows.Forms.Button btnNumberSign;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnPoint;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btnSubs;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnMult;
        private System.Windows.Forms.Button btn1DivByX;
        private System.Windows.Forms.Button btnPower2;
        private System.Windows.Forms.Button btnSqrt;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Button btn10PowerX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox RtxtbHistory;
        private System.Windows.Forms.Label lbDisign;
        private System.Windows.Forms.Button btnClearHistory;
        private System.Windows.Forms.Label label2;
    }
}

