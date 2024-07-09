namespace WinFormsApp_FilterMySQL
{
    partial class Form_Authorize
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
            this.maskedTextBox_password = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.maskedTextBox_login = new System.Windows.Forms.MaskedTextBox();
            this.button_register = new System.Windows.Forms.Button();
            this.button_vhod = new System.Windows.Forms.Button();
            this.button_byguest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // maskedTextBox_password
            // 
            this.maskedTextBox_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBox_password.Location = new System.Drawing.Point(128, 112);
            this.maskedTextBox_password.Name = "maskedTextBox_password";
            this.maskedTextBox_password.Size = new System.Drawing.Size(125, 22);
            this.maskedTextBox_password.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(70, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(63, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Пароль";
            // 
            // maskedTextBox_login
            // 
            this.maskedTextBox_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBox_login.Location = new System.Drawing.Point(128, 72);
            this.maskedTextBox_login.Name = "maskedTextBox_login";
            this.maskedTextBox_login.Size = new System.Drawing.Size(125, 22);
            this.maskedTextBox_login.TabIndex = 3;
            // 
            // button_register
            // 
            this.button_register.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_register.Location = new System.Drawing.Point(249, 226);
            this.button_register.Name = "button_register";
            this.button_register.Size = new System.Drawing.Size(114, 25);
            this.button_register.TabIndex = 4;
            this.button_register.Text = "Регистрация";
            this.button_register.UseVisualStyleBackColor = true;
            this.button_register.Click += new System.EventHandler(this.button_register_Click);
            // 
            // button_vhod
            // 
            this.button_vhod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_vhod.Location = new System.Drawing.Point(145, 157);
            this.button_vhod.Name = "button_vhod";
            this.button_vhod.Size = new System.Drawing.Size(88, 25);
            this.button_vhod.TabIndex = 5;
            this.button_vhod.Text = "Вход";
            this.button_vhod.UseVisualStyleBackColor = true;
            this.button_vhod.Click += new System.EventHandler(this.button_vhod_Click);
            // 
            // button_byguest
            // 
            this.button_byguest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_byguest.Location = new System.Drawing.Point(12, 226);
            this.button_byguest.Name = "button_byguest";
            this.button_byguest.Size = new System.Drawing.Size(128, 25);
            this.button_byguest.TabIndex = 6;
            this.button_byguest.Text = "Войти как гость";
            this.button_byguest.UseVisualStyleBackColor = true;
            this.button_byguest.Click += new System.EventHandler(this.button_byguest_Click);
            // 
            // Form_Authorize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(375, 263);
            this.Controls.Add(this.button_byguest);
            this.Controls.Add(this.button_vhod);
            this.Controls.Add(this.button_register);
            this.Controls.Add(this.maskedTextBox_login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maskedTextBox_password);
            this.MaximizeBox = false;
            this.Name = "Form_Authorize";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация пользователя";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedTextBox_password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_login;
        private System.Windows.Forms.Button button_register;
        private System.Windows.Forms.Button button_vhod;
        private System.Windows.Forms.Button button_byguest;
    }
}