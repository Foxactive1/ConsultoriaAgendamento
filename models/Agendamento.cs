
using System;

namespace ConsultoriaAgendamentos.Models
{
    public class Agendamento
    {
        public string NomeCliente { get; set; }
        public DateTime Data { get; set; }
        public string Descricao { get; set; }

        public void Exibir()
        {
            Console.WriteLine($"{Data:dd/MM/yyyy} - {NomeCliente}: {Descricao}");
        }
    }
}
