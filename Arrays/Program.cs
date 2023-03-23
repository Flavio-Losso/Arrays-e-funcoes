using System.Collections;
using System.ComponentModel;

namespace Arrays
{
    internal class Program
    {
        static int[] numeros = { -5, 3, 4, 5, 9, 6, 10, -2, 11, 1 };
        static int[] maiores = { int.MinValue, int.MinValue, int.MinValue };
        static void Main(string[] args)
        {
            int[] negativos, auxiliar;
            int maior, menor, c, remove, soma;
            Declaracao(out negativos, out auxiliar, out maior, out menor, out c, out remove, out soma);
            Numeros(negativos, auxiliar, ref maior, ref menor, ref c, ref soma);
            Exibicao(negativos, maior, menor, c, remove, soma);
        }

        static void Exibicao(int[] negativos, int maior, int menor, int c, int remove, int soma)
        {
            Console.WriteLine($"O maior valor é: {maior}");
            Console.WriteLine($"O menor valor é: {menor}");
            Console.WriteLine($"A média é: {soma}");
            Console.Write($"Os 3 maiores valores são: ");
            for (int i = 0; i < maiores.Length; i++)
            {
                if (i == maiores.Length - 1)
                {
                    Console.Write($"{maiores[i]}");
                }
                else
                {
                    Console.Write($"{maiores[i]} ,");
                }
            }
            Console.WriteLine();
            Console.Write($"Os negativos são: ");
            for (int i = 0; i < c; i++)
            {
                if (i == c - 1)
                {
                    Console.Write($"{negativos[i]}");
                }
                else
                {
                    Console.Write($"{negativos[i]} ,");
                }
            }
            Console.WriteLine();
            Console.Write($"O array original era: ");

            for (int i = 0; i < numeros.Length; i++)
            {
                if (i == numeros.Length - 1)
                {
                    Console.Write($"{numeros[i]}");
                }
                else
                {
                    Console.Write($"{numeros[i]} ,");
                }
            }
            Console.WriteLine();
            var aux = numeros.ToList();
            aux.RemoveAt(remove);
            numeros = aux.ToArray();

            Console.Write($"O array com a remoção de um valor aleatorio : ");
            for (int i = 0; i < numeros.Length; i++)
            {
                if (i == numeros.Length - 1)
                {
                    Console.Write($"{numeros[i]}");
                }
                else
                {
                    Console.Write($"{numeros[i]} ,");
                }
            }
        }

        static void Numeros(int[] negativos, int[] auxiliar, ref int maior, ref int menor, ref int c, ref int soma)
        {
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] > maior)
                {
                    maior = numeros[i];
                }
                if (numeros[i] < menor)
                {
                    menor = numeros[i];
                }
                if ((numeros[i] < 0))
                {
                    negativos[c] = numeros[i];
                    c++;
                }
                soma += numeros[i];
            }
            soma = soma / numeros.Length;
            Array.Copy(numeros, auxiliar,numeros.Length);
            Array.Sort<int>(auxiliar);
            for (int d = 0; d < auxiliar.Length; d++)
            {
                if (auxiliar[d] > maiores[0])
                {
                    maiores[0] = auxiliar[d];
                }
            }
            for (int d = 0; d < auxiliar.Length - 1; d++)
            {
                if (auxiliar[d] > maiores[1])
                {
                    maiores[1] = auxiliar[d];
                }
            }
            for (int d = 0; d < auxiliar.Length - 2; d++)
            {
                if (auxiliar[d] > maiores[2])
                {
                    maiores[2] = auxiliar[d];
                }
            }
        }

        static void Declaracao(out int[] negativos, out int[] auxiliar, out int maior, out int menor, out int c, out int remove, out int soma)
        {
            negativos = new int[numeros.Length];
            auxiliar = new int[numeros.Length];
            maior = int.MinValue;
            menor = int.MaxValue;
            Random rnd = new Random();
            c = 0;
            remove = rnd.Next(0, (numeros.Length - 1));
            soma = 0;
        }
    }
}