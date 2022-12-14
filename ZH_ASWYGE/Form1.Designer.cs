namespace ZH_ASWYGE
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
            this.components = new System.ComponentModel.Container();
            this.listBoxÜgyfél = new System.Windows.Forms.ListBox();
            this.listBoxRendelés = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.termékkódDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.terméknévDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kategóriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.egységárDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mennyiségDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mértékegységDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.árDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tételekBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.tételekBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tételekBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tételekBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listBoxTermék = new System.Windows.Forms.ListBox();
            this.textBoxÜgyfél = new System.Windows.Forms.TextBox();
            this.textBoxTermék = new System.Windows.Forms.TextBox();
            this.textBoxÖsszérték = new System.Windows.Forms.TextBox();
            this.textBoxMennyiség = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tételekBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tételekBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tételekBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tételekBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxÜgyfél
            // 
            this.listBoxÜgyfél.FormattingEnabled = true;
            this.listBoxÜgyfél.ItemHeight = 15;
            this.listBoxÜgyfél.Location = new System.Drawing.Point(14, 77);
            this.listBoxÜgyfél.Name = "listBoxÜgyfél";
            this.listBoxÜgyfél.Size = new System.Drawing.Size(120, 154);
            this.listBoxÜgyfél.TabIndex = 0;
            this.listBoxÜgyfél.SelectedIndexChanged += new System.EventHandler(this.listBoxÜgyfél_SelectedIndexChanged);
            // 
            // listBoxRendelés
            // 
            this.listBoxRendelés.FormattingEnabled = true;
            this.listBoxRendelés.ItemHeight = 15;
            this.listBoxRendelés.Location = new System.Drawing.Point(140, 77);
            this.listBoxRendelés.Name = "listBoxRendelés";
            this.listBoxRendelés.Size = new System.Drawing.Size(120, 154);
            this.listBoxRendelés.TabIndex = 1;
            this.listBoxRendelés.SelectedIndexChanged += new System.EventHandler(this.listBoxRendelés_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.termékkódDataGridViewTextBoxColumn,
            this.terméknévDataGridViewTextBoxColumn,
            this.kategóriaDataGridViewTextBoxColumn,
            this.egységárDataGridViewTextBoxColumn,
            this.mennyiségDataGridViewTextBoxColumn,
            this.mértékegységDataGridViewTextBoxColumn,
            this.árDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tételekBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(266, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(240, 154);
            this.dataGridView1.TabIndex = 2;
            // 
            // termékkódDataGridViewTextBoxColumn
            // 
            this.termékkódDataGridViewTextBoxColumn.DataPropertyName = "Termékkód";
            this.termékkódDataGridViewTextBoxColumn.HeaderText = "Termékkód";
            this.termékkódDataGridViewTextBoxColumn.Name = "termékkódDataGridViewTextBoxColumn";
            // 
            // terméknévDataGridViewTextBoxColumn
            // 
            this.terméknévDataGridViewTextBoxColumn.DataPropertyName = "Terméknév";
            this.terméknévDataGridViewTextBoxColumn.HeaderText = "Terméknév";
            this.terméknévDataGridViewTextBoxColumn.Name = "terméknévDataGridViewTextBoxColumn";
            // 
            // kategóriaDataGridViewTextBoxColumn
            // 
            this.kategóriaDataGridViewTextBoxColumn.DataPropertyName = "Kategória";
            this.kategóriaDataGridViewTextBoxColumn.HeaderText = "Kategória";
            this.kategóriaDataGridViewTextBoxColumn.Name = "kategóriaDataGridViewTextBoxColumn";
            // 
            // egységárDataGridViewTextBoxColumn
            // 
            this.egységárDataGridViewTextBoxColumn.DataPropertyName = "Egységár";
            this.egységárDataGridViewTextBoxColumn.HeaderText = "Egységár";
            this.egységárDataGridViewTextBoxColumn.Name = "egységárDataGridViewTextBoxColumn";
            // 
            // mennyiségDataGridViewTextBoxColumn
            // 
            this.mennyiségDataGridViewTextBoxColumn.DataPropertyName = "Mennyiség";
            this.mennyiségDataGridViewTextBoxColumn.HeaderText = "Mennyiség";
            this.mennyiségDataGridViewTextBoxColumn.Name = "mennyiségDataGridViewTextBoxColumn";
            // 
            // mértékegységDataGridViewTextBoxColumn
            // 
            this.mértékegységDataGridViewTextBoxColumn.DataPropertyName = "Mértékegység";
            this.mértékegységDataGridViewTextBoxColumn.HeaderText = "Mértékegység";
            this.mértékegységDataGridViewTextBoxColumn.Name = "mértékegységDataGridViewTextBoxColumn";
            // 
            // árDataGridViewTextBoxColumn
            // 
            this.árDataGridViewTextBoxColumn.DataPropertyName = "Ár";
            this.árDataGridViewTextBoxColumn.HeaderText = "Ár";
            this.árDataGridViewTextBoxColumn.Name = "árDataGridViewTextBoxColumn";
            // 
            // tételekBindingSource3
            // 
            this.tételekBindingSource3.DataSource = typeof(ZH_ASWYGE.Tételek);
            // 
            // tételekBindingSource1
            // 
            this.tételekBindingSource1.DataSource = typeof(ZH_ASWYGE.Tételek);
            // 
            // tételekBindingSource2
            // 
            this.tételekBindingSource2.DataSource = typeof(ZH_ASWYGE.Tételek);
            // 
            // tételekBindingSource
            // 
            this.tételekBindingSource.DataSource = typeof(ZH_ASWYGE.Tételek);
            // 
            // listBoxTermék
            // 
            this.listBoxTermék.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxTermék.FormattingEnabled = true;
            this.listBoxTermék.ItemHeight = 15;
            this.listBoxTermék.Location = new System.Drawing.Point(566, 77);
            this.listBoxTermék.Name = "listBoxTermék";
            this.listBoxTermék.Size = new System.Drawing.Size(120, 154);
            this.listBoxTermék.TabIndex = 3;
            // 
            // textBoxÜgyfél
            // 
            this.textBoxÜgyfél.Location = new System.Drawing.Point(14, 48);
            this.textBoxÜgyfél.Name = "textBoxÜgyfél";
            this.textBoxÜgyfél.Size = new System.Drawing.Size(120, 23);
            this.textBoxÜgyfél.TabIndex = 4;
            this.textBoxÜgyfél.TextChanged += new System.EventHandler(this.textBoxÜgyfél_TextChanged);
            // 
            // textBoxTermék
            // 
            this.textBoxTermék.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTermék.Location = new System.Drawing.Point(566, 48);
            this.textBoxTermék.Name = "textBoxTermék";
            this.textBoxTermék.Size = new System.Drawing.Size(120, 23);
            this.textBoxTermék.TabIndex = 5;
            this.textBoxTermék.TextChanged += new System.EventHandler(this.textBoxTermék_TextChanged);
            // 
            // textBoxÖsszérték
            // 
            this.textBoxÖsszérték.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxÖsszérték.Location = new System.Drawing.Point(407, 237);
            this.textBoxÖsszérték.Name = "textBoxÖsszérték";
            this.textBoxÖsszérték.Size = new System.Drawing.Size(99, 23);
            this.textBoxÖsszérték.TabIndex = 6;
            // 
            // textBoxMennyiség
            // 
            this.textBoxMennyiség.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMennyiség.Location = new System.Drawing.Point(586, 237);
            this.textBoxMennyiség.Name = "textBoxMennyiség";
            this.textBoxMennyiség.Size = new System.Drawing.Size(100, 23);
            this.textBoxMennyiség.TabIndex = 7;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd.Location = new System.Drawing.Point(512, 121);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(48, 23);
            this.buttonAdd.TabIndex = 8;
            this.buttonAdd.Text = "+";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRemove.Location = new System.Drawing.Point(512, 150);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(48, 23);
            this.buttonRemove.TabIndex = 9;
            this.buttonRemove.Text = "-";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(547, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Új termék létrehozása";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxMennyiség);
            this.Controls.Add(this.textBoxÖsszérték);
            this.Controls.Add(this.textBoxTermék);
            this.Controls.Add(this.textBoxÜgyfél);
            this.Controls.Add(this.listBoxTermék);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.listBoxRendelés);
            this.Controls.Add(this.listBoxÜgyfél);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tételekBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tételekBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tételekBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tételekBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listBoxÜgyfél;
        private ListBox listBoxRendelés;
        private DataGridView dataGridView1;
        private ListBox listBoxTermék;
        private TextBox textBoxÜgyfél;
        private TextBox textBoxTermék;
        private TextBox textBoxÖsszérték;
        private TextBox textBoxMennyiség;
        private Button buttonAdd;
        private Button buttonRemove;
        private BindingSource tételekBindingSource;
        private BindingSource tételekBindingSource1;
        private BindingSource tételekBindingSource2;
        private DataGridViewTextBoxColumn termékkódDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn terméknévDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn kategóriaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn egységárDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn mennyiségDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn mértékegységDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn árDataGridViewTextBoxColumn;
        private BindingSource tételekBindingSource3;
        private Button button1;
    }
}