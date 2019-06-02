using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcApp
{
    public partial class BasicCalcForm : Form
    {
        CalcEngine calcEngine;
        FormatUtils formatUtils;

        public BasicCalcForm()
        {
            InitializeComponent();
            calcEngine = new CalcEngine();
            formatUtils = new FormatUtils();
        }


        //Key Pressed Event
        private void GetKeyPress(object sender, KeyPressEventArgs e)
        {
            btnEqual.Focus();

            switch (e.KeyChar.ToString())
            {
                case "0":
                    btn0.PerformClick();
                    break;
                case "1":
                    btn1.PerformClick();
                    break;
                case "2":
                    btn2.PerformClick();
                    break;
                case "3":
                    btn3.PerformClick();
                    break;
                case "4":
                    btn4.PerformClick();
                    break;
                case "5":
                    btn5.PerformClick();
                    break;
                case "6":
                    btn6.PerformClick();
                    break;
                case "7":
                    btn7.PerformClick();
                    break;
                case "8":
                    btn8.PerformClick();
                    break;
                case "9":
                    btn9.PerformClick();
                    break;
                case "+":
                    btnPlus.PerformClick();
                    break;
                case "-":
                    btnMns.PerformClick();
                    break;
                case "*":
                    btnMul.PerformClick();
                    break;
                case "/":
                    btnDiv.PerformClick();
                    break;
                case "=":
                    btnEqual.PerformClick();
                    break;
                case "\b":
                    btnBack.PerformClick();
                    break;
                case ".":
                    btnDecimal.PerformClick();
                    break;
                default:
                    break;
            }
        }//GetKeyPress()


        /// <summary>
        /// [0~9], [00] Number Button Click
        /// 
        /// </summary>
        private void ClickNumButton(object sender, EventArgs e)
        {

            //Sender Type Check
            if (sender is Button)
            {
                Button numButton = sender as Button;
                int numValue;

                //MaxInput Check
                //9桁で"00"入力時に"0"入力
                if (IsMaxInput(numButton.Name))
                {
                    if (calcEngine.countDigit == 9 && numButton.Name.Equals("btn00"))
                    {
                        btn0.PerformClick();
                        return;
                    }

                    formatUtils.ShowMessage();
                    return;
                }

                switch (numButton.Name)
                {
                    case "btn1":
                        numValue = 1;
                        break;
                    case "btn2":
                        numValue = 2;
                        break;
                    case "btn3":
                        numValue = 3;
                        break;
                    case "btn4":
                        numValue = 4;
                        break;
                    case "btn5":
                        numValue = 5;
                        break;
                    case "btn6":
                        numValue = 6;
                        break;
                    case "btn7":
                        numValue = 7;
                        break;
                    case "btn8":
                        numValue = 8;
                        break;
                    case "btn9":
                        numValue = 9;
                        break;
                    case "btn00":
                        calcEngine.AppendNum("00");
                        UpdateResult();
                        return;
                    default:
                        numValue = 0;
                        break;
                }

                calcEngine.AppendNum(numValue);
                UpdateResult();

            }
        }//ClickNumButton()


        /// <summary>
        /// Operator Button Click
        /// 基本演算(+, -, *, /)を処理
        /// </summary>
        private void ClickOperatorButton(object sender, EventArgs e)
        {
            Button button = sender as Button;

            calcEngine.Calculate(button.Text);
            UpdateResult();
        }


        /// <summary>
        /// Equal Button Click
        /// </summary>
        private void ClickEqualbutton(object sender, EventArgs e)
        {
            Button button = sender as Button;

            calcEngine.Calculate(button.Text);
            calcEngine.Solve();
            UpdateResult();
        }


        /// <summary>
        /// Append Decimal
        /// </summary>
        private void ClickDecimalButton(object sender, EventArgs e)
        {
            Button button = sender as Button;

            //MaxInput Check
            if (IsMaxInput(button.Name))
            {
                formatUtils.ShowMessage();
                return;
            }

            if (!calcEngine.isDecimal)
            {
                calcEngine.AppendDecimal();
                UpdateResult();
                return;
            }

            calcEngine.AppendDecimal();
            UpdateResult();
        }


        /// <summary>
        /// Switch Sign +-
        /// </summary>
        private void ClickSignButton(object sender, EventArgs e)
        {
            calcEngine.SwitchSign();
            UpdateResult();
        }


        /// <summary>
        /// Click ▶ Button (BackSpace)
        /// </summary>
        private void ClickBackButton(object sender, EventArgs e)
        {
            calcEngine.RemoveDigit();
            UpdateResult();
        }


        /// <summary>
        /// Click AC button
        /// </summary>
        private void ClickAllClearButton(object sender, EventArgs e)
        {
            pnlBtn.Enabled = true;
            calcEngine.ClearAll();
            UpdateResult();
        }

        /// <summary>
        /// Click C Button
        /// </summary>
        private void ClickClearButton(object sender, EventArgs e)
        {
            if (calcEngine.isError)
            {
                pnlBtn.Enabled = true;
            }

            if (calcEngine.isWait)
            {
                calcEngine.ClearAll();
            }
            else
            {
                calcEngine.Clear();
            }

            UpdateResult();
        }

 
        // TxtResult, Label Update Function
        private void UpdateResult()
        {
            txtResult.Text = formatUtils.ResultFormat(calcEngine.GetResult());

            UpdateLabelText();
        }


        /// <summary>
        /// Label Text Update
        /// GT, M, E 表示
        /// </summary>
        private void UpdateLabelText()
        {
            if (calcEngine.operation.Equals("="))
            {
                lblOperator.Text = String.Empty;
            }
            else
            {
                lblOperator.Text = calcEngine.operation;
            }

            if (calcEngine.isError)
            {
                lblError.Text = "E";
                pnlBtn.Enabled = false;
            }
            else
            {
                lblError.Text = String.Empty;
            }
        }


        /// <summary>
        /// 数字が入力されると、10桁が超過するかをチェックして
        /// メッセージ表示
        /// </summary>
        /// <param name="btnName">Button Name</param>
        private bool IsMaxInput(string btnName)
        {
            bool isMax = false;

            if (calcEngine.IsMaxInput())
            {
                isMax = true;
            }
            else if (calcEngine.countDigit == 9 && btnName.Equals("btn00"))
            {
                isMax = true;
            }

            return isMax;
        }

    }
}
