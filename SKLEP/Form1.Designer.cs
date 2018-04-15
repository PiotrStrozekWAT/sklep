namespace SKLEP
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnGetData = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolor_boolean = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drukarkiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produktyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drukarkiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGetData
            // 
            this.btnGetData.Location = new System.Drawing.Point(631, 12);
            this.btnGetData.Name = "btnGetData";
            this.btnGetData.Size = new System.Drawing.Size(110, 34);
            this.btnGetData.TabIndex = 1;
            this.btnGetData.Text = "Pobierz dane";
            this.btnGetData.UseVisualStyleBackColor = true;
            this.btnGetData.Click += new System.EventHandler(this.btnGetData_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.producent,
            this.kolor_boolean,
            this.cena,
            this.produktyDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.drukarkiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(9, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(609, 387);
            this.dataGridView1.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Produkty";
            this.dataGridViewTextBoxColumn1.HeaderText = "Produkty";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // producent
            // 
            this.producent.DataPropertyName = "producent";
            this.producent.HeaderText = "producent";
            this.producent.Name = "producent";
            this.producent.ReadOnly = true;
            // 
            // kolor_boolean
            // 
            this.kolor_boolean.DataPropertyName = "kolor_boolean";
            this.kolor_boolean.HeaderText = "kolor";
            this.kolor_boolean.Name = "kolor_boolean";
            this.kolor_boolean.ReadOnly = true;
            // 
            // cena
            // 
            this.cena.DataPropertyName = "cena";
            this.cena.HeaderText = "cena";
            this.cena.Name = "cena";
            this.cena.ReadOnly = true;
            // 
            // drukarkiBindingSource
            // 
            this.drukarkiBindingSource.DataSource = typeof(SKLEP.Drukarki);
            // 
            // produktyDataGridViewTextBoxColumn
            // 
            this.produktyDataGridViewTextBoxColumn.DataPropertyName = "Produkty";
            this.produktyDataGridViewTextBoxColumn.HeaderText = "Produkty";
            this.produktyDataGridViewTextBoxColumn.Name = "produktyDataGridViewTextBoxColumn";
            this.produktyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 411);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnGetData);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drukarkiBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnGetData;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource drukarkiBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn producent;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolor_boolean;
        private System.Windows.Forms.DataGridViewTextBoxColumn cena;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn produktyDataGridViewTextBoxColumn;
    }
}

