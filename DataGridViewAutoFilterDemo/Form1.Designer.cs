
namespace DataGridViewAutoFilterDemo
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
            this.dataSet11 = new DataGridViewAutoFilterDemo.DataSet1();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gunCollectionAmmoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gun_Collection_AmmoTableAdapter = new DataGridViewAutoFilterDemo.DataSet1TableAdapters.Gun_Collection_AmmoTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Manufacturer = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grainDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jacketDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.veltDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.velnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.synclastupdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunCollectionAmmoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.dataSet11;
            this.bindingSource1.Position = 0;
            this.bindingSource1.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.Manufacturer,
            this.nameDataGridViewTextBoxColumn,
            this.calDataGridViewTextBoxColumn,
            this.grainDataGridViewTextBoxColumn,
            this.jacketDataGridViewTextBoxColumn,
            this.qtyDataGridViewTextBoxColumn,
            this.dcalDataGridViewTextBoxColumn,
            this.veltDataGridViewTextBoxColumn,
            this.velnDataGridViewTextBoxColumn,
            this.synclastupdateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.gunCollectionAmmoBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 450);
            this.dataGridView1.TabIndex = 0;
            // 
            // gunCollectionAmmoBindingSource
            // 
            this.gunCollectionAmmoBindingSource.DataMember = "Gun_Collection_Ammo";
            this.gunCollectionAmmoBindingSource.DataSource = this.bindingSource1;
            // 
            // gun_Collection_AmmoTableAdapter
            // 
            this.gun_Collection_AmmoTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // Manufacturer
            // 
            this.Manufacturer.DataPropertyName = "Manufacturer";
            this.Manufacturer.HeaderText = "Manufacturer";
            this.Manufacturer.Name = "Manufacturer";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // calDataGridViewTextBoxColumn
            // 
            this.calDataGridViewTextBoxColumn.DataPropertyName = "Cal";
            this.calDataGridViewTextBoxColumn.HeaderText = "Cal";
            this.calDataGridViewTextBoxColumn.Name = "calDataGridViewTextBoxColumn";
            // 
            // grainDataGridViewTextBoxColumn
            // 
            this.grainDataGridViewTextBoxColumn.DataPropertyName = "Grain";
            this.grainDataGridViewTextBoxColumn.HeaderText = "Grain";
            this.grainDataGridViewTextBoxColumn.Name = "grainDataGridViewTextBoxColumn";
            // 
            // jacketDataGridViewTextBoxColumn
            // 
            this.jacketDataGridViewTextBoxColumn.DataPropertyName = "Jacket";
            this.jacketDataGridViewTextBoxColumn.HeaderText = "Jacket";
            this.jacketDataGridViewTextBoxColumn.Name = "jacketDataGridViewTextBoxColumn";
            // 
            // qtyDataGridViewTextBoxColumn
            // 
            this.qtyDataGridViewTextBoxColumn.DataPropertyName = "Qty";
            this.qtyDataGridViewTextBoxColumn.HeaderText = "Qty";
            this.qtyDataGridViewTextBoxColumn.Name = "qtyDataGridViewTextBoxColumn";
            // 
            // dcalDataGridViewTextBoxColumn
            // 
            this.dcalDataGridViewTextBoxColumn.DataPropertyName = "dcal";
            this.dcalDataGridViewTextBoxColumn.HeaderText = "dcal";
            this.dcalDataGridViewTextBoxColumn.Name = "dcalDataGridViewTextBoxColumn";
            // 
            // veltDataGridViewTextBoxColumn
            // 
            this.veltDataGridViewTextBoxColumn.DataPropertyName = "vel_t";
            this.veltDataGridViewTextBoxColumn.HeaderText = "vel_t";
            this.veltDataGridViewTextBoxColumn.Name = "veltDataGridViewTextBoxColumn";
            // 
            // velnDataGridViewTextBoxColumn
            // 
            this.velnDataGridViewTextBoxColumn.DataPropertyName = "vel_n";
            this.velnDataGridViewTextBoxColumn.HeaderText = "vel_n";
            this.velnDataGridViewTextBoxColumn.Name = "velnDataGridViewTextBoxColumn";
            // 
            // synclastupdateDataGridViewTextBoxColumn
            // 
            this.synclastupdateDataGridViewTextBoxColumn.DataPropertyName = "sync_lastupdate";
            this.synclastupdateDataGridViewTextBoxColumn.HeaderText = "sync_lastupdate";
            this.synclastupdateDataGridViewTextBoxColumn.Name = "synclastupdateDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunCollectionAmmoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataSet1 dataSet11;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource gunCollectionAmmoBindingSource;
        private DataSet1TableAdapters.Gun_Collection_AmmoTableAdapter gun_Collection_AmmoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn Manufacturer;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn calDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn grainDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jacketDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn veltDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn velnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn synclastupdateDataGridViewTextBoxColumn;
    }
}

