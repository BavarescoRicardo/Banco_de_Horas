namespace Banco_de_Horas
{
    partial class CadastroFuncionario
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGravar = new System.Windows.Forms.Button();
            this.cbAtivo = new System.Windows.Forms.CheckBox();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.comboSetor = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matricula";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cargo";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nome";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Setor";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 330);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ativo";
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(454, 395);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(126, 32);
            this.btnGravar.TabIndex = 5;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.BtnGravar_Click);
            // 
            // cbAtivo
            // 
            this.cbAtivo.AutoSize = true;
            this.cbAtivo.Location = new System.Drawing.Point(43, 357);
            this.cbAtivo.Name = "cbAtivo";
            this.cbAtivo.Size = new System.Drawing.Size(18, 17);
            this.cbAtivo.TabIndex = 6;
            this.cbAtivo.UseVisualStyleBackColor = true;
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(33, 62);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(135, 22);
            this.txtMatricula.TabIndex = 7;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(33, 137);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(314, 22);
            this.txtNome.TabIndex = 8;
            // 
            // txtCargo
            // 
            this.txtCargo.Location = new System.Drawing.Point(33, 215);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(314, 22);
            this.txtCargo.TabIndex = 9;
            // 
            // comboSetor
            // 
            this.comboSetor.FormattingEnabled = true;
            this.comboSetor.Location = new System.Drawing.Point(33, 285);
            this.comboSetor.Name = "comboSetor";
            this.comboSetor.Size = new System.Drawing.Size(314, 24);
            this.comboSetor.TabIndex = 10;
            // 
            // CadastroFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(678, 450);
            this.Controls.Add(this.comboSetor);
            this.Controls.Add(this.txtCargo);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.cbAtivo);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CadastroFuncionario";
            this.Text = "CadastroFuncionario";
            this.Load += new System.EventHandler(this.CadastroFuncionario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.CheckBox cbAtivo;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.ComboBox comboSetor;
    }
}