﻿namespace WindowsFormsTest
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Createbutton = new System.Windows.Forms.Button();
            this.ReadtextBox = new System.Windows.Forms.TextBox();
            this.ChetSumButton = new System.Windows.Forms.Button();
            this.OutputtextBox = new System.Windows.Forms.TextBox();
            this.NeChetbutton = new System.Windows.Forms.Button();
            this.ArraytextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Createbutton
            // 
            this.Createbutton.Location = new System.Drawing.Point(0, 0);
            this.Createbutton.Name = "Createbutton";
            this.Createbutton.Size = new System.Drawing.Size(75, 23);
            this.Createbutton.TabIndex = 0;
            this.Createbutton.Text = "Create";
            this.Createbutton.UseVisualStyleBackColor = true;
            this.Createbutton.Click += new System.EventHandler(this.Createbutton_Click);
            // 
            // ReadtextBox
            // 
            this.ReadtextBox.Location = new System.Drawing.Point(103, 3);
            this.ReadtextBox.Name = "ReadtextBox";
            this.ReadtextBox.Size = new System.Drawing.Size(100, 20);
            this.ReadtextBox.TabIndex = 1;
            // 
            // ChetSumButton
            // 
            this.ChetSumButton.Location = new System.Drawing.Point(0, 32);
            this.ChetSumButton.Name = "ChetSumButton";
            this.ChetSumButton.Size = new System.Drawing.Size(75, 23);
            this.ChetSumButton.TabIndex = 2;
            this.ChetSumButton.Text = "ChetSum";
            this.ChetSumButton.UseCompatibleTextRendering = true;
            this.ChetSumButton.UseVisualStyleBackColor = true;
            this.ChetSumButton.Click += new System.EventHandler(this.ChetSumButton_Click);
            // 
            // OutputtextBox
            // 
            this.OutputtextBox.Location = new System.Drawing.Point(103, 32);
            this.OutputtextBox.Name = "OutputtextBox";
            this.OutputtextBox.Size = new System.Drawing.Size(100, 20);
            this.OutputtextBox.TabIndex = 3;
            // 
            // NeChetbutton
            // 
            this.NeChetbutton.Location = new System.Drawing.Point(0, 61);
            this.NeChetbutton.Name = "NeChetbutton";
            this.NeChetbutton.Size = new System.Drawing.Size(75, 23);
            this.NeChetbutton.TabIndex = 4;
            this.NeChetbutton.Text = "NeChetSum";
            this.NeChetbutton.UseCompatibleTextRendering = true;
            this.NeChetbutton.UseVisualStyleBackColor = true;
            this.NeChetbutton.Click += new System.EventHandler(this.NeChetbutton_Click);
            // 
            // ArraytextBox
            // 
            this.ArraytextBox.Location = new System.Drawing.Point(231, 3);
            this.ArraytextBox.Name = "ArraytextBox";
            this.ArraytextBox.Size = new System.Drawing.Size(100, 20);
            this.ArraytextBox.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ArraytextBox);
            this.Controls.Add(this.NeChetbutton);
            this.Controls.Add(this.OutputtextBox);
            this.Controls.Add(this.ChetSumButton);
            this.Controls.Add(this.ReadtextBox);
            this.Controls.Add(this.Createbutton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Createbutton;
        private System.Windows.Forms.TextBox ReadtextBox;
        private System.Windows.Forms.Button ChetSumButton;
        private System.Windows.Forms.TextBox OutputtextBox;
        private System.Windows.Forms.Button NeChetbutton;
        private System.Windows.Forms.TextBox ArraytextBox;
    }
}

