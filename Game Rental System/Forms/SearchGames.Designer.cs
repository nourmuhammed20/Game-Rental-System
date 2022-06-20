namespace Game_Rental_System
{
    partial class SearchGames
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchGames));
            this.panel2 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.GNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRICEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cATEGORYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATEPUBLISHEDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATECREATEDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gAMEIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vENDORIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoRented = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gAMEBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.game_rentalFINAL = new Game_Rental_System.Game_rentalFINAL();
            this.label1 = new System.Windows.Forms.Label();
            this.gAMEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.game_rentalv3 = new Game_Rental_System.Game_rentalv3();
            this.gAMETableAdapter = new Game_Rental_System.Game_rentalv3TableAdapters.GAMETableAdapter();
            this.vENDORBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vENDORTableAdapter = new Game_Rental_System.Game_rentalv3TableAdapters.VENDORTableAdapter();
            this.gAMETableAdapter1 = new Game_Rental_System.Game_rentalFINALTableAdapters.GAMETableAdapter();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gAMEBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.game_rentalFINAL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gAMEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.game_rentalv3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENDORBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.textBox4);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(235, 665);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 288);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(208, 21);
            this.dateTimePicker1.TabIndex = 42;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Open Sans Extrabold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(55)))), ((int)(((byte)(252)))));
            this.button2.Location = new System.Drawing.Point(35, 348);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 46);
            this.button2.TabIndex = 41;
            this.button2.Text = "Filter";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(17, 205);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(205, 29);
            this.textBox4.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(17, 111);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(205, 29);
            this.textBox1.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(55)))), ((int)(((byte)(252)))));
            this.label6.Location = new System.Drawing.Point(12, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "YEAR";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(55)))), ((int)(((byte)(252)))));
            this.label5.Location = new System.Drawing.Point(13, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "CATEGORY";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(55)))), ((int)(((byte)(252)))));
            this.label2.Location = new System.Drawing.Point(13, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Game Name";
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Open Sans Extrabold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(55)))), ((int)(((byte)(252)))));
            this.button3.Location = new System.Drawing.Point(593, 614);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(152, 39);
            this.button3.TabIndex = 41;
            this.button3.Text = "Return";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Open Sans Extrabold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(55)))), ((int)(((byte)(252)))));
            this.button1.Location = new System.Drawing.Point(593, 569);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 39);
            this.button1.TabIndex = 41;
            this.button1.Text = "Rent";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(329, 604);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(186, 29);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(55)))), ((int)(((byte)(252)))));
            this.label3.Location = new System.Drawing.Point(325, 582);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Client ID";
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(94, 604);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(186, 29);
            this.textBox5.TabIndex = 1;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Impact", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(55)))), ((int)(((byte)(252)))));
            this.label7.Location = new System.Drawing.Point(90, 582);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "Game ID";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(228, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 665);
            this.panel1.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GNAME,
            this.pRICEDataGridViewTextBoxColumn,
            this.cATEGORYDataGridViewTextBoxColumn,
            this.dATEPUBLISHEDDataGridViewTextBoxColumn,
            this.dATECREATEDDataGridViewTextBoxColumn,
            this.gAMEIDDataGridViewTextBoxColumn,
            this.vENDORIDDataGridViewTextBoxColumn,
            this.NoRented});
            this.dataGridView1.DataSource = this.gAMEBindingSource1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(3, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(742, 471);
            this.dataGridView1.TabIndex = 42;
            // 
            // GNAME
            // 
            this.GNAME.DataPropertyName = "GNAME";
            this.GNAME.HeaderText = "Game Name";
            this.GNAME.Name = "GNAME";
            this.GNAME.ReadOnly = true;
            // 
            // pRICEDataGridViewTextBoxColumn
            // 
            this.pRICEDataGridViewTextBoxColumn.DataPropertyName = "PRICE";
            this.pRICEDataGridViewTextBoxColumn.HeaderText = "PRICE";
            this.pRICEDataGridViewTextBoxColumn.Name = "pRICEDataGridViewTextBoxColumn";
            this.pRICEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cATEGORYDataGridViewTextBoxColumn
            // 
            this.cATEGORYDataGridViewTextBoxColumn.DataPropertyName = "CATEGORY";
            this.cATEGORYDataGridViewTextBoxColumn.HeaderText = "CATEGORY";
            this.cATEGORYDataGridViewTextBoxColumn.Name = "cATEGORYDataGridViewTextBoxColumn";
            this.cATEGORYDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dATEPUBLISHEDDataGridViewTextBoxColumn
            // 
            this.dATEPUBLISHEDDataGridViewTextBoxColumn.DataPropertyName = "DATEPUBLISHED";
            this.dATEPUBLISHEDDataGridViewTextBoxColumn.HeaderText = "DATEPUBLISHED";
            this.dATEPUBLISHEDDataGridViewTextBoxColumn.Name = "dATEPUBLISHEDDataGridViewTextBoxColumn";
            this.dATEPUBLISHEDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dATECREATEDDataGridViewTextBoxColumn
            // 
            this.dATECREATEDDataGridViewTextBoxColumn.DataPropertyName = "DATECREATED";
            this.dATECREATEDDataGridViewTextBoxColumn.HeaderText = "DATECREATED";
            this.dATECREATEDDataGridViewTextBoxColumn.Name = "dATECREATEDDataGridViewTextBoxColumn";
            this.dATECREATEDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gAMEIDDataGridViewTextBoxColumn
            // 
            this.gAMEIDDataGridViewTextBoxColumn.DataPropertyName = "GAMEID";
            this.gAMEIDDataGridViewTextBoxColumn.HeaderText = "GAMEID";
            this.gAMEIDDataGridViewTextBoxColumn.Name = "gAMEIDDataGridViewTextBoxColumn";
            this.gAMEIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vENDORIDDataGridViewTextBoxColumn
            // 
            this.vENDORIDDataGridViewTextBoxColumn.DataPropertyName = "VENDORID";
            this.vENDORIDDataGridViewTextBoxColumn.HeaderText = "VENDORID";
            this.vENDORIDDataGridViewTextBoxColumn.Name = "vENDORIDDataGridViewTextBoxColumn";
            this.vENDORIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // NoRented
            // 
            this.NoRented.DataPropertyName = "NoRented";
            this.NoRented.HeaderText = "#Rented";
            this.NoRented.Name = "NoRented";
            this.NoRented.ReadOnly = true;
            // 
            // gAMEBindingSource1
            // 
            this.gAMEBindingSource1.DataMember = "GAME";
            this.gAMEBindingSource1.DataSource = this.game_rentalFINAL;
            // 
            // game_rentalFINAL
            // 
            this.game_rentalFINAL.DataSetName = "Game_rentalFINAL";
            this.game_rentalFINAL.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Impact", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 53);
            this.label1.TabIndex = 35;
            this.label1.Text = "Search Games";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gAMEBindingSource
            // 
            this.gAMEBindingSource.DataMember = "GAME";
            this.gAMEBindingSource.DataSource = this.game_rentalv3;
            // 
            // game_rentalv3
            // 
            this.game_rentalv3.DataSetName = "Game_rentalv3";
            this.game_rentalv3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gAMETableAdapter
            // 
            this.gAMETableAdapter.ClearBeforeFill = true;
            // 
            // vENDORBindingSource
            // 
            this.vENDORBindingSource.DataMember = "VENDOR";
            this.vENDORBindingSource.DataSource = this.game_rentalv3;
            // 
            // vENDORTableAdapter
            // 
            this.vENDORTableAdapter.ClearBeforeFill = true;
            // 
            // gAMETableAdapter1
            // 
            this.gAMETableAdapter1.ClearBeforeFill = true;
            // 
            // SearchGames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(72)))));
            this.ClientSize = new System.Drawing.Size(1026, 665);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SearchGames";
            this.Text = "SearchGames";
            this.Load += new System.EventHandler(this.SearchGames_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gAMEBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.game_rentalFINAL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gAMEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.game_rentalv3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENDORBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label7;
        private Game_rentalv3 game_rentalv3;
        private System.Windows.Forms.BindingSource gAMEBindingSource;
        private Game_rentalv3TableAdapters.GAMETableAdapter gAMETableAdapter;
        private System.Windows.Forms.BindingSource vENDORBindingSource;
        private Game_rentalv3TableAdapters.VENDORTableAdapter vENDORTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn GNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRICEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cATEGORYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATEPUBLISHEDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATECREATEDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gAMEIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vENDORIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoRented;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private Game_rentalFINAL game_rentalFINAL;
        private System.Windows.Forms.BindingSource gAMEBindingSource1;
        private Game_rentalFINALTableAdapters.GAMETableAdapter gAMETableAdapter1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}