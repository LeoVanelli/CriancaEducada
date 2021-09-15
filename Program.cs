using System;

namespace CriancaEducada
{
    class Program
    {
        static void Main(string[] args)
        {
            // Solicite que o usuário digite uma frase. Substitua as palavras da lista por uma sequência de símbolos (como `#@$%*!&`, por exemplo).

            //chato/chata, bobo/boba, feio/feia, boboca, bocó, tonto/tonta, palerma, paspalho/paspalha, tantã, panaca, pentelho/pentelha, burro/burra, besta

            string[] palavras = new string[] {"chato","chata","bobo","boba","feio","feia","boboca","bocó","tonto","tonta","palerma","paspalho","paspalha","tantã","panaca","pentelho","pentelha","burro","burra","besta"};
            
            Console.Write("Me diga o que você pensa sobre o aluno que não faz a lição de casa: ");           
            
            string texto = Console.ReadLine();

            string[] textoSeparado = texto.Split(' ');

            Console.WriteLine("\nEu sou uma criança educada, no seu lugar eu diria:");

            for (int i = 0; i < textoSeparado.Length; i++) // Vai procurar a quantidade de palavras do texto
            {
                foreach (string palavra in palavras)
                {
                    if(textoSeparado[i] == palavra){
                        textoSeparado[i] = "#@$%*!&"; // Separa os caracteres da palavra para censura-la
                    }
                }
                Console.Write("{0} ",textoSeparado[i]);
            }
        }
    }
}
