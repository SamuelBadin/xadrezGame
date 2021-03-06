namespace tabuleiro
{
    abstract class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; } // acessada somente pelas subclasses dela
        public int qteMovimentos { get; protected set; }
        public Tabuleiro tab { get; protected set; }

        public Peca(Tabuleiro tab, Cor cor)
        {
            this.posicao = null;
            this.cor = cor;
            this.tab = tab;
            this.qteMovimentos = 0;
        }

        public abstract bool[,] movimentosPossiveis();


        public void incrementarMovimentos() {
            qteMovimentos++;
        }

    }
}
