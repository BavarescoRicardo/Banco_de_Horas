namespace Banco_de_Horas
{
    partial class PesquisaNome
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
            this.tabelaFuncionario = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaFuncionario)).BeginInit();
            this.SuspendLayout();
            // 
            // tabelaFuncionario
            // 
            this.tabelaFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelaFuncionario.Location = new System.Drawing.Point(0, 12);
            this.tabelaFuncionario.Name = "tabelaFuncionario";
            this.tabelaFuncionario.RowHeadersWidth = 51;
            this.tabelaFuncionario.RowTemplate.Height = 24;
            this.tabelaFuncionario.Size = new System.Drawing.Size(707, 328);
            this.tabelaFuncionario.TabIndex = 0;
            this.tabelaFuncionario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TabelaFuncionario_CellContentClick);
            // 
            // PesquisaNome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 352);
            this.Controls.Add(this.tabelaFuncionario);
            this.MaximizeBox = false;
            this.Name = "PesquisaNome";
            this.Text = "PesquisaNome";
            this.Load += new System.EventHandler(this.PesquisaNome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabelaFuncionario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tabelaFuncionario;
    }
}