using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisaoVetorMatriz
{
    public class MatrizExercicio4
    {

        //Declare uma matriz multidimensional chamada números do tipo int que tenha 4 linhas e 4 colunas.
        //Preencha a matriz com os números de 1 à 16 de forma que de 1 a 4 esteja na primeira linha, de 5 a 8 na segunda linha,
        //9 a 12 na terceira linha e 13 a 16 na quarta linha.
        //Após preencher a matriz, multiplique o valor de cada posição por 10.


        public static int[,] numeros = new int[4, 4] { { 1, 2, 3, 4 }, {5,6,7,8}, {9,10,11,12}, {13,14,15,16} };

        public static void MultMatriz()
        {
            for (int i = 0; i < numeros.GetLength(0); i++)
            {
                for(int j = 0; j < numeros.GetLength(1); j++)
                {
                    numeros[i, j] *= 10;
                    Console.Write(numeros[i, j] + "\t");
                }
                Console.WriteLine();
            
            }

        }
        

    }
}
