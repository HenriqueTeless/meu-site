using System;

namespace calendarioacademico
{
    class Program
    {
     static void Main(string[] args)
     {

         Console.WriteLine("Calendário Académico\n")

         //definindo as datas importantes
         DateTime inicioSemestre = new DateTime(2024, 9, 1);
         DateTime fimSemestre = new DateTime(2024, 12, 15);
         DateTime inicioFerias = new DateTime(2024, 12, 16);
         DateTime voltaAulas = new DateTime(2024, 1, 20);

         //exibindo as datas importantes 
         Console.WriteLine("Datas Importantes:\n");
         Console.WriteLine("inicio do Semestre: " + inicioSemestre.ToShortDateString()); 
         Console.WriteLine("inicio do Semestre: " + fimSemestre.ToShortDateString());         
         Console.WriteLine("inicio do Semestre: " + inicioFerias.ToShortDateString());
         Console.WriteLine("inicio do Semestre: " + voltaAulas.ToShortDateString());     
    
        // Calculandoa duração do semestre em dias
        TimeSpan duracaoSemestre = fimSemestre - inicioSemestre;
        int diasSemestre = duracaoSemestre.Days;
        Console.WriteLine("\nDuração do semestre: " + diasSemestre + "dias");

        // Caluculo dias retantes  para o fim do semestre
        DateTime hoje = DateTime.Today;
        TimeSpan diasRestantes = fimSemestre - hoje;
        Console.WriteLine("Dias restantes até o fim do Semestre: " + diasRestantes.Days + "dias")
        Console.ReadLine();
     }
    }
}