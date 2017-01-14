using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MADKOUA;

namespace MADKOUA_ADMIN
{
    public partial class Form1 : Form
    {
        DataTable TabelaRequisicao;
        DataTable TabelaLivros;
        DataTable TabelaAutores;
        DataTable TabelaEditoras;

        DataTable Requisicoes;
        DataTable Livros;
        DataTable Autores;
        DataTable Editoras;

        AdicionaBD AddBD;

        #region Construtor
        public Form1()
        {
            InitializeComponent();
            Panel_Home.Visible = true;
            Panel_Autor.Visible = false;
            Panel_Editora.Visible = false;
            Panel_Livro.Visible = false;

            AddBD = new AdicionaBD();

        }
        #endregion

        #region Eventos

        private void Form1_Load(object sender, EventArgs e)
        {

            Requisicoes = Requisicao.ListaRequisicao();
            Livros = Livro.ListaLivros();
            Autores = Autor.ListaAutores();
            Editoras = Editora.ListaEditoras();

            DGV_Livro.DataSource = Livros;
            DGV_Editora.DataSource = Editoras;
            DGV_Autor.DataSource = Autores;

        }

        #endregion

        #region Navegação
        private void BTN_Home_Click(object sender, EventArgs e)
        {
            Panel_Home.Visible = true;
            Panel_Autor.Visible = false;
            Panel_Editora.Visible = false;
            Panel_Livro.Visible = false;

        }

        private void BTN_Pesquisa_Click(object sender, EventArgs e)
        {
            Panel_Home.Visible = false;
            Panel_Autor.Visible = false;
            Panel_Editora.Visible = false;
            Panel_Livro.Visible = false;

        }

        private void BTN_AddLivro_Click(object sender, EventArgs e)
        {
            Panel_Home.Visible = false;
            Panel_Autor.Visible = false;
            Panel_Editora.Visible = false;
            Panel_Livro.Visible = true;

        }

        private void BTN_AddAutor_Click(object sender, EventArgs e)
        {
            Panel_Home.Visible = false;
            Panel_Autor.Visible = true;
            Panel_Editora.Visible = false;
            Panel_Livro.Visible = false;

        }

        private void BTN_AddEditora_Click(object sender, EventArgs e)
        {
            Panel_Home.Visible = false;
            Panel_Autor.Visible = false;
            Panel_Editora.Visible = true;
            Panel_Livro.Visible = false;

        }






        #endregion

        #region Livro



        #endregion

        #region Autor



        #endregion

        #region Editora

        private void BTN_Editora_Inserir_Click(object sender, EventArgs e)
        {

            BTN_Editora_OK.Visible = true;
            BTN_Editora_Cancelar.Visible = true;
            BTN_Editora_Inserir.Enabled = false;
            BTN_Editora_Eliminar.Enabled = false;
            TB_Editora_Pesquisa.Enabled = false;
            DGV_Editora.Enabled = false;

        }


        private void BTN_Editora_Cancelar_Click(object sender, EventArgs e)
        {

            LimpaInsercaoEditora();

        }



        private void BTN_Editora_OK_Click(object sender, EventArgs e)
        {

            AddBD.AdicionaEditora(TB_Editora_Nome.Text, TB_Editora_Morada.Text);
            LimpaInsercaoEditora();

        }

        private void LimpaInsercaoEditora()
        {
            BTN_Editora_Cancelar.Visible = false;
            BTN_Editora_OK.Visible = false;
            BTN_Editora_Inserir.Enabled = true;
            BTN_Editora_Eliminar.Enabled = true;
            TB_Editora_Pesquisa.Enabled = true;
            TB_Editora_Nome.Text = "";
            TB_Editora_Morada.Text = "";
        }

        #endregion
    }
}
