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
            this.txtObsComp = new System.Windows.Forms.TextBox();
            this.escolheDiaComp = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaExtra)).BeginInit();
            this.SuspendLayout();
            // 
            // tabelaExtra
            // 
            this.tabelaExtra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelaExtra.Location = new System.Drawing.Point(3, 78);
            this.tabelaExtra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabelaExtra.Name = "tabelaExtra";
            this.tabelaExtra.RowHeadersWidth = 51;
            this.tabelaExtra.RowTemplate.Height = 24;
            this.tabelaExtra.Size = new System.Drawing.Size(884, 150);
            this.tabelaExtra.TabIndex = 0;
            this.tabelaExtra.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TabelaExtra_CellContentClick);
            // 
            // lbNome
            // 
            this.lbNome.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.Location = new System.Drawing.Point(12, 9);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(227, 23);
            this.lbNome.TabIndex = 1;
            this.lbNome.Text = "label1";
            this.lbNome.Click += new System.EventHandler(this.LbNome_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Quantidade";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(384, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Observação";
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(388, 320);
            this.txtObs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(100, 22);
            this.txtObs.TabIndex = 5;
            this.txtObs.TabStop = false;
            this.txtObs.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // escolhaDia
            // 
            this.escolhaDia.Location = new System.Drawing.Point(1, 319);
            this.escolhaDia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.escolhaDia.Name = "escolhaDia";
            this.escolhaDia.Size = new System.Drawing.Size(200, 22);
            this.escolhaDia.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(543, 318);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(89, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txtHora
            // 
            this.txtHora.Location = new System.Drawing.Point(241, 319);
            this.txtHora.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(32, 22);
            this.txtHora.TabIndex = 8;
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(280, 319);
            this.txtMin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(49, 22);
            this.txtMin.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Total";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(95, 235);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(16, 17);
            this.lblTotal.TabIndex = 13;
            this.lblTotal.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 283);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Inserir";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 343);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Compensou";
            // 
            // compH
            // 
            this.compH.Location = new System.Drawing.Point(241, 370);
            this.compH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.compH.Name = "compH";
            this.compH.Size = new System.Drawing.Size(32, 22);
            this.compH.TabIndex = 16;
            // 
            // compM
            // 
            this.compM.Location = new System.Drawing.Point(280, 370);
            this.compM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.compM.Name = "compM";
            this.compM.Size = new System.Drawing.Size(49, 22);
            this.compM.TabIndex = 17;
            // 
            // btnDescontar
            // 
            this.btnDescontar.Location = new System.Drawing.Point(543, 370);
            this.btnDescontar.Margin = new System.Windows.Forms.Padding(4);
            this.btnDescontar.Name = "btnDescontar";
            this.btnDescontar.Size = new System.Drawing.Size(89, 23);
            this.btnDescontar.TabIndex = 18;
            this.btnDescontar.Text = "Descontar";
            this.btnDescontar.UseVisualStyleBackColor = true;
            this.btnDescontar.Click += new System.EventHandler(this.BtnDescontar_Click);
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Location = new System.Drawing.Point(273, 16);
            this.lblMatricula.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(16, 17);
            this.lblMatricula.TabIndex = 20;
            this.lblMatricula.Text = "0";
            // 
            // txtObsComp
            // 
            this.txtObsComp.Location = new System.Drawing.Point(388, 370);
            this.txtObsComp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtObsComp.Name = "txtObsComp";
            this.txtObsComp.Size = new System.Drawing.Size(100, 22);
            this.txtObsComp.TabIndex = 21;
            this.txtObsComp.TabStop = false;
            // 
            // escolheDiaComp
            // 
            this.escolheDiaComp.Location = new System.Drawing.Point(6, 368);
            this.escolheDiaComp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.escolheDiaComp.Name = "escolheDiaComp";
            this.escolheDiaComp.Size = new System.Drawing.Size(200, 22);
            this.escolheDiaComp.TabIndex = 22;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 401);
            this.Controls.Add(this.escolheDiaComp);
            this.Controls.Add(this.txtObsComp);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
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
        private System.Windows.Forms.TextBox txtObsComp;
        private System.Windows.Forms.DateTimePicker escolheDiaComp;
    }
}