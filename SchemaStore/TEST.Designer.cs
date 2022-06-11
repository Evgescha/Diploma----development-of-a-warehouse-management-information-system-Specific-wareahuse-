namespace SchemaStore
{
    partial class TEST
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
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
            this.товарBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.товарTableAdapter = new SchemaStore.DatabaseDataSetTableAdapters.ТоварTableAdapter();
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.заказDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.товарDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.количествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценаНаМоментПродажиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фактЦенаПродажиЗаШтDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.суммаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказТоварыЗаказаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1269, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 342);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1271, 398);
            this.dataGridView1.TabIndex = 1;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dataGridView2.DataSource = this.заказBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(13, 49);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(1269, 104);
            this.dataGridView2.TabIndex = 2;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn1,
            this.заказDataGridViewTextBoxColumn,
            this.товарDataGridViewTextBoxColumn,
            this.количествоDataGridViewTextBoxColumn,
            this.ценаНаМоментПродажиDataGridViewTextBoxColumn,
            this.фактЦенаПродажиЗаШтDataGridViewTextBoxColumn,
            this.суммаDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.заказТоварыЗаказаBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(12, 200);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(1269, 104);
            this.dataGridView3.TabIndex = 3;
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
            // товарBindingSource
            // 
            this.товарBindingSource.DataMember = "Товар";
            this.товарBindingSource.DataSource = this.databaseDataSet;
            // 
            // товарTableAdapter
            // 
            this.товарTableAdapter.ClearBeforeFill = true;
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
            this.товарDataGridViewTextBoxColumn.DataSource = this.товарBindingSource;
            this.товарDataGridViewTextBoxColumn.DisplayMember = "Наименование";
            this.товарDataGridViewTextBoxColumn.HeaderText = "Товар";
            this.товарDataGridViewTextBoxColumn.Name = "товарDataGridViewTextBoxColumn";
            this.товарDataGridViewTextBoxColumn.ReadOnly = true;
            this.товарDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.товарDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.товарDataGridViewTextBoxColumn.ValueMember = "НН";
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
            // TEST
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1294, 749);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "TEST";
            this.Text = "TEST";
            this.Load += new System.EventHandler(this.TEST_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказТоварыЗаказаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
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
        private System.Windows.Forms.BindingSource товарBindingSource;
        private DatabaseDataSetTableAdapters.ТоварTableAdapter товарTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn заказDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn товарDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценаНаМоментПродажиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фактЦенаПродажиЗаШтDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn суммаDataGridViewTextBoxColumn;
    }
}