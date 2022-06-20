namespace Game_Rental_System
{
    partial class BrowseGames
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrowseGames));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cATEGORYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRICEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATECREATEDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gAMEIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vENDORIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDMINIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noRentedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATEPUBLISHEDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTATDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gAMEBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.game_rentalFINAL = new Game_Rental_System.Game_rentalFINAL();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gAMEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.game_rentaV2 = new Game_Rental_System.Game_rentaV2();
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB2022DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB2022DataSet = new Game_Rental_System.DB2022DataSet();
            this.departmentTableAdapter = new Game_Rental_System.DB2022DataSetTableAdapters.departmentTableAdapter();
            this.gamerentaV2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gAMETableAdapter = new Game_Rental_System.Game_rentaV2TableAdapters.GAMETableAdapter();
            this.tableAdapterManager = new Game_Rental_System.Game_rentaV2TableAdapters.TableAdapterManager();
            this.gamerentalFINALBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gAMETableAdapter1 = new Game_Rental_System.Game_rentalFINALTableAdapters.GAMETableAdapter();
            this.tableAdapterManager1 = new Game_Rental_System.Game_rentalFINALTableAdapters.TableAdapterManager();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gAMEBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.game_rentalFINAL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gAMEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.game_rentaV2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB2022DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB2022DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamerentaV2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamerentalFINALBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(263, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(763, 665);
            this.panel1.TabIndex = 1;
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
            this.gNAMEDataGridViewTextBoxColumn,
            this.cATEGORYDataGridViewTextBoxColumn,
            this.pRICEDataGridViewTextBoxColumn,
            this.dATECREATEDDataGridViewTextBoxColumn,
            this.gAMEIDDataGridViewTextBoxColumn,
            this.vENDORIDDataGridViewTextBoxColumn,
            this.aDMINIDDataGridViewTextBoxColumn,
            this.noRentedDataGridViewTextBoxColumn,
            this.dATEPUBLISHEDDataGridViewTextBoxColumn,
            this.sTATDataGridViewTextBoxColumn});
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
            this.dataGridView1.Location = new System.Drawing.Point(20, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(711, 471);
            this.dataGridView1.TabIndex = 42;
            // 
            // gNAMEDataGridViewTextBoxColumn
            // 
            this.gNAMEDataGridViewTextBoxColumn.DataPropertyName = "GNAME";
            this.gNAMEDataGridViewTextBoxColumn.HeaderText = "GAME NAME";
            this.gNAMEDataGridViewTextBoxColumn.Name = "gNAMEDataGridViewTextBoxColumn";
            this.gNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cATEGORYDataGridViewTextBoxColumn
            // 
            this.cATEGORYDataGridViewTextBoxColumn.DataPropertyName = "CATEGORY";
            this.cATEGORYDataGridViewTextBoxColumn.HeaderText = "CATEGORY";
            this.cATEGORYDataGridViewTextBoxColumn.Name = "cATEGORYDataGridViewTextBoxColumn";
            this.cATEGORYDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pRICEDataGridViewTextBoxColumn
            // 
            this.pRICEDataGridViewTextBoxColumn.DataPropertyName = "PRICE";
            this.pRICEDataGridViewTextBoxColumn.HeaderText = "PRICE";
            this.pRICEDataGridViewTextBoxColumn.Name = "pRICEDataGridViewTextBoxColumn";
            this.pRICEDataGridViewTextBoxColumn.ReadOnly = true;
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
            // aDMINIDDataGridViewTextBoxColumn
            // 
            this.aDMINIDDataGridViewTextBoxColumn.DataPropertyName = "ADMINID";
            this.aDMINIDDataGridViewTextBoxColumn.HeaderText = "ADMINID";
            this.aDMINIDDataGridViewTextBoxColumn.Name = "aDMINIDDataGridViewTextBoxColumn";
            this.aDMINIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // noRentedDataGridViewTextBoxColumn
            // 
            this.noRentedDataGridViewTextBoxColumn.DataPropertyName = "NoRented";
            this.noRentedDataGridViewTextBoxColumn.HeaderText = "NoRented";
            this.noRentedDataGridViewTextBoxColumn.Name = "noRentedDataGridViewTextBoxColumn";
            this.noRentedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dATEPUBLISHEDDataGridViewTextBoxColumn
            // 
            this.dATEPUBLISHEDDataGridViewTextBoxColumn.DataPropertyName = "DATEPUBLISHED";
            this.dATEPUBLISHEDDataGridViewTextBoxColumn.HeaderText = "DATEPUBLISHED";
            this.dATEPUBLISHEDDataGridViewTextBoxColumn.Name = "dATEPUBLISHEDDataGridViewTextBoxColumn";
            this.dATEPUBLISHEDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sTATDataGridViewTextBoxColumn
            // 
            this.sTATDataGridViewTextBoxColumn.DataPropertyName = "STAT";
            this.sTATDataGridViewTextBoxColumn.HeaderText = "STAT";
            this.sTATDataGridViewTextBoxColumn.Name = "sTATDataGridViewTextBoxColumn";
            this.sTATDataGridViewTextBoxColumn.ReadOnly = true;
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
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Open Sans Extrabold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(55)))), ((int)(((byte)(252)))));
            this.button1.Location = new System.Drawing.Point(608, 574);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 49);
            this.button1.TabIndex = 41;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Impact", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 53);
            this.label1.TabIndex = 35;
            this.label1.Text = "Browse Games";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gAMEBindingSource
            // 
            this.gAMEBindingSource.DataMember = "GAME";
            this.gAMEBindingSource.DataSource = this.game_rentaV2;
            // 
            // game_rentaV2
            // 
            this.game_rentaV2.DataSetName = "Game_rentaV2";
            this.game_rentaV2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataMember = "department";
            this.departmentBindingSource.DataSource = this.dB2022DataSetBindingSource;
            // 
            // dB2022DataSetBindingSource
            // 
            this.dB2022DataSetBindingSource.DataSource = this.dB2022DataSet;
            this.dB2022DataSetBindingSource.Position = 0;
            // 
            // dB2022DataSet
            // 
            this.dB2022DataSet.DataSetName = "DB2022DataSet";
            this.dB2022DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // departmentTableAdapter
            // 
            this.departmentTableAdapter.ClearBeforeFill = true;
            // 
            // gamerentaV2BindingSource
            // 
            this.gamerentaV2BindingSource.DataSource = this.game_rentaV2;
            this.gamerentaV2BindingSource.Position = 0;
            // 
            // gAMETableAdapter
            // 
            this.gAMETableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ADMINTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BROWSETableAdapter = null;
            this.tableAdapterManager.CLIENTTableAdapter = null;
            this.tableAdapterManager.GAMETableAdapter = this.gAMETableAdapter;
            this.tableAdapterManager.RENTTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Game_Rental_System.Game_rentaV2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VENDORTableAdapter = null;
            // 
            // gamerentalFINALBindingSource
            // 
            this.gamerentalFINALBindingSource.DataSource = this.game_rentalFINAL;
            this.gamerentalFINALBindingSource.Position = 0;
            // 
            // gAMETableAdapter1
            // 
            this.gAMETableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.ADMINTableAdapter = null;
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.CLIENTTableAdapter = null;
            this.tableAdapterManager1.GAMETableAdapter = this.gAMETableAdapter1;
            this.tableAdapterManager1.RENTTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = Game_Rental_System.Game_rentalFINALTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.VENDORTableAdapter = null;
            // 
            // BrowseGames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(72)))));
            this.ClientSize = new System.Drawing.Size(1026, 665);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BrowseGames";
            this.Text = "BrowseGames";
            this.Load += new System.EventHandler(this.BrowseGames_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gAMEBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.game_rentalFINAL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gAMEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.game_rentaV2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB2022DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB2022DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamerentaV2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamerentalFINALBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource dB2022DataSetBindingSource;
        private DB2022DataSet dB2022DataSet;
        private System.Windows.Forms.BindingSource departmentBindingSource;
        private DB2022DataSetTableAdapters.departmentTableAdapter departmentTableAdapter;
        private System.Windows.Forms.BindingSource gamerentaV2BindingSource;
        private Game_rentaV2 game_rentaV2;
        private System.Windows.Forms.BindingSource gAMEBindingSource;
        private Game_rentaV2TableAdapters.GAMETableAdapter gAMETableAdapter;
        private Game_rentaV2TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource gamerentalFINALBindingSource;
        private Game_rentalFINAL game_rentalFINAL;
        private System.Windows.Forms.BindingSource gAMEBindingSource1;
        private Game_rentalFINALTableAdapters.GAMETableAdapter gAMETableAdapter1;
        private Game_rentalFINALTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cATEGORYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRICEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATECREATEDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gAMEIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vENDORIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDMINIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noRentedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATEPUBLISHEDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTATDataGridViewTextBoxColumn;
    }
}