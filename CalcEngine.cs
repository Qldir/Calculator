﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CalcApp
{


    public class CalcEngine
    {
        #region fields

        private string input;            //Display Number
        private decimal recentResult;    //Last Displayed Number
        private string lastInput;        //Last Input Number
        public string operation;        //Current operator
        private string sign;             //Sign of Number
        public bool isDecimal;           //Decimal status
        public bool isWait;              //Wait for new input after a number
        public bool isError;             //Error status
        public bool isGrandTotal;        //GrandTotal status
        public bool isMemory;            //Memory status
        public int countDigit;           //Count of Digit

        public static readonly int MaxDigit = 10;     //Max Digit 10

        #endregion


        /// <summary>
        /// Init CalcEngine
        /// </summary>
        public CalcEngine()
        {
            input = String.Empty;
            recentResult = 0;
            lastInput = String.Empty;
            operation = String.Empty;
            sign = "+";
            isDecimal = false;
            isWait = false;
            isError = false;
            isGrandTotal = false;
            isMemory = false;
        }


        /// <summary>
        /// Reset All Variables
        /// Event Method : ClickAllClearButton
        /// </summary>
        public void ClearAll()
        {
            input = String.Empty;
            recentResult = 0;
            lastInput = String.Empty;
            operation = String.Empty;
            sign = "+";
            isDecimal = false;
            isWait = false;
            countDigit = 0;
            isError = false;
            isGrandTotal = false;
            isMemory = false;
        }


        public void Clear()
        {
            input = String.Empty;
            sign = "+";
            isDecimal = false;
            isWait = false;
            isError = false;
            countDigit = 0;
        }


        /// <summary>
        /// AppendNum "0~9"
        /// Event Method : ClickNumButton
        /// 初めて入力が'0'であることを除外
        /// </summary>
        /// <param name="numValue">Double Type</param>
        public void AppendNum(double numValue)
        {
            PrepareAppend();

            if (String.IsNullOrEmpty(input))
            {
                input = "" + numValue;
                return;
            }

            if(IsZeroValue())
            {
                return;
            }

            input += "" + numValue;

        }


        /// <summary>
        /// AppendNum 00
        /// Event Method : ClickNumButton
        /// 初めて入力が0であることを除外
        /// "00"の場合Int刑変換を通じて'0'でチェック
        /// </summary>
        /// <param name="numValue">Input Number Value</param>arithmetic
        public void AppendNum(string numValue)
        {
            PrepareAppend();

            if(String.IsNullOrEmpty(input)){
                input = "0";
                return;
            }

            if (IsZeroValue())
            {
                return;
            }

            input += numValue;
        }


        /// <summary>
        /// Check if input is zero.
        /// </summary>
        private bool IsZeroValue()
        {
            return !isDecimal && Convert.ToDecimal(input) == 0;
        }


        /// <summary>
        /// Append Decimal
        /// Event Method : ClickDecimalButton
        /// isDecimal == true  -> return
        /// input == String.Empty -> 0.####
        /// </summary>
        public void AppendDecimal()
        {
            PrepareAppend();

            if (isDecimal)
            {
                return;
            }

            if (String.IsNullOrEmpty(input))
            {
                input = "0.";
                isDecimal = true;
                return;
            }

            input += ".";
            isDecimal = true;
        }


        /// <summary>
        /// Check if new input state
        /// 新しい入力を受ける状況なのか確認してclear
        /// </summary>
        private void PrepareAppend()
        {
            if (operation.Equals("="))
            {
                ClearAll();
                return;
            }

            if (isWait)
            {
                Clear();
                return;
            }

        }


        /// <summary>
        /// Calculate
        /// Event Method : ClickOperatorButton
        /// 基本演算(+, -, *, /)を処理するメソッド
        /// ÷,×, -, +
        /// </summary>
        /// <param name="operatorType">演算(+, -, *, /)タイプ</param>
        public void Calculate(string operatorType)
        {

            if (!IsPrepareCalculate(operatorType))
            {
                return;
            }

            //Arithmetic Operation
            CalculateOperation(operatorType);

            lastInput = input;
            isWait = true;
        }


        private bool IsPrepareCalculate(string operatorType)
        {
            if (isWait)
            {
                operation = operatorType;
                return false;
            }

            if (String.IsNullOrEmpty(input))
            {
                input = "0";
            }

            if (String.IsNullOrEmpty(lastInput))
            {
                ApplyDecimalPattern();
                lastInput = input;
                isWait = true;
                operation = operatorType;

                return false;
            }

            return true;
        }


        /// <summary>
        /// Arithmetic Operation
        /// 基本演算(+, -, *, /)を処理するメソッド
        /// </summary>
        private void CalculateOperation(string operatorType)
        {
            switch (operation)
            {
                case "+":
                    PrepareOperation();
                    recentResult = Convert.ToDecimal(lastInput) + Convert.ToDecimal(input);
                    break;
                case "-":
                    PrepareOperation();
                    recentResult = Convert.ToDecimal(lastInput) - Convert.ToDecimal(input);
                    break;
                case "×":
                    recentResult = Convert.ToDecimal(lastInput) * Convert.ToDecimal(input);
                    break;
                case "÷":
                    if (Convert.ToDecimal(input) == 0)
                    {
                        recentResult = 0;
                        isError = true;
                        break;
                    }
                    recentResult = Convert.ToDecimal(lastInput) / Convert.ToDecimal(input);
                    break;
            }

            if (recentResult < 0)
            {
                sign = "-";
            }

            operation = operatorType;

            input = Convert.ToString(recentResult);

            //input小数点フォーマット適用
            ApplyDecimalPattern();
        }


        /// <summary>
        /// Check the values to calculate
        /// +- 演算前に桁超過を防止する切り捨て処理
        /// 演算される二つの値の一番長い整数桁と、小数点以下桁を加えて
        /// 10桁を超過する場合は長い小数点を持った数の桁を切り捨てる
        /// 例 : 10-0.000000001   ->    10-0.00000000
        /// </summary>
        private void PrepareOperation()
        {
            int integerLength;
            int decimalLength;
            int totalLength;
            int deleteLength;

            //  numA : 1
            //  numB : 0
            int deleteTarget = 0;


            integerLength =
                CheckIntegerLength(lastInput) >= CheckIntegerLength(input)
                ? CheckIntegerLength(lastInput) : CheckIntegerLength(input);

            if (CheckDecimalLength(lastInput) >= CheckDecimalLength(input))
            {
                decimalLength = CheckDecimalLength(lastInput);
                deleteTarget = 1;
            }
            else
            {
                decimalLength = CheckDecimalLength(input);
            }

            totalLength = integerLength + decimalLength;

            if (totalLength > 10)
            {
                deleteLength = totalLength - 10;

                if (deleteTarget == 1)
                {
                    lastInput = lastInput.Remove(lastInput.Length - 1, 1);
                }
                else
                {
                    input = input.Remove(input.Length - 1, 1);
                }
            }
        }


        private int CheckIntegerLength(string number)
        {
            number = number.Replace("-", "");

            bool isDecimalCheck = (number.IndexOf(".") != -1);

            if (isDecimalCheck)
            {
                return number.IndexOf(".");
            }

            return number.Length;
        }

        private int CheckDecimalLength(string number)
        {
            int decimalLength = 0;

            bool isDecimalCheck = (number.IndexOf(".") != -1);

            if (isDecimalCheck)
            {
                decimalLength = number.Length - (number.IndexOf(".") + 1);
            }

            return decimalLength;
        }


        

        //TODO: GT機能追加
        /// <summary>
        /// Equal Operation
        /// Event Method : ClickEqualButton
        /// </summary>
        public void Solve()
        {
            lastInput = String.Empty;
            isWait = false;
        }


        /// <summary>
        /// Switch Sign +-
        /// Event Method : ClickSignButton
        /// </summary>
        public void SwitchSign()
        {
            if (String.IsNullOrEmpty(input))
            {
                return;
            }

            if (sign.Equals("+"))
            {
                sign = "-";
                input = sign + input;
            }
            else
            {
                if (sign.Equals("-"))
                {
                    input = input.Remove(0, 1);
                }
                sign = "+";
            }
        }


        /// <summary>
        /// Remove Digit
        /// Event Method : ClickBackButton
        /// - One digit delete
        /// </summary>
        public void RemoveDigit()
        {
            if (String.IsNullOrEmpty(input))
            {
                return;
            }

            //(input.Length <= 1) || (input.Length == 2 && sign.Equals("-")) || (input.Equals("0."))
            if (IsRemoveDigit())
            {
                input = String.Empty;
                isDecimal = false;
                sign = "+";

                return;
            }

            //削除する文字数
            int removeCount = 1;

            //BackSpace when the last digit is "."
            if (input.Substring(input.Length - 1).Equals("."))
            {
                isDecimal = false;
                removeCount++;
            }

            input = input.Remove(input.Length - removeCount, removeCount);
        }


        private bool IsRemoveDigit()
        {
            return (input.Length <= 1) || (input.Length == 2 && sign.Equals("-")) || (input.Equals("0."));
        }


        /// <summary>
        /// IsMaxInput
        /// 入力された数字の長さをチェックして
        /// 現在の数字長さを保存。
        /// string入力値で数字を析出
        /// </summary>
        /// <returns>設定した最大長さになるとbool値trueで変換</returns>
        public bool IsMaxInput()
        {
            bool isMax = false;


            if (String.IsNullOrEmpty(input) || isWait || operation.Equals("="))
            {
                return isMax;
            }

            ///<summary>
            ///Extracting Number
            ///Regex.Replace(string input, string pattern, string replacement);
            ///Replace pattern(@"\D") is [^0-9]
            ///正規表現を利用して数字以外の文字を変換
            ///例 : -123.441  ->  123441
            ///</summary>
            string extractNumber = Regex.Replace(input, @"\D", "");

            countDigit = extractNumber.Length;

            if (countDigit >= MaxDigit)
            {
                isMax = true;
            }

            return isMax;
        }//isMaxInput()


        public string GetOperation()
        {
            return operation;
        }


        /// <summary>
        /// Limit the number of digits
        /// 出力値の桁を10文字まで限る
        /// 0.123 + 12345678 = 12345678.12
        /// 0.000000001 X 0.5 = 0
        /// </summary>
        private string LimitDigit(string resultNumber)
        {
            string extractNumber = Regex.Replace(resultNumber, @"\D", "");

            if (extractNumber.Length <= MaxDigit)
            {
                return resultNumber;
            }

            int maxLength = MaxDigit;

            if (sign.Equals("-") || resultNumber.IndexOf(".") != -1)
            {
                maxLength++;
            }

            if (resultNumber.IndexOf(".") == 10)
            {
                maxLength--;
            }

            input = resultNumber.Substring(0, maxLength);

            // 小数点があるときだけ表示
            ApplyDecimalPattern();

            lastInput = input;

            return input;
        }


        /// <summary>
        /// 演算結果に適用
        /// 小数点があるときだけ表示
        /// </summary>
        private void ApplyDecimalPattern()
        {
            if(input.IndexOf(".") == -1)
            {
                return;
            }

            while ((input.IndexOf(".") != -1) && (input.LastIndexOf("0") == input.Length - 1))
            {
                RemoveDigit();
            }

            if (input.IndexOf(".") == input.Length - 1)
            {
                input = input.Remove(input.Length - 1, 1);
            }
        }


        /// <summary>
        /// 現在の入力された値をreturn
        /// </summary>
        public string GetResult()
        {
            return LimitDigit(input);
        }

    }
}
