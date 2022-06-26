using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BasicFacebookFeatures.User_Interface
{
    public partial class FormIntro : Form
    {
        private Dictionary<CheckBox, TextBox> ButtonCheckList { get; set; } = new Dictionary<CheckBox, TextBox>();

        public List<Tuple<string, string, bool>> ListToIntro { get; set; } = new List<Tuple<string, string, bool>>();

        public FormIntro()
        {
            InitializeComponent();
            initIntroDictionary();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            updateIntro();
            this.Hide();
        }

        private void updateIntro()
        {
            List<Tuple<string, string, bool>> introList = new List<Tuple<string, string, bool>>
            { 
                new Tuple<string, string, bool>("Gender: ", textBoxGender.Text, checkBoxGender.Checked), 
                new Tuple<string, string, bool>("Email: ", textBoxEmail.Text, checkBoxEmail.Checked),
                new Tuple<string, string, bool>("Birthday: ", textBoxBirthday.Text, checkBoxBirthday.Checked),
                new Tuple<string, string, bool>("Hometown: ", textBoxHometown.Text, checkBoxHometown.Checked),
                new Tuple<string, string, bool>("Study: ", textBoxStudy.Text, checkBoxStudy.Checked),
                new Tuple<string, string, bool>("Interested In: ", textBoxInterestedIn.Text, checkBoxInterestedIn.Checked),
                new Tuple<string, string, bool>("Quote: ", textBoxQuote.Text, checkBoxQuote.Checked),
                new Tuple<string, string, bool>("Religion: ", textBoxReligion.Text, checkBoxReligion.Checked)
            };

            ListToIntro = introList;
        }

        private Tuple<string, string, bool> getTupleFromKey(string i_Key, List<Tuple<string, string, bool>> i_IntroList)
        {
            Tuple<string, string, bool> result = new Tuple<string, string, bool>(string.Empty, string.Empty, true);

            foreach (Tuple<string, string, bool> row in i_IntroList)
            {
                if (row.Item1 == i_Key)
                {
                    result = row;
                }
            }

            return result;
        }

        private void initIntroDictionary()
        {
            ButtonCheckList.Add(this.checkBoxGender, this.textBoxGender);
            ButtonCheckList.Add(this.checkBoxEmail, this.textBoxEmail);
            ButtonCheckList.Add(this.checkBoxBirthday, this.textBoxBirthday);
            ButtonCheckList.Add(this.checkBoxHometown, this.textBoxHometown);
            ButtonCheckList.Add(this.checkBoxStudy, this.textBoxStudy);
            ButtonCheckList.Add(this.checkBoxInterestedIn, this.textBoxInterestedIn);
            ButtonCheckList.Add(this.checkBoxQuote, this.textBoxQuote);
            ButtonCheckList.Add(this.checkBoxReligion, this.textBoxReligion);
        }

        public void InitIntroForm(List<Tuple<string, string, bool>> i_IntroList)
        {
            ListToIntro = i_IntroList;

            foreach (KeyValuePair<CheckBox, TextBox> item in ButtonCheckList)
            {
                string key = item.Key.Text;
                Tuple<string, string, bool> row = getTupleFromKey(key, i_IntroList);

                switch (key)
                {
                    case "Gender: ":
                        checkBoxGender.Checked = row.Item3;
                        textBoxGender.Text = row.Item2;
                        break;
                    case "Email: ":
                        checkBoxEmail.Checked = row.Item3;
                        textBoxEmail.Text = row.Item2;
                        break;
                    case "Birthday: ":
                        checkBoxBirthday.Checked = row.Item3;
                        textBoxBirthday.Text = row.Item2;
                        break;
                    case "Hometown: ":
                        checkBoxHometown.Checked = row.Item3;
                        textBoxHometown.Text = row.Item2;
                        break;
                    case "Study: ":
                        checkBoxStudy.Checked = row.Item3;
                        textBoxStudy.Text = row.Item2;
                        break;
                    case "Interested In: ":
                        checkBoxInterestedIn.Checked = row.Item3;
                        textBoxInterestedIn.Text = row.Item2;
                        break;
                    case "Quote: ":
                        checkBoxQuote.Checked = row.Item3;
                        textBoxQuote.Text = row.Item2;
                        break;
                    case "Religion: ":
                        checkBoxReligion.Checked = row.Item3;
                        textBoxReligion.Text = row.Item2;
                        break;
                }
            }
        }
    }
}
