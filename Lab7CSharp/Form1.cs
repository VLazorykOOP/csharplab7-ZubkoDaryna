using System;
using System.Windows.Forms;

namespace TextBoxToRichTextBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string currentTime = DateTime.Now.ToString("HH:mm:ss");
            string sentence = textBox.Text;
            string textToAdd = $"[{currentTime}] {sentence}\n";
            richTextBox.AppendText(textToAdd);
            textBox.Clear();
        }
    }
}
