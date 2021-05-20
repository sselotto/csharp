using Interfaces.Model.Enums;

namespace Interfaces.Model.Entities
{
    abstract class AbstractShape : IShape // a classe AbstractShape vai ser uma sub tipo da interface IShape
    {
        public Color Color { get; set; } // Declaração Propriedade Color

        public abstract double Area(); //declaração do metodo area

    }
}
