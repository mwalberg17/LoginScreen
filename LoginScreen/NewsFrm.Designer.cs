﻿
namespace LoginScreen
{
    partial class NewsFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.uxBackBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxBackBtn
            // 
            this.uxBackBtn.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxBackBtn.Location = new System.Drawing.Point(253, 200);
            this.uxBackBtn.Name = "uxBackBtn";
            this.uxBackBtn.Size = new System.Drawing.Size(96, 46);
            this.uxBackBtn.TabIndex = 1;
            this.uxBackBtn.Text = "Back";
            this.uxBackBtn.UseVisualStyleBackColor = true;
            this.uxBackBtn.Click += new System.EventHandler(this.uxBackBtn_Click);
            // 
            // NewsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(106)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(435, 426);
            this.Controls.Add(this.uxBackBtn);
            this.Name = "NewsFrm";
            this.Text = "NewsFrm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button uxBackBtn;
    }
}