namespace SchemaStore
{
    partial class ReportGenerator
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
            this.productGrid = new System.Windows.Forms.DataGridView();
            this.grusoGrid = new System.Windows.Forms.DataGridView();
            this.customerGrid = new System.Windows.Forms.DataGridView();
            this.кППDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.иННDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.индексDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.адресDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.заказчикDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кППDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.иННDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.индексDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.адресDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderGrid = new System.Windows.Forms.DataGridView();
            this.databaseDataSet = new SchemaStore.DatabaseDataSet();
            this.заказBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.заказTableAdapter = new SchemaStore.DatabaseDataSetTableAdapters.ЗаказTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.заказчикDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.статусDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаВыполненияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.общаяСтоимостьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.стоимостьНДСDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.типДоставкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.стоимостьСДоставкойDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.грузополучательDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаЗаказаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.заказТоварыЗаказаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.товарыЗаказаTableAdapter = new SchemaStore.DatabaseDataSetTableAdapters.ТоварыЗаказаTableAdapter();
            this.заказчикBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.заказчикTableAdapter = new SchemaStore.DatabaseDataSetTableAdapters.ЗаказчикTableAdapter();
            this.заказчикГрузополучательBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.заказчикГрузополучательTableAdapter = new SchemaStore.DatabaseDataSetTableAdapters.ЗаказчикГрузополучательTableAdapter();
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.заказDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.товарDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценаНаМоментПродажиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фактЦенаПродажиЗаШтDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.суммаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.productGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grusoGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказТоварыЗаказаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказчикBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказчикГрузополучательBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // productGrid
            // 
            this.productGrid.AllowUserToAddRows = false;
            this.productGrid.AllowUserToDeleteRows = false;
            this.productGrid.AutoGenerateColumns = false;
            this.productGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn1,
            this.заказDataGridViewTextBoxColumn,
            this.товарDataGridViewTextBoxColumn,
            this.количествоDataGridViewTextBoxColumn,
            this.ценаНаМоментПродажиDataGridViewTextBoxColumn,
            this.фактЦенаПродажиЗаШтDataGridViewTextBoxColumn,
            this.суммаDataGridViewTextBoxColumn});
            this.productGrid.DataSource = this.заказТоварыЗаказаBindingSource;
            this.productGrid.Location = new System.Drawing.Point(13, 174);
            this.productGrid.Name = "productGrid";
            this.productGrid.ReadOnly = true;
            this.productGrid.Size = new System.Drawing.Size(1310, 96);
            this.productGrid.TabIndex = 3;
            // 
            // grusoGrid
            // 
            this.grusoGrid.AllowUserToAddRows = false;
            this.grusoGrid.AllowUserToDeleteRows = false;
            this.grusoGrid.AutoGenerateColumns = false;
            this.grusoGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grusoGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn2,
            this.заказчикDataGridViewTextBoxColumn1,
            this.названиеDataGridViewTextBoxColumn,
            this.адресDataGridViewTextBoxColumn,
            this.индексDataGridViewTextBoxColumn,
            this.иННDataGridViewTextBoxColumn,
            this.кППDataGridViewTextBoxColumn});
            this.grusoGrid.DataSource = this.заказчикГрузополучательBindingSource;
            this.grusoGrid.Location = new System.Drawing.Point(12, 276);
            this.grusoGrid.Name = "grusoGrid";
            this.grusoGrid.ReadOnly = true;
            this.grusoGrid.Size = new System.Drawing.Size(634, 145);
            this.grusoGrid.TabIndex = 4;
            // 
            // customerGrid
            // 
            this.customerGrid.AutoGenerateColumns = false;
            this.customerGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn3,
            this.названиеDataGridViewTextBoxColumn1,
            this.адресDataGridViewTextBoxColumn1,
            this.индексDataGridViewTextBoxColumn1,
            this.иННDataGridViewTextBoxColumn1,
            this.кППDataGridViewTextBoxColumn1});
            this.customerGrid.DataSource = this.заказчикBindingSource;
            this.customerGrid.Location = new System.Drawing.Point(652, 276);
            this.customerGrid.Name = "customerGrid";
            this.customerGrid.Size = new System.Drawing.Size(670, 145);
            this.customerGrid.TabIndex = 5;
            // 
            // кППDataGridViewTextBoxColumn
            // 
            this.кППDataGridViewTextBoxColumn.DataPropertyName = "КПП";
            this.кППDataGridViewTextBoxColumn.HeaderText = "КПП";
            this.кППDataGridViewTextBoxColumn.Name = "кППDataGridViewTextBoxColumn";
            this.кППDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // иННDataGridViewTextBoxColumn
            // 
            this.иННDataGridViewTextBoxColumn.DataPropertyName = "ИНН";
            this.иННDataGridViewTextBoxColumn.HeaderText = "ИНН";
            this.иННDataGridViewTextBoxColumn.Name = "иННDataGridViewTextBoxColumn";
            this.иННDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // индексDataGridViewTextBoxColumn
            // 
            this.индексDataGridViewTextBoxColumn.DataPropertyName = "Индекс";
            this.индексDataGridViewTextBoxColumn.HeaderText = "Индекс";
            this.индексDataGridViewTextBoxColumn.Name = "индексDataGridViewTextBoxColumn";
            this.индексDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // адресDataGridViewTextBoxColumn
            // 
            this.адресDataGridViewTextBoxColumn.DataPropertyName = "Адрес";
            this.адресDataGridViewTextBoxColumn.HeaderText = "Адрес";
            this.адресDataGridViewTextBoxColumn.Name = "адресDataGridViewTextBoxColumn";
            this.адресDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // названиеDataGridViewTextBoxColumn
            // 
            this.названиеDataGridViewTextBoxColumn.DataPropertyName = "Название";
            this.названиеDataGridViewTextBoxColumn.HeaderText = "Название";
            this.названиеDataGridViewTextBoxColumn.Name = "названиеDataGridViewTextBoxColumn";
            this.названиеDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // заказчикDataGridViewTextBoxColumn1
            // 
            this.заказчикDataGridViewTextBoxColumn1.DataPropertyName = "Заказчик";
            this.заказчикDataGridViewTextBoxColumn1.HeaderText = "Заказчик";
            this.заказчикDataGridViewTextBoxColumn1.Name = "заказчикDataGridViewTextBoxColumn1";
            this.заказчикDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // iDDataGridViewTextBoxColumn2
            // 
            this.iDDataGridViewTextBoxColumn2.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn2.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn2.Name = "iDDataGridViewTextBoxColumn2";
            this.iDDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // кППDataGridViewTextBoxColumn1
            // 
            this.кППDataGridViewTextBoxColumn1.DataPropertyName = "КПП";
            this.кППDataGridViewTextBoxColumn1.HeaderText = "КПП";
            this.кППDataGridViewTextBoxColumn1.Name = "кППDataGridViewTextBoxColumn1";
            // 
            // иННDataGridViewTextBoxColumn1
            // 
            this.иННDataGridViewTextBoxColumn1.DataPropertyName = "ИНН";
            this.иННDataGridViewTextBoxColumn1.HeaderText = "ИНН";
            this.иННDataGridViewTextBoxColumn1.Name = "иННDataGridViewTextBoxColumn1";
            // 
            // индексDataGridViewTextBoxColumn1
            // 
            this.индексDataGridViewTextBoxColumn1.DataPropertyName = "Индекс";
            this.индексDataGridViewTextBoxColumn1.HeaderText = "Индекс";
            this.индексDataGridViewTextBoxColumn1.Name = "индексDataGridViewTextBoxColumn1";
            // 
            // адресDataGridViewTextBoxColumn1
            // 
            this.адресDataGridViewTextBoxColumn1.DataPropertyName = "Адрес";
            this.адресDataGridViewTextBoxColumn1.HeaderText = "Адрес";
            this.адресDataGridViewTextBoxColumn1.Name = "адресDataGridViewTextBoxColumn1";
            // 
            // названиеDataGridViewTextBoxColumn1
            // 
            this.названиеDataGridViewTextBoxColumn1.DataPropertyName = "Название";
            this.названиеDataGridViewTextBoxColumn1.HeaderText = "Название";
            this.названиеDataGridViewTextBoxColumn1.Name = "названиеDataGridViewTextBoxColumn1";
            // 
            // iDDataGridViewTextBoxColumn3
            // 
            this.iDDataGridViewTextBoxColumn3.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn3.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn3.Name = "iDDataGridViewTextBoxColumn3";
            // 
            // orderGrid
            // 
            this.orderGrid.AutoGenerateColumns = false;
            this.orderGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.заказчикDataGridViewTextBoxColumn,
            this.статусDataGridViewTextBoxColumn,
            this.датаВыполненияDataGridViewTextBoxColumn,
            this.общаяСтоимостьDataGridViewTextBoxColumn,
            this.стоимостьНДСDataGridViewTextBoxColumn,
            this.типДоставкиDataGridViewTextBoxColumn,
            this.стоимостьСДоставкойDataGridViewTextBoxColumn,
            this.грузополучательDataGridViewTextBoxColumn,
            this.датаЗаказаDataGridViewTextBoxColumn});
            this.orderGrid.DataSource = this.заказBindingSource;
            this.orderGrid.Location = new System.Drawing.Point(13, 13);
            this.orderGrid.Name = "orderGrid";
            this.orderGrid.Size = new System.Drawing.Size(1309, 126);
            this.orderGrid.TabIndex = 6;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // заказBindingSource
            // 
            this.заказBindingSource.DataMember = "Заказ";
            this.заказBindingSource.DataSource = this.databaseDataSet;
            // 
            // заказTableAdapter
            // 
            this.заказTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // заказчикDataGridViewTextBoxColumn
            // 
            this.заказчикDataGridViewTextBoxColumn.DataPropertyName = "Заказчик";
            this.заказчикDataGridViewTextBoxColumn.HeaderText = "Заказчик";
            this.заказчикDataGridViewTextBoxColumn.Name = "заказчикDataGridViewTextBoxColumn";
            // 
            // статусDataGridViewTextBoxColumn
            // 
            this.статусDataGridViewTextBoxColumn.DataPropertyName = "Статус";
            this.статусDataGridViewTextBoxColumn.HeaderText = "Статус";
            this.статусDataGridViewTextBoxColumn.Name = "статусDataGridViewTextBoxColumn";
            // 
            // датаВыполненияDataGridViewTextBoxColumn
            // 
            this.датаВыполненияDataGridViewTextBoxColumn.DataPropertyName = "ДатаВыполнения";
            this.датаВыполненияDataGridViewTextBoxColumn.HeaderText = "ДатаВыполнения";
            this.датаВыполненияDataGridViewTextBoxColumn.Name = "датаВыполненияDataGridViewTextBoxColumn";
            // 
            // общаяСтоимостьDataGridViewTextBoxColumn
            // 
            this.общаяСтоимостьDataGridViewTextBoxColumn.DataPropertyName = "ОбщаяСтоимость";
            this.общаяСтоимостьDataGridViewTextBoxColumn.HeaderText = "ОбщаяСтоимость";
            this.общаяСтоимостьDataGridViewTextBoxColumn.Name = "общаяСтоимостьDataGridViewTextBoxColumn";
            // 
            // стоимостьНДСDataGridViewTextBoxColumn
            // 
            this.стоимостьНДСDataGridViewTextBoxColumn.DataPropertyName = "СтоимостьНДС";
            this.стоимостьНДСDataGridViewTextBoxColumn.HeaderText = "СтоимостьНДС";
            this.стоимостьНДСDataGridViewTextBoxColumn.Name = "стоимостьНДСDataGridViewTextBoxColumn";
            // 
            // типДоставкиDataGridViewTextBoxColumn
            // 
            this.типДоставкиDataGridViewTextBoxColumn.DataPropertyName = "ТипДоставки";
            this.типДоставкиDataGridViewTextBoxColumn.HeaderText = "ТипДоставки";
            this.типДоставкиDataGridViewTextBoxColumn.Name = "типДоставкиDataGridViewTextBoxColumn";
            // 
            // стоимостьСДоставкойDataGridViewTextBoxColumn
            // 
            this.стоимостьСДоставкойDataGridViewTextBoxColumn.DataPropertyName = "СтоимостьСДоставкой";
            this.стоимостьСДоставкойDataGridViewTextBoxColumn.HeaderText = "СтоимостьСДоставкой";
            this.стоимостьСДоставкойDataGridViewTextBoxColumn.Name = "стоимостьСДоставкойDataGridViewTextBoxColumn";
            // 
            // грузополучательDataGridViewTextBoxColumn
            // 
            this.грузополучательDataGridViewTextBoxColumn.DataPropertyName = "Грузополучатель";
            this.грузополучательDataGridViewTextBoxColumn.HeaderText = "Грузополучатель";
            this.грузополучательDataGridViewTextBoxColumn.Name = "грузополучательDataGridViewTextBoxColumn";
            // 
            // датаЗаказаDataGridViewTextBoxColumn
            // 
            this.датаЗаказаDataGridViewTextBoxColumn.DataPropertyName = "ДатаЗаказа";
            this.датаЗаказаDataGridViewTextBoxColumn.HeaderText = "ДатаЗаказа";
            this.датаЗаказаDataGridViewTextBoxColumn.Name = "датаЗаказаDataGridViewTextBoxColumn";
            // 
            // заказТоварыЗаказаBindingSource
            // 
            this.заказТоварыЗаказаBindingSource.DataMember = "ЗаказТоварыЗаказа";
            this.заказТоварыЗаказаBindingSource.DataSource = this.заказBindingSource;
            // 
            // товарыЗаказаTableAdapter
            // 
            this.товарыЗаказаTableAdapter.ClearBeforeFill = true;
            // 
            // заказчикBindingSource
            // 
            this.заказчикBindingSource.DataMember = "Заказчик";
            this.заказчикBindingSource.DataSource = this.databaseDataSet;
            // 
            // заказчикTableAdapter
            // 
            this.заказчикTableAdapter.ClearBeforeFill = true;
            // 
            // заказчикГрузополучательBindingSource
            // 
            this.заказчикГрузополучательBindingSource.DataMember = "ЗаказчикГрузополучатель";
            this.заказчикГрузополучательBindingSource.DataSource = this.databaseDataSet;
            // 
            // заказчикГрузополучательTableAdapter
            // 
            this.заказчикГрузополучательTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn1
            // 
            this.iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
            this.iDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // заказDataGridViewTextBoxColumn
            // 
            this.заказDataGridViewTextBoxColumn.DataPropertyName = "Заказ";
            this.заказDataGridViewTextBoxColumn.HeaderText = "Заказ";
            this.заказDataGridViewTextBoxColumn.Name = "заказDataGridViewTextBoxColumn";
            this.заказDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // товарDataGridViewTextBoxColumn
            // 
            this.товарDataGridViewTextBoxColumn.DataPropertyName = "Товар";
            this.товарDataGridViewTextBoxColumn.HeaderText = "Товар";
            this.товарDataGridViewTextBoxColumn.Name = "товарDataGridViewTextBoxColumn";
            this.товарDataGridViewTextBoxColumn.ReadOnly = true;
            this.товарDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // количествоDataGridViewTextBoxColumn
            // 
            this.количествоDataGridViewTextBoxColumn.DataPropertyName = "Количество";
            this.количествоDataGridViewTextBoxColumn.HeaderText = "Количество";
            this.количествоDataGridViewTextBoxColumn.Name = "количествоDataGridViewTextBoxColumn";
            this.количествоDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ценаНаМоментПродажиDataGridViewTextBoxColumn
            // 
            this.ценаНаМоментПродажиDataGridViewTextBoxColumn.DataPropertyName = "ЦенаНаМоментПродажи";
            this.ценаНаМоментПродажиDataGridViewTextBoxColumn.HeaderText = "ЦенаНаМоментПродажи";
            this.ценаНаМоментПродажиDataGridViewTextBoxColumn.Name = "ценаНаМоментПродажиDataGridViewTextBoxColumn";
            this.ценаНаМоментПродажиDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // фактЦенаПродажиЗаШтDataGridViewTextBoxColumn
            // 
            this.фактЦенаПродажиЗаШтDataGridViewTextBoxColumn.DataPropertyName = "ФактЦенаПродажиЗаШт";
            this.фактЦенаПродажиЗаШтDataGridViewTextBoxColumn.HeaderText = "ФактЦенаПродажиЗаШт";
            this.фактЦенаПродажиЗаШтDataGridViewTextBoxColumn.Name = "фактЦенаПродажиЗаШтDataGridViewTextBoxColumn";
            this.фактЦенаПродажиЗаШтDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // суммаDataGridViewTextBoxColumn
            // 
            this.суммаDataGridViewTextBoxColumn.DataPropertyName = "Сумма";
            this.суммаDataGridViewTextBoxColumn.HeaderText = "Сумма";
            this.суммаDataGridViewTextBoxColumn.Name = "суммаDataGridViewTextBoxColumn";
            this.суммаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ReportGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 433);
            this.Controls.Add(this.orderGrid);
            this.Controls.Add(this.customerGrid);
            this.Controls.Add(this.grusoGrid);
            this.Controls.Add(this.productGrid);
            this.Name = "ReportGenerator";
            this.Text = "TEST";
            this.Load += new System.EventHandler(this.TEST_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grusoGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказТоварыЗаказаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказчикBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказчикГрузополучательBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView productGrid;
        private System.Windows.Forms.DataGridView grusoGrid;
        private System.Windows.Forms.DataGridView customerGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn заказчикDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn адресDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn индексDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn иННDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кППDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn адресDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn индексDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn иННDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn кППDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView orderGrid;
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource заказBindingSource;
        private DatabaseDataSetTableAdapters.ЗаказTableAdapter заказTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn заказчикDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn статусDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаВыполненияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn общаяСтоимостьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn стоимостьНДСDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn типДоставкиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn стоимостьСДоставкойDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn грузополучательDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаЗаказаDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource заказТоварыЗаказаBindingSource;
        private DatabaseDataSetTableAdapters.ТоварыЗаказаTableAdapter товарыЗаказаTableAdapter;
        private System.Windows.Forms.BindingSource заказчикBindingSource;
        private DatabaseDataSetTableAdapters.ЗаказчикTableAdapter заказчикTableAdapter;
        private System.Windows.Forms.BindingSource заказчикГрузополучательBindingSource;
        private DatabaseDataSetTableAdapters.ЗаказчикГрузополучательTableAdapter заказчикГрузополучательTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn заказDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn товарDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценаНаМоментПродажиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фактЦенаПродажиЗаШтDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn суммаDataGridViewTextBoxColumn;
    }
}