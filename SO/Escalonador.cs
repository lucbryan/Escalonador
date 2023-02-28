using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.IO;

namespace SO
{
    class Escalonador
    {
        private int numeroProcessos = 0;
        private const int prioridadeMaxima = 31;
        private Boolean validate;

        private ListaEspera listaEspera = new ListaEspera();
        private ListaPronto listaPronto = new ListaPronto();
        private Processador processador = new Processador();
        private ListaProcessados listaProcessados = new ListaProcessados();
        private List<Processo> listaCompleta = new List<Processo>();

        public ListaEspera GetListaEspera { get { return listaEspera; } }
        public ListaPronto GetListaPronto { get { return listaPronto; } }
        public Processador GetProcessador { get { return processador; } }
        public ListaProcessados GetListaProcessados { get { return listaProcessados; } }
        public int NumeroProcessos { get { return numeroProcessos; } }
        public Boolean GetValidate { get { return validate; } }

        public void LerProcessos(string path)
        {
            Dados dados = new Dados();
            listaCompleta = dados.CarregarArquivo(path);
            if(listaCompleta != null) { validate = true; SegregaProcessos(listaCompleta); EscreveProcessos(); }
            else { validate = false; }
        }
        private void SegregaProcessos(List<Processo>ListaProcessos)
        {
            foreach (var processo in ListaProcessos)
            {
                if (processo.Prioridade >= prioridadeMaxima)
                 listaPronto.Adicionar(processo); 
                else
                 listaEspera.Adicionar(processo); 
               
                numeroProcessos++;
            }
        }
        public void SegregaProcessoII(Processo processo)
        {
            if (processo.Prioridade >= prioridadeMaxima)
                listaPronto.Adicionar(processo);
            else
                listaEspera.Adicionar(processo);
        }
        public void ExecutaProcesso()
        {
            lock (this)
            {
                if (numeroProcessos > listaProcessados.GetContador)
                {
                    if (processador.ProcessoAtual == null)
                    {
                        VerificaListaPronto();
                    }
                    else
                    {
                        VerificaProcessador();
                    }
                    AumentaPrioridade();
                    VerificaListaEspera();
                }
            }
        }
        private Processo EscolheProcesso()
        {
            return listaEspera.GetPrimeiro.Proximo;
        }
        private void AbaixaPrioridade(Processo processo)
        {
            Random random = new Random();
            processo.Prioridade -= random.Next(1, 4);
        }
        private void AumentaPrioridade()
        {
            listaEspera.Regra();
        }
        private void VerificaListaEspera()
        {

            string IdProntos = listaEspera.BuscarProntos();
            if (IdProntos != "")
                DespachaProcesso(IdProntos);
        }
        private void VerificaListaPronto()
        {
            Processo menorP = listaPronto.MenorTempo();
            if (listaPronto.GetContador > 0 && menorP != null)
            {
                processador.ProcessoAtual = menorP;
                listaPronto.RetirarQualquer(menorP.Id);
            }
        }
        private void VerificaProcessador()
        {
            Processo processoExecutado = processador.Executa();
            if (processoExecutado.StatusProcesso() == true)
            { listaProcessados.Adicionar(RecriaProcesso(processoExecutado)); }
            else
            {
                AbaixaPrioridade(processoExecutado);
                SegregaProcessoII(RecriaProcesso(processoExecutado));
            }
                processador.ProcessoAtual = null;
        }
        private void DespachaProcesso(string Idprocessos)
        {
            string[] prontos = Idprocessos.Split('*');
            foreach(var id in prontos)
            {
                if (id != "")
                {
                    listaPronto.Adicionar(RecriaProcesso(listaEspera.Buscar(Convert.ToInt32(id))));
                    listaEspera.RetirarQualquer(Convert.ToInt32(id));
                }
                else { }
            }
        }
        public Processo RecriaProcesso(Processo processo)
        {
            Processo processoRecriado = new Processo();
            processoRecriado.Descricao = processo.Descricao;
            processoRecriado.Execucao = processo.Execucao;
            processoRecriado.Id = processo.Id;
            processoRecriado.Prioridade = processo.Prioridade;
            processoRecriado.TempoProcessado = processo.TempoProcessado;
            return processoRecriado;
        }
        public void EscreveProcessos()
        {
            StreamWriter writer = new StreamWriter(@"C:\Users\GSE\Desktop\END(SO)\Dados\dadosEscrito.txt");
            foreach(var item in GetListaEspera.Listar())
            {
                writer.WriteLine(item.ToString());
            }
            foreach (var item in GetListaPronto.Listar())
            {
                writer.WriteLine(item.ToString());
            }
            foreach (var item in GetListaProcessados.Listar())
            {
                writer.WriteLine(item.ToString());
            }
            writer.Close();
        }
    }
}