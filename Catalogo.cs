using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Dev_Project
{
    public partial class Catalogo : Form
    {

        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Dev_Project;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        int ID = 0;

        public Catalogo()
        {
            InitializeComponent();
         
        }

        
      
        private void LimparDados()
        {
            txtNome.Text = "";
            txtDescricao.Text = "";
            txtLinguagem.Text = "";
            txtDono.Text = "";
            ID = 0;
        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text != "" && txtLinguagem.Text != "" && txtDescricao.Text != "" && txtDono.Text != "" )
            {
                try
                {
                    cmd = new SqlCommand(" INSERT INTO Projeto (nome,descricao,linguagem,dt_atualizacao,dono_repositorio) VALUES(@nome,@descricao,@linguagem,@dt_atualizacao,@dono_repositorio)", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@nome", txtNome.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@descricao", txtDescricao.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@linguagem", txtLinguagem.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@dt_atualizacao", DateTime.Today);
                    cmd.Parameters.AddWithValue("@dono_repositorio", txtDono.Text.ToUpper());

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registro incluído com sucesso...");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro : " + ex.Message);
                }
                finally
                {
                    con.Close();
                    LimparDados();
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
                if (MessageBox.Show("Deseja Deletar todos os registros ?", "Repositório", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        cmd = new SqlCommand("DELETE Projeto ", con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("registros deletado com sucesso...!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro : " + ex.Message);
                    }
                    finally
                    {
                        con.Close();
                        LimparDados();
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione um registro para deletar");
            }
        }

        private void dtgProjeto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            {
                
               
                ID = Convert.ToInt32(dtgProjeto.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtNome.Text = dtgProjeto.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtDescricao.Text = dtgProjeto.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtLinguagem.Text = dtgProjeto.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtDono.Text = dtgProjeto.Rows[e.RowIndex].Cells[5].Value.ToString();
                DateTime data = Convert.ToDateTime(dtgProjeto.Rows[e.RowIndex].Cells[4].Value.ToString());

                MeusRepositorios meusRepositorios = new MeusRepositorios(ID, txtNome.Text, txtDescricao.Text,txtLinguagem.Text,data ,txtDono.Text);
                meusRepositorios.Show();
            }
            
        }

      



        private void btnListar_Click(object sender, EventArgs e)
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("SELECT * FROM Projeto", con);
            adapt.Fill(dt);
            dtgProjeto.DataSource = dt;

            con.Close();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            con.Open();

            txtDescricao.Visible = false;
            txtDono.Visible = false;
            txtLinguagem.Visible = false;
            label2.Visible = false;
            label4.Visible = false;
            label5.Visible = false;

            DataTable dt = new DataTable();

            SqlDataAdapter cmd = new SqlDataAdapter("SELECT * FROM Projeto WHERE nome like @nome", con);
            cmd.SelectCommand.Parameters.AddWithValue("@nome", string.Format("%{0}%",txtNome.Text.ToUpper()));
            cmd.Fill(dt);

       
            dtgProjeto.DataSource = dt;

            con.Close();
        }

        private void btnListarFavoritos_Click(object sender, EventArgs e)
        {
            con.Open();

            DataTable dt = new();

            SqlDataAdapter cmd = new SqlDataAdapter("SELECT * FROM Projeto pj inner join Projeto_favorito pf on pj.id = pf.id ", con);

           
            cmd.Fill(dt);


            dtgProjeto.DataSource = dt;

            con.Close();
        }
    }
}