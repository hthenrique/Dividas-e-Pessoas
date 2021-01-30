namespace Dividas_e_Pessoas
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bancodadosDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.banco_dadosDataSet = new Dividas_e_Pessoas.banco_dadosDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listaPessoas = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ImprimirLista = new System.Windows.Forms.Button();
            this.atualizarLista = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bancodadosDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banco_dadosDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaPessoas)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // bancodadosDataSetBindingSource
            // 
            this.bancodadosDataSetBindingSource.DataSource = this.banco_dadosDataSet;
            this.bancodadosDataSetBindingSource.Position = 0;
            // 
            // banco_dadosDataSet
            // 
            this.banco_dadosDataSet.DataSetName = "banco_dadosDataSet";
            this.banco_dadosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.button3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(976, 35);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.ImprimirLista);
            this.panel2.Controls.Add(this.atualizarLista);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(49, 539);
            this.panel2.TabIndex = 9;
            // 
            // listaPessoas
            // 
            this.listaPessoas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listaPessoas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaPessoas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listaPessoas.Location = new System.Drawing.Point(0, 0);
            this.listaPessoas.Name = "listaPessoas";
            this.listaPessoas.Size = new System.Drawing.Size(927, 539);
            this.listaPessoas.TabIndex = 6;
            this.listaPessoas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.editarPessoa);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.listaPessoas);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(49, 35);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(927, 539);
            this.panel3.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Gray;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 49);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gray;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderSize = 5;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Gray;
            this.button2.Location = new System.Drawing.Point(0, 482);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(49, 49);
            this.button2.TabIndex = 3;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ImprimirLista
            // 
            this.ImprimirLista.BackColor = System.Drawing.Color.Gray;
            this.ImprimirLista.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ImprimirLista.BackgroundImage")));
            this.ImprimirLista.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ImprimirLista.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.ImprimirLista.FlatAppearance.BorderSize = 0;
            this.ImprimirLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ImprimirLista.Location = new System.Drawing.Point(0, 120);
            this.ImprimirLista.Name = "ImprimirLista";
            this.ImprimirLista.Size = new System.Drawing.Size(49, 49);
            this.ImprimirLista.TabIndex = 7;
            this.ImprimirLista.UseVisualStyleBackColor = false;
            // 
            // atualizarLista
            // 
            this.atualizarLista.BackColor = System.Drawing.Color.Gray;
            this.atualizarLista.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("atualizarLista.BackgroundImage")));
            this.atualizarLista.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.atualizarLista.FlatAppearance.BorderSize = 0;
            this.atualizarLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.atualizarLista.ForeColor = System.Drawing.Color.Gray;
            this.atualizarLista.Location = new System.Drawing.Point(0, 55);
            this.atualizarLista.Name = "atualizarLista";
            this.atualizarLista.Size = new System.Drawing.Size(49, 49);
            this.atualizarLista.TabIndex = 0;
            this.atualizarLista.UseVisualStyleBackColor = false;
            this.atualizarLista.Click += new System.EventHandler(this.atualizarLista_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::Dividas_e_Pessoas.Properties.Resources.close_button;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Dock = System.Windows.Forms.DockStyle.Right;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button3.Location = new System.Drawing.Point(941, 0);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(10);
            this.button3.Size = new System.Drawing.Size(35, 35);
            this.button3.TabIndex = 0;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(976, 574);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(16, 489);
            this.Name = "Form1";
            this.Text = "Dividas e Pessoas";
            this.Load += new System.EventHandler(this.Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bancodadosDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banco_dadosDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listaPessoas)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button atualizarLista;
        private System.Windows.Forms.BindingSource bancodadosDataSetBindingSource;
        private banco_dadosDataSet banco_dadosDataSet;
        private System.Windows.Forms.Button ImprimirLista;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView listaPessoas;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button3;
    }
}

