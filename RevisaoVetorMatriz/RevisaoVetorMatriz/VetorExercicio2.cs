using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisaoVetorMatriz
{
    public class VetorExercicio2
    {

        //Crie um programa que receba 20 números e ao final exiba os 20 números na ordem contrária em que foram recebidos. (Utilizando vetores).

        static float[] recebeNum = new float[10];

        public static void ReceberNumeros()
        {
            for (int i = 0; i < recebeNum.Length; i++)
            {
                Console.Write($"Defina um numero para a posição {i} do vetor: ");
                string text = Console.ReadLine();
                if (!float.TryParse(text, out recebeNum[i]))
                {
                    Console.WriteLine("Não utilize digitos especiais");
                    i--;
                }
            }
        
            
        }
        public static void ImprimirVetor()
        {
            for ( int i = recebeNum.Length;  --i >= 0;)
            {
                Console.Write($"{recebeNum[i]},");
            }            
         
        }
    }
}
