using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcApp
{
    public class FormatUtils
    {
        /// <summary>
        /// Update 2019/05/15
        /// Input Commas
        /// 100000.0000 -> 100,000.0000
        /// </summary>
        public string ResultFormat(string getResult)
        {
            if (String.IsNullOrEmpty(getResult))
            {
                return getResult = "0";
            }

            if(getResult.Length <= 2)
            {
                return getResult;
            }

            /// <summary>
            /// コンマの表示される桁を設定
            /// </summary>
            int digit = 3;

            /// <summary>
            /// 定数の長さ
            /// Length of Integer
            /// </summary>
            int integerLength;

            if (getResult.IndexOf(".") != -1)
            {
                integerLength = getResult.IndexOf(".");
            }
            else
            {
                integerLength = getResult.Length;
            }

            /// <summary>
            /// 表示されるコンマの数計算
            /// Counting Commas
            /// </summary>
            int commaCount = integerLength / digit;

            if (integerLength % digit == 0)
            {
                commaCount--;
            }
            else if (integerLength % digit <= 1 && getResult.IndexOf("-") == 0)
            {
                commaCount--;
            }

            if (commaCount > 0)
            {
                int index = integerLength - 3;

                while (commaCount > 0)
                {
                    getResult = getResult.Insert(index, ",");
                    index -= 3;
                    commaCount--;
                }
            }

            return getResult;
        }


        /// <summary>
        /// 数字の10桁が超過するとき出力
        /// </summary>
        public void ShowMessage()
        {
            MessageBox.Show("10桁までしか入力できません");
        }

    }
}
