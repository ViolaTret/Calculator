using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class FormCalculator : Form
    {
        private string _firstNumber;
        private string _secondNumber;
        private string _operation;
        private string _result;
        private bool _isOutPutResult;
        private ListNumbers _queueInitializationNumbers;
        private bool _isOperation;

        public FormCalculator()
        {
            InitializeComponent();
            _firstNumber = "0";
            _secondNumber = "0";
            _operation = "";
            _result = "0";
            _isOutPutResult = false;
            _queueInitializationNumbers = ListNumbers.FirstNumber;
            _isOperation = false;
        }

        private void ButtonNumber_Click(object sender, EventArgs e)
        {
            if(_isOperation)
            {
                labelText.Text = "0";
                _isOperation = false;   
            }
            labelText.Text = labelText.Text == "0" ? ((Button)sender).Text : labelText.Text + ((Button)sender).Text;
            _isOutPutResult = false;
        }

        private void ButtonComma_Click(object sender, EventArgs e)
        {
            if(_isOutPutResult) { return; }
            if(labelText.Text.Contains(",")) { return; }
            labelText.Text += ((Button)sender).Text;
        }

        private void ButtonBcksp_Click(object sender, EventArgs e)
        {
            if (_isOutPutResult) { return; }
            labelText.Text = labelText.Text.Remove(labelText.Text.Length - 1);
            if (labelText.Text == "")
            {
                labelText.Text = "0";
            }
        }

        private void ButtonClearLableText_Click(object sender, EventArgs e)
        {
            if (_isOutPutResult) { return; }
            labelText.Text = "0";
        }

        private void ButtonResetAllValues_Click(object sender, EventArgs e)
        {
            labelText.Text = "0";
            labelHistory.Text = "";
            _isOperation = false;
            _isOutPutResult = false;
            _queueInitializationNumbers = ListNumbers.FirstNumber;
        }

        private void RunOperationForTwoNumbers(string operation)
        {
            switch (_queueInitializationNumbers)
            {
                case ListNumbers.FirstNumber:
                    _firstNumber = labelText.Text;
                    _queueInitializationNumbers = ListNumbers.SecondNumber;
                    break;
                case ListNumbers.SecondNumber:
                    _secondNumber = labelText.Text;
                    _result = MathOperation.RunOperationForTwoNumbers(_firstNumber, _secondNumber, _operation);
                    labelText.Text = _result;
                    _isOutPutResult = true;
                    _firstNumber = _result;
                    break;
                default:
                    break;
            }
            _operation = operation;
            _isOperation = true;
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            RunOperationForTwoNumbers(((Button)sender).Text);
            labelHistory.Text = $"{_firstNumber} {_operation}";
        }

        private void ButtonSub_Click(object sender, EventArgs e)
        {

            RunOperationForTwoNumbers(((Button)sender).Text);
            labelHistory.Text = $"{_firstNumber} {_operation}";
        }

        private void ButtonMultiply_Click(object sender, EventArgs e)
        {
            RunOperationForTwoNumbers(((Button)sender).Text);
            labelHistory.Text = $"{_firstNumber} {_operation}";
        }

        private void ButtonDivide_Click(object sender, EventArgs e)
        {
            RunOperationForTwoNumbers(((Button)sender).Text);
            labelHistory.Text = $"{_firstNumber} {_operation}";
        }

        private void ButtonPercentage_Click(object sender, EventArgs e)
        {
            RunOperationForTwoNumbers(((Button)sender).Text);
            labelHistory.Text = $"{_firstNumber} {_operation}";
        }

        private void RunOperationForOneNumber(string operation)
        {
            _firstNumber = labelText.Text;
            _operation = operation;
            _isOperation = true;
            _result = MathOperation.RunOperationForOneNumbers(_firstNumber, _operation);
            labelText.Text = _result;
            _isOutPutResult = true;
        }

        private void ButtonSqrt_Click(object sender, EventArgs e)
        {
            RunOperationForOneNumber(((Button)sender).Text);
            labelHistory.Text = $"√({_firstNumber})";
        }

        private void ButtonPow_Click(object sender, EventArgs e)
        {
            RunOperationForOneNumber(((Button)sender).Text);
            labelHistory.Text = $"sqr({_firstNumber})";
        }

        private void ButtonFlipFraction_Click(object sender, EventArgs e)
        {
            RunOperationForOneNumber(((Button)sender).Text);
            labelHistory.Text = $"1/({_firstNumber})";
        }

        private void ButtonEqual_Click(object sender, EventArgs e)
        {
            switch (_queueInitializationNumbers)
            {
                case ListNumbers.FirstNumber:
                    _firstNumber = labelText.Text;
                    _result = MathOperation.RunOperationForTwoNumbers(_firstNumber, _secondNumber, _operation);
                    labelText.Text = _result;
                    _isOutPutResult = true;
                    break;
                case ListNumbers.SecondNumber:
                    _secondNumber = labelText.Text;
                    _result = MathOperation.RunOperationForTwoNumbers(_firstNumber, _secondNumber, _operation);
                    labelText.Text = _result;
                    _isOutPutResult = true;
                    _queueInitializationNumbers = ListNumbers.FirstNumber;
                    break;
                default:
                    break;
            }
            _isOperation = true;
            labelHistory.Text = $"{_firstNumber} {_operation} {_secondNumber} =";
        }

        private void LabelText_TextChanged(object sender, EventArgs e)
        {
            const int maxCharacters = 11;
            if (labelText.Text.Length > maxCharacters)
            {
                labelText.Text = labelText.Text.Remove(maxCharacters);
            }
        }
    }
}
