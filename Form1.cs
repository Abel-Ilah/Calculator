using System;
using System.Drawing;
using System.Windows.Forms;



namespace Calculator_Project
{
    public partial class Calculator : Form
    {
        enum enOperationType { eSum = 1, eSubstr = 2, eMult = 3, eDiv = 4 }

        double Result = 0;
        double Num1 = 0;
        double Num2 = 0;

        bool IsFirstInput = true;
        bool IsNewCalcule=false;

        enOperationType OperationType = enOperationType.eSum;

        void GetNum1Value()
        {
            if (string.IsNullOrEmpty(TxtbScreen.Text)) return;
           
            if (IsFirstInput)
            {
                Num1 = Convert.ToDouble(TxtbScreen.Text);
                IsFirstInput = false;
                TxtbScreen.Clear();
                return;
            }
            
                switch (OperationType)
                {
                    case enOperationType.eSum:
                        Num1 = Num1 + Convert.ToDouble(TxtbScreen.Text);
                        break;
                    case enOperationType.eSubstr:
                        Num1 = Num1 - Convert.ToDouble(TxtbScreen.Text);
                        break;
                    case enOperationType.eMult:
                        Num1 = Num1 * Convert.ToDouble(TxtbScreen.Text);
                        break;
                    case enOperationType.eDiv:
                        if (Convert.ToDouble(TxtbScreen.Text) == 0)
                            TxtbScreen.Text = "Math Error!";
                        else
                            Num1 = Num1 / Convert.ToDouble(TxtbScreen.Text);
                        break;

                }
           
            TxtbScreen.Clear();
        }
        void CalculeResult()
        {

            switch (OperationType)
            {
                case enOperationType.eSum:
                    Result = Num1 + Num2;
                    break;
                case enOperationType.eSubstr:
                    Result = Num1 - Num2;
                    break;
                case enOperationType.eMult:
                    Result = Num1 * Num2;
                    break;
                case enOperationType.eDiv:
                    if (Num2 == 0)
                        TxtbScreen.Text = "Math Error!";
                    else
                        Result = Num1 / Num2;
                    break;

            }


        }

        void DisableSomeButtonsWhenResultIsMathError()
        {
            if (TxtbScreen.Text == "Math Error!" || TxtbScreen.Text == "-" || TxtbScreen.Text == "+")
            {
                btnSubs.Enabled = false;
                btnSum.Enabled = false;
                btnDiv.Enabled = false;
                btnMult.Enabled = false;
                btn10PowerX.Enabled = false;
                btn1DivByX.Enabled = false;
                btnSqrt.Enabled = false;

                if (TxtbScreen.Text == "Math Error!")
                {
                    btnNumberSign.Enabled = false;
                    btnBack.Enabled = false;
                }

                btnResult.Enabled = false;
                btnPower2.Enabled = false;
               
            }
            else
            {
                btnSubs.Enabled = true;
                btnSum.Enabled = true;
                btnDiv.Enabled = true;
                btnMult.Enabled = true;
                btn10PowerX.Enabled = true;
                btn1DivByX.Enabled = true;
                btnSqrt.Enabled = true;
                btnNumberSign.Enabled = true;
                btnResult.Enabled = true;
                btnPower2.Enabled = true;
                btnBack.Enabled = true;
            }
        }

        void PrintNumbersOnScreen(object sender, EventArgs e)
        {
            if (IsNewCalcule)
            {
                Result = 0;
                Num1 = 0;
                Num2 = 0;
                IsFirstInput=true;
                TxtbScreen.Clear();
                IsNewCalcule = false;
            }
      
            if (TxtbScreen.Text == "0")
                TxtbScreen.Text = ((Button)sender).Text;

            else TxtbScreen.Text += ((Button)sender).Text;

            if (TxtbScreen.Text == ".")
                TxtbScreen.Text = "0.";
        }

        public Calculator()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DisableSomeButtonsWhenResultIsMathError();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            Result = 0;
            TxtbScreen.Text = Result.ToString();
            Num1 = 0;
            Num2 = 0;
            IsFirstInput = true;

        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < TxtbScreen.TextLength; i++)
            {
                if (TxtbScreen.Text[i] == '.')
                    return;
            }
            PrintNumbersOnScreen(sender, e);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (TxtbScreen.Text == "") return; 
            TxtbScreen.Text = TxtbScreen.Text.Substring(0, TxtbScreen.TextLength - 1);
            if (IsNewCalcule)
            TxtbScreen.Clear();

            if (string.IsNullOrEmpty(TxtbScreen.Text))
            {
                TxtbScreen.Text = "0";
                return;
            }
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            if (IsNewCalcule) 
            {
                Result= Convert.ToDouble(TxtbScreen.Text);
                TxtbScreen.Text = Result.ToString();
                RtxtbHistory.Text += "Result = "+Result.ToString()+"\n";
                return;
            }
            

            IsNewCalcule = true;
            IsFirstInput = true;

            if (string.IsNullOrEmpty(TxtbScreen.Text) || TxtbScreen.Text == "+")
                Result = Num1;
            else if (TxtbScreen.Text=="-" )
                Result = Num1*(-1);
            else
            {
                Num2 = Convert.ToDouble(TxtbScreen.Text);
                if (Num2==0 && OperationType==enOperationType.eDiv)
                {
                    TxtbScreen.Text = "Math Error!";
                    return;
                }
                CalculeResult();
            }

            TxtbScreen.Text = Result.ToString();
            RtxtbHistory.Text += "Result = " + Result.ToString() + "\n";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TxtbScreen.Text = "0";

        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            IsNewCalcule = false;
            GetNum1Value();
            OperationType = enOperationType.eSum;
        }

        private void btnSubs_Click(object sender, EventArgs e)
        {
            IsNewCalcule = false;
            GetNum1Value();
            OperationType = enOperationType.eSubstr;

        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            IsNewCalcule = false;
            GetNum1Value();
            OperationType = enOperationType.eMult;

           
        }

        private void btnDiv_Click_1(object sender, EventArgs e)
        {
            IsNewCalcule = false;
            GetNum1Value();
            OperationType = enOperationType.eDiv;

            
        }

        private void btnNumberSign_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtbScreen.Text)||TxtbScreen.Text=="0")
            {  
                TxtbScreen.Text = "-";
                return;
            }
            if (TxtbScreen.Text=="-")
            {
                TxtbScreen.Text = "+";
                return;
            }
            if (TxtbScreen.Text == "+")
            {
                TxtbScreen.Text = "-";
                return;
            }
            if (TxtbScreen.Text == ".")
            {
                TxtbScreen.Text = "-0.";
                return;
            }
            double d = Convert.ToDouble(TxtbScreen.Text)*(-1);
            TxtbScreen.Text=d.ToString();
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtbScreen.Text)) return;

            if (Convert.ToDouble(TxtbScreen.Text) < 0)
            {
                TxtbScreen.Text = "Math Error!";
                IsNewCalcule = true;
                return;
            }

            else
                Result = Math.Sqrt(Convert.ToDouble(TxtbScreen.Text));

            RtxtbHistory.Text += $"√{Convert.ToDouble(TxtbScreen.Text)} = " + Result.ToString() + "\n";
            TxtbScreen.Text=Result.ToString();
            
            IsNewCalcule = true;

        }

        private void btnPower2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtbScreen.Text)) return;
           
            else
                Result = Math.Pow(Convert.ToDouble(TxtbScreen.Text),2);
            RtxtbHistory.Text += $"{Convert.ToDouble(TxtbScreen.Text)} ² = " + Result.ToString() + "\n";
            TxtbScreen.Text = Result.ToString();
            IsNewCalcule = true;
        }

        private void btn1DivByX_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtbScreen.Text)) return;
            if (TxtbScreen.Text == "0")
            {
                TxtbScreen.Text = "Math Error!";
                IsNewCalcule=true;
                return;
            }


            else
                Result = (double)1/(Convert.ToDouble(TxtbScreen.Text));
            RtxtbHistory.Text += $"1/{Convert.ToDouble(TxtbScreen.Text)} = " + Result.ToString() + "\n";
            TxtbScreen.Text = Result.ToString();
            IsNewCalcule = true;
        }

        private void btn10PowerX_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtbScreen.Text)) return;

            else
                Result = Math.Pow(10, Convert.ToDouble(TxtbScreen.Text));
            RtxtbHistory.Text += $"10^{Convert.ToDouble(TxtbScreen.Text)} = " + Result.ToString() + "\n";
            TxtbScreen.Text = Result.ToString();
            IsNewCalcule = true;
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            if (RtxtbHistory.Visible && lbDisign.Visible)
            {
                RtxtbHistory.Visible = false;
                lbDisign.Visible = false;
                btnClearHistory.Visible = false;
            }
            else
            {
                RtxtbHistory.Visible = true;
                lbDisign.Visible = true;
                btnClearHistory.Visible = true;
            }
        }

        private void btnClearHistory_Click(object sender, EventArgs e)
        {
            RtxtbHistory.Clear();
        }

        private void btnClearHistory_MouseEnter(object sender, EventArgs e)
        {
            btnClearHistory.Size = new System.Drawing.Size(46, 47);
        }

        private void btnClearHistory_MouseLeave(object sender, EventArgs e)
        {
            btnClearHistory.Size = new System.Drawing.Size(40, 41);
        }
    }
}
