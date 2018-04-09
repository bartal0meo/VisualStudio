namespace botstrony
{
    partial class Form1
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
            this.tresc_textbox = new System.Windows.Forms.RichTextBox();
            this.name_textbox = new System.Windows.Forms.TextBox();
            this.upload_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.email_textbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.phone_textbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mylomza_checkBox = new System.Windows.Forms.CheckBox();
            this.fourlomza_checkBox = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.time_label = new System.Windows.Forms.Label();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.kaliszak_checkbox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // tresc_textbox
            // 
            this.tresc_textbox.Location = new System.Drawing.Point(179, 33);
            this.tresc_textbox.Name = "tresc_textbox";
            this.tresc_textbox.Size = new System.Drawing.Size(358, 282);
            this.tresc_textbox.TabIndex = 0;
            this.tresc_textbox.Text = "";
            // 
            // name_textbox
            // 
            this.name_textbox.Location = new System.Drawing.Point(179, 343);
            this.name_textbox.Name = "name_textbox";
            this.name_textbox.Size = new System.Drawing.Size(358, 20);
            this.name_textbox.TabIndex = 1;
            // 
            // upload_button
            // 
            this.upload_button.Location = new System.Drawing.Point(28, 33);
            this.upload_button.Name = "upload_button";
            this.upload_button.Size = new System.Drawing.Size(109, 78);
            this.upload_button.TabIndex = 2;
            this.upload_button.Text = "Wyślij";
            this.upload_button.UseVisualStyleBackColor = true;
            this.upload_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Treść ogłoszenia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 327);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nazwa firmy";
            // 
            // email_textbox
            // 
            this.email_textbox.Location = new System.Drawing.Point(179, 382);
            this.email_textbox.Name = "email_textbox";
            this.email_textbox.Size = new System.Drawing.Size(358, 20);
            this.email_textbox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(176, 366);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "E-mail";
            // 
            // phone_textbox
            // 
            this.phone_textbox.Location = new System.Drawing.Point(179, 421);
            this.phone_textbox.Name = "phone_textbox";
            this.phone_textbox.Size = new System.Drawing.Size(358, 20);
            this.phone_textbox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(176, 405);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Telefon";
            // 
            // mylomza_checkBox
            // 
            this.mylomza_checkBox.AutoSize = true;
            this.mylomza_checkBox.Location = new System.Drawing.Point(12, 147);
            this.mylomza_checkBox.Name = "mylomza_checkBox";
            this.mylomza_checkBox.Size = new System.Drawing.Size(77, 17);
            this.mylomza_checkBox.TabIndex = 9;
            this.mylomza_checkBox.Text = "mylomza.pl";
            this.mylomza_checkBox.UseVisualStyleBackColor = true;
            this.mylomza_checkBox.CheckedChanged += new System.EventHandler(this.mylomza_checkBox_CheckedChanged);
            // 
            // fourlomza_checkBox
            // 
            this.fourlomza_checkBox.AutoSize = true;
            this.fourlomza_checkBox.Location = new System.Drawing.Point(12, 170);
            this.fourlomza_checkBox.Name = "fourlomza_checkBox";
            this.fourlomza_checkBox.Size = new System.Drawing.Size(70, 17);
            this.fourlomza_checkBox.TabIndex = 10;
            this.fourlomza_checkBox.Text = "4lomza.pl";
            this.fourlomza_checkBox.UseVisualStyleBackColor = true;
            this.fourlomza_checkBox.CheckedChanged += new System.EventHandler(this.fourlomza_checkBox_CheckedChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // time_label
            // 
            this.time_label.AutoSize = true;
            this.time_label.Location = new System.Drawing.Point(312, 17);
            this.time_label.Name = "time_label";
            this.time_label.Size = new System.Drawing.Size(0, 13);
            this.time_label.TabIndex = 11;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(552, 33);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(787, 408);
            this.webBrowser1.TabIndex = 13;
            // 
            // kaliszak_checkbox
            // 
            this.kaliszak_checkbox.AutoSize = true;
            this.kaliszak_checkbox.Location = new System.Drawing.Point(12, 193);
            this.kaliszak_checkbox.Name = "kaliszak_checkbox";
            this.kaliszak_checkbox.Size = new System.Drawing.Size(75, 17);
            this.kaliszak_checkbox.TabIndex = 14;
            this.kaliszak_checkbox.Text = "kaliszak.pl";
            this.kaliszak_checkbox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1342, 457);
            this.Controls.Add(this.kaliszak_checkbox);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.time_label);
            this.Controls.Add(this.fourlomza_checkBox);
            this.Controls.Add(this.mylomza_checkBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.phone_textbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.email_textbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.upload_button);
            this.Controls.Add(this.name_textbox);
            this.Controls.Add(this.tresc_textbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox tresc_textbox;
        private System.Windows.Forms.TextBox name_textbox;
        private System.Windows.Forms.Button upload_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox email_textbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox phone_textbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox mylomza_checkBox;
        private System.Windows.Forms.CheckBox fourlomza_checkBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label time_label;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.CheckBox kaliszak_checkbox;
    }
}

