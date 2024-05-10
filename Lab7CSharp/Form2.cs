using System;
using System.Drawing;
using System.Windows.Forms;

namespace ImageManipulation
{
    public partial class Form2 : Form
    {
        private Bitmap originalImage;

        public Form2()
        {
            InitializeComponent();
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Image Files|*.bmp;*.jpg;*.jpeg;*.png;*.gif";
            openFileDialog.FilterIndex = 1;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                originalImage = new Bitmap(openFileDialog.FileName);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (originalImage == null)
            {
                MessageBox.Show("Please open an image first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Bitmap manipulatedImage = new Bitmap(originalImage);

            if (radioButtonRed.Checked || radioButtonGreen.Checked || radioButtonBlue.Checked)
            {
                Color componentColor;
                if (radioButtonRed.Checked)
                {
                    componentColor = Color.Red;
                }
                else if (radioButtonGreen.Checked)
                {
                    componentColor = Color.Green;
                }
                else 
                {
                    componentColor = Color.Blue;
                }

                for (int x = 0; x < manipulatedImage.Width; x++)
                {
                    for (int y = 0; y < manipulatedImage.Height; y++)
                    {
                        Color pixelColor = manipulatedImage.GetPixel(x, y);
                        Color newColor = Color.FromArgb(pixelColor.A, componentColor);
                        manipulatedImage.SetPixel(x, y, newColor);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a color component.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            saveFileDialog.Filter = "Bitmap Files (*.bmp)|*.bmp|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                manipulatedImage.Save(saveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Bmp);
            }
        }
    }
}
