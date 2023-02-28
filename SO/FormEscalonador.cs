using System;
using System.Threading;
using System.Windows.Forms;

namespace SO
{
    public partial class FormEscalonador : Form
    {
        Escalonador escalonador = new Escalonador();
        Thread threadI, threadII;
        private int executor = 1300;
        private Boolean stopped = false;

        public FormEscalonador()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            ExecutaThreadTS.Enabled = false;
            PausarTS.Enabled = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            string file = "";
            if (openFile.ShowDialog().Equals(DialogResult.OK))
            {
                file = openFile.FileName;
                escalonador.LerProcessos(file);
                if (escalonador.GetValidate == true)
                {
                    ExecutaThreadTS.Enabled = true;
                    Preenche();
                    button1.Visible = false;
                }
                else
                {
                    MessageBox.Show("Erro ao carregar este arquivo.");
                    button1.Visible = true;
                }
            }
            else
            { MessageBox.Show("Erro ao carregar este arquivo."); }
        }
        private void Preenche()
        {
            ListaEsperaTXB.Invoke(new Action(() => ListaEsperaTXB.Text = escalonador.GetListaEspera.Imprimir()));
            ListaProntoTXB.Invoke(new Action(() => ListaProntoTXB.Text = escalonador.GetListaPronto.Imprimir()));
            ListaFinalizadosTXB.Invoke(new Action(() => ListaFinalizadosTXB.Text = escalonador.GetListaProcessados.Imprimir()));
            ProcessadorTXB.Invoke(new Action(() => ProcessadorTXB.Text = escalonador.GetProcessador.MostrarProcesso()));
        }
        private void ThreadI()
        {
            do
            {
                Monitor.Enter(threadI);
                try
                {
                    escalonador.ExecutaProcesso();
                    Preenche();
                    Thread.Sleep(executor);
                }
                catch (ArgumentException)
                {
                    threadI.Abort();
                    threadII.Abort();
                    MessageBox.Show("Processos finalizados.");

                }
                finally
                {
                    Monitor.Exit(threadI);
                }
            } while (!Exit());
            MessageBox.Show("Processos finalizados.");
            ListaFinalizadosTXB.Clear();
            PausarTS.Enabled = false;
            button1.Visible = true;
            Reiniciar();
        }
        private void ThreadII()
        {
            while (!Exit())
            {
                Preenche();
                Thread.Sleep(800);
            }
        }
        private void ExecutaThreadTS_Click(object sender, EventArgs e)
        {
            if (stopped == false)
            {
                threadI = new Thread(ThreadI);
                threadII = new Thread(ThreadII);

                threadI.Start();
                //threadII.Start();
            }
            else
            {
                threadI.Resume();
                stopped = false;
            }
            ExecutaThreadTS.Enabled = false;
            PausarTS.Enabled = true;
        }
        private void PausarTS_Click(object sender, EventArgs e)
        {
            stopped = true;
            PausarTS.Enabled = false;
            ExecutaThreadTS.Enabled = true;
            threadI.Suspend();
        }
        private void FinalizarTS_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ConfiguracaoTS_Click(object sender, EventArgs e)
        {
            escalonador.EscreveProcessos();
            Configuracoes();
        }
        private void Configuracoes()
        {
            ConfigForm configForm = new ConfigForm();
            configForm.ShowDialog();

            if (configForm.confirm == true)
            {
                executor = configForm.Return();
                escalonador.GetProcessador.Quantum = configForm.ReturII();

                if (configForm.validate == true)
                {
                    Processo processo;
                    int id = configForm.ReturnId();
                    int nova = configForm.NovaPrioridade();

                    processo = escalonador.GetListaEspera.Buscar(id);
                    if (processo != null)
                    {
                        escalonador.GetListaEspera.RetirarQualquer(id);
                        Modifica(processo, nova);
                    }
                    processo = escalonador.GetListaPronto.Buscar(id);
                    if (processo != null)
                    {
                        escalonador.GetListaPronto.RetirarQualquer(id);
                        Modifica(processo, nova);
                    }
                    processo = escalonador.GetListaProcessados.Buscar(id);
                    if (processo != null)
                    {
                        escalonador.GetListaProcessados.RetirarQualquer(id);
                        Modifica(processo, nova);

                    }
                }

            }
        }
        private void Modifica(Processo processo, int nova)
        {
            if(processo != null)
            {
                processo.Prioridade = nova;
                escalonador.SegregaProcessoII(escalonador.RecriaProcesso(processo));
                Preenche();
            }
        }
        private Boolean Exit()
        {
            if (escalonador.NumeroProcessos > escalonador.GetListaProcessados.GetContador)
                return false;
            else
                return true;
        }
        private void Reiniciar()
        {
            escalonador = null;
            escalonador = new Escalonador();
        }
    }
}
