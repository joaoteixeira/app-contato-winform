using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppContatoForm
{
    public partial class ContatoForm : Form
    {
        private MySqlConnection conexao;

        private MySqlCommand comando;

        public ContatoForm()
        {
            InitializeComponent();

            Conexao();
        }

        private void Conexao()
        {
            string conexaoString = "server=localhost;database=app_contato_bd;user=root;password=root;port=3360";
            conexao = new MySqlConnection(conexaoString);
            comando = conexao.CreateCommand();

            conexao.Open();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if( ! rdSexo1.Checked && ! rdSexo2.Checked)
                {
                    MessageBox.Show("Marque uma opção!");
                } 
                else
                {
                    var nome = txtNome.Text;
                    var email = txtEmail.Text;

                    var sexo = "Feminino";

                    if (rdSexo1.Checked)
                    {
                        sexo = "Masculino";
                    }



                    string query = "INSERT INTO contato_con (nome_con, email_con, sexo_con) VALUES (@_nome, @_email, @_sexo)";
                    var comando = new MySqlCommand(query, conexao);

                    comando.Parameters.AddWithValue("@_nome", nome);
                    comando.Parameters.AddWithValue("@_email", email);
                    comando.Parameters.AddWithValue("@_sexo", sexo);

                    comando.ExecuteNonQuery();

                }
                


            } catch(Exception ex) {
                //MessageBox.Show($"Ocorreram erros ao tentar salvar os dados!" +
                //    $" Contate o suporte do sistema. (CAD 25)");

                MessageBox.Show(ex.Message);
            }


            
        }
    }
}
