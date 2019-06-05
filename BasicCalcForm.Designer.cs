namespace CalcApp
{
    partial class BasicCalcForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BasicCalcForm));
            this.txtResult = new System.Windows.Forms.RichTextBox();
            this.btnMemClear = new System.Windows.Forms.Button();
            this.btnMemRead = new System.Windows.Forms.Button();
            this.btnIncludedTax = new System.Windows.Forms.Button();
            this.btnMemAdd = new System.Windows.Forms.Button();
            this.btnMemSubtract = new System.Windows.Forms.Button();
            this.btnGrandTotal = new System.Windows.Forms.Button();
            this.btnSign = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAllClear = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnPercent = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btnExcludedTax = new System.Windows.Forms.Button();
            this.btnMul = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btnMns = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnDecimal = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.lblOperator = new System.Windows.Forms.Label();
            this.btn00 = new System.Windows.Forms.Button();
            this.pnlBackGround = new System.Windows.Forms.Panel();
            this.lblMemory = new System.Windows.Forms.Label();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.lblOnText = new System.Windows.Forms.Label();
            this.pnlBtn = new System.Windows.Forms.Panel();
            this.pnlClear = new System.Windows.Forms.Panel();
            this.pnlBackGround.SuspendLayout();
            this.pnlBtn.SuspendLayout();
            this.pnlClear.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtResult
            // 
            this.txtResult.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.txtResult, "txtResult");
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            // 
            // btnMemClear
            // 
            this.btnMemClear.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnMemClear.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnMemClear, "btnMemClear");
            this.btnMemClear.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMemClear.Name = "btnMemClear";
            this.btnMemClear.UseVisualStyleBackColor = false;
            this.btnMemClear.Click += new System.EventHandler(this.ClickMemoryButton);
            // 
            // btnMemRead
            // 
            this.btnMemRead.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnMemRead.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnMemRead, "btnMemRead");
            this.btnMemRead.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMemRead.Name = "btnMemRead";
            this.btnMemRead.UseVisualStyleBackColor = false;
            this.btnMemRead.Click += new System.EventHandler(this.ClickMemoryButton);
            // 
            // btnIncludedTax
            // 
            this.btnIncludedTax.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnIncludedTax.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnIncludedTax, "btnIncludedTax");
            this.btnIncludedTax.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnIncludedTax.Name = "btnIncludedTax";
            this.btnIncludedTax.UseVisualStyleBackColor = false;
            // 
            // btnMemAdd
            // 
            this.btnMemAdd.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnMemAdd.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnMemAdd, "btnMemAdd");
            this.btnMemAdd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMemAdd.Name = "btnMemAdd";
            this.btnMemAdd.UseVisualStyleBackColor = false;
            this.btnMemAdd.Click += new System.EventHandler(this.ClickMemoryButton);
            // 
            // btnMemSubtract
            // 
            this.btnMemSubtract.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnMemSubtract.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnMemSubtract, "btnMemSubtract");
            this.btnMemSubtract.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMemSubtract.Name = "btnMemSubtract";
            this.btnMemSubtract.UseVisualStyleBackColor = false;
            this.btnMemSubtract.Click += new System.EventHandler(this.ClickMemoryButton);
            // 
            // btnGrandTotal
            // 
            this.btnGrandTotal.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnGrandTotal.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnGrandTotal, "btnGrandTotal");
            this.btnGrandTotal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGrandTotal.Name = "btnGrandTotal";
            this.btnGrandTotal.UseVisualStyleBackColor = false;
            // 
            // btnSign
            // 
            this.btnSign.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnSign.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnSign, "btnSign");
            this.btnSign.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSign.Name = "btnSign";
            this.btnSign.UseVisualStyleBackColor = false;
            this.btnSign.Click += new System.EventHandler(this.ClickSignButton);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.LightCoral;
            this.btnClear.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnClear, "btnClear");
            this.btnClear.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClear.Name = "btnClear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.ClickClearButton);
            // 
            // btnAllClear
            // 
            this.btnAllClear.BackColor = System.Drawing.Color.LightCoral;
            this.btnAllClear.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnAllClear, "btnAllClear");
            this.btnAllClear.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAllClear.Name = "btnAllClear";
            this.btnAllClear.UseVisualStyleBackColor = false;
            this.btnAllClear.Click += new System.EventHandler(this.ClickAllClearButton);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnBack.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnBack, "btnBack");
            this.btnBack.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBack.Name = "btnBack";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.ClickBackButton);
            // 
            // btnPercent
            // 
            this.btnPercent.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnPercent.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnPercent, "btnPercent");
            this.btnPercent.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPercent.Name = "btnPercent";
            this.btnPercent.UseVisualStyleBackColor = false;
            // 
            // btnDiv
            // 
            this.btnDiv.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnDiv.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnDiv, "btnDiv");
            this.btnDiv.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.UseVisualStyleBackColor = false;
            this.btnDiv.Click += new System.EventHandler(this.ClickOperatorButton);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn9.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btn9, "btn9");
            this.btn9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn9.Name = "btn9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.ClickNumButton);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn8.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btn8, "btn8");
            this.btn8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn8.Name = "btn8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.ClickNumButton);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn7.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btn7, "btn7");
            this.btn7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn7.Name = "btn7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.ClickNumButton);
            // 
            // btnExcludedTax
            // 
            this.btnExcludedTax.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnExcludedTax.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnExcludedTax, "btnExcludedTax");
            this.btnExcludedTax.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExcludedTax.Name = "btnExcludedTax";
            this.btnExcludedTax.UseVisualStyleBackColor = false;
            // 
            // btnMul
            // 
            this.btnMul.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnMul.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnMul, "btnMul");
            this.btnMul.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMul.Name = "btnMul";
            this.btnMul.UseVisualStyleBackColor = false;
            this.btnMul.Click += new System.EventHandler(this.ClickOperatorButton);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn6.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btn6, "btn6");
            this.btn6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn6.Name = "btn6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.ClickNumButton);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn5.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btn5, "btn5");
            this.btn5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn5.Name = "btn5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.ClickNumButton);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn4.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btn4, "btn4");
            this.btn4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn4.Name = "btn4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.ClickNumButton);
            // 
            // btnEqual
            // 
            this.btnEqual.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnEqual.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnEqual, "btnEqual");
            this.btnEqual.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.UseVisualStyleBackColor = false;
            this.btnEqual.Click += new System.EventHandler(this.ClickEqualbutton);
            this.btnEqual.LostFocus += new System.EventHandler(this.LostFocusEqual);
            // 
            // btnMns
            // 
            this.btnMns.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnMns.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnMns, "btnMns");
            this.btnMns.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMns.Name = "btnMns";
            this.btnMns.UseVisualStyleBackColor = false;
            this.btnMns.Click += new System.EventHandler(this.ClickOperatorButton);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn3.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btn3, "btn3");
            this.btn3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn3.Name = "btn3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.ClickNumButton);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn2.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btn2, "btn2");
            this.btn2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn2.Name = "btn2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.ClickNumButton);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn1.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btn1, "btn1");
            this.btn1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn1.Name = "btn1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.ClickNumButton);
            // 
            // btnPlus
            // 
            this.btnPlus.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnPlus.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnPlus, "btnPlus");
            this.btnPlus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.UseVisualStyleBackColor = false;
            this.btnPlus.Click += new System.EventHandler(this.ClickOperatorButton);
            // 
            // btnDecimal
            // 
            this.btnDecimal.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnDecimal.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnDecimal, "btnDecimal");
            this.btnDecimal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDecimal.Name = "btnDecimal";
            this.btnDecimal.UseVisualStyleBackColor = false;
            this.btnDecimal.Click += new System.EventHandler(this.ClickDecimalButton);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn0.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btn0, "btn0");
            this.btn0.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn0.Name = "btn0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.ClickNumButton);
            // 
            // lblOperator
            // 
            this.lblOperator.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.lblOperator, "lblOperator");
            this.lblOperator.Name = "lblOperator";
            // 
            // btn00
            // 
            this.btn00.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn00.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btn00, "btn00");
            this.btn00.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn00.Name = "btn00";
            this.btn00.UseVisualStyleBackColor = false;
            this.btn00.Click += new System.EventHandler(this.ClickNumButton);
            // 
            // pnlBackGround
            // 
            this.pnlBackGround.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnlBackGround.Controls.Add(this.lblMemory);
            this.pnlBackGround.Controls.Add(this.lblGrandTotal);
            this.pnlBackGround.Controls.Add(this.lblError);
            this.pnlBackGround.Controls.Add(this.lblOperator);
            this.pnlBackGround.Controls.Add(this.txtResult);
            resources.ApplyResources(this.pnlBackGround, "pnlBackGround");
            this.pnlBackGround.Name = "pnlBackGround";
            // 
            // lblMemory
            // 
            this.lblMemory.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.lblMemory, "lblMemory");
            this.lblMemory.Name = "lblMemory";
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.lblGrandTotal, "lblGrandTotal");
            this.lblGrandTotal.Name = "lblGrandTotal";
            // 
            // lblError
            // 
            this.lblError.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.lblError, "lblError");
            this.lblError.Name = "lblError";
            // 
            // lblOnText
            // 
            resources.ApplyResources(this.lblOnText, "lblOnText");
            this.lblOnText.Name = "lblOnText";
            // 
            // pnlBtn
            // 
            this.pnlBtn.Controls.Add(this.btn00);
            this.pnlBtn.Controls.Add(this.btnPlus);
            this.pnlBtn.Controls.Add(this.btnDecimal);
            this.pnlBtn.Controls.Add(this.btn0);
            this.pnlBtn.Controls.Add(this.btnEqual);
            this.pnlBtn.Controls.Add(this.btnMns);
            this.pnlBtn.Controls.Add(this.btn3);
            this.pnlBtn.Controls.Add(this.btn2);
            this.pnlBtn.Controls.Add(this.btn1);
            this.pnlBtn.Controls.Add(this.btnExcludedTax);
            this.pnlBtn.Controls.Add(this.btnMul);
            this.pnlBtn.Controls.Add(this.btn6);
            this.pnlBtn.Controls.Add(this.btn5);
            this.pnlBtn.Controls.Add(this.btn4);
            this.pnlBtn.Controls.Add(this.btnPercent);
            this.pnlBtn.Controls.Add(this.btnDiv);
            this.pnlBtn.Controls.Add(this.btn9);
            this.pnlBtn.Controls.Add(this.btn8);
            this.pnlBtn.Controls.Add(this.btn7);
            this.pnlBtn.Controls.Add(this.btnGrandTotal);
            this.pnlBtn.Controls.Add(this.btnSign);
            this.pnlBtn.Controls.Add(this.btnBack);
            this.pnlBtn.Controls.Add(this.btnMemSubtract);
            this.pnlBtn.Controls.Add(this.btnMemAdd);
            this.pnlBtn.Controls.Add(this.btnIncludedTax);
            this.pnlBtn.Controls.Add(this.btnMemRead);
            this.pnlBtn.Controls.Add(this.btnMemClear);
            resources.ApplyResources(this.pnlBtn, "pnlBtn");
            this.pnlBtn.Name = "pnlBtn";
            // 
            // pnlClear
            // 
            this.pnlClear.Controls.Add(this.btnClear);
            this.pnlClear.Controls.Add(this.btnAllClear);
            resources.ApplyResources(this.pnlClear, "pnlClear");
            this.pnlClear.Name = "pnlClear";
            // 
            // BasicCalcForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.pnlClear);
            this.Controls.Add(this.lblOnText);
            this.Controls.Add(this.pnlBackGround);
            this.Controls.Add(this.pnlBtn);
            this.KeyPreview = true;
            this.Name = "BasicCalcForm";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GetKeyPress);
            this.pnlBackGround.ResumeLayout(false);
            this.pnlBtn.ResumeLayout(false);
            this.pnlClear.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
            //
            // Form Load Control
            //
            this.ActiveControl = btnEqual;
        }

        #endregion
        private System.Windows.Forms.RichTextBox txtResult;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAllClear;
        public System.Windows.Forms.Label lblOperator;
        private System.Windows.Forms.Panel pnlBackGround;
        private System.Windows.Forms.Label lblOnText;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblMemory;
        private System.Windows.Forms.Label lblGrandTotal;
        private System.Windows.Forms.Button btnMemClear;
        private System.Windows.Forms.Button btnMemRead;
        private System.Windows.Forms.Button btnIncludedTax;
        private System.Windows.Forms.Button btnMemAdd;
        private System.Windows.Forms.Button btnMemSubtract;
        private System.Windows.Forms.Button btnGrandTotal;
        private System.Windows.Forms.Button btnSign;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnPercent;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btnExcludedTax;
        private System.Windows.Forms.Button btnMul;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btnMns;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnDecimal;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn00;
        private System.Windows.Forms.Panel pnlBtn;
        private System.Windows.Forms.Panel pnlClear;
    }
}

