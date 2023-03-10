using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula10
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void listBoxNumeros_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonMostrar1_Click(object sender, EventArgs e)
        {
            listBoxNumeros.Items.Clear();

            for (int i = 1; i <= numericUpDownValor.Value; i++)
            {
                listBoxNumeros.Items.Add(i);
            }
        }

        private void buttonMostrar2_Click(object sender, EventArgs e)
        {
            listBoxNumeros.Items.Clear();

            int aux = 1;

            while (aux <= numericUpDownValor.Value)
            {
                listBoxNumeros.Items.Add(aux);
                aux++;
            }

        }

        private void buttonMostrarTab1_Click(object sender, EventArgs e)
        {
            listBoxTab1.Items.Clear();
            for (int i = 1; i <= 10; i++)
            {
                listBoxTab1.Items.Add(numericUpDownTab1.Value+"X"+i+"="+numericUpDownTab1.Value * i);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBoxTab2.Items.Clear();
            int aux2 = 1;

            while (aux2 <= 10)
            {
                listBoxTab2.Items.Add(numericUpDownTab2.Value + "X" + aux2 + "=" + numericUpDownTab2.Value * aux2);
                aux2++;
            }
        }
    }
}
