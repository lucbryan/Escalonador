using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SO
{
    class Processador
    {
        private int quantum = 5;
        private Processo processoAtual;
        public Processo ProcessoAtual { get { return processoAtual; } set { processoAtual = value; } }
        public int Quantum { get { return quantum; } set { quantum = value; } }
        public string MostrarProcesso()
        {
            if (Status() == true)
                return ProcessoAtual.ToString() + ". Tempo restante: " + TempoR();
            else
                return "";
        }
        public Processo Executa()
        {
            if (processoAtual.TempoRestante() >= quantum)
            { processoAtual.TempoProcessado += quantum; }
            else
            { 
                processoAtual.TempoProcessado += processoAtual.TempoRestante();
                processoAtual.Prioridade = 32;
            }
            processoAtual.TempoEspera = 0;
            return processoAtual;
        }
        public bool Status()
        {
            if (ProcessoAtual != null)
                return true;
            return false;
        }
        private int TempoR()
        {
            if (processoAtual.TempoRestante()  > quantum) { return (processoAtual.TempoRestante() - quantum); }
            else return 0;

        }
    }
}
