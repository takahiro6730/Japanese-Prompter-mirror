using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace JapanesePrompter
{
    public partial class TextForm : Form
    {
        public string selectedFile = "";
        public TextForm()
        {
            InitializeComponent();
        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            OpenFileDialog txtOpenDlg = new OpenFileDialog();
            txtOpenDlg.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            txtOpenDlg.Multiselect = false;
            txtOpenDlg.Title= "OpenFile";
            DialogResult result = txtOpenDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                selectedFile = txtOpenDlg.FileName;
                // Do something with the selected file...
                if (File.Exists(selectedFile))
                {
                    StreamReader reader = new StreamReader(selectedFile);
                    string contents = reader.ReadToEnd();
                    reader.Close();

                    rtxt_content.Text = contents;
                }
                else
                {
                    MessageBox.Show("The file does not exist.");
                }
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if(selectedFile == "")
            {
                MessageBox.Show("パスを入力する必要があります。");
                return;
            }
            string filePath = selectedFile;

            StreamWriter writer = new StreamWriter(filePath);
            writer.Write(rtxt_content.Text);
            writer.Close();

            MessageBox.Show("保存しました。");
        }

        private void TextForm_Load(object sender, EventArgs e)
        {
            input_font.Text = input_font.Font.Size.ToString();
        }

        private void input_font_TextChanged(object sender, EventArgs e)
        {
            if (input_font.Text == null) return;
            string tp_txt = input_font.Text;
            float num;
            bool isNumeric = float.TryParse(tp_txt, out num);

            if (isNumeric)
            {
                float tp_font_size = float.Parse(input_font.Text.ToString());
                Font newFont = new Font(rtxt_content.Font.FontFamily, tp_font_size, FontStyle.Regular);
                rtxt_content.SelectionFont = newFont;
            }
            else
            {
                MessageBox.Show("The text cannot be converted to an integer.");
                string tp_replace = input_font.Text;
                string pattern = "[^0-9.]";
                string replacement = "";
                string result = Regex.Replace(tp_replace, pattern, replacement);
                input_font.Text = result;
                return;
            }
        }
    }
}
