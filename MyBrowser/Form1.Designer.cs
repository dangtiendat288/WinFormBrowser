namespace MyBrowser
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
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.refreshButton = new System.Windows.Forms.Button();
            this.goButton = new System.Windows.Forms.Button();
            this.addrTextBox = new System.Windows.Forms.TextBox();
            this.homeButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.subButton = new System.Windows.Forms.Button();
            this.mulButton = new System.Windows.Forms.Button();
            this.divButton = new System.Windows.Forms.Button();
            this.nbr1TextBox = new System.Windows.Forms.TextBox();
            this.nbr2TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.resLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.encTextBox = new System.Windows.Forms.TextBox();
            this.encButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.decButton = new System.Windows.Forms.Button();
            this.decTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.encResLabel = new System.Windows.Forms.Label();
            this.decResLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(2, 34);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(796, 415);
            this.webBrowser1.TabIndex = 0;
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(2, 4);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 23);
            this.refreshButton.TabIndex = 3;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // goButton
            // 
            this.goButton.Location = new System.Drawing.Point(722, 5);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(75, 23);
            this.goButton.TabIndex = 4;
            this.goButton.Text = "Go";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // addrTextBox
            // 
            this.addrTextBox.Location = new System.Drawing.Point(164, 5);
            this.addrTextBox.Name = "addrTextBox";
            this.addrTextBox.Size = new System.Drawing.Size(552, 22);
            this.addrTextBox.TabIndex = 5;
            // 
            // homeButton
            // 
            this.homeButton.Location = new System.Drawing.Point(83, 4);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(75, 23);
            this.homeButton.TabIndex = 6;
            this.homeButton.Text = "Home";
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(43, 562);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(40, 23);
            this.addButton.TabIndex = 7;
            this.addButton.Text = "+";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // subButton
            // 
            this.subButton.Location = new System.Drawing.Point(89, 562);
            this.subButton.Name = "subButton";
            this.subButton.Size = new System.Drawing.Size(40, 23);
            this.subButton.TabIndex = 8;
            this.subButton.Text = "-";
            this.subButton.UseVisualStyleBackColor = true;
            this.subButton.Click += new System.EventHandler(this.subButton_Click);
            // 
            // mulButton
            // 
            this.mulButton.Location = new System.Drawing.Point(135, 562);
            this.mulButton.Name = "mulButton";
            this.mulButton.Size = new System.Drawing.Size(40, 23);
            this.mulButton.TabIndex = 9;
            this.mulButton.Text = "*";
            this.mulButton.UseVisualStyleBackColor = true;
            this.mulButton.Click += new System.EventHandler(this.mulButton_Click);
            // 
            // divButton
            // 
            this.divButton.Location = new System.Drawing.Point(181, 562);
            this.divButton.Name = "divButton";
            this.divButton.Size = new System.Drawing.Size(40, 23);
            this.divButton.TabIndex = 10;
            this.divButton.Text = "/";
            this.divButton.UseVisualStyleBackColor = true;
            this.divButton.Click += new System.EventHandler(this.divButton_Click);
            // 
            // nbr1TextBox
            // 
            this.nbr1TextBox.Location = new System.Drawing.Point(30, 511);
            this.nbr1TextBox.Name = "nbr1TextBox";
            this.nbr1TextBox.Size = new System.Drawing.Size(100, 22);
            this.nbr1TextBox.TabIndex = 11;
            // 
            // nbr2TextBox
            // 
            this.nbr2TextBox.Location = new System.Drawing.Point(136, 511);
            this.nbr2TextBox.Name = "nbr2TextBox";
            this.nbr2TextBox.Size = new System.Drawing.Size(100, 22);
            this.nbr2TextBox.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 472);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Simple calculator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 611);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "=";
            // 
            // resLabel
            // 
            this.resLabel.Location = new System.Drawing.Point(73, 645);
            this.resLabel.Name = "resLabel";
            this.resLabel.Size = new System.Drawing.Size(115, 16);
            this.resLabel.TabIndex = 15;
            this.resLabel.Text = "show result here";
            this.resLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(445, 472);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Text encryption/decryption";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(297, 511);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(283, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Please type the text you want to encrypt:";
            // 
            // encTextBox
            // 
            this.encTextBox.Location = new System.Drawing.Point(300, 539);
            this.encTextBox.Name = "encTextBox";
            this.encTextBox.Size = new System.Drawing.Size(392, 22);
            this.encTextBox.TabIndex = 18;
            // 
            // encButton
            // 
            this.encButton.Location = new System.Drawing.Point(698, 532);
            this.encButton.Name = "encButton";
            this.encButton.Size = new System.Drawing.Size(77, 36);
            this.encButton.TabIndex = 19;
            this.encButton.Text = "Encrypt";
            this.encButton.UseVisualStyleBackColor = true;
            this.encButton.Click += new System.EventHandler(this.encButton_Click);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(297, 577);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "Encrypted text:";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(297, 683);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 16);
            this.label6.TabIndex = 24;
            this.label6.Text = "Decrypted text:";
            // 
            // decButton
            // 
            this.decButton.Location = new System.Drawing.Point(698, 636);
            this.decButton.Name = "decButton";
            this.decButton.Size = new System.Drawing.Size(77, 36);
            this.decButton.TabIndex = 23;
            this.decButton.Text = "Decrypt";
            this.decButton.UseVisualStyleBackColor = true;
            this.decButton.Click += new System.EventHandler(this.decButton_Click);
            // 
            // decTextBox
            // 
            this.decTextBox.Location = new System.Drawing.Point(300, 643);
            this.decTextBox.Name = "decTextBox";
            this.decTextBox.Size = new System.Drawing.Size(392, 22);
            this.decTextBox.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(297, 613);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(284, 16);
            this.label7.TabIndex = 21;
            this.label7.Text = "Please type the text you want to decrypt:";
            // 
            // encResLabel
            // 
            this.encResLabel.Location = new System.Drawing.Point(395, 577);
            this.encResLabel.Name = "encResLabel";
            this.encResLabel.Size = new System.Drawing.Size(385, 16);
            this.encResLabel.TabIndex = 25;
            this.encResLabel.Text = "show encrypted text here";
            // 
            // decResLabel
            // 
            this.decResLabel.Location = new System.Drawing.Point(397, 683);
            this.decResLabel.Name = "decResLabel";
            this.decResLabel.Size = new System.Drawing.Size(385, 16);
            this.decResLabel.TabIndex = 26;
            this.decResLabel.Text = "show decrypted text here";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 719);
            this.Controls.Add(this.decResLabel);
            this.Controls.Add(this.encResLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.decButton);
            this.Controls.Add(this.decTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.encButton);
            this.Controls.Add(this.encTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.resLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nbr2TextBox);
            this.Controls.Add(this.nbr1TextBox);
            this.Controls.Add(this.divButton);
            this.Controls.Add(this.mulButton);
            this.Controls.Add(this.subButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.addrTextBox);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.webBrowser1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.TextBox addrTextBox;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button subButton;
        private System.Windows.Forms.Button mulButton;
        private System.Windows.Forms.Button divButton;
        private System.Windows.Forms.TextBox nbr1TextBox;
        private System.Windows.Forms.TextBox nbr2TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label resLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox encTextBox;
        private System.Windows.Forms.Button encButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button decButton;
        private System.Windows.Forms.TextBox decTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label encResLabel;
        private System.Windows.Forms.Label decResLabel;
    }
}

