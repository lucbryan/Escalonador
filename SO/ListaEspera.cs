using System;
using System.Collections.Generic;
using System.Text;

namespace SO
{
    class ListaEspera : Lista
    {
        public ListaEspera() : base() { }
        public string BuscarProntos()
        {
            string IdProntos = "";
            Aux =  GetPrimeiro.Proximo;
            while (Aux != null)
            {
                if (Aux.Prioridade >= 31)
                {
                    Aux.Prioridade = 31;
                    IdProntos += Aux.Id + "*";
                }
                else
                {
                    Aux.TempoEspera++;
                }
                Aux = Aux.Proximo;

            }
            return IdProntos;
        }
        public Processo Sortear()
        {
            // sorteia uma Id de processo.
            Random random = new Random();
            return Buscar(random.Next(1, GetUltimo.Id));
        }
        public void Regra()
        {
            // Aumenta a prioridade de processos que esperaram 3x sem ser atendido.

            Aux = GetPrimeiro.Proximo;
            while(Aux != null)
            {
                if (Aux.TempoEspera == 3)
                {
                    Random random = new Random();
                    Aux.Prioridade += random.Next(0,3);
                }
                else if (Aux.TempoEspera > 3)
                {
                    Aux.TempoEspera = 0;
                }
                Aux = Aux.Proximo;
            }
        }

    }
}
