using System;
using System.Collections.Generic;
using System.Text;


namespace SO
{
    class Processo
    {
        private int id;
        private string descricao;
        private int prioridade;
        private int tempoExecucao;
        private int tempoProcessado;
        private int tempoEspera;
        private Processo proximo;

        public int Id { get { return id; } set { id = value; } }
        public string Descricao { get { return descricao; } set { descricao = value; } }
        public int Prioridade { get { return prioridade; } set { prioridade = value; } }
        public int Execucao { get { return tempoExecucao; } set { tempoExecucao = value; } }
        public int TempoProcessado { get { return tempoProcessado; } set { tempoProcessado = value; } }
        public int TempoEspera { get { return tempoEspera; } set { tempoEspera = value; } }
        public Processo Proximo { get { return proximo; } set { proximo = value; } }

        public Boolean StatusProcesso()
        {
            if (TempoProcessado < Execucao)
                return false;
            else
                return true;
        }
        public int TempoRestante()
        {
            int tempoRestante = tempoExecucao - tempoProcessado;
            return tempoRestante;
        }
        public override string ToString()
        {
            return string.Format("{0};{1};{2};{3};{4}", id.ToString(), descricao, prioridade.ToString(), tempoExecucao.ToString(), TempoProcessado);
        }
    }
    
}
