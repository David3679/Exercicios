using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Exercicios
{
    internal class ListaDeTarefas_CRUD
    {
        /*
        class Tarefa
        {
            public string Titulo { get; set; }
            public bool Completou { get; set; }

            public Tarefa(string titulo)
            {
                Titulo = titulo;
                Completou = false;
            }
        }

        class ListaDeTarefas
        {
            private List<Tarefa> tarefas;

            public ListaDeTarefas()           
            {
                tarefas = new List<Tarefa>();
            }

            public void AdicionarTarefas(string titulo)
            {
                Tarefa novaTarefa = new Tarefa(titulo);  
                tarefas.Add(novaTarefa);
            }

            //=================================== EXEMPLO COM ARRAY ===========================================

            public void ExcluirTarefa(int indice)
            {
                if (indice >= 0 && indice < contadorTarefas)
                {
                    for (int i = indice; i < contadorTarefas - 1; i++)
                    {
                        tarefas[i] = tarefas[i + 1];
                    }
                    tarefas[contadorTarefas - 1] = null;
                    contadorTarefas--;
                }
                else
                {
                    Console.WriteLine("O índice não foi encontrado.");
                }
            }

            //=================================== EXEMPLO COM LIST ===========================================

            public void ExcluirTarefa(int indice)
            {
                if(indice >= 0 && indice <= tarefas.Count)
                {
                    tarefas.RemoveAt(indice);
                }
                else
                {
                    Console.WriteLine("O indice não foi encontrado.");
                }
            }

            public void EditarTarefas(int indice, string novoTitulo)
            {
                if(indice >= 0 && indice <= tarefas.Count)
                {
                    tarefas[indice].Titulo = novoTitulo;
                }
                else
                {
                    Console.WriteLine("O indice não foi encontrado.");
                }
            }

            public void MarcarCompletou(int indice)
            {
                if(indice >= 0 && indice <= tarefas.Count)
                {
                    tarefas[indice].Completou = true;
                }
                else
                {
                    Console.WriteLine("O indice não foi encontrado.");
                }
            }

            public void DesmarcarCompletou(int indice)
            {
                if(indice >= 0 && indice < tarefas.Count)
                {
                    tarefas[indice].Completou = false;
                }
                else
                {
                    Console.WriteLine("O indice não foi encontrado.");
                }
            }

            public void ListarTodasTarefas()
            {
                Console.WriteLine("Lista de Tarefas");
                for(int i = 0; i < tarefas.Count; i++)
                {
                    string status = tarefas[i].Completou ? "Completa" : "Incompleta";
                    Console.WriteLine($"A tarefa {tarefas[i].Titulo} está {status}");
                }
            }

            public void OrdenarTarefas()
            {
                tarefas.OrderBy(t => t.Titulo).ToList();
            }

            public void FiltrarPorStatus(bool completas)
            {
                List<Tarefa> tarefasFiltradas = tarefas.Where(t => t.Completou == completas).ToList();
                tarefas = tarefasFiltradas;
            }

            static void Main(string[] args)
            {
                ListaDeTarefas tarefas1 = new ListaDeTarefas();

                tarefas1.AdicionarTarefas("Estudar mais C#");
                tarefas1.AdicionarTarefas("Começar a fazer exercicíos");
                tarefas1.ListarTodasTarefas();

                tarefas1.EditarTarefas(0, "Estudar muito mais C#");
                tarefas1.DesmarcarCompletou(1);
                tarefas1.MarcarCompletou(0);
                tarefas1.ListarTodasTarefas();

                tarefas1.ExcluirTarefa(0);
                tarefas1.ListarTodasTarefas();           
            }
        }*/
    }
}
