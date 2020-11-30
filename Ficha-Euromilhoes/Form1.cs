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
        ChaveRepository repository = new ChaveRepository(path);
        public Form1()
        {
            
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            display(repository.chaves);
            initComboBox();
        }

        private void initComboBox()
        {
            cmbChaves.Items.Clear();
            foreach(var chave in repository.chaves)
            {
                if (cmbChaves.Items.Contains(chave.Data))
                {
                    continue;
                }
                cmbChaves.Items.Add(chave.Data);
            }
        }

        private void display(List<Chave> source)
        {
            dgvChaves.Rows.Clear();
            foreach (var chave in source)
            {
                dgvChaves.Rows.Add(chave.PrincipalString(), chave.EstrelaString());
            }
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            int nChave = 0;
            int.TryParse(this.txtNChaves.Text, out nChave);

            for (int i = 0; i < nChave; i++)
            {
                Chave myChave = repository.addChave();
                dgvChaves.Rows.Add(myChave.PrincipalString(), myChave.EstrelaString());
            }

            txtNChaves.ResetText();
            repository.save();
            initComboBox();
        }

        private void cmbChaves_SelectedIndexChanged(object sender, EventArgs e)
        {
            string data = cmbChaves.Text;
            List<Chave> chaves = repository.search(data);
            display(chaves);
            btnShowAll.Text = "Exibir todos";
        }

        // Recarrega o documento e em seguida exibe todas as chaves
        private void btnShowAll_Click(object sender, EventArgs e)
        {
            cmbChaves.Text = "";
            btnShowAll.Text = "Atualizar";
            repository.load();
            initComboBox();
            display(repository.chaves);
        }
    }
}
