using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte x = 100;
            byte n1 = 255;
            int n2 = 1000;
            int n3 = 2147483647;
            long n4 = 2147483649;
            char sexo = 'M';
            float flutua = 0.5f;
            string nome = "Jonathan";

            Console.WriteLine(x);
        }
    }
}

/*
 sbyte - tamanho de um byte e suporta numero inteiro desde que não seja negativo
 byte - suporta numero inteiro desde que não seja negativo e não ultrapasse o valor de 255
quando vamos declarar o tipo de dado que irá constar em uma variavel temos que levar em conta se a variavel está como é usada em c# ou em .NET
quando usada em .net é necessario o using System
- Overflow é a extrapolação do valor que a variável suporta
- Os tipos de dados que irão dar sentido a variaveis tem limites de dados, e quando um tipo atinge o limite precisamos usar outro tipo
 char -> caractere unico e usado com aspas simples ''
 float necessita alem de ser um número flutuante, precisa conter a letra f depois do número
 string pode conter mais caracteres que char e usamos aspas duplas ""
*/