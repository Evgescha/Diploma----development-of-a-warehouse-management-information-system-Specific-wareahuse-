namespace SchemaStore
{
    partial class AboutProduct
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.databaseDataSet = new SchemaStore.DatabaseDataSet();
            this.товарBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.товарTableAdapter = new SchemaStore.DatabaseDataSetTableAdapters.ТоварTableAdapter();
            this.нНDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.сокращенноDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценаBYNБезНдсDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценаRUBБезНдсDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.приЗаказе19DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.приЗаказе1049DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.приЗаказе5099DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.приЗаказеОт100DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.складBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.складTableAdapter = new SchemaStore.DatabaseDataSetTableAdapters.СкладTableAdapter();
            this.iDТовараDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.остатокDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.годсКоличествомDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.предзаказаноDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ожидаетсяОтПоставщикаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.виртуальныйОстатокDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.складBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.нНDataGridViewTextBoxColumn,
            this.наименованиеDataGridViewTextBoxColumn,
            this.сокращенноDataGridViewTextBoxColumn,
            this.ценаBYNБезНдсDataGridViewTextBoxColumn,
            this.ценаRUBБезНдсDataGridViewTextBoxColumn,
            this.приЗаказе19DataGridViewTextBoxColumn,
            this.приЗаказе1049DataGridViewTextBoxColumn,
            this.приЗаказе5099DataGridViewTextBoxColumn,
            this.приЗаказеОт100DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.товарBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1114, 112);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDТовараDataGridViewTextBoxColumn,
            this.остатокDataGridViewTextBoxColumn,
            this.годсКоличествомDataGridViewTextBoxColumn,
            this.предзаказаноDataGridViewTextBoxColumn,
            this.ожидаетсяОтПоставщикаDataGridViewTextBoxColumn,
            this.виртуальныйОстатокDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.складBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(12, 142);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(1114, 61);
            this.dataGridView2.TabIndex = 1;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(12, 288);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(1114, 61);
            this.dataGridView3.TabIndex = 2;
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(12, 355);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(1114, 61);
            this.dataGridView4.TabIndex = 3;
            // 
            // dataGridView5
            // 
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Location = new System.Drawing.Point(12, 434);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.Size = new System.Drawing.Size(1114, 61);
            this.dataGridView5.TabIndex = 4;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // товарBindingSource
            // 
            this.товарBindingSource.DataMember = "Товар";
            this.товарBindingSource.DataSource = this.databaseDataSet;
            // 
            // товарTableAdapter
            // 
            this.товарTableAdapter.ClearBeforeFill = true;
            // 
            // нНDataGridViewTextBoxColumn
            // 
            this.нНDataGridViewTextBoxColumn.DataPropertyName = "НН";
            this.нНDataGridViewTextBoxColumn.HeaderText = "НН";
            this.нНDataGridViewTextBoxColumn.Name = "нНDataGridViewTextBoxColumn";
            // 
            // наименованиеDataGridViewTextBoxColumn
            // 
            this.наименованиеDataGridViewTextBoxColumn.DataPropertyName = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn.Name = "наименованиеDataGridViewTextBoxColumn";
            // 
            // сокращенноDataGridViewTextBoxColumn
            // 
            this.сокращенноDataGridViewTextBoxColumn.DataPropertyName = "Сокращенно";
            this.сокращенноDataGridViewTextBoxColumn.HeaderText = "Сокращенно";
            this.сокращенноDataGridViewTextBoxColumn.Name = "сокращенноDataGridViewTextBoxColumn";
            // 
            // ценаBYNБезНдсDataGridViewTextBoxColumn
            // 
            this.ценаBYNБезНдсDataGridViewTextBoxColumn.DataPropertyName = "ЦенаBYNБезНдс";
            this.ценаBYNБезНдсDataGridViewTextBoxColumn.HeaderText = "ЦенаBYNБезНдс";
            this.ценаBYNБезНдсDataGridViewTextBoxColumn.Name = "ценаBYNБезНдсDataGridViewTextBoxColumn";
            // 
            // ценаRUBБезНдсDataGridViewTextBoxColumn
            // 
            this.ценаRUBБезНдсDataGridViewTextBoxColumn.DataPropertyName = "ЦенаRUBБезНдс";
            this.ценаRUBБезНдсDataGridViewTextBoxColumn.HeaderText = "ЦенаRUBБезНдс";
            this.ценаRUBБезНдсDataGridViewTextBoxColumn.Name = "ценаRUBБезНдсDataGridViewTextBoxColumn";
            // 
            // приЗаказе19DataGridViewTextBoxColumn
            // 
            this.приЗаказе19DataGridViewTextBoxColumn.DataPropertyName = "ПриЗаказе1-9";
            this.приЗаказе19DataGridViewTextBoxColumn.HeaderText = "ПриЗаказе1-9";
            this.приЗаказе19DataGridViewTextBoxColumn.Name = "приЗаказе19DataGridViewTextBoxColumn";
            // 
            // приЗаказе1049DataGridViewTextBoxColumn
            // 
            this.приЗаказе1049DataGridViewTextBoxColumn.DataPropertyName = "ПриЗаказе10-49";
            this.приЗаказе1049DataGridViewTextBoxColumn.HeaderText = "ПриЗаказе10-49";
            this.приЗаказе1049DataGridViewTextBoxColumn.Name = "приЗаказе1049DataGridViewTextBoxColumn";
            // 
            // приЗаказе5099DataGridViewTextBoxColumn
            // 
            this.приЗаказе5099DataGridViewTextBoxColumn.DataPropertyName = "ПриЗаказе50-99";
            this.приЗаказе5099DataGridViewTextBoxColumn.HeaderText = "ПриЗаказе50-99";
            this.приЗаказе5099DataGridViewTextBoxColumn.Name = "приЗаказе5099DataGridViewTextBoxColumn";
            // 
            // приЗаказеОт100DataGridViewTextBoxColumn
            // 
            this.приЗаказеОт100DataGridViewTextBoxColumn.DataPropertyName = "ПриЗаказеОт100";
            this.приЗаказеОт100DataGridViewTextBoxColumn.HeaderText = "ПриЗаказеОт100";
            this.приЗаказеОт100DataGridViewTextBoxColumn.Name = "приЗаказеОт100DataGridViewTextBoxColumn";
            // 
            // складBindingSource
            // 
            this.складBindingSource.DataMember = "Склад";
            this.складBindingSource.DataSource = this.databaseDataSet;
            // 
            // складTableAdapter
            // 
            this.складTableAdapter.ClearBeforeFill = true;
            // 
            // iDТовараDataGridViewTextBoxColumn
            // 
            this.iDТовараDataGridViewTextBoxColumn.DataPropertyName = "IDТовара";
            this.iDТовараDataGridViewTextBoxColumn.HeaderText = "IDТовара";
            this.iDТовараDataGridViewTextBoxColumn.Name = "iDТовараDataGridViewTextBoxColumn";
            // 
            // остатокDataGridViewTextBoxColumn
            // 
            this.остатокDataGridViewTextBoxColumn.DataPropertyName = "Остаток";
            this.остатокDataGridViewTextBoxColumn.HeaderText = "Остаток";
            this.остатокDataGridViewTextBoxColumn.Name = "остатокDataGridViewTextBoxColumn";
            // 
            // годсКоличествомDataGridViewTextBoxColumn
            // 
            this.годсКоличествомDataGridViewTextBoxColumn.DataPropertyName = "Год(сКоличеством)";
            this.годсКоличествомDataGridViewTextBoxColumn.HeaderText = "Год(сКоличеством)";
            this.годсКоличествомDataGridViewTextBoxColumn.Name = "годсКоличествомDataGridViewTextBoxColumn";
            // 
            // предзаказаноDataGridViewTextBoxColumn
            // 
            this.предзаказаноDataGridViewTextBoxColumn.DataPropertyName = "Предзаказано";
            this.предзаказаноDataGridViewTextBoxColumn.HeaderText = "Предзаказано";
            this.предзаказаноDataGridViewTextBoxColumn.Name = "предзаказаноDataGridViewTextBoxColumn";
            // 
            // ожидаетсяОтПоставщикаDataGridViewTextBoxColumn
            // 
            this.ожидаетсяОтПоставщикаDataGridViewTextBoxColumn.DataPropertyName = "ОжидаетсяОтПоставщика";
            this.ожидаетсяОтПоставщикаDataGridViewTextBoxColumn.HeaderText = "ОжидаетсяОтПоставщика";
            this.ожидаетсяОтПоставщикаDataGridViewTextBoxColumn.Name = "ожидаетсяОтПоставщикаDataGridViewTextBoxColumn";
            // 
            // виртуальныйОстатокDataGridViewTextBoxColumn
            // 
            this.виртуальныйОстатокDataGridViewTextBoxColumn.DataPropertyName = "ВиртуальныйОстаток";
            this.виртуальныйОстатокDataGridViewTextBoxColumn.HeaderText = "ВиртуальныйОстаток";
            this.виртуальныйОстатокDataGridViewTextBoxColumn.Name = "виртуальныйОстатокDataGridViewTextBoxColumn";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(13, 220);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // AboutProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 653);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridView5);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AboutProduct";
            this.Text = "О товарах";
            this.Load += new System.EventHandler(this.AboutProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.складBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridView dataGridView5;
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource товарBindingSource;
        private DatabaseDataSetTableAdapters.ТоварTableAdapter товарTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn нНDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn сокращенноDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценаBYNБезНдсDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценаRUBБезНдсDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn приЗаказе19DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn приЗаказе1049DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn приЗаказе5099DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn приЗаказеОт100DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource складBindingSource;
        private DatabaseDataSetTableAdapters.СкладTableAdapter складTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDТовараDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn остатокDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn годсКоличествомDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn предзаказаноDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ожидаетсяОтПоставщикаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn виртуальныйОстатокDataGridViewTextBoxColumn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}