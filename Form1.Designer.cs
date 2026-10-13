namespace SistemaChamados
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
            lblTitulo = new Label();
            lblSubtitulo = new Label();
            btnNovoChamado = new Button();
            btnAtualizar = new Button();
            btnExcluir = new Button();
            lblPesquisar = new Label();
            txtPesquisar = new TextBox();
            btnPesquisar = new Button();
            btnSair = new Button();
            btnTestarConexao = new Button();
            dgvChamados = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvChamados).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(254, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(366, 32);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "SISTEMA DE CHAMADOS DE TI";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Location = new Point(291, 52);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(263, 15);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Gerenciamento de chamados de suporte técnico";
            // 
            // btnNovoChamado
            // 
            btnNovoChamado.Location = new Point(129, 125);
            btnNovoChamado.Name = "btnNovoChamado";
            btnNovoChamado.Size = new Size(75, 23);
            btnNovoChamado.TabIndex = 2;
            btnNovoChamado.Text = "Novo Chamado";
            btnNovoChamado.UseVisualStyleBackColor = true;
            btnNovoChamado.Click += btnNovoChamado_Click_1;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Location = new Point(406, 125);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(75, 23);
            btnAtualizar.TabIndex = 3;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click_1;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(668, 125);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 23);
            btnExcluir.TabIndex = 4;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click_1;
            // 
            // lblPesquisar
            // 
            lblPesquisar.AutoSize = true;
            lblPesquisar.Location = new Point(58, 218);
            lblPesquisar.Name = "lblPesquisar";
            lblPesquisar.Size = new Size(113, 15);
            lblPesquisar.TabIndex = 5;
            lblPesquisar.Text = "Pesquisar chamado:";
            // 
            // txtPesquisar
            // 
            txtPesquisar.Location = new Point(229, 214);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.Size = new Size(380, 23);
            txtPesquisar.TabIndex = 6;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Location = new Point(668, 214);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(75, 23);
            btnPesquisar.TabIndex = 7;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click_1;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(387, 454);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(75, 23);
            btnSair.TabIndex = 8;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            // 
            // btnTestarConexao
            // 
            btnTestarConexao.Location = new Point(668, 378);
            btnTestarConexao.Name = "btnTestarConexao";
            btnTestarConexao.Size = new Size(75, 23);
            btnTestarConexao.TabIndex = 9;
            btnTestarConexao.Text = "Testar Conexão";
            btnTestarConexao.UseVisualStyleBackColor = true;
            btnTestarConexao.Click += btnTestarConexao_Click;
            // 
            // dgvChamados
            // 
            dgvChamados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChamados.Location = new Point(274, 271);
            dgvChamados.Name = "dgvChamados";
            dgvChamados.Size = new Size(280, 149);
            dgvChamados.TabIndex = 10;
            dgvChamados.CellContentClick += dgvChamados_CellContentClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(913, 506);
            Controls.Add(dgvChamados);
            Controls.Add(btnTestarConexao);
            Controls.Add(btnSair);
            Controls.Add(btnPesquisar);
            Controls.Add(txtPesquisar);
            Controls.Add(lblPesquisar);
            Controls.Add(btnExcluir);
            Controls.Add(btnAtualizar);
            Controls.Add(btnNovoChamado);
            Controls.Add(lblSubtitulo);
            Controls.Add(lblTitulo);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvChamados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblSubtitulo;
        private Button btnNovoChamado;
        private Button btnAtualizar;
        private Button btnExcluir;
        private Label lblPesquisar;
        private TextBox txtPesquisar;
        private Button btnPesquisar;
        private Button btnSair;
        private Button btnTestarConexao;
        private DataGridView dgvChamados;
    }
}
