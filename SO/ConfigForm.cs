using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SO
{
    public partial class ConfigForm : Form
    {
        public ConfigForm()
        {
            InitializeComponent();
            Lista();
        }

        private Processo processo;
        public bool validate = false;
        public bool confirm = false;
        private int prioridadeAntiga;
        private int novaPrior;

        private void ConfirmarButton_Click(object sender, EventArgs e)
        {
            confirm = true;
            this.Close();
        }
        public Boolean RetornaValidacao()
        { return validate; }
        public int Return()
        {
            string n = ThreadExec.Text;
            if (n == "")
            { return 1000; }
            else
            { return Convert.ToInt32(ThreadExec.Text); }
        }
        public int ReturII()
        {
            string n = QuantConfig.Text;
            if (n == "")
            { return 5; }
            else
            { return Convert.ToInt32(QuantConfig.Text); }
        }
        public int ReturnId()
        {
            return processo.Id;
        }
        public int NovaPrioridade()
        {
            return novaPrior;
        }
        public int PrioridadeAtual()
        {
            return prioridadeAntiga;
        }
        private List<Processo> Lista()
        {
            List<Processo> ListaP = new List<Processo>();
            StreamReader reader = new StreamReader(@"C:\Users\GSE\Desktop\END(SO)\Dados\dadosEscrito.txt");
            while (!reader.EndOfStream)
            {
                string[] dados = reader.ReadLine().Split(';');
                Processo processo = new Processo();
                processo.Id = Convert.ToInt32(dados[0]);
                processo.Descricao = dados[1];
                processo.Prioridade = Convert.ToInt32(dados[2]);
                processo.Execucao = Convert.ToInt32(dados[3]);
                ListaP.Add(processo);
            }
            reader.Close();
            return ListaP;
        }
        private void bttonBusca_Click(object sender, EventArgs e)
        {
            processo = Busca();
            if(processo != null)
            {
                Preenche();
                errorProvider1.Clear();
            }
            else
            {
                listView1.Items.Clear();
                MessageBox.Show("Processo não encontrado.");
            }
        }
        private Processo Busca()
        {
            string key = IdTB.Text;
            foreach (var item in Lista())
            {
                if (item.Id.ToString() == key)
                { return item; }
            }
            return null;

        }
        private void Preenche()
        {
            listView1.Items.Clear();
            ListViewItem item = new ListViewItem();
            item.Text = processo.Id.ToString();
            item.SubItems.Add(processo.Descricao);
            item.SubItems.Add(processo.Prioridade.ToString());
            item.SubItems.Add(processo.Execucao.ToString());
            listView1.Items.Add(item);
        }
        private void BttonAltera_Click(object sender, EventArgs e)
        {
            if (processo == null)
            { errorProvider1.SetError(IdTB, "Insira uma id válida."); }
            else
            {
                try
                {
                    prioridadeAntiga = processo.Prioridade;
                    novaPrior = Convert.ToInt32(PriorTX.Text);
                    if (novaPrior >= 0 && novaPrior <= 31)
                    {
                        processo.Prioridade = novaPrior;
                        validate = true;
                        Preenche();
                    }
                    else
                    {
                        { MessageBox.Show("Insira um valor de 0 a 31."); validate = false; }
                    }
                }
                catch
                {
                    MessageBox.Show("Formato inválido."); validate = false;
                }
            }
        }
    }
}
