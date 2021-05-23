﻿using Metodos_Abstratos.Entities.Enums;

namespace Metodos_Abstratos.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }

        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();
    }
}