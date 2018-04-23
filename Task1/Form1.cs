using System.Windows.Forms;
using Task1.Drawing;
using Task1.Models;

namespace Task1
{
    public partial class Figures : MetroFramework.Forms.MetroForm
    {
        public Figures()
        {
            InitializeComponent();
        }

        private void Figures_Paint(object sender, PaintEventArgs e)
        {
            var figureList = new FigureCollection
            {
                new Circle(50, 50, 200, 200),
                new Ellipse (300, 100, 200, 100),
                new Square(50, 300, 200, 200),
                new Rectangle (300, 300, 200, 150),
                new LineSegment {X1 = 550, Y1 = 50, X2 = 700, Y2 = 200},
                new Rhomb (550, 300, 200, 200)
            };

            var drawFigures = new DrawFigure(e);
            drawFigures.DrawFigures(figureList);
        }
    }
}
