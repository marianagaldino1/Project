using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dev_Project
{
    public partial class MeusRepositorios : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Dev_Project;Integrated Security=True");
        SqlCommand cmd;
        int ID = 0;
     


      
        public MeusRepositorios(int iD, string nome, string descricao, string linguagem, DateTime data, string dono) 
        {
            InitializeComponent();
            ID = iD;
            txtNome.Text = nome;
            txtDescricao.Text = descricao;
            txtLinguagem.Text = linguagem;
            txtDono.Text = dono;
            txtData.Text = data.ToString();
            
        }
     
        public MeusRepositorios()
        {
        }

        private void btnSalvarFavorito_Click(object sender, EventArgs e)
        {
            if (txtNome.Text != "" && txtLinguagem.Text != "" && txtDescricao.Text != "" && txtDono.Text != "")
            {
                try
                {
                    cmd = new SqlCommand(" INSERT INTO Projeto_favorito (id) VALUES(@id)", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@id", ID);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registro adicionado aos favoritos...");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro : " + ex.Message);
                }
                finally
                {
                    con.Close();
                   
                }
            }
            else
            {
                MessageBox.Show("Informe todos os dados requeridos");
            }

        }
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text != "" && txtLinguagem.Text != "" && txtDescricao.Text != "" && txtDono.Text != "")
            {
                try
                {
                    cmd = new SqlCommand("UPDATE Projeto SET nome=@nome, descricao=@descricao, linguagem=@linguagem,dt_atualizacao=@dt_atualizacao,dono_repositorio=@dono_repositorio WHERE id=@id", con);
                    con.Open();

                    cmd.Parameters.AddWithValue("@nome", txtNome.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@descricao", txtDescricao.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@linguagem", txtLinguagem.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@dt_atualizacao", DateTime.Today);
                    cmd.Parameters.AddWithValue("@dono_repositorio", txtDono.Text.ToUpper());
                    MessageBox.Show("Registro atualizado com sucesso...");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro : " + ex.Message);
                }
                finally
                {
                    con.Close();
                   
                }
            }
            else
            {
                MessageBox.Show("Informe todos os dados requeridos");
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                if (MessageBox.Show("Deseja Deletar esse  registro ?", "Repositório", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        cmd = new SqlCommand("DELETE Projeto WHERE id=@id", con);
                        con.Open();
                        cmd.Parameters.AddWithValue("@id", ID);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("registro deletado com sucesso...!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro : " + ex.Message);
                    }
                    finally
                    {
                        con.Close();
                        MeusRepositorios meusRepositorios = new MeusRepositorios();
                        meusRepositorios.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione um registro para deletar");
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
