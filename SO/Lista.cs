using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace SO
{
    abstract class Lista
    {
        protected int contador;
        protected Processo primeiro;
        protected Processo ultimo;
        protected Processo aux;

        public int GetContador { get { return contador; } }
        public Processo GetPrimeiro { get { return primeiro; } }
        public Processo GetUltimo { get { return ultimo; } }
        public Processo Aux { get { return aux; } set { aux = value; } }
        public Lista()
        {
            contador = 0;
            primeiro = new Processo();
            ultimo = primeiro;
        }
        public void Adicionar(Processo NovoProcesso)
        {
            ultimo.Proximo = NovoProcesso;
            ultimo = NovoProcesso;
            contador++;
        }
        public Processo Retirar()
        {
            Processo processo = primeiro.Proximo;
            if (Vazia() == false)
            {
                primeiro.Proximo = processo.Proximo;
                return processo;
            }
            processo.Proximo = null;
            contador--;
            return null;
        }
        public Processo RetirarQualquer(int id)
        {
            Processo anterior;
            anterior = primeiro;

            aux = primeiro.Proximo;

            while (aux != null)
            {
                if (aux.Id == id)
                {
                    anterior.Proximo = aux.Proximo;

                    if (aux == ultimo)
                    {
                        ultimo = anterior;
                    }
                    contador--;
                    return aux;
                }
                else
                {
                    anterior = aux;
                    aux = aux.Proximo;
                }
            }
            return aux;
        }
        public bool Vazia()
        {
            if (primeiro == ultimo)
                return true;
            else
                return false;
        }
        public Processo Buscar(int id)
        {
            aux = primeiro.Proximo;
            while (aux != null)
            {
                if (aux.Id == id)
                    return aux;
                else
                    aux = aux.Proximo;
            }
            return null;
        }
        public Processo MenorTempo()
        {
            Processo menor = new Processo();
            menor.Execucao = int.MaxValue;

            Aux = GetPrimeiro.Proximo;
            while (Aux != null)
            {
                if (Aux.Execucao < menor.Execucao)
                {
                    menor = Aux;
                }
                else
                    Aux = Aux.Proximo;
            }
            return menor;
        }
        public string Imprimir()
        {
            string processos = "";
            if (primeiro.Proximo == null)
                return processos;
            else
            {
                 
                aux = primeiro.Proximo;
                while (aux != null)
                {
                    processos += aux.ToString() + "\n"; aux = aux.Proximo;
                }
                return processos;
            }
        }
        public List<Processo> Listar()
        {
            List <Processo> listaProcessos = new List<Processo>();
            if (primeiro.Proximo == null)
                return listaProcessos;
            else
            {

                aux = primeiro.Proximo;
                while (aux != null)
                {
                    listaProcessos.Add(aux) ; aux = aux.Proximo;
                }
                return listaProcessos;
            }
        }


    }
}
