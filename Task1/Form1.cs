using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            var figureList = new Figure();
            figureList.Add(new Circle { x = 50, y = 50, width = 200, height = 200 });
            figureList.Add(new Ellipse { x = 300, y = 100, width = 200, height = 100 });
            figureList.Add(new Square { x = 50, y = 300, width = 200, height = 200 });
            figureList.Add(new Models.Rectangle { x = 300, y = 300, width = 200, height = 150 });
            figureList.Add(new LineSegment { x1 = 550, y1 = 50, x2 = 700, y2 = 200 });
            figureList.Add(new Rhomb { x = 550, y = 300, width = 200, height = 200 });
            figureList.Accept(new DrawFigure(e));
        }
    }
}
