namespace SchoolFormApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.TextBox();
            this.city = new System.Windows.Forms.TextBox();
            this.state = new System.Windows.Forms.TextBox();
            this.twitter = new System.Windows.Forms.TextBox();
            this.zip = new System.Windows.Forms.TextBox();
            this.phoneNumber = new System.Windows.Forms.TextBox();
            this.btnPushToText = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "School Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "City";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "State";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Zip";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Phone Number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(56, 305);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Twitter";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(189, 27);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(125, 27);
            this.name.TabIndex = 7;
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(189, 69);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(125, 27);
            this.address.TabIndex = 8;
            // 
            // city
            // 
            this.city.Location = new System.Drawing.Point(189, 116);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(125, 27);
            this.city.TabIndex = 9;
            // 
            // state
            // 
            this.state.Location = new System.Drawing.Point(189, 160);
            this.state.Name = "state";
            this.state.Size = new System.Drawing.Size(125, 27);
            this.state.TabIndex = 10;
            // 
            // twitter
            // 
            this.twitter.Location = new System.Drawing.Point(189, 302);
            this.twitter.Name = "twitter";
            this.twitter.Size = new System.Drawing.Size(125, 27);
            this.twitter.TabIndex = 11;
            // 
            // zip
            // 
            this.zip.Location = new System.Drawing.Point(189, 215);
            this.zip.Name = "zip";
            this.zip.Size = new System.Drawing.Size(125, 27);
            this.zip.TabIndex = 12;
            // 
            // phoneNumber
            // 
            this.phoneNumber.Location = new System.Drawing.Point(189, 259);
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.Size = new System.Drawing.Size(125, 27);
            this.phoneNumber.TabIndex = 13;
            // 
            // btnPushToText
            // 
            this.btnPushToText.Location = new System.Drawing.Point(87, 365);
            this.btnPushToText.Name = "btnPushToText";
            this.btnPushToText.Size = new System.Drawing.Size(188, 29);
            this.btnPushToText.TabIndex = 14;
            this.btnPushToText.Text = "Push To Test";
            this.btnPushToText.UseVisualStyleBackColor = true;
            this.btnPushToText.Click += new System.EventHandler(this.btnPushToText_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 450);
            this.Controls.Add(this.btnPushToText);
            this.Controls.Add(this.phoneNumber);
            this.Controls.Add(this.zip);
            this.Controls.Add(this.twitter);
            this.Controls.Add(this.state);
            this.Controls.Add(this.city);
            this.Controls.Add(this.address);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox name;
        private TextBox address;
        private TextBox city;
        private TextBox state;
        private TextBox twitter;
        private TextBox zip;
        private TextBox phoneNumber;
        private Button btnPushToText;
    }
}