namespace Lab14
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.numDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kod2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kod3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kod4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kod5DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kod6DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datavvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLab14BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lab14DataSet = new Lab14.lab14DataSet();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tableLab14TableAdapter = new Lab14.lab14DataSetTableAdapters.TableLab14TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableLab14BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lab14DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numDataGridViewTextBoxColumn,
            this.kodDataGridViewTextBoxColumn,
            this.kod2DataGridViewTextBoxColumn,
            this.kod3DataGridViewTextBoxColumn,
            this.kod4DataGridViewTextBoxColumn,
            this.kod5DataGridViewTextBoxColumn,
            this.kod6DataGridViewTextBoxColumn,
            this.datavvDataGridViewTextBoxColumn,
            this.colDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tableLab14BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(950, 389);
            this.dataGridView1.TabIndex = 0;
            // 
            // numDataGridViewTextBoxColumn
            // 
            this.numDataGridViewTextBoxColumn.DataPropertyName = "num";
            this.numDataGridViewTextBoxColumn.HeaderText = "num";
            this.numDataGridViewTextBoxColumn.Name = "numDataGridViewTextBoxColumn";
            // 
            // kodDataGridViewTextBoxColumn
            // 
            this.kodDataGridViewTextBoxColumn.DataPropertyName = "kod";
            this.kodDataGridViewTextBoxColumn.HeaderText = "kod";
            this.kodDataGridViewTextBoxColumn.Name = "kodDataGridViewTextBoxColumn";
            // 
            // kod2DataGridViewTextBoxColumn
            // 
            this.kod2DataGridViewTextBoxColumn.DataPropertyName = "kod2";
            this.kod2DataGridViewTextBoxColumn.HeaderText = "kod2";
            this.kod2DataGridViewTextBoxColumn.Name = "kod2DataGridViewTextBoxColumn";
            // 
            // kod3DataGridViewTextBoxColumn
            // 
            this.kod3DataGridViewTextBoxColumn.DataPropertyName = "kod3";
            this.kod3DataGridViewTextBoxColumn.HeaderText = "kod3";
            this.kod3DataGridViewTextBoxColumn.Name = "kod3DataGridViewTextBoxColumn";
            // 
            // kod4DataGridViewTextBoxColumn
            // 
            this.kod4DataGridViewTextBoxColumn.DataPropertyName = "kod4";
            this.kod4DataGridViewTextBoxColumn.HeaderText = "kod4";
            this.kod4DataGridViewTextBoxColumn.Name = "kod4DataGridViewTextBoxColumn";
            // 
            // kod5DataGridViewTextBoxColumn
            // 
            this.kod5DataGridViewTextBoxColumn.DataPropertyName = "kod5";
            this.kod5DataGridViewTextBoxColumn.HeaderText = "kod5";
            this.kod5DataGridViewTextBoxColumn.Name = "kod5DataGridViewTextBoxColumn";
            // 
            // kod6DataGridViewTextBoxColumn
            // 
            this.kod6DataGridViewTextBoxColumn.DataPropertyName = "kod6";
            this.kod6DataGridViewTextBoxColumn.HeaderText = "kod6";
            this.kod6DataGridViewTextBoxColumn.Name = "kod6DataGridViewTextBoxColumn";
            // 
            // datavvDataGridViewTextBoxColumn
            // 
            this.datavvDataGridViewTextBoxColumn.DataPropertyName = "datavv";
            this.datavvDataGridViewTextBoxColumn.HeaderText = "datavv";
            this.datavvDataGridViewTextBoxColumn.Name = "datavvDataGridViewTextBoxColumn";
            // 
            // colDataGridViewTextBoxColumn
            // 
            this.colDataGridViewTextBoxColumn.DataPropertyName = "col";
            this.colDataGridViewTextBoxColumn.HeaderText = "col";
            this.colDataGridViewTextBoxColumn.Name = "colDataGridViewTextBoxColumn";
            // 
            // tableLab14BindingSource
            // 
            this.tableLab14BindingSource.DataMember = "TableLab14";
            this.tableLab14BindingSource.DataSource = this.lab14DataSet;
            // 
            // lab14DataSet
            // 
            this.lab14DataSet.DataSetName = "lab14DataSet";
            this.lab14DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(13, 433);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(188, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(18, 508);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(146, 20);
            this.dateTimePicker2.TabIndex = 2;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(194, 508);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(153, 20);
            this.dateTimePicker3.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(301, 425);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 41);
            this.button1.TabIndex = 4;
            this.button1.Text = "фильтр по дате";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(805, 487);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 41);
            this.button2.TabIndex = 5;
            this.button2.Text = "отмена дат";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(459, 494);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 34);
            this.button3.TabIndex = 6;
            this.button3.Text = "фильтр по диапозону дат";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(607, 487);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(158, 59);
            this.textBox1.TabIndex = 7;
            // 
            // tableLab14TableAdapter
            // 
            this.tableLab14TableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 558);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker3);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableLab14BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lab14DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private lab14DataSet lab14DataSet;
        private System.Windows.Forms.BindingSource tableLab14BindingSource;
        private lab14DataSetTableAdapters.TableLab14TableAdapter tableLab14TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn numDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kod2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kod3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kod4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kod5DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kod6DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datavvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDataGridViewTextBoxColumn;
    }
}

