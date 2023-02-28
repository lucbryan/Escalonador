using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace SO
{
    class Dados
    {
        public List<Processo> CarregarArquivo(string path)
        {
            try
            {
                List<Processo> ListaProcesso = new List<Processo>();
                string[] dados = new string[0];
                StreamReader leitor = new StreamReader(path);
                while (!leitor.EndOfStream)
                {
                    dados = leitor.ReadLine().Split(';');
                    Processo processo = new Processo();
                    processo.Id = Convert.ToInt32(dados[0]);
                    processo.Descricao = dados[1];
                    processo.Prioridade = Convert.ToInt32(dados[2]);
                    processo.Execucao = Convert.ToInt32(dados[3]);
                    ListaProcesso.Add(processo);
                }
                leitor.Close();
                return ListaProcesso;
            }
            catch
            {
                return null;
            }
        }
    }
}
