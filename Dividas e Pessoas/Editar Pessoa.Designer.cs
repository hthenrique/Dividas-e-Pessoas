namespace Dividas_e_Pessoas
{
    partial class Editar_Pessoa
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
            this.numTelefone = new System.Windows.Forms.MaskedTextBox();
            this.numCelular = new System.Windows.Forms.MaskedTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.richTextBoxObservacao = new System.Windows.Forms.RichTextBox();
            this.textBoxParcelasPagas = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxParcelas = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxDivida = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxEndereco = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNomePessoa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.excluirPessoa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // numTelefone
            // 
            this.numTelefone.Location = new System.Drawing.Point(12, 74);
            this.numTelefone.Mask = "(99) 0000-0000";
            this.numTelefone.Name = "numTelefone";
            this.numTelefone.Size = new System.Drawing.Size(100, 20);
            this.numTelefone.TabIndex = 49;
            // 
            // numCelular
            // 
            this.numCelular.Location = new System.Drawing.Point(126, 74);
            this.numCelular.Mask = "(99) 00000-0000";
            this.numCelular.Name = "numCelular";
            this.numCelular.Size = new System.Drawing.Size(100, 20);
            this.numCelular.TabIndex = 48;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(218, 585);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 47;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(304, 585);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 46;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 261);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 13);
            this.label11.TabIndex = 45;
            this.label11.Text = "Observações";
            // 
            // richTextBoxObservacao
            // 
            this.richTextBoxObservacao.Location = new System.Drawing.Point(15, 277);
            this.richTextBoxObservacao.Name = "richTextBoxObservacao";
            this.richTextBoxObservacao.Size = new System.Drawing.Size(364, 302);
            this.richTextBoxObservacao.TabIndex = 44;
            this.richTextBoxObservacao.Text = "";
            // 
            // textBoxParcelasPagas
            // 
            this.textBoxParcelasPagas.Location = new System.Drawing.Point(193, 232);
            this.textBoxParcelasPagas.MaxLength = 10;
            this.textBoxParcelasPagas.Name = "textBoxParcelasPagas";
            this.textBoxParcelasPagas.Size = new System.Drawing.Size(100, 20);
            this.textBoxParcelasPagas.TabIndex = 43;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(190, 216);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 13);
            this.label10.TabIndex = 42;
            this.label10.Text = "Parcelas pagas";
            // 
            // textBoxParcelas
            // 
            this.textBoxParcelas.Location = new System.Drawing.Point(193, 188);
            this.textBoxParcelas.MaxLength = 10;
            this.textBoxParcelas.Name = "textBoxParcelas";
            this.textBoxParcelas.Size = new System.Drawing.Size(100, 20);
            this.textBoxParcelas.TabIndex = 41;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(190, 172);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 40;
            this.label9.Text = "Parcelas";
            // 
            // textBoxDivida
            // 
            this.textBoxDivida.Location = new System.Drawing.Point(12, 189);
            this.textBoxDivida.MaxLength = 20;
            this.textBoxDivida.Name = "textBoxDivida";
            this.textBoxDivida.Size = new System.Drawing.Size(121, 20);
            this.textBoxDivida.TabIndex = 39;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 38;
            this.label8.Text = "Valor da Divida";
            // 
            // textBoxEndereco
            // 
            this.textBoxEndereco.Location = new System.Drawing.Point(12, 130);
            this.textBoxEndereco.MaxLength = 100;
            this.textBoxEndereco.Name = "textBoxEndereco";
            this.textBoxEndereco.Size = new System.Drawing.Size(367, 20);
            this.textBoxEndereco.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Endereço";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(123, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Celular";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Telefone";
            // 
            // textBoxNomePessoa
            // 
            this.textBoxNomePessoa.Location = new System.Drawing.Point(12, 25);
            this.textBoxNomePessoa.MaxLength = 100;
            this.textBoxNomePessoa.Name = "textBoxNomePessoa";
            this.textBoxNomePessoa.Size = new System.Drawing.Size(367, 20);
            this.textBoxNomePessoa.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Nome";
            // 
            // excluirPessoa
            // 
            this.excluirPessoa.Location = new System.Drawing.Point(12, 584);
            this.excluirPessoa.Name = "excluirPessoa";
            this.excluirPessoa.Size = new System.Drawing.Size(121, 23);
            this.excluirPessoa.TabIndex = 50;
            this.excluirPessoa.Text = "Excluir Pessoa";
            this.excluirPessoa.UseVisualStyleBackColor = true;
            this.excluirPessoa.Click += new System.EventHandler(this.excluirPessoa_Click);
            // 
            // Editar_Pessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 620);
            this.Controls.Add(this.excluirPessoa);
            this.Controls.Add(this.numTelefone);
            this.Controls.Add(this.numCelular);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.richTextBoxObservacao);
            this.Controls.Add(this.textBoxParcelasPagas);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxParcelas);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxDivida);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxEndereco);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNomePessoa);
            this.Controls.Add(this.label1);
            this.Name = "Editar_Pessoa";
            this.Text = "Editar_Pessoa";
            this.Load += new System.EventHandler(this.Editar_Pessoa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.MaskedTextBox numTelefone;
        private System.Windows.Forms.MaskedTextBox numCelular;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox richTextBoxObservacao;
        private System.Windows.Forms.TextBox textBoxParcelasPagas;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxParcelas;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxDivida;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxEndereco;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNomePessoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button excluirPessoa;
    }
}