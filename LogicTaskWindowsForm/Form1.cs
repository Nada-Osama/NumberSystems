using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogicTaskWindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void DecTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void BinTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void OctTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void HexTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void DecConvertionBtn_Click(object sender, EventArgs e)
        {
            Decimal DecObj = new Decimal();
            if (string.IsNullOrWhiteSpace(DecTextBox.Text) && string.IsNullOrWhiteSpace(BinTextBox.Text)
                && string.IsNullOrWhiteSpace(OctTextBox.Text) && string.IsNullOrWhiteSpace(HexTextBox.Text))
                MessageBox.Show("Please, Enter a number to convert!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                BinTextBox.Text = DecObj.DecToBin(int.Parse(DecTextBox.Text));
                OctTextBox.Text = DecObj.DecToOct(int.Parse(DecTextBox.Text));
                HexTextBox.Text = DecObj.DecToHex(int.Parse(DecTextBox.Text)).ToUpper();
            }
        }

        private void BinConvertionBtn_Click(object sender, EventArgs e)
        {
            Binary BinObj = new Binary();
            if (string.IsNullOrWhiteSpace(DecTextBox.Text) && string.IsNullOrWhiteSpace(BinTextBox.Text)
                && string.IsNullOrWhiteSpace(OctTextBox.Text) && string.IsNullOrWhiteSpace(HexTextBox.Text))
                MessageBox.Show("Please, Enter a number to convert!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                DecTextBox.Text = BinObj.BinToDec(BinTextBox.Text).ToString();
                OctTextBox.Text = BinObj.BinToOct(BinTextBox.Text).ToString();
                HexTextBox.Text = BinObj.BinToHex(BinTextBox.Text).ToUpper();
            }
        }

        private void OctConvertionBtn_Click(object sender, EventArgs e)
        {
            Octal octObj = new Octal();
            if (string.IsNullOrWhiteSpace(DecTextBox.Text) && string.IsNullOrWhiteSpace(BinTextBox.Text)
                && string.IsNullOrWhiteSpace(OctTextBox.Text) && string.IsNullOrWhiteSpace(HexTextBox.Text))
                MessageBox.Show("Please, Enter a number to convert!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                DecTextBox.Text = octObj.OctToDec(OctTextBox.Text);
                BinTextBox.Text = octObj.OctToBin(OctTextBox.Text);
                HexTextBox.Text = octObj.OctToHex(OctTextBox.Text).ToUpper();
            }
        }


        private void HexConvertionBtn_Click(object sender, EventArgs e)
        {
            Hexdecimal hexObj = new Hexdecimal();
            if (string.IsNullOrWhiteSpace(DecTextBox.Text) && string.IsNullOrWhiteSpace(BinTextBox.Text)
                && string.IsNullOrWhiteSpace(OctTextBox.Text) && string.IsNullOrWhiteSpace(HexTextBox.Text))
                MessageBox.Show("Please, Enter a number to convert!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                DecTextBox.Text = hexObj.HexToDec(HexTextBox.Text);
                BinTextBox.Text = hexObj.HexToBin(HexTextBox.Text);
                OctTextBox.Text = hexObj.HexToOct(HexTextBox.Text);
            }
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            DecTextBox.Clear();
            BinTextBox.Clear();
            OctTextBox.Clear();
            HexTextBox.Clear();
        }
    }
}
