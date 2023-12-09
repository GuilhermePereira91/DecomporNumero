using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Decompor.Library;

namespace DecomporNumero
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }        

        private void DecomporNumeroButton_Click(object sender, EventArgs e)
        {
            try
            {
                int numero = 0;

                numero = (int)NumeroNumericUpDown.Value;

                if (!string.IsNullOrEmpty(SaidaTextBox.Text))
                    SaidaTextBox.Text = string.Empty;

                if (!ValidarNumero(numero))
                {
                    MessageBox.Show("Falha ao decompor o número em todos seus divisores. Detalhes: Número inválido");
                    return;
                }

                SaidaTextBox.Text = ObterDivisoresFormatado(numero);
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Falha ao decompor o número em todos seus divisores. Detalhes: {0}", ex.Message));
                return;
            }
        }

        private string ObterDivisoresFormatado(int numero)
        {
            StringBuilder stringBuilder = new StringBuilder();
            Divisores divisores = new Divisores(numero);

            if(divisores != null)
            {
                string naturais = string.Join(", ", divisores.DivisoresNaturais.ToArray());
                string primos = string.Join(", ", divisores.DivisoresPrimos.ToArray());

                stringBuilder.Append(string.Format("Divisores: {0}", naturais));
                stringBuilder.Append(Environment.NewLine);
                stringBuilder.Append(string.Format("Divisores Primos: {0}", primos));
            }

            return stringBuilder.ToString();
        }

        private bool ValidarNumero(int numero)
        {
            return numero > 0;
        }
    }
}
