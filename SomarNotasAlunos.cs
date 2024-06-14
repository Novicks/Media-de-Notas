using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftLearn_SomaNotas
{
    internal class SomarNotasAlunos
    {
        public static void Main(string[] args) {
            // Inicialização de variaveis
            int qtdTarefas = 5;

            int sophia1 = 93;
            int sophia2 = 87;
            int sophia3 = 98;
            int sophia4 = 95;
            int sophia5 = 100;

            int nicolas1 = 80;
            int nicolas2 = 83;
            int nicolas3 = 98;
            int nicolas4 = 95;
            int nicolas5 = 100;

            int zahirah1 = 84;
            int zahirah2 = 96;
            int zahirah3 = 73;
            int zahirah4 = 85;
            int zahirah5 = 79;

            int jeong1 = 90;
            int jeong2 = 92;
            int jeong3 = 98;
            int jeong4 = 100;
            int jeong5 = 97;

            int sophiaSoma = sophia1 + sophia2
                + sophia3 + sophia4 + sophia5;

            int nicolasSoma = nicolas1 + nicolas2 
                + nicolas3 + nicolas4 + nicolas5;

            int zahirahSoma= zahirah1 + zahirah2 
                + zahirah3 + zahirah4 + zahirah5;

            int jeongSoma = jeong1 + jeong2
                + jeong3 + jeong4 + jeong5;

            // Nota bruta
            //Console.WriteLine("Sophia: " + sophiaSoma);
            //Console.WriteLine("Nicolas: " + nicolasSoma);
            //Console.WriteLine("Zahirah: " + zahirahSoma);
            //Console.WriteLine("Jeong: " + jeongSoma);

            //Média
            Console.WriteLine("Estudantes\tNota\n");

            decimal sophiaPontuacao = (decimal)sophiaSoma / qtdTarefas;
            decimal nicolasPontuacao = (decimal)nicolasSoma / qtdTarefas;
            decimal zahirahPontuacao = (decimal)zahirahSoma / qtdTarefas;
            decimal jeongPontuacao = (decimal)jeongSoma / qtdTarefas;

            // Formatação feita usando tabulação \t, é quebra de linha \n.
            Console.WriteLine("Sophia:\t\t" + sophiaPontuacao + "\tA");
            Console.WriteLine("Nicolas:\t" + nicolasPontuacao + "\tB");
            Console.WriteLine("Zahirah:\t" + zahirahPontuacao + "\tB");
            Console.WriteLine("Jeong:\t\t" + jeongPontuacao + "\tA");
        }
    }
}
