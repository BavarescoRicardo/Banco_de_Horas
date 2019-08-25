namespace Ponto_Educacional.telas
{
    partial class TelaVisualizarProfess
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
            this.tabelaProfessores = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaProfessores)).BeginInit();
            this.SuspendLayout();
            // 
            // tabelaProfessores
            // 
            this.tabelaProfessores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelaProfessores.Location = new System.Drawing.Point(-1, 53);
            this.tabelaProfessores.Name = "tabelaProfessores";
            this.tabelaProfessores.RowHeadersWidth = 51;
            this.tabelaProfessores.RowTemplate.Height = 24;
            this.tabelaProfessores.Size = new System.Drawing.Size(1047, 358);
            this.tabelaProfessores.TabIndex = 0;
            this.tabelaProfessores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TabelaProfessores_CellContentClick);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(68, 13);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(158, 24);
            this.comboBox1.TabIndex = 1;
            // 
            // TelaVisualizarProfess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.tabelaProfessores);
            this.Name = "TelaVisualizarProfess";
            this.Text = "TelaVisualizarProfess";
            this.Load += new System.EventHandler(this.TelaVisualizarProfess_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabelaProfessores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tabelaProfessores;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}