namespace ZH_ASWYGE
{
    partial class Form2
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
            this.textBoxMegnevezés = new System.Windows.Forms.TextBox();
            this.textBoxEgységár = new System.Windows.Forms.TextBox();
            this.textBoxMe = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxMegnevezés
            // 
            this.textBoxMegnevezés.Location = new System.Drawing.Point(114, 38);
            this.textBoxMegnevezés.Name = "textBoxMegnevezés";
            this.textBoxMegnevezés.Size = new System.Drawing.Size(100, 23);
            this.textBoxMegnevezés.TabIndex = 0;
            // 
            // textBoxEgységár
            // 
            this.textBoxEgységár.Location = new System.Drawing.Point(114, 96);
            this.textBoxEgységár.Name = "textBoxEgységár";
            this.textBoxEgységár.Size = new System.Drawing.Size(100, 23);
            this.textBoxEgységár.TabIndex = 2;
            // 
            // textBoxMe
            // 
            this.textBoxMe.Location = new System.Drawing.Point(114, 125);
            this.textBoxMe.Name = "textBoxMe";
            this.textBoxMe.Size = new System.Drawing.Size(100, 23);
            this.textBoxMe.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Megnevezés";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(114, 67);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 23);
            this.comboBox1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Kategória";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Egységár";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Mértékegység";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(27, 154);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(90, 22);
            this.buttonCancel.TabIndex = 9;
            this.buttonCancel.Text = "Mégse";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(123, 154);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(91, 22);
            this.buttonOK.TabIndex = 10;
            this.buttonOK.Text = "Létrehozás";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Validating += new System.ComponentModel.CancelEventHandler(this.buttonOK_Validating);
            this.buttonOK.Validated += new System.EventHandler(this.buttonOK_Validated);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxMe);
            this.Controls.Add(this.textBoxEgységár);
            this.Controls.Add(this.textBoxMegnevezés);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button buttonCancel;
        private Button buttonOK;
        public TextBox textBoxMegnevezés;
        public TextBox textBoxEgységár;
        public TextBox textBoxMe;
        public ComboBox comboBox1;
    }
}