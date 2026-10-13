namespace SistemaChamados
{
    partial class FrmChamado
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblSolicitante = new Label();
            cmbSolicitante = new ComboBox();
            lblEquipamento = new Label();
            comboBox1 = new ComboBox();
            lblCategoria = new Label();
            cmbCategoria = new ComboBox();
            lblTecnico = new Label();
            cmbTecnico = new ComboBox();
            lblPrioridade = new Label();
            cmbPrioridade = new ComboBox();
            lblStatus = new Label();
            cmbStatus = new ComboBox();
            Aberto = new Label();
            txtDescricao = new TextBox();
            btnSalvar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // lblSolicitante
            // 
            lblSolicitante.AutoSize = true;
            lblSolicitante.Location = new Point(64, 44);
            lblSolicitante.Name = "lblSolicitante";
            lblSolicitante.Size = new Size(65, 15);
            lblSolicitante.TabIndex = 15;
            lblSolicitante.Text = "Solicitante:";
            // 
            // cmbSolicitante
            // 
            cmbSolicitante.FormattingEnabled = true;
            cmbSolicitante.Location = new Point(149, 41);
            cmbSolicitante.Name = "cmbSolicitante";
            cmbSolicitante.Size = new Size(121, 23);
            cmbSolicitante.TabIndex = 14;
            // 
            // lblEquipamento
            // 
            lblEquipamento.AutoSize = true;
            lblEquipamento.Location = new Point(48, 92);
            lblEquipamento.Name = "lblEquipamento";
            lblEquipamento.Size = new Size(81, 15);
            lblEquipamento.TabIndex = 13;
            lblEquipamento.Text = "Equipamento:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(149, 89);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 12;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(68, 132);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(61, 15);
            lblCategoria.TabIndex = 11;
            lblCategoria.Text = "Categoria:";
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(149, 132);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(121, 23);
            cmbCategoria.TabIndex = 10;
            // 
            // lblTecnico
            // 
            lblTecnico.AutoSize = true;
            lblTecnico.Location = new Point(12, 179);
            lblTecnico.Name = "lblTecnico";
            lblTecnico.Size = new Size(116, 15);
            lblTecnico.TabIndex = 9;
            lblTecnico.Text = "Técnico responsável:";
            // 
            // cmbTecnico
            // 
            cmbTecnico.FormattingEnabled = true;
            cmbTecnico.Location = new Point(149, 179);
            cmbTecnico.Name = "cmbTecnico";
            cmbTecnico.Size = new Size(121, 23);
            cmbTecnico.TabIndex = 8;
            cmbTecnico.SelectedIndexChanged += cmbTecnico_SelectedIndexChanged;
            // 
            // lblPrioridade
            // 
            lblPrioridade.AutoSize = true;
            lblPrioridade.Location = new Point(65, 232);
            lblPrioridade.Name = "lblPrioridade";
            lblPrioridade.Size = new Size(64, 15);
            lblPrioridade.TabIndex = 7;
            lblPrioridade.Text = "Prioridade:";
            // 
            // cmbPrioridade
            // 
            cmbPrioridade.FormattingEnabled = true;
            cmbPrioridade.Items.AddRange(new object[] { "Baixa", "Média", "Alta", "Urgente" });
            cmbPrioridade.Location = new Point(149, 232);
            cmbPrioridade.Name = "cmbPrioridade";
            cmbPrioridade.Size = new Size(121, 23);
            cmbPrioridade.TabIndex = 6;
            cmbPrioridade.Text = "media";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(87, 282);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(42, 15);
            lblStatus.TabIndex = 5;
            lblStatus.Text = "Status:";
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Aberto", "Em andamento", "Aguardando", "Resolvido", "Cancelado" });
            cmbStatus.Location = new Point(149, 282);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(121, 23);
            cmbStatus.TabIndex = 4;
            // 
            // Aberto
            // 
            Aberto.AutoSize = true;
            Aberto.Location = new Point(12, 336);
            Aberto.Name = "Aberto";
            Aberto.Size = new Size(61, 15);
            Aberto.TabIndex = 3;
            Aberto.Text = "Descrição:";
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(87, 328);
            txtDescricao.Multiline = true;
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(503, 110);
            txtDescricao.TabIndex = 2;
            txtDescricao.Text = "hhhhtht";
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(677, 327);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(100, 30);
            btnSalvar.TabIndex = 1;
            btnSalvar.Text = "Salvar Chamado";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(677, 375);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(100, 30);
            btnCancelar.TabIndex = 0;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // FrmChamado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(txtDescricao);
            Controls.Add(Aberto);
            Controls.Add(cmbStatus);
            Controls.Add(lblStatus);
            Controls.Add(cmbPrioridade);
            Controls.Add(lblPrioridade);
            Controls.Add(cmbTecnico);
            Controls.Add(lblTecnico);
            Controls.Add(cmbCategoria);
            Controls.Add(lblCategoria);
            Controls.Add(comboBox1);
            Controls.Add(lblEquipamento);
            Controls.Add(cmbSolicitante);
            Controls.Add(lblSolicitante);
            Name = "FrmChamado";
            Text = "Novo Chamado";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblSolicitante;
        private ComboBox cmbSolicitante;
        private Label lblEquipamento;
        private ComboBox comboBox1;
        private Label lblCategoria;
        private ComboBox cmbCategoria;
        private Label lblTecnico;
        private ComboBox cmbTecnico;
        private Label lblPrioridade;
        private ComboBox cmbPrioridade;
        private Label lblStatus;
        private ComboBox cmbStatus;
        private Label Aberto;
        private TextBox txtDescricao;
        private Button btnSalvar;
        private Button btnCancelar;
    }
}