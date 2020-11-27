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


namespace Ficha_Euromilhoes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Chave myChave = new Chave();
            Debug.WriteLine(myChave.Data);

            foreach (var num in myChave.Principais)
            {
                Debug.WriteLine(num);
            }
            Debug.WriteLine("-------------------------");
            foreach (var num in myChave.Estrelas)
            {
                Debug.WriteLine(num);
            }

        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            Chave myChave = new Chave();

            dgvChaves.Rows.Add(myChave.getPrincipais(), myChave.getEstrelas());
            
        }
    }
}
