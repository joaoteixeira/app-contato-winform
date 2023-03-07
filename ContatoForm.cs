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
            
            var nome = txtNome.Text;
            var email = txtEmail.Text;



            string query = "INSERT INTO contato_con (nome_con, email_con) VALUES (@_nome, @_email)";
            var comando = new MySqlCommand(query, conexao);

            comando.Parameters.AddWithValue("@_nome", nome);
            comando.Parameters.AddWithValue("@_email", email);

            comando.ExecuteNonQuery();
        }
    }
}
