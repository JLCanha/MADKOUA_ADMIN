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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BTN_AddEditora = new System.Windows.Forms.Button();
            this.BTN_AddAutor = new System.Windows.Forms.Button();
            this.BTN_AddLivro = new System.Windows.Forms.Button();
            this.BTN_Pesquisa = new System.Windows.Forms.Button();
            this.BTN_Home = new System.Windows.Forms.Button();
            this.Panel_Home = new System.Windows.Forms.Panel();
            this.Panel_Pesquisa = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.Panel_Livro = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.Panel_Autor = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.Panel_Editora = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.LB_Livro = new System.Windows.Forms.Label();
            this.LB_Requisitante = new System.Windows.Forms.Label();
            this.LB_Estado = new System.Windows.Forms.Label();
            this.TB_Livro = new System.Windows.Forms.TextBox();
            this.TB_Requisitante = new System.Windows.Forms.TextBox();
            this.TB_Estado = new System.Windows.Forms.TextBox();
            this.BTN_Entrega = new System.Windows.Forms.Button();
            this.BTN_Devolucao = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.Panel_Home.SuspendLayout();
            this.Panel_Pesquisa.SuspendLayout();
            this.Panel_Livro.SuspendLayout();
            this.Panel_Autor.SuspendLayout();
            this.Panel_Editora.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BTN_AddEditora);
            this.panel1.Controls.Add(this.BTN_AddAutor);
            this.panel1.Controls.Add(this.BTN_AddLivro);
            this.panel1.Controls.Add(this.BTN_Pesquisa);
            this.panel1.Controls.Add(this.BTN_Home);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(53, 482);
            this.panel1.TabIndex = 0;
            // 
            // BTN_AddEditora
            // 
            this.BTN_AddEditora.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTN_AddEditora.Location = new System.Drawing.Point(0, 212);
            this.BTN_AddEditora.Name = "BTN_AddEditora";
            this.BTN_AddEditora.Size = new System.Drawing.Size(53, 53);
            this.BTN_AddEditora.TabIndex = 4;
            this.BTN_AddEditora.Text = "Editora";
            this.BTN_AddEditora.UseVisualStyleBackColor = true;
            this.BTN_AddEditora.Click += new System.EventHandler(this.BTN_AddEditora_Click);
            // 
            // BTN_AddAutor
            // 
            this.BTN_AddAutor.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTN_AddAutor.Location = new System.Drawing.Point(0, 159);
            this.BTN_AddAutor.Name = "BTN_AddAutor";
            this.BTN_AddAutor.Size = new System.Drawing.Size(53, 53);
            this.BTN_AddAutor.TabIndex = 3;
            this.BTN_AddAutor.Text = "Autor";
            this.BTN_AddAutor.UseVisualStyleBackColor = true;
            this.BTN_AddAutor.Click += new System.EventHandler(this.BTN_AddAutor_Click);
            // 
            // BTN_AddLivro
            // 
            this.BTN_AddLivro.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTN_AddLivro.Location = new System.Drawing.Point(0, 106);
            this.BTN_AddLivro.Name = "BTN_AddLivro";
            this.BTN_AddLivro.Size = new System.Drawing.Size(53, 53);
            this.BTN_AddLivro.TabIndex = 2;
            this.BTN_AddLivro.Text = "Livro";
            this.BTN_AddLivro.UseVisualStyleBackColor = true;
            this.BTN_AddLivro.Click += new System.EventHandler(this.BTN_AddLivro_Click);
            // 
            // BTN_Pesquisa
            // 
            this.BTN_Pesquisa.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTN_Pesquisa.Location = new System.Drawing.Point(0, 53);
            this.BTN_Pesquisa.Name = "BTN_Pesquisa";
            this.BTN_Pesquisa.Size = new System.Drawing.Size(53, 53);
            this.BTN_Pesquisa.TabIndex = 1;
            this.BTN_Pesquisa.Text = "Pesquisa";
            this.BTN_Pesquisa.UseVisualStyleBackColor = true;
            this.BTN_Pesquisa.Click += new System.EventHandler(this.BTN_Pesquisa_Click);
            // 
            // BTN_Home
            // 
            this.BTN_Home.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTN_Home.Location = new System.Drawing.Point(0, 0);
            this.BTN_Home.Name = "BTN_Home";
            this.BTN_Home.Size = new System.Drawing.Size(53, 53);
            this.BTN_Home.TabIndex = 0;
            this.BTN_Home.Text = "Home";
            this.BTN_Home.UseVisualStyleBackColor = true;
            this.BTN_Home.Click += new System.EventHandler(this.BTN_Home_Click);
            // 
            // Panel_Home
            // 
            this.Panel_Home.Controls.Add(this.panel3);
            this.Panel_Home.Controls.Add(this.panel2);
            this.Panel_Home.Location = new System.Drawing.Point(53, 0);
            this.Panel_Home.Name = "Panel_Home";
            this.Panel_Home.Size = new System.Drawing.Size(815, 482);
            this.Panel_Home.TabIndex = 1;
            // 
            // Panel_Pesquisa
            // 
            this.Panel_Pesquisa.Controls.Add(this.button3);
            this.Panel_Pesquisa.Location = new System.Drawing.Point(1000, 6);
            this.Panel_Pesquisa.Name = "Panel_Pesquisa";
            this.Panel_Pesquisa.Size = new System.Drawing.Size(815, 482);
            this.Panel_Pesquisa.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(82, 47);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 0;
            this.button3.Text = "pesquisa";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Panel_Livro
            // 
            this.Panel_Livro.Controls.Add(this.button4);
            this.Panel_Livro.Location = new System.Drawing.Point(1000, 6);
            this.Panel_Livro.Name = "Panel_Livro";
            this.Panel_Livro.Size = new System.Drawing.Size(815, 482);
            this.Panel_Livro.TabIndex = 3;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(60, 46);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 0;
            this.button4.Text = "livro";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Panel_Autor
            // 
            this.Panel_Autor.Controls.Add(this.button1);
            this.Panel_Autor.Location = new System.Drawing.Point(1000, 122);
            this.Panel_Autor.Name = "Panel_Autor";
            this.Panel_Autor.Size = new System.Drawing.Size(815, 482);
            this.Panel_Autor.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(107, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "autor";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Panel_Editora
            // 
            this.Panel_Editora.Controls.Add(this.button5);
            this.Panel_Editora.Location = new System.Drawing.Point(1000, 303);
            this.Panel_Editora.Name = "Panel_Editora";
            this.Panel_Editora.Size = new System.Drawing.Size(815, 482);
            this.Panel_Editora.TabIndex = 5;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(89, 76);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 0;
            this.button5.Text = "editora";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BTN_Devolucao);
            this.panel2.Controls.Add(this.BTN_Entrega);
            this.panel2.Controls.Add(this.TB_Estado);
            this.panel2.Controls.Add(this.TB_Requisitante);
            this.panel2.Controls.Add(this.TB_Livro);
            this.panel2.Controls.Add(this.LB_Estado);
            this.panel2.Controls.Add(this.LB_Requisitante);
            this.panel2.Controls.Add(this.LB_Livro);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(815, 106);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 106);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(815, 376);
            this.panel3.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(815, 376);
            this.dataGridView1.TabIndex = 0;
            // 
            // LB_Livro
            // 
            this.LB_Livro.AutoSize = true;
            this.LB_Livro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Livro.Location = new System.Drawing.Point(6, 40);
            this.LB_Livro.Name = "LB_Livro";
            this.LB_Livro.Size = new System.Drawing.Size(44, 18);
            this.LB_Livro.TabIndex = 0;
            this.LB_Livro.Text = "Livro:";
            // 
            // LB_Requisitante
            // 
            this.LB_Requisitante.AutoSize = true;
            this.LB_Requisitante.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Requisitante.Location = new System.Drawing.Point(6, 10);
            this.LB_Requisitante.Name = "LB_Requisitante";
            this.LB_Requisitante.Size = new System.Drawing.Size(93, 18);
            this.LB_Requisitante.TabIndex = 1;
            this.LB_Requisitante.Text = "Requisitante:";
            // 
            // LB_Estado
            // 
            this.LB_Estado.AutoSize = true;
            this.LB_Estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Estado.Location = new System.Drawing.Point(544, 10);
            this.LB_Estado.Name = "LB_Estado";
            this.LB_Estado.Size = new System.Drawing.Size(59, 18);
            this.LB_Estado.TabIndex = 2;
            this.LB_Estado.Text = "Estado:";
            // 
            // TB_Livro
            // 
            this.TB_Livro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Livro.Location = new System.Drawing.Point(96, 37);
            this.TB_Livro.Name = "TB_Livro";
            this.TB_Livro.Size = new System.Drawing.Size(441, 24);
            this.TB_Livro.TabIndex = 3;
            // 
            // TB_Requisitante
            // 
            this.TB_Requisitante.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Requisitante.Location = new System.Drawing.Point(609, 7);
            this.TB_Requisitante.Name = "TB_Requisitante";
            this.TB_Requisitante.Size = new System.Drawing.Size(194, 24);
            this.TB_Requisitante.TabIndex = 4;
            // 
            // TB_Estado
            // 
            this.TB_Estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Estado.Location = new System.Drawing.Point(96, 7);
            this.TB_Estado.Name = "TB_Estado";
            this.TB_Estado.Size = new System.Drawing.Size(441, 24);
            this.TB_Estado.TabIndex = 5;
            // 
            // BTN_Entrega
            // 
            this.BTN_Entrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Entrega.Location = new System.Drawing.Point(709, 67);
            this.BTN_Entrega.Name = "BTN_Entrega";
            this.BTN_Entrega.Size = new System.Drawing.Size(94, 31);
            this.BTN_Entrega.TabIndex = 6;
            this.BTN_Entrega.Text = "Entrega";
            this.BTN_Entrega.UseVisualStyleBackColor = true;
            // 
            // BTN_Devolucao
            // 
            this.BTN_Devolucao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Devolucao.Location = new System.Drawing.Point(609, 67);
            this.BTN_Devolucao.Name = "BTN_Devolucao";
            this.BTN_Devolucao.Size = new System.Drawing.Size(94, 31);
            this.BTN_Devolucao.TabIndex = 7;
            this.BTN_Devolucao.Text = "Devolução";
            this.BTN_Devolucao.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 482);
            this.Controls.Add(this.Panel_Editora);
            this.Controls.Add(this.Panel_Autor);
            this.Controls.Add(this.Panel_Livro);
            this.Controls.Add(this.Panel_Pesquisa);
            this.Controls.Add(this.Panel_Home);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.Panel_Home.ResumeLayout(false);
            this.Panel_Pesquisa.ResumeLayout(false);
            this.Panel_Livro.ResumeLayout(false);
            this.Panel_Autor.ResumeLayout(false);
            this.Panel_Editora.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BTN_AddEditora;
        private System.Windows.Forms.Button BTN_AddAutor;
        private System.Windows.Forms.Button BTN_AddLivro;
        private System.Windows.Forms.Button BTN_Pesquisa;
        private System.Windows.Forms.Button BTN_Home;
        private System.Windows.Forms.Panel Panel_Home;
        private System.Windows.Forms.Panel Panel_Pesquisa;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel Panel_Livro;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel Panel_Autor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel Panel_Editora;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BTN_Devolucao;
        private System.Windows.Forms.Button BTN_Entrega;
        private System.Windows.Forms.TextBox TB_Estado;
        private System.Windows.Forms.TextBox TB_Requisitante;
        private System.Windows.Forms.TextBox TB_Livro;
        private System.Windows.Forms.Label LB_Estado;
        private System.Windows.Forms.Label LB_Requisitante;
        private System.Windows.Forms.Label LB_Livro;
    }
}

