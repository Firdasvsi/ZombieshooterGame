﻿namespace ZombieshooterGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menu = new System.Windows.Forms.Panel();
            this.btn_exit = new System.Windows.Forms.PictureBox();
            this.btn_option = new System.Windows.Forms.PictureBox();
            this.btn_start = new System.Windows.Forms.PictureBox();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_option)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_start)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.Transparent;
            this.menu.BackgroundImage = global::ZombieshooterGame.Properties.Resources.menu;
            this.menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menu.Controls.Add(this.btn_exit);
            this.menu.Controls.Add(this.btn_option);
            this.menu.Controls.Add(this.btn_start);
            this.menu.Location = new System.Drawing.Point(131, 77);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(252, 333);
            this.menu.TabIndex = 0;
            // 
            // btn_exit
            // 
            this.btn_exit.Image = global::ZombieshooterGame.Properties.Resources.exit_normal;
            this.btn_exit.Location = new System.Drawing.Point(67, 209);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(100, 43);
            this.btn_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btn_exit.TabIndex = 0;
            this.btn_exit.TabStop = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            this.btn_exit.MouseLeave += new System.EventHandler(this.btn_exit_MouseLeave);
            this.btn_exit.MouseHover += new System.EventHandler(this.btn_exit_MouseHover);
            // 
            // btn_option
            // 
            this.btn_option.Image = global::ZombieshooterGame.Properties.Resources.option_normal;
            this.btn_option.Location = new System.Drawing.Point(67, 144);
            this.btn_option.Name = "btn_option";
            this.btn_option.Size = new System.Drawing.Size(100, 43);
            this.btn_option.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btn_option.TabIndex = 0;
            this.btn_option.TabStop = false;
            this.btn_option.Click += new System.EventHandler(this.btn_option_Click);
            this.btn_option.MouseLeave += new System.EventHandler(this.btn_option_MouseLeave);
            this.btn_option.MouseHover += new System.EventHandler(this.btn_option_MouseHover);
            // 
            // btn_start
            // 
            this.btn_start.Image = global::ZombieshooterGame.Properties.Resources.start_normal;
            this.btn_start.Location = new System.Drawing.Point(67, 75);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(100, 43);
            this.btn_start.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btn_start.TabIndex = 0;
            this.btn_start.TabStop = false;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            this.btn_start.MouseLeave += new System.EventHandler(this.btn_start_MouseLeave);
            this.btn_start.MouseHover += new System.EventHandler(this.btn_start_MouseHover);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ZombieshooterGame.Properties.Resources.иииии;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(519, 503);
            this.Controls.Add(this.menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Start_Menu";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_option)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_start)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menu;
        private System.Windows.Forms.PictureBox btn_exit;
        private System.Windows.Forms.PictureBox btn_option;
        private System.Windows.Forms.PictureBox btn_start;
    }
}

