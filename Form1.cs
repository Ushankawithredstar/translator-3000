using System.Diagnostics;

namespace Translator_3000
{
    public partial class Form1 : Form
    {
        private string humanInput;
        private string gooseInput;

        public Form1()
        {
            InitializeComponent();
        }

        private void txt_humanInput_TextChanged(object sender, EventArgs e)
        {
            humanInput = txt_humanInput.Text;
            Debug.Write(humanInput);
        }

        private void txt_gooseInput_TextChanged(object sender, EventArgs e)
        {
            gooseInput = txt_gooseInput.Text;
            Debug.Write(gooseInput);
        }

        private void btn_translateHumanToGoose_Click(object sender, EventArgs e)
        {
            Translator t = new();
            txt_gooseOutput.Text = t.Encode(humanInput);
        }

        private void btn_translateGooseToHuman_Click(object sender, EventArgs e)
        {
            Translator t = new();
            txt_humanOutput.Text = t.Decode(gooseInput);
        }
    }
}