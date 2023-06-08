namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            doctorsComboBox = new ComboBox();
            methodComboBox = new ComboBox();
            parameterTextBox = new TextBox();
            button1 = new Button();
            resultLabel = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(88, 20);
            label1.TabIndex = 0;
            label1.Text = "Hello Dear ,";
            label1.Click += label1_Click;
            // 
            // doctorsComboBox
            // 
            doctorsComboBox.AccessibleName = "";
            doctorsComboBox.FormattingEnabled = true;
            doctorsComboBox.Location = new Point(12, 41);
            doctorsComboBox.Name = "doctorsComboBox";
            doctorsComboBox.Size = new Size(151, 28);
            doctorsComboBox.TabIndex = 1;
            // 
            // methodComboBox
            // 
            methodComboBox.FormattingEnabled = true;
            methodComboBox.Location = new Point(12, 75);
            methodComboBox.Name = "methodComboBox";
            methodComboBox.Size = new Size(151, 28);
            methodComboBox.TabIndex = 2;
            // 
            // parameterTextBox
            // 
            parameterTextBox.Location = new Point(12, 109);
            parameterTextBox.Name = "parameterTextBox";
            parameterTextBox.Size = new Size(125, 27);
            parameterTextBox.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(12, 142);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 4;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Location = new Point(254, 37);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(0, 20);
            resultLabel.TabIndex = 5;
            resultLabel.Click += label2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(456, 211);
            Controls.Add(resultLabel);
            Controls.Add(button1);
            Controls.Add(parameterTextBox);
            Controls.Add(methodComboBox);
            Controls.Add(doctorsComboBox);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox doctorsComboBox;
        private ComboBox methodComboBox;
        private TextBox parameterTextBox;
        private Button button1;
        private Label resultLabel;
    }
}