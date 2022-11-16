namespace ModuleForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblMedicine = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnGetMedicine = new System.Windows.Forms.Button();
            this.cbMedicines = new System.Windows.Forms.ComboBox();
            this.medicineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.medicineBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMedicine
            // 
            this.lblMedicine.AutoSize = true;
            this.lblMedicine.Location = new System.Drawing.Point(135, 162);
            this.lblMedicine.Name = "lblMedicine";
            this.lblMedicine.Size = new System.Drawing.Size(83, 15);
            this.lblMedicine.TabIndex = 1;
            this.lblMedicine.Text = "Medicijnnaam";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(248, 103);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Opslaan";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnGetMedicine
            // 
            this.btnGetMedicine.Location = new System.Drawing.Point(479, 70);
            this.btnGetMedicine.Name = "btnGetMedicine";
            this.btnGetMedicine.Size = new System.Drawing.Size(126, 23);
            this.btnGetMedicine.TabIndex = 3;
            this.btnGetMedicine.Text = "GetMedicine";
            this.btnGetMedicine.UseVisualStyleBackColor = true;
            this.btnGetMedicine.Click += new System.EventHandler(this.btnGetMedicine_Click);
            // 
            // cbMedicines
            // 
            this.cbMedicines.DataSource = this.medicineBindingSource;
            this.cbMedicines.DisplayMember = "Name";
            this.cbMedicines.FormattingEnabled = true;
            this.cbMedicines.Location = new System.Drawing.Point(238, 159);
            this.cbMedicines.Name = "cbMedicines";
            this.cbMedicines.Size = new System.Drawing.Size(121, 23);
            this.cbMedicines.TabIndex = 4;
            this.cbMedicines.ValueMember = "Id";
            // 
            // medicineBindingSource
            // 
            this.medicineBindingSource.DataSource = typeof(Data.Medicine);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbMedicines);
            this.Controls.Add(this.btnGetMedicine);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblMedicine);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.medicineBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblMedicine;
        private Button btnSave;
        private Button btnGetMedicine;
        private ComboBox cbMedicines;
        private BindingSource medicineBindingSource;
    }
}