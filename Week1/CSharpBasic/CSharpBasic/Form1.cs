using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpBasic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnBool_Click(object sender, EventArgs e)
        {
            textType.Text = "Bool";
            textSize.Text = sizeof(bool).ToString();
            textMinimum.Text = bool.FalseString;
            textMaximum.Text = bool.TrueString;
        }

        private void BtnSbyte_Click(object sender, EventArgs e)
        {
            textType.Text = "Sbyte";
            textSize.Text = sizeof(sbyte).ToString();
            textMinimum.Text = sbyte.MinValue.ToString();
            textMaximum.Text = sbyte.MaxValue.ToString();
        }

        private void BtnByte_Click(object sender, EventArgs e)
        {
            textType.Text = "Byte";
            textSize.Text = sizeof(byte).ToString();
            textMinimum.Text = byte.MinValue.ToString();
            textMaximum.Text = byte.MaxValue.ToString();
        }

        private void BtnShort_Click(object sender, EventArgs e)
        {
            textType.Text = "Short";
            textSize.Text = sizeof(short).ToString();
            textMinimum.Text = short.MinValue.ToString();
            textMaximum.Text = short.MaxValue.ToString();
        }

        private void BtnUshort_Click(object sender, EventArgs e)
        {
            textType.Text = "unsigned Short";
            textSize.Text = sizeof(ushort).ToString();
            textMinimum.Text = ushort.MinValue.ToString();
            textMaximum.Text = ushort.MaxValue.ToString();
        }

        private void BtnInt_Click(object sender, EventArgs e)
        {
            textType.Text = "Integer";
            textSize.Text = sizeof(int).ToString();
            textMinimum.Text = int.MinValue.ToString();
            textMaximum.Text = int.MaxValue.ToString();
        }

        private void BtnUInt16_Click(object sender, EventArgs e)
        {
            textType.Text = "unsigned int 16 bit";
            textSize.Text = sizeof(UInt16).ToString();
            textMinimum.Text = UInt16.MinValue.ToString();
            textMaximum.Text = UInt16.MaxValue.ToString();
        }

        private void BtnUint32_Click(object sender, EventArgs e)
        {
            textType.Text = "unsigned int 32 bit";
            textSize.Text = sizeof(UInt32).ToString();
            textMinimum.Text = UInt32.MinValue.ToString();
            textMaximum.Text = UInt32.MaxValue.ToString();
        }

        private void BtnLong_Click(object sender, EventArgs e)
        {
            textType.Text = "Long";
            textSize.Text = sizeof(long).ToString();
            textMinimum.Text = long.MinValue.ToString();
            textMaximum.Text = long.MaxValue.ToString();
        }

        private void BtnUlong_Click(object sender, EventArgs e)
        {
            textType.Text = "unsigned long";
            textSize.Text = sizeof(ulong).ToString();
            textMinimum.Text = ulong.MinValue.ToString();
            textMaximum.Text = ulong.MaxValue.ToString();
        }

        private void BtnChar_Click(object sender, EventArgs e)
        {
            textType.Text = "Character";
            textSize.Text = sizeof(char).ToString();
            textMinimum.Text = (char.MinValue - '\0').ToString();
            textMaximum.Text = (char.MaxValue - '\0').ToString();
        }

        private void Btnfloat_Click(object sender, EventArgs e)
        {
            textType.Text = "float";
            textSize.Text = sizeof(float).ToString();
            textMinimum.Text = float.Epsilon.ToString();
            textMaximum.Text = float.MaxValue.ToString();
        }

        private void BtnDouble_Click(object sender, EventArgs e)
        {
            textType.Text = "Double";
            textSize.Text = sizeof(double).ToString();
            textMinimum.Text = double.Epsilon.ToString();
            textMaximum.Text = double.MaxValue.ToString();
        }

        private void BtnDecimal_Click(object sender, EventArgs e)
        {
            textType.Text = "Decimal";
            textSize.Text = sizeof(decimal).ToString();
            textMinimum.Text = decimal.MinValue.ToString();
            textMaximum.Text = decimal.MaxValue.ToString();
        } 

    }
}
