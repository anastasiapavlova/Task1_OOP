﻿using Task1.Interfaces;

namespace Task1.Models
{
    public class Square : BaseFigure
    {
        public Square(float x, float y, float width, float height) : base(x, y, width, height) { }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
