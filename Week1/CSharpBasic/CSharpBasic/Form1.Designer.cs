namespace CSharpBasic
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textMaximum = new System.Windows.Forms.TextBox();
            this.textMinimum = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textSize = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTpye = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textType = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnDecimal = new System.Windows.Forms.Button();
            this.BtnDouble = new System.Windows.Forms.Button();
            this.BtnUlong = new System.Windows.Forms.Button();
            this.BtnUint32 = new System.Windows.Forms.Button();
            this.BtnInt = new System.Windows.Forms.Button();
            this.BtnUshort = new System.Windows.Forms.Button();
            this.BtnShort = new System.Windows.Forms.Button();
            this.BtnByte = new System.Windows.Forms.Button();
            this.Btnfloat = new System.Windows.Forms.Button();
            this.BtnLong = new System.Windows.Forms.Button();
            this.BtnSbyte = new System.Windows.Forms.Button();
            this.BtnUInt16 = new System.Windows.Forms.Button();
            this.BtnChar = new System.Windows.Forms.Button();
            this.BtnBool = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(920, 497);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(912, 471);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Value Type";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(912, 471);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "If";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textMaximum);
            this.groupBox2.Controls.Add(this.textMinimum);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textSize);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtTpye);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textType);
            this.groupBox2.Location = new System.Drawing.Point(224, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(312, 132);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detail";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Max";
            // 
            // textMaximum
            // 
            this.textMaximum.Location = new System.Drawing.Point(45, 97);
            this.textMaximum.Name = "textMaximum";
            this.textMaximum.Size = new System.Drawing.Size(184, 20);
            this.textMaximum.TabIndex = 10;
            // 
            // textMinimum
            // 
            this.textMinimum.Location = new System.Drawing.Point(45, 71);
            this.textMinimum.Name = "textMinimum";
            this.textMinimum.Size = new System.Drawing.Size(184, 20);
            this.textMinimum.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Min";
            // 
            // textSize
            // 
            this.textSize.Location = new System.Drawing.Point(45, 45);
            this.textSize.Name = "textSize";
            this.textSize.Size = new System.Drawing.Size(100, 20);
            this.textSize.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(162, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Byte(s)";
            // 
            // txtTpye
            // 
            this.txtTpye.AutoSize = true;
            this.txtTpye.Location = new System.Drawing.Point(13, 22);
            this.txtTpye.Name = "txtTpye";
            this.txtTpye.Size = new System.Drawing.Size(31, 13);
            this.txtTpye.TabIndex = 4;
            this.txtTpye.Text = "Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Size";
            // 
            // textType
            // 
            this.textType.Location = new System.Drawing.Point(46, 19);
            this.textType.Name = "textType";
            this.textType.Size = new System.Drawing.Size(100, 20);
            this.textType.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnDecimal);
            this.groupBox1.Controls.Add(this.BtnDouble);
            this.groupBox1.Controls.Add(this.BtnUlong);
            this.groupBox1.Controls.Add(this.BtnUint32);
            this.groupBox1.Controls.Add(this.BtnInt);
            this.groupBox1.Controls.Add(this.BtnUshort);
            this.groupBox1.Controls.Add(this.BtnShort);
            this.groupBox1.Controls.Add(this.BtnByte);
            this.groupBox1.Controls.Add(this.Btnfloat);
            this.groupBox1.Controls.Add(this.BtnLong);
            this.groupBox1.Controls.Add(this.BtnSbyte);
            this.groupBox1.Controls.Add(this.BtnUInt16);
            this.groupBox1.Controls.Add(this.BtnChar);
            this.groupBox1.Controls.Add(this.BtnBool);
            this.groupBox1.Location = new System.Drawing.Point(30, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(179, 434);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Button";
            // 
            // BtnDecimal
            // 
            this.BtnDecimal.Location = new System.Drawing.Point(35, 383);
            this.BtnDecimal.Margin = new System.Windows.Forms.Padding(2);
            this.BtnDecimal.Name = "BtnDecimal";
            this.BtnDecimal.Size = new System.Drawing.Size(106, 23);
            this.BtnDecimal.TabIndex = 12;
            this.BtnDecimal.Text = "Decimal";
            this.BtnDecimal.UseVisualStyleBackColor = true;
            // 
            // BtnDouble
            // 
            this.BtnDouble.Location = new System.Drawing.Point(35, 356);
            this.BtnDouble.Margin = new System.Windows.Forms.Padding(2);
            this.BtnDouble.Name = "BtnDouble";
            this.BtnDouble.Size = new System.Drawing.Size(106, 23);
            this.BtnDouble.TabIndex = 11;
            this.BtnDouble.Text = "Double";
            this.BtnDouble.UseVisualStyleBackColor = true;
            // 
            // BtnUlong
            // 
            this.BtnUlong.Location = new System.Drawing.Point(35, 271);
            this.BtnUlong.Margin = new System.Windows.Forms.Padding(2);
            this.BtnUlong.Name = "BtnUlong";
            this.BtnUlong.Size = new System.Drawing.Size(106, 23);
            this.BtnUlong.TabIndex = 10;
            this.BtnUlong.Text = "Ulong";
            this.BtnUlong.UseVisualStyleBackColor = true;
            // 
            // BtnUint32
            // 
            this.BtnUint32.Location = new System.Drawing.Point(35, 215);
            this.BtnUint32.Margin = new System.Windows.Forms.Padding(2);
            this.BtnUint32.Name = "BtnUint32";
            this.BtnUint32.Size = new System.Drawing.Size(106, 23);
            this.BtnUint32.TabIndex = 9;
            this.BtnUint32.Text = "Uint32";
            this.BtnUint32.UseVisualStyleBackColor = true;
            // 
            // BtnInt
            // 
            this.BtnInt.Location = new System.Drawing.Point(35, 159);
            this.BtnInt.Margin = new System.Windows.Forms.Padding(2);
            this.BtnInt.Name = "BtnInt";
            this.BtnInt.Size = new System.Drawing.Size(106, 23);
            this.BtnInt.TabIndex = 8;
            this.BtnInt.Text = "Int";
            this.BtnInt.UseVisualStyleBackColor = true;
            // 
            // BtnUshort
            // 
            this.BtnUshort.Location = new System.Drawing.Point(35, 133);
            this.BtnUshort.Margin = new System.Windows.Forms.Padding(2);
            this.BtnUshort.Name = "BtnUshort";
            this.BtnUshort.Size = new System.Drawing.Size(106, 23);
            this.BtnUshort.TabIndex = 7;
            this.BtnUshort.Text = "ushort";
            this.BtnUshort.UseVisualStyleBackColor = true;
            // 
            // BtnShort
            // 
            this.BtnShort.Location = new System.Drawing.Point(35, 106);
            this.BtnShort.Margin = new System.Windows.Forms.Padding(2);
            this.BtnShort.Name = "BtnShort";
            this.BtnShort.Size = new System.Drawing.Size(106, 23);
            this.BtnShort.TabIndex = 6;
            this.BtnShort.Text = "Short";
            this.BtnShort.UseVisualStyleBackColor = true;
            // 
            // BtnByte
            // 
            this.BtnByte.Location = new System.Drawing.Point(35, 79);
            this.BtnByte.Margin = new System.Windows.Forms.Padding(2);
            this.BtnByte.Name = "BtnByte";
            this.BtnByte.Size = new System.Drawing.Size(106, 23);
            this.BtnByte.TabIndex = 5;
            this.BtnByte.Text = "Byte";
            this.BtnByte.UseVisualStyleBackColor = true;
            // 
            // Btnfloat
            // 
            this.Btnfloat.Location = new System.Drawing.Point(35, 328);
            this.Btnfloat.Name = "Btnfloat";
            this.Btnfloat.Size = new System.Drawing.Size(106, 23);
            this.Btnfloat.TabIndex = 4;
            this.Btnfloat.Text = "float";
            this.Btnfloat.UseVisualStyleBackColor = true;
            // 
            // BtnLong
            // 
            this.BtnLong.Location = new System.Drawing.Point(35, 243);
            this.BtnLong.Name = "BtnLong";
            this.BtnLong.Size = new System.Drawing.Size(106, 23);
            this.BtnLong.TabIndex = 4;
            this.BtnLong.Text = "Long";
            this.BtnLong.UseVisualStyleBackColor = true;
            // 
            // BtnSbyte
            // 
            this.BtnSbyte.Location = new System.Drawing.Point(35, 51);
            this.BtnSbyte.Name = "BtnSbyte";
            this.BtnSbyte.Size = new System.Drawing.Size(106, 23);
            this.BtnSbyte.TabIndex = 3;
            this.BtnSbyte.Text = "Sbyte";
            this.BtnSbyte.UseVisualStyleBackColor = true;
            // 
            // BtnUInt16
            // 
            this.BtnUInt16.Location = new System.Drawing.Point(35, 187);
            this.BtnUInt16.Name = "BtnUInt16";
            this.BtnUInt16.Size = new System.Drawing.Size(106, 23);
            this.BtnUInt16.TabIndex = 2;
            this.BtnUInt16.Text = "UInt16";
            this.BtnUInt16.UseVisualStyleBackColor = true;
            // 
            // BtnChar
            // 
            this.BtnChar.Location = new System.Drawing.Point(35, 299);
            this.BtnChar.Name = "BtnChar";
            this.BtnChar.Size = new System.Drawing.Size(106, 23);
            this.BtnChar.TabIndex = 1;
            this.BtnChar.Text = "char";
            this.BtnChar.UseVisualStyleBackColor = true;
            // 
            // BtnBool
            // 
            this.BtnBool.Location = new System.Drawing.Point(35, 22);
            this.BtnBool.Name = "BtnBool";
            this.BtnBool.Size = new System.Drawing.Size(106, 23);
            this.BtnBool.TabIndex = 0;
            this.BtnBool.Text = "Bool";
            this.BtnBool.UseVisualStyleBackColor = true;
            this.BtnBool.Click += new System.EventHandler(this.BtnBool_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 497);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textMaximum;
        private System.Windows.Forms.TextBox textMinimum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtTpye;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textType;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnDecimal;
        private System.Windows.Forms.Button BtnDouble;
        private System.Windows.Forms.Button BtnUlong;
        private System.Windows.Forms.Button BtnUint32;
        private System.Windows.Forms.Button BtnInt;
        private System.Windows.Forms.Button BtnUshort;
        private System.Windows.Forms.Button BtnShort;
        private System.Windows.Forms.Button BtnByte;
        private System.Windows.Forms.Button Btnfloat;
        private System.Windows.Forms.Button BtnLong;
        private System.Windows.Forms.Button BtnSbyte;
        private System.Windows.Forms.Button BtnUInt16;
        private System.Windows.Forms.Button BtnChar;
        private System.Windows.Forms.Button BtnBool;
    }
}

