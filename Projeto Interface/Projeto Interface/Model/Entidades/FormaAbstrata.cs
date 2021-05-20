using Projeto_Interface.Model.Enums;


namespace Projeto_Interface.Modelo.Entidades
{
    abstract class FormaAbstrata : IForma
    {
        public Cor cor { get; set; }

        public abstract double Area();

    }
}
