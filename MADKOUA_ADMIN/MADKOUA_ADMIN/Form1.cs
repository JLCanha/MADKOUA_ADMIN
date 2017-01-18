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

        DataTable TabelaLivros;

        DataTable Requisicoes;
        DataTable Livros;
        DataTable Autores;
        DataTable Editoras;

        Livro LivroSelecionado;
        Autor AutorSelecionado;
        Editora EditoraSelecionada;
        Requisicao RequisicaoSelecionada;

        Autor AutorInsercaoSelecionado;
        Editora EditoraInsercaoSelecionada;

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

            LivroSelecionado = new Livro();
            AutorSelecionado = new Autor();
            EditoraSelecionada = new Editora();
            RequisicaoSelecionada = new Requisicao();

            AutorInsercaoSelecionado = new Autor();
            EditoraInsercaoSelecionada = new Editora();

            TabelaLivros = new DataTable();

        }
        #endregion

        #region Eventos

        private void Form1_Load(object sender, EventArgs e)
        {

            init();


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

        #region Home

        private void BTN_Home_Devolucao_Click(object sender, EventArgs e)
        {
            Requisicao.MudaEstado(RequisicaoSelecionada.ID, "DevolvidoABib");
            Livro.IncrementaNLivrosDisp(RequisicaoSelecionada.livro.ID);
        }

        private void BTN_Home_Entrega_Click(object sender, EventArgs e)
        {
            Requisicao.MudaEstado(RequisicaoSelecionada.ID, "PorDevolver");
        }

        private void DGV_Home_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int RowIndex = DGV_Home.SelectedCells[0].RowIndex;
            RequisicaoSelecionada.ID = (int)DGV_Home.Rows[RowIndex].Cells["ID"].Value;
            TB_Home_Requisitante.Text = RequisicaoSelecionada.requisitante.Nome;
            TB_Home_Livro.Text = RequisicaoSelecionada.livro.Titulo;
            TB_Home_Estado.Text = RequisicaoSelecionada.Estado;
        }

        #endregion

        #region Livro

        private void TB_Livros_Pesquisa_TextChanged(object sender, EventArgs e)
        {
            ApresentaLivros(TB_Livro_Pesquisa.Text);
        }

        private void DGV_Livro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int RowIndex = DGV_Livro.SelectedCells[0].RowIndex;
            LivroSelecionado.ID = (int)DGV_Livro.Rows[RowIndex].Cells["ID"].Value;
            TB_Livro_Titulo.Text = LivroSelecionado.Titulo;
            TB_Livro_Autor.Text = LivroSelecionado.autor.Nome + LivroSelecionado.autor.Apelido;
            TB_Livro_Edicao.Text = LivroSelecionado.Edicao.ToString();
            TB_Livro_Editora.Text = LivroSelecionado.editora.Nome;
            TB_Livro_ISBN.Text = LivroSelecionado.ISBN;
            TB_Livro_NLivrosDisp.Text = LivroSelecionado.NLivrosDisp.ToString();
        }

        private void InicializaLivros()
        {
            TabelaLivros.Columns.Add("ID", typeof(int));
            TabelaLivros.Columns.Add("Titulo", typeof(String));
            TabelaLivros.Columns.Add("Autor", typeof(String));
            TabelaLivros.Columns.Add("Editora", typeof(String));
            TabelaLivros.Columns.Add("ISBN", typeof(String));
            TabelaLivros.Columns.Add("Edição", typeof(int));

        }

        private void ApresentaLivros(String pesquisa)
        {
            TabelaLivros.Clear();

            Livros = Livro.ListaLivros("Titulo", pesquisa);

            Autor autor = new Autor();
            Editora editora = new Editora();
            foreach (DataRow Linha in Livros.Rows)
            {
                autor.ID = Linha.Field<int>(Livro.ColunaAutorId);
                editora.ID = Linha.Field<int>(Livro.ColunaEditoraId);
                TabelaLivros.Rows.Add(Linha.Field<int>("ID"), Linha.Field<String>(Livro.ColunaTitulo), autor.Nome + " " + autor.Apelido, editora.Nome, Linha.Field<String>(Livro.ColunaISBN), Linha.Field<int>(Livro.ColunaEdicao));
            }
            DGV_Livro.DataSource = TabelaLivros;
        }

        private void BTN_Livro_Inserir_Click(object sender, EventArgs e)
        {

            BTN_Livro_OK.Visible = true;
            BTN_Livro_Cancelar.Visible = true;
            BTN_Livro_Inserir.Enabled = false;
            BTN_Livro_Eliminar.Enabled = false;
            TB_Livro_Pesquisa.Enabled = false;
            DGV_Livro.Enabled = false;

        }

        private void BTN_Livro_Cancelar_Click(object sender, EventArgs e)
        {

            LimpaInsercaoLivro();

        }

        private void BTN_Livro_OK_Click(object sender, EventArgs e)
        {

            AddBD.AdicionaLivro(AutorInsercaoSelecionado, EditoraInsercaoSelecionada, TB_Livro_Titulo.Text, Int32.Parse(TB_Livro_Edicao.Text), TB_Livro_ISBN.Text, Int32.Parse(TB_Livro_NLivrosDisp.Text));
            LimpaInsercaoLivro();
            AtualizaGrids();
        }

        private void BTN_Livro_Eliminar_Click(object sender, EventArgs e)
        {

            Livro.EliminaLivro(LivroSelecionado.ID);
            AtualizaGrids();

        }

        private void LimpaInsercaoLivro()
        {
            BTN_Livro_Cancelar.Visible = false;
            BTN_Livro_OK.Visible = false;
            BTN_Livro_Inserir.Enabled = true;
            BTN_Livro_Eliminar.Enabled = true;
            DGV_Livro.Enabled = true;
            TB_Livro_Titulo.Text = "";
            TB_Livro_Autor.Text = "";
            TB_Livro_Editora.Text = "";
            TB_Livro_ISBN.Text = "";
            TB_Livro_Edicao.Text = "";
            TB_Livro_NLivrosDisp.Text = "";
        }

        #endregion

        #region Autor

        private void BTN_Autor_Eliminar_Click(object sender, EventArgs e)
        {



        }

        private void BTN_Autor_Inserir_Click(object sender, EventArgs e)
        {
            BTN_Autor_OK.Visible = true;
            BTN_Autor_Cancelar.Visible = true;
            BTN_Autor_Inserir.Enabled = false;
            BTN_Autor_Eliminar.Enabled = false;
            TB_Autor_Pesquisa.Enabled = false;
            DGV_Autor.Enabled = false;
        }

        private void BTN_Autor_Cancelar_Click(object sender, EventArgs e)
        {
            LimpaInsercaoAutor();
        }

        private void BTN_Autor_OK_Click(object sender, EventArgs e)
        {
            AddBD.AdicionaAutor(TB_Autor_Nome.Text, TB_Autor_Apelido.Text);
            LimpaInsercaoAutor();
            AtualizaGrids();
        }

        private void DGV_Autor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int RowIndex = DGV_Autor.SelectedCells[0].RowIndex;
            AutorSelecionado.ID = (int)DGV_Autor.Rows[RowIndex].Cells["ID"].Value;
            TB_Autor_Nome.Text = AutorSelecionado.Nome;
            TB_Autor_Apelido.Text = AutorSelecionado.Apelido;
        }

        private void LimpaInsercaoAutor()
        {
            BTN_Autor_Cancelar.Visible = false;
            BTN_Autor_OK.Visible = false;
            BTN_Autor_Inserir.Enabled = true;
            BTN_Autor_Eliminar.Enabled = true;
            TB_Autor_Pesquisa.Enabled = true;
            TB_Autor_Nome.Text = "";
            TB_Autor_Apelido.Text = "";
        }

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
            AtualizaGrids();

        }

        private void DGV_Editora_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int RowIndex = DGV_Editora.SelectedCells[0].RowIndex;
            EditoraSelecionada.ID = (int)DGV_Editora.Rows[RowIndex].Cells["ID"].Value;
            TB_Editora_Nome.Text = EditoraSelecionada.Nome;
            TB_Editora_Morada.Text = EditoraSelecionada.Morada;
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

        #region MetodosAuxiliares

        private void init()
        {

            Panel_SelecaoEditora.Visible = false;
            Panel_Selecao_Autor.Visible = false;

            InicializaLivros();

            AtualizaGrids();


            ApresentaLivros("");
        }


        #endregion

        private void BTN_Livro_Autor_Selecionar_Click(object sender, EventArgs e)
        {
            Panel_Selecao_Autor.Visible = !Panel_Selecao_Autor.Visible;
        }

        private void BTN_Livro_Editora_Selecionar_Click(object sender, EventArgs e)
        {
            Panel_SelecaoEditora.Visible = !Panel_SelecaoEditora.Visible;
        }

        private void DGV_Livro_Autor_Selecao_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int RowIndex = DGV_Livro_Autor_Selecao.SelectedCells[0].RowIndex;
            AutorInsercaoSelecionado.ID = (int)DGV_Livro_Autor_Selecao.Rows[RowIndex].Cells["ID"].Value;
            TB_Livro_Autor.Text = AutorInsercaoSelecionado.Nome + " " + AutorInsercaoSelecionado.Apelido;
            Panel_Selecao_Autor.Visible = false;
        }

        private void DGV_Livro_Editora_Selecao_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int RowIndex = DGV_Livro_Editora_Selecao.SelectedCells[0].RowIndex;
            EditoraInsercaoSelecionada.ID = (int) DGV_Livro_Editora_Selecao.Rows[RowIndex].Cells["ID"].Value;
            TB_Livro_Editora.Text = EditoraInsercaoSelecionada.Nome;
            Panel_SelecaoEditora.Visible = false;
        }

        private void AtualizaGrids()
        {

            Requisicoes = Requisicao.ListaRequisicao();
            Livros = Livro.ListaLivros();
            Autores = Autor.ListaAutores();
            Editoras = Editora.ListaEditoras();


            DGV_Home.DataSource = Requisicoes;
            ApresentaLivros("");
            DGV_Editora.DataSource = Editoras;
            DGV_Autor.DataSource = Autores;
            DGV_Livro_Autor_Selecao.DataSource = Autores;
            DGV_Livro_Editora_Selecao.DataSource = Editoras;
        }
    }
}
