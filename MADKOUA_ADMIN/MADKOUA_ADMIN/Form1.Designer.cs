namespace MADKOUA_ADMIN
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Panel_Botoes = new System.Windows.Forms.Panel();
            this.BTN_AddEditora = new System.Windows.Forms.Button();
            this.BTN_AddAutor = new System.Windows.Forms.Button();
            this.BTN_AddLivro = new System.Windows.Forms.Button();
            this.BTN_Home = new System.Windows.Forms.Button();
            this.Panel_Home = new System.Windows.Forms.Panel();
            this.Panel_Home_DGV = new System.Windows.Forms.Panel();
            this.DGV_Home = new System.Windows.Forms.DataGridView();
            this.Panel_Home_Cabecalho = new System.Windows.Forms.Panel();
            this.BTN_Devolucao = new System.Windows.Forms.Button();
            this.BTN_Entrega = new System.Windows.Forms.Button();
            this.TB_Estado = new System.Windows.Forms.TextBox();
            this.TB_Requisitante = new System.Windows.Forms.TextBox();
            this.TB_Livro = new System.Windows.Forms.TextBox();
            this.LB_Estado = new System.Windows.Forms.Label();
            this.LB_Requisitante = new System.Windows.Forms.Label();
            this.LB_Livro = new System.Windows.Forms.Label();
            this.Panel_Livro = new System.Windows.Forms.Panel();
            this.LB_NLivrosDisp = new System.Windows.Forms.Label();
            this.LB_Edicao = new System.Windows.Forms.Label();
            this.LB_Autor = new System.Windows.Forms.Label();
            this.LB_Titulo = new System.Windows.Forms.Label();
            this.TB_Livro_NLivrosDisp = new System.Windows.Forms.TextBox();
            this.Panel_Autor = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.Panel_Editora = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.TB_Livro_Edicao = new System.Windows.Forms.TextBox();
            this.TB_Livro_Autor = new System.Windows.Forms.TextBox();
            this.TB_Livro_Titulo = new System.Windows.Forms.TextBox();
            this.TB_Livro_Pesquisa = new System.Windows.Forms.TextBox();
            this.Panel_Livro_Top = new System.Windows.Forms.Panel();
            this.Panel_Livro_DGV = new System.Windows.Forms.Panel();
            this.DGV_Livro = new System.Windows.Forms.DataGridView();
            this.BTN_Livro_Eliminar = new System.Windows.Forms.Button();
            this.BTN_Livro_Inserir = new System.Windows.Forms.Button();
            this.Panel_Botoes.SuspendLayout();
            this.Panel_Home.SuspendLayout();
            this.Panel_Home_DGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Home)).BeginInit();
            this.Panel_Home_Cabecalho.SuspendLayout();
            this.Panel_Livro.SuspendLayout();
            this.Panel_Autor.SuspendLayout();
            this.Panel_Editora.SuspendLayout();
            this.Panel_Livro_Top.SuspendLayout();
            this.Panel_Livro_DGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Livro)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel_Botoes
            // 
            this.Panel_Botoes.Controls.Add(this.BTN_AddEditora);
            this.Panel_Botoes.Controls.Add(this.BTN_AddAutor);
            this.Panel_Botoes.Controls.Add(this.BTN_AddLivro);
            this.Panel_Botoes.Controls.Add(this.BTN_Home);
            this.Panel_Botoes.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel_Botoes.Location = new System.Drawing.Point(0, 0);
            this.Panel_Botoes.Margin = new System.Windows.Forms.Padding(4);
            this.Panel_Botoes.Name = "Panel_Botoes";
            this.Panel_Botoes.Size = new System.Drawing.Size(71, 593);
            this.Panel_Botoes.TabIndex = 0;
            // 
            // BTN_AddEditora
            // 
            this.BTN_AddEditora.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTN_AddEditora.Location = new System.Drawing.Point(0, 195);
            this.BTN_AddEditora.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_AddEditora.Name = "BTN_AddEditora";
            this.BTN_AddEditora.Size = new System.Drawing.Size(71, 65);
            this.BTN_AddEditora.TabIndex = 4;
            this.BTN_AddEditora.Text = "Editora";
            this.BTN_AddEditora.UseVisualStyleBackColor = true;
            this.BTN_AddEditora.Click += new System.EventHandler(this.BTN_AddEditora_Click);
            // 
            // BTN_AddAutor
            // 
            this.BTN_AddAutor.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTN_AddAutor.Location = new System.Drawing.Point(0, 130);
            this.BTN_AddAutor.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_AddAutor.Name = "BTN_AddAutor";
            this.BTN_AddAutor.Size = new System.Drawing.Size(71, 65);
            this.BTN_AddAutor.TabIndex = 3;
            this.BTN_AddAutor.Text = "Autor";
            this.BTN_AddAutor.UseVisualStyleBackColor = true;
            this.BTN_AddAutor.Click += new System.EventHandler(this.BTN_AddAutor_Click);
            // 
            // BTN_AddLivro
            // 
            this.BTN_AddLivro.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTN_AddLivro.Location = new System.Drawing.Point(0, 65);
            this.BTN_AddLivro.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_AddLivro.Name = "BTN_AddLivro";
            this.BTN_AddLivro.Size = new System.Drawing.Size(71, 65);
            this.BTN_AddLivro.TabIndex = 2;
            this.BTN_AddLivro.Text = "Livro";
            this.BTN_AddLivro.UseVisualStyleBackColor = true;
            this.BTN_AddLivro.Click += new System.EventHandler(this.BTN_AddLivro_Click);
            // 
            // BTN_Home
            // 
            this.BTN_Home.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTN_Home.Location = new System.Drawing.Point(0, 0);
            this.BTN_Home.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_Home.Name = "BTN_Home";
            this.BTN_Home.Size = new System.Drawing.Size(71, 65);
            this.BTN_Home.TabIndex = 0;
            this.BTN_Home.Text = "Home";
            this.BTN_Home.UseVisualStyleBackColor = true;
            this.BTN_Home.Click += new System.EventHandler(this.BTN_Home_Click);
            // 
            // Panel_Home
            // 
            this.Panel_Home.Controls.Add(this.Panel_Home_DGV);
            this.Panel_Home.Controls.Add(this.Panel_Home_Cabecalho);
            this.Panel_Home.Location = new System.Drawing.Point(1333, 0);
            this.Panel_Home.Margin = new System.Windows.Forms.Padding(4);
            this.Panel_Home.Name = "Panel_Home";
            this.Panel_Home.Size = new System.Drawing.Size(1087, 593);
            this.Panel_Home.TabIndex = 1;
            // 
            // Panel_Home_DGV
            // 
            this.Panel_Home_DGV.Controls.Add(this.DGV_Home);
            this.Panel_Home_DGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Home_DGV.Location = new System.Drawing.Point(0, 130);
            this.Panel_Home_DGV.Margin = new System.Windows.Forms.Padding(4);
            this.Panel_Home_DGV.Name = "Panel_Home_DGV";
            this.Panel_Home_DGV.Size = new System.Drawing.Size(1087, 463);
            this.Panel_Home_DGV.TabIndex = 3;
            // 
            // DGV_Home
            // 
            this.DGV_Home.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Home.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_Home.Location = new System.Drawing.Point(0, 0);
            this.DGV_Home.Margin = new System.Windows.Forms.Padding(4);
            this.DGV_Home.Name = "DGV_Home";
            this.DGV_Home.Size = new System.Drawing.Size(1087, 463);
            this.DGV_Home.TabIndex = 0;
            // 
            // Panel_Home_Cabecalho
            // 
            this.Panel_Home_Cabecalho.Controls.Add(this.BTN_Devolucao);
            this.Panel_Home_Cabecalho.Controls.Add(this.BTN_Entrega);
            this.Panel_Home_Cabecalho.Controls.Add(this.TB_Estado);
            this.Panel_Home_Cabecalho.Controls.Add(this.TB_Requisitante);
            this.Panel_Home_Cabecalho.Controls.Add(this.TB_Livro);
            this.Panel_Home_Cabecalho.Controls.Add(this.LB_Estado);
            this.Panel_Home_Cabecalho.Controls.Add(this.LB_Requisitante);
            this.Panel_Home_Cabecalho.Controls.Add(this.LB_Livro);
            this.Panel_Home_Cabecalho.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Home_Cabecalho.Location = new System.Drawing.Point(0, 0);
            this.Panel_Home_Cabecalho.Margin = new System.Windows.Forms.Padding(4);
            this.Panel_Home_Cabecalho.Name = "Panel_Home_Cabecalho";
            this.Panel_Home_Cabecalho.Size = new System.Drawing.Size(1087, 130);
            this.Panel_Home_Cabecalho.TabIndex = 2;
            // 
            // BTN_Devolucao
            // 
            this.BTN_Devolucao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Devolucao.Location = new System.Drawing.Point(812, 82);
            this.BTN_Devolucao.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_Devolucao.Name = "BTN_Devolucao";
            this.BTN_Devolucao.Size = new System.Drawing.Size(125, 38);
            this.BTN_Devolucao.TabIndex = 7;
            this.BTN_Devolucao.Text = "Devolução";
            this.BTN_Devolucao.UseVisualStyleBackColor = true;
            // 
            // BTN_Entrega
            // 
            this.BTN_Entrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Entrega.Location = new System.Drawing.Point(945, 82);
            this.BTN_Entrega.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_Entrega.Name = "BTN_Entrega";
            this.BTN_Entrega.Size = new System.Drawing.Size(125, 38);
            this.BTN_Entrega.TabIndex = 6;
            this.BTN_Entrega.Text = "Entrega";
            this.BTN_Entrega.UseVisualStyleBackColor = true;
            // 
            // TB_Estado
            // 
            this.TB_Estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Estado.Location = new System.Drawing.Point(128, 9);
            this.TB_Estado.Margin = new System.Windows.Forms.Padding(4);
            this.TB_Estado.Name = "TB_Estado";
            this.TB_Estado.Size = new System.Drawing.Size(587, 29);
            this.TB_Estado.TabIndex = 5;
            // 
            // TB_Requisitante
            // 
            this.TB_Requisitante.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Requisitante.Location = new System.Drawing.Point(812, 9);
            this.TB_Requisitante.Margin = new System.Windows.Forms.Padding(4);
            this.TB_Requisitante.Name = "TB_Requisitante";
            this.TB_Requisitante.Size = new System.Drawing.Size(257, 29);
            this.TB_Requisitante.TabIndex = 4;
            // 
            // TB_Livro
            // 
            this.TB_Livro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Livro.Location = new System.Drawing.Point(128, 46);
            this.TB_Livro.Margin = new System.Windows.Forms.Padding(4);
            this.TB_Livro.Name = "TB_Livro";
            this.TB_Livro.Size = new System.Drawing.Size(587, 29);
            this.TB_Livro.TabIndex = 3;
            // 
            // LB_Estado
            // 
            this.LB_Estado.AutoSize = true;
            this.LB_Estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Estado.Location = new System.Drawing.Point(725, 12);
            this.LB_Estado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_Estado.Name = "LB_Estado";
            this.LB_Estado.Size = new System.Drawing.Size(73, 24);
            this.LB_Estado.TabIndex = 2;
            this.LB_Estado.Text = "Estado:";
            // 
            // LB_Requisitante
            // 
            this.LB_Requisitante.AutoSize = true;
            this.LB_Requisitante.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Requisitante.Location = new System.Drawing.Point(8, 12);
            this.LB_Requisitante.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_Requisitante.Name = "LB_Requisitante";
            this.LB_Requisitante.Size = new System.Drawing.Size(118, 24);
            this.LB_Requisitante.TabIndex = 1;
            this.LB_Requisitante.Text = "Requisitante:";
            // 
            // LB_Livro
            // 
            this.LB_Livro.AutoSize = true;
            this.LB_Livro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Livro.Location = new System.Drawing.Point(8, 49);
            this.LB_Livro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_Livro.Name = "LB_Livro";
            this.LB_Livro.Size = new System.Drawing.Size(55, 24);
            this.LB_Livro.TabIndex = 0;
            this.LB_Livro.Text = "Livro:";
            // 
            // Panel_Livro
            // 
            this.Panel_Livro.Controls.Add(this.Panel_Livro_DGV);
            this.Panel_Livro.Controls.Add(this.Panel_Livro_Top);
            this.Panel_Livro.Location = new System.Drawing.Point(71, 0);
            this.Panel_Livro.Margin = new System.Windows.Forms.Padding(4);
            this.Panel_Livro.Name = "Panel_Livro";
            this.Panel_Livro.Size = new System.Drawing.Size(1087, 593);
            this.Panel_Livro.TabIndex = 3;
            this.Panel_Livro.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_Livro_Paint);
            // 
            // LB_NLivrosDisp
            // 
            this.LB_NLivrosDisp.AutoSize = true;
            this.LB_NLivrosDisp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_NLivrosDisp.Location = new System.Drawing.Point(29, 136);
            this.LB_NLivrosDisp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_NLivrosDisp.Name = "LB_NLivrosDisp";
            this.LB_NLivrosDisp.Size = new System.Drawing.Size(258, 24);
            this.LB_NLivrosDisp.TabIndex = 4;
            this.LB_NLivrosDisp.Text = "Número de livros disponíveis:";
            // 
            // LB_Edicao
            // 
            this.LB_Edicao.AutoSize = true;
            this.LB_Edicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Edicao.Location = new System.Drawing.Point(29, 113);
            this.LB_Edicao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_Edicao.Name = "LB_Edicao";
            this.LB_Edicao.Size = new System.Drawing.Size(74, 24);
            this.LB_Edicao.TabIndex = 3;
            this.LB_Edicao.Text = "Edição:";
            // 
            // LB_Autor
            // 
            this.LB_Autor.AutoSize = true;
            this.LB_Autor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Autor.Location = new System.Drawing.Point(29, 89);
            this.LB_Autor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_Autor.Name = "LB_Autor";
            this.LB_Autor.Size = new System.Drawing.Size(60, 24);
            this.LB_Autor.TabIndex = 2;
            this.LB_Autor.Text = "Autor:";
            // 
            // LB_Titulo
            // 
            this.LB_Titulo.AutoSize = true;
            this.LB_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Titulo.Location = new System.Drawing.Point(29, 65);
            this.LB_Titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_Titulo.Name = "LB_Titulo";
            this.LB_Titulo.Size = new System.Drawing.Size(61, 24);
            this.LB_Titulo.TabIndex = 1;
            this.LB_Titulo.Text = "Titulo:";
            // 
            // TB_Livro_NLivrosDisp
            // 
            this.TB_Livro_NLivrosDisp.Location = new System.Drawing.Point(295, 138);
            this.TB_Livro_NLivrosDisp.Margin = new System.Windows.Forms.Padding(4);
            this.TB_Livro_NLivrosDisp.Name = "TB_Livro_NLivrosDisp";
            this.TB_Livro_NLivrosDisp.Size = new System.Drawing.Size(779, 22);
            this.TB_Livro_NLivrosDisp.TabIndex = 0;
            // 
            // Panel_Autor
            // 
            this.Panel_Autor.Controls.Add(this.button1);
            this.Panel_Autor.Location = new System.Drawing.Point(1333, 150);
            this.Panel_Autor.Margin = new System.Windows.Forms.Padding(4);
            this.Panel_Autor.Name = "Panel_Autor";
            this.Panel_Autor.Size = new System.Drawing.Size(1087, 593);
            this.Panel_Autor.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(143, 81);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "autor";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Panel_Editora
            // 
            this.Panel_Editora.Controls.Add(this.button5);
            this.Panel_Editora.Location = new System.Drawing.Point(1333, 373);
            this.Panel_Editora.Margin = new System.Windows.Forms.Padding(4);
            this.Panel_Editora.Name = "Panel_Editora";
            this.Panel_Editora.Size = new System.Drawing.Size(1087, 593);
            this.Panel_Editora.TabIndex = 5;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(119, 94);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 28);
            this.button5.TabIndex = 0;
            this.button5.Text = "editora";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // TB_Livro_Edicao
            // 
            this.TB_Livro_Edicao.Location = new System.Drawing.Point(295, 113);
            this.TB_Livro_Edicao.Name = "TB_Livro_Edicao";
            this.TB_Livro_Edicao.Size = new System.Drawing.Size(779, 22);
            this.TB_Livro_Edicao.TabIndex = 5;
            // 
            // TB_Livro_Autor
            // 
            this.TB_Livro_Autor.Location = new System.Drawing.Point(295, 89);
            this.TB_Livro_Autor.Name = "TB_Livro_Autor";
            this.TB_Livro_Autor.Size = new System.Drawing.Size(779, 22);
            this.TB_Livro_Autor.TabIndex = 6;
            // 
            // TB_Livro_Titulo
            // 
            this.TB_Livro_Titulo.Location = new System.Drawing.Point(295, 65);
            this.TB_Livro_Titulo.Name = "TB_Livro_Titulo";
            this.TB_Livro_Titulo.Size = new System.Drawing.Size(779, 22);
            this.TB_Livro_Titulo.TabIndex = 7;
            // 
            // TB_Livro_Pesquisa
            // 
            this.TB_Livro_Pesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Livro_Pesquisa.Location = new System.Drawing.Point(33, 16);
            this.TB_Livro_Pesquisa.Name = "TB_Livro_Pesquisa";
            this.TB_Livro_Pesquisa.Size = new System.Drawing.Size(1041, 28);
            this.TB_Livro_Pesquisa.TabIndex = 8;
            // 
            // Panel_Livro_Top
            // 
            this.Panel_Livro_Top.Controls.Add(this.BTN_Livro_Inserir);
            this.Panel_Livro_Top.Controls.Add(this.BTN_Livro_Eliminar);
            this.Panel_Livro_Top.Controls.Add(this.TB_Livro_Pesquisa);
            this.Panel_Livro_Top.Controls.Add(this.TB_Livro_NLivrosDisp);
            this.Panel_Livro_Top.Controls.Add(this.TB_Livro_Titulo);
            this.Panel_Livro_Top.Controls.Add(this.LB_Titulo);
            this.Panel_Livro_Top.Controls.Add(this.TB_Livro_Autor);
            this.Panel_Livro_Top.Controls.Add(this.LB_Autor);
            this.Panel_Livro_Top.Controls.Add(this.TB_Livro_Edicao);
            this.Panel_Livro_Top.Controls.Add(this.LB_Edicao);
            this.Panel_Livro_Top.Controls.Add(this.LB_NLivrosDisp);
            this.Panel_Livro_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Livro_Top.Location = new System.Drawing.Point(0, 0);
            this.Panel_Livro_Top.Name = "Panel_Livro_Top";
            this.Panel_Livro_Top.Size = new System.Drawing.Size(1087, 228);
            this.Panel_Livro_Top.TabIndex = 9;
            // 
            // Panel_Livro_DGV
            // 
            this.Panel_Livro_DGV.Controls.Add(this.DGV_Livro);
            this.Panel_Livro_DGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Livro_DGV.Location = new System.Drawing.Point(0, 228);
            this.Panel_Livro_DGV.Name = "Panel_Livro_DGV";
            this.Panel_Livro_DGV.Size = new System.Drawing.Size(1087, 365);
            this.Panel_Livro_DGV.TabIndex = 10;
            // 
            // DGV_Livro
            // 
            this.DGV_Livro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Livro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_Livro.Location = new System.Drawing.Point(0, 0);
            this.DGV_Livro.Name = "DGV_Livro";
            this.DGV_Livro.RowTemplate.Height = 24;
            this.DGV_Livro.Size = new System.Drawing.Size(1087, 365);
            this.DGV_Livro.TabIndex = 0;
            // 
            // BTN_Livro_Eliminar
            // 
            this.BTN_Livro_Eliminar.Location = new System.Drawing.Point(984, 192);
            this.BTN_Livro_Eliminar.Name = "BTN_Livro_Eliminar";
            this.BTN_Livro_Eliminar.Size = new System.Drawing.Size(90, 30);
            this.BTN_Livro_Eliminar.TabIndex = 9;
            this.BTN_Livro_Eliminar.Text = "Eliminar";
            this.BTN_Livro_Eliminar.UseVisualStyleBackColor = true;
            // 
            // BTN_Livro_Inserir
            // 
            this.BTN_Livro_Inserir.Location = new System.Drawing.Point(888, 192);
            this.BTN_Livro_Inserir.Name = "BTN_Livro_Inserir";
            this.BTN_Livro_Inserir.Size = new System.Drawing.Size(90, 30);
            this.BTN_Livro_Inserir.TabIndex = 10;
            this.BTN_Livro_Inserir.Text = "Inserir";
            this.BTN_Livro_Inserir.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 593);
            this.Controls.Add(this.Panel_Editora);
            this.Controls.Add(this.Panel_Autor);
            this.Controls.Add(this.Panel_Livro);
            this.Controls.Add(this.Panel_Home);
            this.Controls.Add(this.Panel_Botoes);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Panel_Botoes.ResumeLayout(false);
            this.Panel_Home.ResumeLayout(false);
            this.Panel_Home_DGV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Home)).EndInit();
            this.Panel_Home_Cabecalho.ResumeLayout(false);
            this.Panel_Home_Cabecalho.PerformLayout();
            this.Panel_Livro.ResumeLayout(false);
            this.Panel_Autor.ResumeLayout(false);
            this.Panel_Editora.ResumeLayout(false);
            this.Panel_Livro_Top.ResumeLayout(false);
            this.Panel_Livro_Top.PerformLayout();
            this.Panel_Livro_DGV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Livro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Botoes;
        private System.Windows.Forms.Button BTN_AddEditora;
        private System.Windows.Forms.Button BTN_AddAutor;
        private System.Windows.Forms.Button BTN_AddLivro;
        private System.Windows.Forms.Button BTN_Home;
        private System.Windows.Forms.Panel Panel_Home;
        private System.Windows.Forms.Panel Panel_Livro;
        private System.Windows.Forms.Panel Panel_Autor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel Panel_Editora;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel Panel_Home_DGV;
        private System.Windows.Forms.DataGridView DGV_Home;
        private System.Windows.Forms.Panel Panel_Home_Cabecalho;
        private System.Windows.Forms.Button BTN_Devolucao;
        private System.Windows.Forms.Button BTN_Entrega;
        private System.Windows.Forms.TextBox TB_Estado;
        private System.Windows.Forms.TextBox TB_Requisitante;
        private System.Windows.Forms.TextBox TB_Livro;
        private System.Windows.Forms.Label LB_Estado;
        private System.Windows.Forms.Label LB_Requisitante;
        private System.Windows.Forms.Label LB_Livro;
        private System.Windows.Forms.Label LB_NLivrosDisp;
        private System.Windows.Forms.Label LB_Edicao;
        private System.Windows.Forms.Label LB_Autor;
        private System.Windows.Forms.Label LB_Titulo;
        private System.Windows.Forms.TextBox TB_Livro_NLivrosDisp;
        private System.Windows.Forms.TextBox TB_Livro_Pesquisa;
        private System.Windows.Forms.TextBox TB_Livro_Titulo;
        private System.Windows.Forms.TextBox TB_Livro_Autor;
        private System.Windows.Forms.TextBox TB_Livro_Edicao;
        private System.Windows.Forms.Panel Panel_Livro_DGV;
        private System.Windows.Forms.DataGridView DGV_Livro;
        private System.Windows.Forms.Panel Panel_Livro_Top;
        private System.Windows.Forms.Button BTN_Livro_Inserir;
        private System.Windows.Forms.Button BTN_Livro_Eliminar;
    }
}

