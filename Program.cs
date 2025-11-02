using System;
using System.Globalization;
using ConsultoriaAgendamentos.Models;

class Program
{
    static void Main()
    {
        string linhaConsultor = Console.ReadLine();
        string nomeConsultor = linhaConsultor.Replace("Consultor:", "").Trim();

        // Pula a linha "Agendamentos:"
        Console.ReadLine();

        var consultor = new Consultor { Nome = nomeConsultor };

        while (true)
        {
            string linha = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(linha))
                break;

            string[] partes = linha.Split(',');
            if (partes.Length != 3) continue;

            var agendamento = new Agendamento
            {
                NomeCliente = partes[0].Trim(),
                Data = DateTime.ParseExact(partes[1].Trim(), "dd/MM/yyyy", CultureInfo.InvariantCulture),
                Descricao = partes[2].Trim()
            };

            consultor.Agendamentos.Add(agendamento);
        }

        consultor.ExibirInformacoes();
    }
}
