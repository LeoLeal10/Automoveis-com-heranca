
namespace N2B2_POO
{
    partial class ucOnibus
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtCapacidadePassageiro = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtQtdEixos = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbModelo = new System.Windows.Forms.ComboBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkLeito = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(9, 236);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(125, 29);
            this.btnCadastrar.TabIndex = 39;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtCapacidadePassageiro
            // 
            this.txtCapacidadePassageiro.Location = new System.Drawing.Point(214, 113);
            this.txtCapacidadePassageiro.Name = "txtCapacidadePassageiro";
            this.txtCapacidadePassageiro.Size = new System.Drawing.Size(85, 26);
            this.txtCapacidadePassageiro.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(207, 20);
            this.label6.TabIndex = 37;
            this.label6.Text = "Capacidade de Passageiros";
            // 
            // txtQtdEixos
            // 
            this.txtQtdEixos.Location = new System.Drawing.Point(165, 145);
            this.txtQtdEixos.Name = "txtQtdEixos";
            this.txtQtdEixos.Size = new System.Drawing.Size(85, 26);
            this.txtQtdEixos.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 20);
            this.label5.TabIndex = 35;
            this.label5.Text = "Quantidade de Eixos";
            // 
            // cbModelo
            // 
            this.cbModelo.FormattingEnabled = true;
            this.cbModelo.Location = new System.Drawing.Point(72, 76);
            this.cbModelo.Name = "cbModelo";
            this.cbModelo.Size = new System.Drawing.Size(188, 28);
            this.cbModelo.TabIndex = 32;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(111, 44);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(242, 26);
            this.txtID.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 30;
            this.label3.Text = "Modelo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "Identificação";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 25);
            this.label1.TabIndex = 28;
            this.label1.Text = "Cadastro de Ônibus";
            // 
            // checkLeito
            // 
            this.checkLeito.AutoSize = true;
            this.checkLeito.Location = new System.Drawing.Point(9, 177);
            this.checkLeito.Name = "checkLeito";
            this.checkLeito.Size = new System.Drawing.Size(123, 24);
            this.checkLeito.TabIndex = 41;
            this.checkLeito.Text = "Possui Leito?";
            this.checkLeito.UseVisualStyleBackColor = true;
            // 
            // ucOnibus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkLeito);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtCapacidadePassageiro);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtQtdEixos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbModelo);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ucOnibus";
            this.Size = new System.Drawing.Size(388, 273);
            this.Load += new System.EventHandler(this.ucOnibus_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtCapacidadePassageiro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtQtdEixos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbModelo;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkLeito;
    }
}
