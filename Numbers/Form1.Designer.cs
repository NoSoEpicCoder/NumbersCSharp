﻿namespace Numbers {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btnIntegers = new System.Windows.Forms.Button();
            this.btnFloat = new System.Windows.Forms.Button();
            this.btnDouble = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIntegers
            // 
            this.btnIntegers.Location = new System.Drawing.Point(110, 20);
            this.btnIntegers.Name = "btnIntegers";
            this.btnIntegers.Size = new System.Drawing.Size(75, 23);
            this.btnIntegers.TabIndex = 0;
            this.btnIntegers.Text = "Integers";
            this.btnIntegers.UseVisualStyleBackColor = true;
            this.btnIntegers.Click += new System.EventHandler(this.BtnIntegers_Click);
            // 
            // btnFloat
            // 
            this.btnFloat.Location = new System.Drawing.Point(110, 75);
            this.btnFloat.Name = "btnFloat";
            this.btnFloat.Size = new System.Drawing.Size(75, 23);
            this.btnFloat.TabIndex = 1;
            this.btnFloat.Text = "Float";
            this.btnFloat.UseVisualStyleBackColor = true;
            this.btnFloat.Click += new System.EventHandler(this.BtnFloat_Click);
            // 
            // btnDouble
            // 
            this.btnDouble.Location = new System.Drawing.Point(110, 130);
            this.btnDouble.Name = "btnDouble";
            this.btnDouble.Size = new System.Drawing.Size(75, 23);
            this.btnDouble.TabIndex = 2;
            this.btnDouble.Text = "Double";
            this.btnDouble.UseVisualStyleBackColor = true;
            this.btnDouble.Click += new System.EventHandler(this.BtnDouble_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDouble);
            this.Controls.Add(this.btnFloat);
            this.Controls.Add(this.btnIntegers);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIntegers;
        private System.Windows.Forms.Button btnFloat;
        private System.Windows.Forms.Button btnDouble;
    }
}

