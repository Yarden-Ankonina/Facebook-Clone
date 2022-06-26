using System;
using System.Windows.Forms;

namespace BasicFacebookFeatures.User_Interface
{
    public partial class TextInputForm : Form
    {
        public string TextInput { get; private set; }

        public TextInputForm()
        {
            InitializeComponent();
            this.AcceptButton = buttonSubmit;
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            TextInput = textBox1.Text;
            this.DialogResult = DialogResult.OK;

            this.Close();
        }
    }
}
