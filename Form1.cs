
using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SistemaChamados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CarregarChamados();
        }

        public void CarregarChamados(string filtro = "")
        {
            try
            {
                Conexao conexao = new Conexao();

                using (MySqlConnection conn = conexao.Conectar())
                {
                    conn.Open();

                    string sql = @"
                        SELECT
                            c.id_chamado AS id,
                            u.nome AS solicitante,
                            e.tipo AS equipamento,
                            cat.nome AS categoria,
                            t.nome AS tecnico,
                            c.prioridade,
                            c.status,
                            c.data_abertura
                        FROM chamados c
                        LEFT JOIN usuarios u
                            ON c.id_usuario = u.id_usuario
                        LEFT JOIN equipamentos e
                            ON c.id_equipamento = e.id_equipamento
                        LEFT JOIN categorias cat
                            ON c.id_categoria = cat.id_categoria
                        LEFT JOIN tecnicos t
                            ON c.id_tecnico = t.id_tecnico";

                    if (!string.IsNullOrWhiteSpace(filtro))
                    {
                        sql += @"
                            WHERE u.nome LIKE @filtro
                            OR e.tipo LIKE @filtro
                            OR c.status LIKE @filtro
                            OR cat.nome LIKE @filtro
                            OR t.nome LIKE @filtro
                            OR c.prioridade LIKE @filtro";
                    }

                    sql += " ORDER BY c.id_chamado DESC";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        if (!string.IsNullOrWhiteSpace(filtro))
                        {
                            cmd.Parameters.AddWithValue(
                                "@filtro", "%" + filtro + "%");
                        }

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        dgvChamados.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar chamados: " + ex.Message);
            }
        }

        private void btnNovoChamado_Click_1(object sender, EventArgs e)
        {
            FrmChamado telaCadastro = new FrmChamado();
            telaCadastro.ShowDialog();
            CarregarChamados();
        }

        private void btnAtualizar_Click_1(object sender, EventArgs e)
        {
            txtPesquisar.Clear();
            CarregarChamados();
        }

        private void btnPesquisar_Click_1(object sender, EventArgs e)
        {
            CarregarChamados(txtPesquisar.Text.Trim());
        }

        private void btnExcluir_Click_1(object sender, EventArgs e)
        {
            if (dgvChamados.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um chamado na tabela para excluir!");
                return;
            }

            object valorId = dgvChamados.SelectedRows[0].Cells["id"].Value;

            if (valorId == null || valorId == DBNull.Value)
            {
                MessageBox.Show("Não foi possível identificar o chamado.");
                return;
            }

            int idChamado = Convert.ToInt32(valorId);

            DialogResult resposta = MessageBox.Show(
                "Deseja realmente excluir o chamado #" + idChamado + "?",
                "Confirmar exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resposta != DialogResult.Yes)
            {
                return;
            }

            try
            {
                Conexao conexao = new Conexao();

                using (MySqlConnection conn = conexao.Conectar())
                {
                    conn.Open();

                    string sql = "DELETE FROM chamados WHERE id_chamado = @id";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", idChamado);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Chamado excluído com sucesso!");
                CarregarChamados();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir chamado: " + ex.Message);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            CarregarChamados();
        }

        private void dgvChamados_CellContentClick(
            object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnTestarConexao_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao conexao = new Conexao();

                using (MySqlConnection conn = conexao.Conectar())
                {
                    conn.Open();
                    MessageBox.Show("Conexão com o banco realizada com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na conexão: " + ex.Message);
            }
        }
    }
}
