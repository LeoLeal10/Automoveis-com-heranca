
namespace N2B2_POO
{
    partial class frmPrincipal
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
            this.cbCadastro = new System.Windows.Forms.ComboBox();
            this.panelCadastro = new System.Windows.Forms.Panel();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnTeste = new System.Windows.Forms.Button();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.btnPesquisaAcoes = new System.Windows.Forms.Button();
            this.panelAcoes = new System.Windows.Forms.Panel();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCarregar = new System.Windows.Forms.Button();
            this.btnLimpadores = new System.Windows.Forms.Button();
            this.btnAtacarTodosVeiculos = new System.Windows.Forms.Button();
            this.btnEmpinarTodosVeiculos = new System.Windows.Forms.Button();
            this.btnAtracarTodosNavios = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbCadastro
            // 
            this.cbCadastro.FormattingEnabled = true;
            this.cbCadastro.Items.AddRange(new object[] {
            "Carro",
            "Caminhão",
            "Ônibus",
            "Moto",
            "Avião",
            "Avião de Guerra",
            "Navio",
            "Navio de Guerra",
            "Trem",
            "Marca",
            "Modelo",
            "Pedagio"});
            this.cbCadastro.Location = new System.Drawing.Point(16, 6);
            this.cbCadastro.Name = "cbCadastro";
            this.cbCadastro.Size = new System.Drawing.Size(147, 28);
            this.cbCadastro.TabIndex = 1;
            // 
            // panelCadastro
            // 
            this.panelCadastro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCadastro.Location = new System.Drawing.Point(16, 40);
            this.panelCadastro.Name = "panelCadastro";
            this.panelCadastro.Size = new System.Drawing.Size(450, 450);
            this.panelCadastro.TabIndex = 2;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(169, 6);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(106, 28);
            this.btnCadastrar.TabIndex = 3;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(281, 6);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(106, 28);
            this.btnListar.TabIndex = 4;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnTeste
            // 
            this.btnTeste.Location = new System.Drawing.Point(307, 527);
            this.btnTeste.Name = "btnTeste";
            this.btnTeste.Size = new System.Drawing.Size(59, 28);
            this.btnTeste.TabIndex = 5;
            this.btnTeste.Text = "Teste";
            this.btnTeste.UseVisualStyleBackColor = true;
            this.btnTeste.Click += new System.EventHandler(this.btnTeste_Click);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(487, 7);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(223, 26);
            this.txtPesquisa.TabIndex = 6;
            // 
            // btnPesquisaAcoes
            // 
            this.btnPesquisaAcoes.Location = new System.Drawing.Point(716, 6);
            this.btnPesquisaAcoes.Name = "btnPesquisaAcoes";
            this.btnPesquisaAcoes.Size = new System.Drawing.Size(175, 28);
            this.btnPesquisaAcoes.TabIndex = 7;
            this.btnPesquisaAcoes.Text = "Pesquisar Ações";
            this.btnPesquisaAcoes.UseVisualStyleBackColor = true;
            this.btnPesquisaAcoes.Click += new System.EventHandler(this.btnPesquisaAcoes_Click);
            // 
            // panelAcoes
            // 
            this.panelAcoes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAcoes.Location = new System.Drawing.Point(487, 40);
            this.panelAcoes.Name = "panelAcoes";
            this.panelAcoes.Size = new System.Drawing.Size(450, 450);
            this.panelAcoes.TabIndex = 3;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Enabled = false;
            this.btnSalvar.Location = new System.Drawing.Point(16, 527);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(132, 28);
            this.btnSalvar.TabIndex = 8;
            this.btnSalvar.Text = "Salvar Dados";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCarregar
            // 
            this.btnCarregar.Enabled = false;
            this.btnCarregar.Location = new System.Drawing.Point(154, 527);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(147, 28);
            this.btnCarregar.TabIndex = 9;
            this.btnCarregar.Text = "Carregar Dados";
            this.btnCarregar.UseVisualStyleBackColor = true;
            this.btnCarregar.Click += new System.EventHandler(this.btnCarregar_Click);
            // 
            // btnLimpadores
            // 
            this.btnLimpadores.Location = new System.Drawing.Point(762, 530);
            this.btnLimpadores.Name = "btnLimpadores";
            this.btnLimpadores.Size = new System.Drawing.Size(175, 28);
            this.btnLimpadores.TabIndex = 10;
            this.btnLimpadores.Text = "Todos limpadores";
            this.btnLimpadores.UseVisualStyleBackColor = true;
            this.btnLimpadores.Click += new System.EventHandler(this.btnLimpadores_Click);
            // 
            // btnAtacarTodosVeiculos
            // 
            this.btnAtacarTodosVeiculos.Location = new System.Drawing.Point(573, 530);
            this.btnAtacarTodosVeiculos.Name = "btnAtacarTodosVeiculos";
            this.btnAtacarTodosVeiculos.Size = new System.Drawing.Size(183, 28);
            this.btnAtacarTodosVeiculos.TabIndex = 11;
            this.btnAtacarTodosVeiculos.Text = "Atacar todos veiculos";
            this.btnAtacarTodosVeiculos.UseVisualStyleBackColor = true;
            this.btnAtacarTodosVeiculos.Click += new System.EventHandler(this.btnAtacarTodosVeiculos_Click);
            // 
            // btnEmpinarTodosVeiculos
            // 
            this.btnEmpinarTodosVeiculos.Location = new System.Drawing.Point(573, 496);
            this.btnEmpinarTodosVeiculos.Name = "btnEmpinarTodosVeiculos";
            this.btnEmpinarTodosVeiculos.Size = new System.Drawing.Size(183, 28);
            this.btnEmpinarTodosVeiculos.TabIndex = 12;
            this.btnEmpinarTodosVeiculos.Text = "Empinar todos veiculos";
            this.btnEmpinarTodosVeiculos.UseVisualStyleBackColor = true;
            this.btnEmpinarTodosVeiculos.Click += new System.EventHandler(this.btnEmpinarTodosVeiculos_Click);
            // 
            // btnAtracarTodosNavios
            // 
            this.btnAtracarTodosNavios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtracarTodosNavios.Location = new System.Drawing.Point(763, 495);
            this.btnAtracarTodosNavios.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAtracarTodosNavios.Name = "btnAtracarTodosNavios";
            this.btnAtracarTodosNavios.Size = new System.Drawing.Size(174, 30);
            this.btnAtracarTodosNavios.TabIndex = 13;
            this.btnAtracarTodosNavios.Text = "Atracar todos navios";
            this.btnAtracarTodosNavios.UseVisualStyleBackColor = true;
            this.btnAtracarTodosNavios.Click += new System.EventHandler(this.btnAtracarTodosNavios_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 567);
            this.Controls.Add(this.btnAtracarTodosNavios);
            this.Controls.Add(this.btnEmpinarTodosVeiculos);
            this.Controls.Add(this.btnAtacarTodosVeiculos);
            this.Controls.Add(this.btnLimpadores);
            this.Controls.Add(this.btnCarregar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.panelAcoes);
            this.Controls.Add(this.btnPesquisaAcoes);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.btnTeste);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.panelCadastro);
            this.Controls.Add(this.cbCadastro);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbCadastro;
        private System.Windows.Forms.Panel panelCadastro;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnTeste;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Button btnPesquisaAcoes;
        private System.Windows.Forms.Panel panelAcoes;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCarregar;
        private System.Windows.Forms.Button btnLimpadores;
        private System.Windows.Forms.Button btnAtacarTodosVeiculos;
        private System.Windows.Forms.Button btnEmpinarTodosVeiculos;
        private System.Windows.Forms.Button btnAtracarTodosNavios;
    }
}

