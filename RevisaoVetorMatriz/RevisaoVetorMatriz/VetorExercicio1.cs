using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisaoVetorMatriz
{
    public class VetorExercicio1
    {
        //Crie um programa que receba 10 números e ao final calcule e exiba a soma dos 10 números. (Utilizando vetores).

        static float[] recebeNum = new float[10];
        static float total;

        public static float ReceberNumeros()
        {
            for (int i = 0; i < recebeNum.Length; i++)
            {
                Console.Write($"Defina um numero para a posição {i} do vetor: ");
                string text = Console.ReadLine();
                if(!float.TryParse(text, out recebeNum[i]))
                {
                    Console.WriteLine("Não utilize digitos especiais");
                    i--;
                }
                else
                {
                    total += recebeNum[i];
                }

            }
            Console.WriteLine(total);
            return total;
        
        }        



    }
}
