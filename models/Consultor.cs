using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsultoriaAgendamentos.Models
{
    public class Consultor
    {
        public string Nome { get; set; }
        public List<Agendamento> Agendamentos { get; set; } = new List<Agendamento>();

        public void ExibirInformacoes()
        {
            Console.WriteLine($"{Nome}:");

            if (Agendamentos.Count == 0)
            {
                Console.WriteLine("Nenhum agendamento cadastrado");
            }
            else
            {
                foreach (var ag in Agendamentos.OrderBy(a => a.Data))
                {
                    ag.Exibir();
                }
            }
        }
    }
}

