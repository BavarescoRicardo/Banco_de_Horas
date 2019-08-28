namespace Banco_de_Horas
{
    partial class Form2
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
            this.tabelaExtra = new System.Windows.Forms.DataGridView();
            this.lbNome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.escolhaDia = new System.Windows.Forms.DateTimePicker();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.compH = new System.Windows.Forms.TextBox();
            this.compM = new System.Windows.Forms.TextBox();
            this.btnDescontar = new System.Windows.Forms.Button();
            this.lblMatricula = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaExtra)).BeginInit();
            this.SuspendLayout();
            // 
            // tabelaExtra
            // 
            this.tabelaExtra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelaExtra.Location = new System.Drawing.Point(2, 63);
            this.tabelaExtra.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabelaExtra.Name = "tabelaExtra";
            this.tabelaExtra.RowHeadersWidth = 51;
            this.tabelaExtra.RowTemplate.Height = 24;
            this.tabelaExtra.Size = new System.Drawing.Size(548, 122);
            this.tabelaExtra.TabIndex = 0;
            this.tabelaExtra.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TabelaExtra_CellContentClick);
            // 
            // lbNome
            // 
            this.lbNome.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.Location = new System.Drawing.Point(9, 7);
            this.lbNome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(170, 19);
            this.lbNome.TabIndex = 1;
            this.lbNome.Text = "label1";
            this.lbNome.Click += new System.EventHandler(this.LbNome_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 244);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 244);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Quantidade";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(288, 245);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Observação";
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(291, 260);
            this.txtObs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(76, 20);
            this.txtObs.TabIndex = 5;
            this.txtObs.TabStop = false;
            this.txtObs.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // escolhaDia
            // 
            this.escolhaDia.Location = new System.Drawing.Point(1, 259);
            this.escolhaDia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.escolhaDia.Name = "escolhaDia";
            this.escolhaDia.Size = new System.Drawing.Size(151, 20);
            this.escolhaDia.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(407, 258);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(67, 19);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txtHora
            // 
            this.txtHora.Location = new System.Drawing.Point(181, 259);
            this.txtHora.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(25, 20);
            this.txtHora.TabIndex = 8;
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(210, 259);
            this.txtMin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(38, 20);
            this.txtMin.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 191);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Total";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(71, 191);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(13, 13);
            this.lblTotal.TabIndex = 13;
            this.lblTotal.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Inserir";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 298);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Compensou";
            // 
            // compH
            // 
            this.compH.Location = new System.Drawing.Point(127, 295);
            this.compH.Margin = new System.Windows.Forms.Padding(2);
            this.compH.Name = "compH";
            this.compH.Size = new System.Drawing.Size(25, 20);
            this.compH.TabIndex = 16;
            // 
            // compM
            // 
            this.compM.Location = new System.Drawing.Point(156, 295);
            this.compM.Margin = new System.Windows.Forms.Padding(2);
            this.compM.Name = "compM";
            this.compM.Size = new System.Drawing.Size(38, 20);
            this.compM.TabIndex = 17;
            // 
            // btnDescontar
            // 
            this.btnDescontar.Location = new System.Drawing.Point(231, 293);
            this.btnDescontar.Name = "btnDescontar";
            this.btnDescontar.Size = new System.Drawing.Size(75, 23);
            this.btnDescontar.TabIndex = 18;
            this.btnDescontar.Text = "Descontar";
            this.btnDescontar.UseVisualStyleBackColor = true;
            this.btnDescontar.Click += new System.EventHandler(this.BtnDescontar_Click);
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Location = new System.Drawing.Point(205, 13);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(13, 13);
            this.lblMatricula.TabIndex = 20;
            this.lblMatricula.Text = "0";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 326);
            this.Controls.Add(this.lblMatricula);
            this.Controls.Add(this.btnDescontar);
            this.Controls.Add(this.compM);
            this.Controls.Add(this.compH);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMin);
            this.Controls.Add(this.txtHora);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.escolhaDia);
            this.Controls.Add(this.txtObs);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.tabelaExtra);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form2";
            this.Text = "Tela Horas";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabelaExtra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tabelaExtra;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.DateTimePicker escolhaDia;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox compH;
        private System.Windows.Forms.TextBox compM;
        private System.Windows.Forms.Button btnDescontar;
        private System.Windows.Forms.Label lblMatricula;
    }
}