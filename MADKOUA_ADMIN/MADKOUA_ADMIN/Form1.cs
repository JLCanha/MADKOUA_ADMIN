using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MADKOUA_ADMIN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Panel_Home.Visible = true;
            Panel_Autor.Visible = false;
            Panel_Editora.Visible = false;
            Panel_Livro.Visible = false;
            
        }

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

        private void Panel_Livro_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
