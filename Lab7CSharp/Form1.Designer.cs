namespace TextBoxToRichTextBox
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.textBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();

            this.textBox.Location = new System.Drawing.Point(12, 12);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(300, 20);
            this.textBox.TabIndex = 0;

            this.addButton.Location = new System.Drawing.Point(12, 38);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);

            this.richTextBox.Location = new System.Drawing.Point(12, 67);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(300, 200);
            this.richTextBox.TabIndex = 2;
            this.richTextBox.Text = "";

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 281);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.textBox);
            this.Name = "Form1";
            this.Text = "TextBox to RichTextBox";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.RichTextBox richTextBox;
    }
}
