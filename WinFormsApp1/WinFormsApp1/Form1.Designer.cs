﻿namespace WinFormsApp1
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
            username = new Label();
            course = new TextBox();
            button = new Button();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // username
            // 
            username.AutoSize = true;
            username.Location = new Point(54, 76);
            username.Name = "username";
            username.Size = new Size(41, 15);
            username.TabIndex = 0;
            username.Text = "NAME";
            // 
            // course
            // 
            course.Location = new Point(131, 72);
            course.Name = "course";
            course.Size = new Size(349, 23);
            course.TabIndex = 1;
            course.Text = "aids";
            // 
            // button
            // 
            button.Location = new Point(516, 72);
            button.Name = "button";
            button.Size = new Size(81, 23);
            button.TabIndex = 2;
            button.Text = "Click";
            button.UseVisualStyleBackColor = true;
            button.Click += button_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(131, 151);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(452, 154);
            listBox1.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox1);
            Controls.Add(button);
            Controls.Add(course);
            Controls.Add(username);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label username;
        private TextBox course;
        private Button button;
        private ListBox listBox1;
    }
}
