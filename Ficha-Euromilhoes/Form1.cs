using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Ficha_Euromilhoes.Models;
using Ficha_Euromilhoes.Repositories;

namespace Ficha_Euromilhoes
{
    public partial class Form1 : Form
    {
        public const string path = "../../data/file.json";
        public Form1()
        {
            InitializeComponent();
            ChaveRepository repository = new ChaveRepository(path);
            repository.save();

        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            Chave myChave = new Chave();

            dgvChaves.Rows.Add(myChave.Principais, myChave.Estrelas);
            
        }
    }
}
