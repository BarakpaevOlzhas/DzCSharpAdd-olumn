namespace AddDataBaseCollumn
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ButtonShowTable = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idSele = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idBuyer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idSeller = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Summ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataSele = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Buyer",
            "Seller",
            "Sale"});
            this.comboBox1.Location = new System.Drawing.Point(82, 48);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "Table";
            // 
            // ButtonShowTable
            // 
            this.ButtonShowTable.Location = new System.Drawing.Point(82, 142);
            this.ButtonShowTable.Name = "ButtonShowTable";
            this.ButtonShowTable.Size = new System.Drawing.Size(75, 23);
            this.ButtonShowTable.TabIndex = 1;
            this.ButtonShowTable.Text = "Show";
            this.ButtonShowTable.UseVisualStyleBackColor = true;
            this.ButtonShowTable.Click += new System.EventHandler(this.ButtonShowTable_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.firstName,
            this.middleName});
            this.dataGridView.Location = new System.Drawing.Point(290, 21);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(523, 375);
            this.dataGridView.TabIndex = 2;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            // 
            // firstName
            // 
            this.firstName.HeaderText = "firstName";
            this.firstName.Name = "firstName";
            // 
            // middleName
            // 
            this.middleName.HeaderText = "middleName";
            this.middleName.Name = "middleName";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idSele,
            this.idBuyer,
            this.idSeller,
            this.Summ,
            this.dataSele});
            this.dataGridView1.Location = new System.Drawing.Point(290, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(523, 375);
            this.dataGridView1.TabIndex = 3;
            // 
            // idSele
            // 
            this.idSele.HeaderText = "id";
            this.idSele.Name = "idSele";
            // 
            // idBuyer
            // 
            this.idBuyer.HeaderText = "idBuyer";
            this.idBuyer.Name = "idBuyer";
            // 
            // idSeller
            // 
            this.idSeller.HeaderText = "idSeller";
            this.idSeller.Name = "idSeller";
            // 
            // Summ
            // 
            this.Summ.HeaderText = "Summ";
            this.Summ.Name = "Summ";
            // 
            // dataSele
            // 
            this.dataSele.HeaderText = "dataSele";
            this.dataSele.Name = "dataSele";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 408);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.ButtonShowTable);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button ButtonShowTable;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn middleName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSele;
        private System.Windows.Forms.DataGridViewTextBoxColumn idBuyer;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSeller;
        private System.Windows.Forms.DataGridViewTextBoxColumn Summ;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataSele;
    }
}

