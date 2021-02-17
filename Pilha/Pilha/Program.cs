﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilha
{
    class Program
    {
        static void Main(string[] args)
        {
            int op; //  variavel opções
            Livro livro; // INICIALIZAÇÃO LIVRO
            PilhaLivro pilha = new PilhaLivro { Topo = null }; // INICIALIZAÇÃO E INSTANCIAMENTO DA PILHA

            do
            {
                try
                {
                    Console.WriteLine("\n1 - Cadastrar Livro\n" + // MENU
                    "2 - Imprimir Livros\n3 - Deletar ultimo Livro\n" +
                    "4 - Quantidade de Livros\n5 - Buscar Livro\n0 - Sair");
                    op = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    op = 6; // LAÇO RODA NOVAMENTE
                }

                Console.Clear();

                switch (op)
                {
                    case 1: // CADASTRO

                        livro = lerLivro(); // CADASTRA LIVRO

                        pilha.push(livro); // CADASTRA LIVRO NA PILHA

                        break;
                    case 2: // IMPRIMIR

                            pilha.imprimir(); // IMPRIME PILHA

                        break;
                    case 3: // DELETAR

                        pilha.pop(); // DELETA 1° DA FILA

                        break;
                    case 4: // QUANTIDADE

                        Console.WriteLine("Quantidade de Livros: " + pilha.qtd()); // IMPRIME QUANTIDADE DE LIVROS

                        break;
                    case 5: //BUSCAR
                        Console.WriteLine("Digite o título do Livro");
                        pilha.buscar(Console.ReadLine()); // BUSCA NA PILHA E JÁ IMPRIME NO MÉTODO
                        break;
                }

            } while (op != 0);

            Console.ReadKey();
        }

        static public Livro lerLivro()
        {
            try
            {
                string titulo, autor;
                int isbn;
                do
                { // LAÇO ENQUANTO VALOR FOR VAZIO
                    Console.Write("Informe o título do livro: ");
                    titulo = Console.ReadLine();
                } while (titulo == "");

                do
                { // LAÇO ENQUANTO VALOR FOR VAZIO
                    Console.Write("Informe o autor do livro: ");
                    autor = Console.ReadLine();
                } while (autor == "");

                Console.Write("Informe o Isbn do livro: ");
                isbn = int.Parse(Console.ReadLine());

                Livro l = new Livro
                {
                    Titulo = titulo,
                    Autor = autor,
                    Isbn = isbn
                };
                return l;
            }
            catch (Exception)
            {
                Console.WriteLine("Informe valores válidos");
                Livro l = lerLivro();
                return l;
            }
        }
    }
}
