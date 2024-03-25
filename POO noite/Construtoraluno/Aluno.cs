using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstrutorAluno
{
    public class Aluno
    {

        //.*.*.*.* TRABALHO, VALE 1 PONTO *.*.*.*.

        //Data de entrega 31/03, pelo Teams, arquivo em .ZIP

        //Criar os atributos matrícula, nome, p1, p2, media
        //Criar os métodos/propriedade get e set, exceto o
        //atributo média
        //Criar o método para calcular a média do aluno
        //O atributo matrícula não terá o método set, pois
        //será gerado por um atributo static e armazenado
        //no atributo matricula 
        //Não use vetor
        //Crie o método MostrarAtributos, chame-o após cada
        //instância
        //Instancia no mínimo 4 objetos

        //private static int proximaMatricula = 1;

        public int Matricula { get; }
        public string Nome { get; set; }
        public double P1 { get; set; }
        public double P2 { get; set; }

        public double Media {get; set;}

        public static int proximaMatricula{get; set;}
        


        public Aluno(string nome, double p1, double p2)
        {
            proximaMatricula++;
            Matricula = "15048222300" + proximaMatricula;
            Nome = nome;
            P1 = p1;
            P2 = p2;
            MostrarAtributos();
        }

        private double CalcularMedia()
        {
            return (P1 + P2) / 2;
        }

        public void MostrarAtributos()
        {
            Console.WriteLine($"Matrícula: {Matricula}, Nome: {Nome}, P1: {P1}, P2: {P2}, Média: {Media}");
        }
    }
}