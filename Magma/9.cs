using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Magma
{
    public partial class TestResultsForm : Form
    {
        public TestResultsForm()
        {
            InitializeComponent();
            FillMessageTextBox();
            FillKeyTextBox();
            FillDataFromTranslatingValuesForm();
            FillSubKeysLabels();
            FillBitwiseAdditionLabel();
            FillBlockLabels();
            FillShiftedN0Label();
            FillShiftedN0XORL0Label();
        }

        private void FillMessageTextBox()
        {
            MessageTextBox.Text = InputData.GetInstance().Message;
        }

        private void FillKeyTextBox()
        {
            KeyTextBox.Text = InputData.GetInstance().Key;
        }

        private void FillDataFromTranslatingValuesForm()
        {
            double L0R0Error = 0;
            string realL0R0 = ByteConverter.GetByteCode(InputData.GetInstance().Message);
            string userL0R0 = InputData.GetInstance().UserAnswers.L0R0;
            for (int i = 0; i < realL0R0.Length; i++)
            {
                if (realL0R0[i] != userL0R0[i])
                {
                    L0R0Error++;
                }
            }
            FillPercentInTextBox(L0R0ErrorPercentLabel, L0R0Error / realL0R0.Length);

            double L0Error = 0;
            string realL0 = ByteConverter.GetByteCode(InputData.GetInstance().Message.Substring(0, 4));
            string userL0 = InputData.GetInstance().UserAnswers.L0;
            for (int i = 0; i < realL0.Length; i++)
            {
                if (realL0[i] != userL0[i])
                {
                    L0Error++;
                }
            }
            FillPercentInTextBox(L0ErrorPercentLabel, L0Error / realL0.Length);

            double R0Error = 0;
            string realR0 = ByteConverter.GetByteCode(InputData.GetInstance().Message.Substring(4, 4));
            string userR0 = InputData.GetInstance().UserAnswers.R0;
            for (int i = 0; i < realR0.Length; i++)
            {
                if (realR0[i] != userR0[i])
                {
                    R0Error++;
                }
            }
            FillPercentInTextBox(R0ErrorPercentLabel, R0Error / realR0.Length);
        }

        private void FillSubKeysLabels()
        {
            string key = InputData.GetInstance().Key;
            int subkeyLenght = 8;
            double errorsCount;
            string realAnswer, userAnswer;

            errorsCount = 0;
            userAnswer = InputData.GetInstance().UserAnswers.K0;
            realAnswer = ByteConverter.GetByteCode(key.Substring(0, 4));
            for (int i = 0; i < subkeyLenght; i++)
            {
                if (realAnswer[i] != userAnswer[i])
                {
                    errorsCount++;
                }
            }
            FillPercentInTextBox(K0ErrorPercentLabel, errorsCount / subkeyLenght);

            errorsCount = 0;
            userAnswer = InputData.GetInstance().UserAnswers.K1;
            realAnswer = ByteConverter.GetByteCode(key.Substring(4, 4));
            for (int i = 0; i < subkeyLenght; i++)
            {
                if (realAnswer[i] != userAnswer[i])
                {
                    errorsCount++;
                }
            }
            FillPercentInTextBox(K1ErrorPercentLabel, errorsCount / subkeyLenght);

            errorsCount = 0;
            userAnswer = InputData.GetInstance().UserAnswers.K2;
            realAnswer = ByteConverter.GetByteCode(key.Substring(8, 4));
            for (int i = 0; i < subkeyLenght; i++)
            {
                if (realAnswer[i] != userAnswer[i])
                {
                    errorsCount++;
                }
            }
            FillPercentInTextBox(K2ErrorPercentLabel, errorsCount / subkeyLenght);

            errorsCount = 0;
            userAnswer = InputData.GetInstance().UserAnswers.K3;
            realAnswer = ByteConverter.GetByteCode(key.Substring(12, 4));
            for (int i = 0; i < subkeyLenght; i++)
            {
                if (realAnswer[i] != userAnswer[i])
                {
                    errorsCount++;
                }
            }
            FillPercentInTextBox(K3ErrorPercentLabel, errorsCount / subkeyLenght);

            errorsCount = 0;
            userAnswer = InputData.GetInstance().UserAnswers.K4;
            realAnswer = ByteConverter.GetByteCode(key.Substring(16, 4));
            for (int i = 0; i < subkeyLenght; i++)
            {
                if (realAnswer[i] != userAnswer[i])
                {
                    errorsCount++;
                }
            }
            FillPercentInTextBox(K4ErrorPercentLabel, errorsCount / subkeyLenght);

            errorsCount = 0;
            userAnswer = InputData.GetInstance().UserAnswers.K5;
            realAnswer = ByteConverter.GetByteCode(key.Substring(20, 4));
            for (int i = 0; i < subkeyLenght; i++)
            {
                if (realAnswer[i] != userAnswer[i])
                {
                    errorsCount++;
                }
            }
            FillPercentInTextBox(K5ErrorPercentLabel, errorsCount / subkeyLenght);

            errorsCount = 0;
            userAnswer = InputData.GetInstance().UserAnswers.K6;
            realAnswer = ByteConverter.GetByteCode(key.Substring(24, 4));
            for (int i = 0; i < subkeyLenght; i++)
            {
                if (realAnswer[i] != userAnswer[i])
                {
                    errorsCount++;
                }
            }
            FillPercentInTextBox(K6ErrorPercentLabel, errorsCount / subkeyLenght);

            errorsCount = 0;
            userAnswer = InputData.GetInstance().UserAnswers.K7;
            realAnswer = ByteConverter.GetByteCode(key.Substring(28, 4));
            for (int i = 0; i < subkeyLenght; i++)
            {
                if (realAnswer[i] != userAnswer[i])
                {
                    errorsCount++;
                }
            }
            FillPercentInTextBox(K7ErrorPercentLabel, errorsCount / subkeyLenght);
        }

        private void FillBitwiseAdditionLabel()
        {
            double errorsCount = 0;
            string userAnswer = InputData.GetInstance().UserAnswers.R0K0;
            string realAnswer = InputData.GetA0PlusK0();
            for (int i = 0; i < realAnswer.Length; i++)
            {
                if (realAnswer[i] != userAnswer[i])
                {
                    errorsCount++;
                }
            }
            FillPercentInTextBox(R0K0ErrorPercentLabel, errorsCount / realAnswer.Length);
        }

        private void FillBlockLabels()
        {
            int blockLenght = 4;
            double errorsCount;
            string[] realOldBlocks = new string[8]
            {
                GetOldBlockValue(0),
                GetOldBlockValue(1),
                GetOldBlockValue(2),
                GetOldBlockValue(3),
                GetOldBlockValue(4),
                GetOldBlockValue(5),
                GetOldBlockValue(6),
                GetOldBlockValue(7)
            };
            string[] userOldBlocks = new string[8]
            {
                InputData.GetInstance().UserAnswers.B8,
                InputData.GetInstance().UserAnswers.B7,
                InputData.GetInstance().UserAnswers.B6,
                InputData.GetInstance().UserAnswers.B5,
                InputData.GetInstance().UserAnswers.B4,
                InputData.GetInstance().UserAnswers.B3,
                InputData.GetInstance().UserAnswers.B2,
                InputData.GetInstance().UserAnswers.B1
            };
            List<Label> OldBlockLabels = new List<Label>()
            {
                B8ErrorPercentLabel,
                B7ErrorPercentLabel,
                B6ErrorPercentLabel,
                B5ErrorPercentLabel,
                B4ErrorPercentLabel,
                B3ErrorPercentLabel,
                B2ErrorPercentLabel,
                B1ErrorPercentLabel
            };
            for (int blockNumber = 0; blockNumber < 8; blockNumber++)
            {
                errorsCount = 0;
                for (int i = 0; i < blockLenght; i++)
                {
                    if (userOldBlocks[blockLenght][i] != realOldBlocks[blockLenght][i])
                    {
                        errorsCount++;
                    }
                }
                FillPercentInTextBox(OldBlockLabels[blockNumber], errorsCount / blockLenght);
            }

            string[] realNewBlocks = new string[8]
            {
                GetNewBlockValue(0),
                GetNewBlockValue(1),
                GetNewBlockValue(2),
                GetNewBlockValue(3),
                GetNewBlockValue(4),
                GetNewBlockValue(5),
                GetNewBlockValue(6),
                GetNewBlockValue(7)
            };
            string[] userNewBlocks = new string[8]
            {
                InputData.GetInstance().UserAnswers.NB8,
                InputData.GetInstance().UserAnswers.NB7,
                InputData.GetInstance().UserAnswers.NB6,
                InputData.GetInstance().UserAnswers.NB5,
                InputData.GetInstance().UserAnswers.NB4,
                InputData.GetInstance().UserAnswers.NB3,
                InputData.GetInstance().UserAnswers.NB2,
                InputData.GetInstance().UserAnswers.NB1
            };
            List<Label> NewBlockLabels = new List<Label>()
            {
                NB8ErrorPercentLabel,
                NB7ErrorPercentLabel,
                NB6ErrorPercentLabel,
                NB5ErrorPercentLabel,
                NB4ErrorPercentLabel,
                NB3ErrorPercentLabel,
                NB2ErrorPercentLabel,
                NB1ErrorPercentLabel
            };
            for (int blockNumber = 0; blockNumber < 8; blockNumber++)
            {
                errorsCount = 0;
                for (int i = 0; i < blockLenght; i++)
                {
                    if (userNewBlocks[blockLenght][i] != realNewBlocks[blockLenght][i])
                    {
                        errorsCount++;
                    }
                }
                FillPercentInTextBox(NewBlockLabels[blockNumber], errorsCount / blockLenght);
            }

            errorsCount = 0;
            string realN0 = InputData.GetN0();
            string userN0 = InputData.GetInstance().UserAnswers.N0;
            for (int i = 0; i < realN0.Length; i++)
            {
                if (realN0[i] != userN0[i])
                {
                    errorsCount++;
                }
                FillPercentInTextBox(N0ErrorPercentLabel, errorsCount / realN0.Length);
            }
        }

        private string GetOldBlockValue(int blockNumber)
        {
            string a = InputData.GetA0PlusK0();
            return InputData.GetA0PlusK0().Substring(blockNumber * 4, 4);
        }

        private string GetNewBlockValue(int blockNumber)
        {
            string result = Convert.ToString(new PermutationTable().Permuate(Convert.ToInt32(InputData.GetA0PlusK0().Substring(blockNumber * 4, 4), 2), blockNumber), 2);
            return FormatBinaryString(result);
        }

        private string FormatBinaryString(string input)
        {
            switch (input.Length)
            {
                case 0:
                    return "0000" + input;
                case 1:
                    return "000" + input;
                case 2:
                    return "00" + input;
                case 3:
                    return "0" + input;
                default:
                    return input.Substring(0, 4);
            }
        }

        private void FillShiftedN0Label()
        {
            double errorsCount = 0;
            string userAnswer = InputData.GetInstance().UserAnswers.N0Shifted; 
            string realAnswer = InputData.GetN0Shifted();
            for (int i = 0; i < realAnswer.Length; i++)
            {
                if (realAnswer[i] != userAnswer[i])
                {
                    errorsCount++;
                }
            }
            FillPercentInTextBox(ShiftedNErrorPercentLabel, errorsCount / realAnswer.Length);
        }

        private void FillShiftedN0XORL0Label()
        {
            double errorsCount = 0;
            string userAnswer = InputData.GetInstance().UserAnswers.N0ShiftedXORL0;
            string realAnswer = InputData.GetN0XORL0(); 
            for (int i = 0; i < realAnswer.Length; i++)
            {
                if (realAnswer[i] != userAnswer[i])
                {
                    errorsCount++;
                }
            }
            FillPercentInTextBox(ShiftedNXORL0ErrorPercentLabel, errorsCount / realAnswer.Length);
        }

        private void FillPercentInTextBox(Label label, double percent)
        {
            label.Text = Math.Round(percent * 100, 2).ToString() + "%";
        }

        private void FinishTestButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
