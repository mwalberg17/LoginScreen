
namespace LoginScreen
{
    partial class LoginFrm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.uxUsernameTextbox = new System.Windows.Forms.TextBox();
            this.uxPasswordTextbox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.uxSubmitBtn = new System.Windows.Forms.Button();
            this.uxExitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // uxUsernameTextbox
            // 
            this.uxUsernameTextbox.Location = new System.Drawing.Point(95, 24);
            this.uxUsernameTextbox.Name = "uxUsernameTextbox";
            this.uxUsernameTextbox.Size = new System.Drawing.Size(170, 22);
            this.uxUsernameTextbox.TabIndex = 2;
            // 
            // uxPasswordTextbox
            // 
            this.uxPasswordTextbox.ContextMenuStrip = this.contextMenuStrip1;
            this.uxPasswordTextbox.Location = new System.Drawing.Point(95, 68);
            this.uxPasswordTextbox.Name = "uxPasswordTextbox";
            this.uxPasswordTextbox.PasswordChar = '*';
            this.uxPasswordTextbox.ShortcutsEnabled = false;
            this.uxPasswordTextbox.Size = new System.Drawing.Size(170, 22);
            this.uxPasswordTextbox.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // uxSubmitBtn
            // 
            this.uxSubmitBtn.Location = new System.Drawing.Point(15, 122);
            this.uxSubmitBtn.Name = "uxSubmitBtn";
            this.uxSubmitBtn.Size = new System.Drawing.Size(102, 71);
            this.uxSubmitBtn.TabIndex = 4;
            this.uxSubmitBtn.Text = "Submit";
            this.uxSubmitBtn.UseVisualStyleBackColor = true;
            this.uxSubmitBtn.Click += new System.EventHandler(this.uxSubmitBtn_Click);
            // 
            // uxExitBtn
            // 
            this.uxExitBtn.Location = new System.Drawing.Point(156, 122);
            this.uxExitBtn.Name = "uxExitBtn";
            this.uxExitBtn.Size = new System.Drawing.Size(109, 71);
            this.uxExitBtn.TabIndex = 5;
            this.uxExitBtn.Text = "Exit";
            this.uxExitBtn.UseVisualStyleBackColor = true;
            this.uxExitBtn.Click += new System.EventHandler(this.uxExitBtn_Click);
            // 
            // LoginFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 205);
            this.Controls.Add(this.uxExitBtn);
            this.Controls.Add(this.uxSubmitBtn);
            this.Controls.Add(this.uxPasswordTextbox);
            this.Controls.Add(this.uxUsernameTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LoginFrm";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox uxUsernameTextbox;
        private System.Windows.Forms.TextBox uxPasswordTextbox;
        private System.Windows.Forms.Button uxSubmitBtn;
        private System.Windows.Forms.Button uxExitBtn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}