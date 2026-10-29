using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisaoVetorMatriz
{
    //Crie um programa que leia 20 números e ao final informe o total de números pares digitados. (Utilizando vetores)
    public class VetorExercicio3
    {

        static float[] recebeNum = new float[20];
        
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
    
        public static int QuantosPares()
        {
            int totalPares = 0;
            for (int i = 0;i < recebeNum.Length; i++)
            {
                float a = recebeNum[i];
                
                if(a % 2 == 0)
                {
                    totalPares++;
                }
            }

            Console.WriteLine(totalPares);
            return totalPares;


        }
    
    
    
    }
}
