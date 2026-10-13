
using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SistemaChamados
{
    public partial class FrmChamado : Form
    {
        public FrmChamado()
        {
            InitializeComponent();

            cmbPrioridade.Items.Clear();
            cmbPrioridade.Items.AddRange(
                new object[] { "Baixa", "Média", "Alta", "Urgente" }
            );

            cmbStatus.Items.Clear();
            cmbStatus.Items.AddRange(
                new object[] {
                    "Aberto",
                    "Em andamento",
                    "Aguardando",
                    "Resolvido",
                    "Cancelado"
                }
            );

            cmbPrioridade.SelectedItem = "Média";
            cmbStatus.SelectedItem = "Aberto";

            btnSalvar.Click += btnSalvar_Click;
            btnCancelar.Click += btnCancelar_Click;

            CarregarSolicitantes();
            CarregarEquipamentos();
            CarregarCategorias();
            CarregarTecnicos();
        }

        private void CarregarSolicitantes()
        {
            CarregarCombo(
                cmbSolicitante,
                "SELECT id_usuario, nome FROM usuarios ORDER BY nome",
                "id_usuario",
                "nome"
            );
        }

        private void CarregarEquipamentos()
        {
            CarregarCombo(
                comboBox1,
                "SELECT id_equipamento, patrimonio, tipo FROM equipamentos ORDER BY patrimonio",
                "id_equipamento",
                "patrimonio",
                "tipo"
            );
        }

        private void CarregarCategorias()
        {
            CarregarCombo(
                cmbCategoria,
                "SELECT id_categoria, nome FROM categorias ORDER BY nome",
                "id_categoria",
                "nome"
            );
        }

        private void CarregarTecnicos()
        {
            CarregarCombo(
                cmbTecnico,
                "SELECT id_tecnico, nome FROM tecnicos ORDER BY nome",
                "id_tecnico",
                "nome"
            );
        }

        private void CarregarCombo(
            ComboBox combo,
            string sql,
            string campoId,
            string campoNome,
            string campoExtra = null)
        {
            try
            {
                Conexao conexao = new Conexao();

                using (MySqlConnection banco = conexao.Conectar())
                {
                    banco.Open();

                    using (MySqlCommand comando = new MySqlCommand(sql, banco))
                    using (MySqlDataReader leitor = comando.ExecuteReader())
                    {
                        combo.Items.Clear();

                        while (leitor.Read())
                        {
                            string texto = leitor[campoId].ToString()
                                + " - " + leitor[campoNome].ToString();

                            if (campoExtra != null)
                            {
                                texto += " - " + leitor[campoExtra].ToString();
                            }

                            combo.Items.Add(texto);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Erro ao carregar " + combo.Name + ":\n" + ex.Message,
                    "Erro de conexão",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private int ObterIdSelecionado(ComboBox combo)
        {
            if (combo.SelectedItem == null)
            {
                return 0;
            }

            string texto = combo.SelectedItem.ToString();
            string[] partes = texto.Split('-');

            int id;

            if (partes.Length > 0 &&
                int.TryParse(partes[0].Trim(), out id))
            {
                return id;
            }

            return 0;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            int idUsuario = ObterIdSelecionado(cmbSolicitante);
            int idEquipamento = ObterIdSelecionado(comboBox1);
            int idCategoria = ObterIdSelecionado(cmbCategoria);
            int idTecnico = ObterIdSelecionado(cmbTecnico);

            if (idUsuario == 0 ||
                idEquipamento == 0 ||
                idCategoria == 0 ||
                idTecnico == 0)
            {
                MessageBox.Show(
                    "Selecione o solicitante, equipamento, categoria e técnico.",
                    "Campos obrigatórios",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            if (string.IsNullOrWhiteSpace(txtDescricao.Text))
            {
                MessageBox.Show(
                    "Digite a descrição do problema.",
                    "Campo obrigatório",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                txtDescricao.Focus();
                return;
            }

            if (txtDescricao.Text.Length > 500)
            {
                MessageBox.Show(
                    "A descrição deve ter no máximo 500 caracteres.",
                    "Descrição muito longa",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            string prioridade = cmbPrioridade.Text;
            string status = cmbStatus.Text;

            if (string.IsNullOrWhiteSpace(prioridade))
                prioridade = "Média";

            if (string.IsNullOrWhiteSpace(status))
                status = "Aberto";

            try
            {
                Conexao conexao = new Conexao();

                using (MySqlConnection banco = conexao.Conectar())
                {
                    banco.Open();

                    string sql = @"
                        INSERT INTO chamados
                        (id_usuario, id_equipamento, id_categoria,
                         id_tecnico, descricao, prioridade, status)
                        VALUES
                        (@usuario, @equipamento, @categoria,
                         @tecnico, @descricao, @prioridade, @status)";

                    using (MySqlCommand comando =
                        new MySqlCommand(sql, banco))
                    {
                        comando.Parameters.AddWithValue("@usuario", idUsuario);
                        comando.Parameters.AddWithValue("@equipamento", idEquipamento);
                        comando.Parameters.AddWithValue("@categoria", idCategoria);
                        comando.Parameters.AddWithValue("@tecnico", idTecnico);
                        comando.Parameters.AddWithValue("@descricao", txtDescricao.Text.Trim());
                        comando.Parameters.AddWithValue("@prioridade", prioridade);
                        comando.Parameters.AddWithValue("@status", status);

                        comando.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Chamado cadastrado com sucesso!",
                    "Sucesso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Erro ao salvar o chamado:\n" + ex.Message,
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            cmbSolicitante.SelectedIndex = -1;
            comboBox1.SelectedIndex = -1;
            cmbCategoria.SelectedIndex = -1;
            cmbTecnico.SelectedIndex = -1;
            cmbPrioridade.SelectedItem = "Média";
            cmbStatus.SelectedItem = "Aberto";
            txtDescricao.Clear();
        }

        private void cmbTecnico_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
