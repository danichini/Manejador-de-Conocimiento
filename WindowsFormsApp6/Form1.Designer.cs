namespace WindowsFormsApp6
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
            System.Windows.Forms.Label id_conocLabel;
            System.Windows.Forms.Label de_conocLabel;
            System.Windows.Forms.Label re_conocLabel;
            System.Windows.Forms.Label fe_conocLabel;
            this.button1 = new System.Windows.Forms.Button();
            this.conocimientoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conocimientoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new WindowsFormsApp6.DataSet1();
            this.button4 = new System.Windows.Forms.Button();
            this.id_conocTextBox = new System.Windows.Forms.TextBox();
            this.de_conocTextBox = new System.Windows.Forms.TextBox();
            this.re_conocTextBox = new System.Windows.Forms.TextBox();
            this.fe_conocDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.button3 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.conocimientoTableAdapter1 = new WindowsFormsApp6.DataSet1TableAdapters.conocimientoTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp6.DataSet1TableAdapters.TableAdapterManager();
            this.button7 = new System.Windows.Forms.Button();
            id_conocLabel = new System.Windows.Forms.Label();
            de_conocLabel = new System.Windows.Forms.Label();
            re_conocLabel = new System.Windows.Forms.Label();
            fe_conocLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.conocimientoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conocimientoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // id_conocLabel
            // 
            id_conocLabel.AutoSize = true;
            id_conocLabel.Location = new System.Drawing.Point(40, 34);
            id_conocLabel.Name = "id_conocLabel";
            id_conocLabel.Size = new System.Drawing.Size(18, 13);
            id_conocLabel.TabIndex = 14;
            id_conocLabel.Text = "ID";
            // 
            // de_conocLabel
            // 
            de_conocLabel.AutoSize = true;
            de_conocLabel.Location = new System.Drawing.Point(116, 20);
            de_conocLabel.Name = "de_conocLabel";
            de_conocLabel.Size = new System.Drawing.Size(63, 13);
            de_conocLabel.TabIndex = 15;
            de_conocLabel.Text = "Descripcion";
            // 
            // re_conocLabel
            // 
            re_conocLabel.AutoSize = true;
            re_conocLabel.Location = new System.Drawing.Point(116, 90);
            re_conocLabel.Name = "re_conocLabel";
            re_conocLabel.Size = new System.Drawing.Size(59, 13);
            re_conocLabel.TabIndex = 16;
            re_conocLabel.Text = "Referencia";
            // 
            // fe_conocLabel
            // 
            fe_conocLabel.AutoSize = true;
            fe_conocLabel.Location = new System.Drawing.Point(127, 62);
            fe_conocLabel.Name = "fe_conocLabel";
            fe_conocLabel.Size = new System.Drawing.Size(37, 13);
            fe_conocLabel.TabIndex = 17;
            fe_conocLabel.Text = "Fecha";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(124, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Insertar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // conocimientoDataGridView
            // 
            this.conocimientoDataGridView.AutoGenerateColumns = false;
            this.conocimientoDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.conocimientoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.conocimientoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.conocimientoDataGridView.DataSource = this.conocimientoBindingSource;
            this.conocimientoDataGridView.Location = new System.Drawing.Point(17, 160);
            this.conocimientoDataGridView.Name = "conocimientoDataGridView";
            this.conocimientoDataGridView.Size = new System.Drawing.Size(469, 177);
            this.conocimientoDataGridView.TabIndex = 3;
            this.conocimientoDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.conocimientoDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_conoc";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_conoc";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "de_conoc";
            this.dataGridViewTextBoxColumn2.HeaderText = "de_conoc";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "re_conoc";
            this.dataGridViewTextBoxColumn3.HeaderText = "re_conoc";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "fe_conoc";
            this.dataGridViewTextBoxColumn4.HeaderText = "fe_conoc";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // conocimientoBindingSource
            // 
            this.conocimientoBindingSource.DataMember = "conocimiento";
            this.conocimientoBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(205, 357);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 11;
            this.button4.Text = "Modificar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // id_conocTextBox
            // 
            this.id_conocTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.conocimientoBindingSource, "id_conoc", true));
            this.id_conocTextBox.Location = new System.Drawing.Point(12, 59);
            this.id_conocTextBox.Name = "id_conocTextBox";
            this.id_conocTextBox.Size = new System.Drawing.Size(80, 20);
            this.id_conocTextBox.TabIndex = 15;
            // 
            // de_conocTextBox
            // 
            this.de_conocTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.conocimientoBindingSource, "de_conoc", true));
            this.de_conocTextBox.Location = new System.Drawing.Point(185, 20);
            this.de_conocTextBox.Multiline = true;
            this.de_conocTextBox.Name = "de_conocTextBox";
            this.de_conocTextBox.Size = new System.Drawing.Size(301, 38);
            this.de_conocTextBox.TabIndex = 16;
            // 
            // re_conocTextBox
            // 
            this.re_conocTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.conocimientoBindingSource, "re_conoc", true));
            this.re_conocTextBox.Location = new System.Drawing.Point(185, 90);
            this.re_conocTextBox.Multiline = true;
            this.re_conocTextBox.Name = "re_conocTextBox";
            this.re_conocTextBox.Size = new System.Drawing.Size(301, 46);
            this.re_conocTextBox.TabIndex = 17;
            // 
            // fe_conocDateTimePicker
            // 
            this.fe_conocDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.conocimientoBindingSource, "fe_conoc", true));
            this.fe_conocDateTimePicker.Location = new System.Drawing.Point(185, 64);
            this.fe_conocDateTimePicker.Name = "fe_conocDateTimePicker";
            this.fe_conocDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fe_conocDateTimePicker.TabIndex = 18;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(286, 357);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 19;
            this.button3.Text = "Eliminar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(17, 90);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 21;
            this.button6.Text = "Limpiar";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 393);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(510, 22);
            this.statusStrip1.TabIndex = 22;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(367, 357);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 23;
            this.button5.Text = "Salir";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(43, 357);
            this.button2.Name = "button2";
            this.button2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 24;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.dataSet1;
            this.bindingSource1.Position = 0;
            this.bindingSource1.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // conocimientoTableAdapter1
            // 
            this.conocimientoTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp6.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(17, 119);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 25;
            this.button7.Text = "Listar";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 415);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(fe_conocLabel);
            this.Controls.Add(this.fe_conocDateTimePicker);
            this.Controls.Add(re_conocLabel);
            this.Controls.Add(this.re_conocTextBox);
            this.Controls.Add(de_conocLabel);
            this.Controls.Add(this.de_conocTextBox);
            this.Controls.Add(id_conocLabel);
            this.Controls.Add(this.id_conocTextBox);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.conocimientoDataGridView);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.conocimientoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conocimientoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource conocimientoBindingSource;
        private System.Windows.Forms.DataGridView conocimientoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataSet1TableAdapters.conocimientoTableAdapter conocimientoTableAdapter1;
        private System.Windows.Forms.Button button4;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox id_conocTextBox;
        private System.Windows.Forms.TextBox de_conocTextBox;
        private System.Windows.Forms.TextBox re_conocTextBox;
        private System.Windows.Forms.DateTimePicker fe_conocDateTimePicker;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button7;
    }
}

