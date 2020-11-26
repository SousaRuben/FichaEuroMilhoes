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
            DateTime date = myChave.CreatedAt.Date;
            string data = $"{date.Day}/{date.Month}/{date.Year}";
            Debug.WriteLine(data);
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

    }
}
