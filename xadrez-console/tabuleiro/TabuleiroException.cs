using System;

namespace tabuleiro
{
    class TabuleiroException : Exception
    {
        public TabuleiroException(string msg) : base(msg) // apenas repassa a mensagem para o exception
        { 
        }
    }
}
