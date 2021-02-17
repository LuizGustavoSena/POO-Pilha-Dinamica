using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilha
{
    class Livro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int Isbn { get; set; }
        public Livro Anterior { get; set; }

        // IMPRESSAO
        public override string ToString()
        {
            return "LIVRO\nTitulo: " + Titulo + 
                "\nAutor: " + Autor + "\nISBN: " + Isbn;
        }
    }
}
