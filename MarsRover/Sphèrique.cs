using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    public class Sphèrique : IPlanète
    {
        private readonly ushort _taille;

        public Sphèrique(ushort taille)
        {
            _taille = taille;
        }

        public Point Canoniser(Point point)
        {
            return new Point((decimal)(point.X % _taille), (decimal)(point.Y % _taille));
        }

        /// <inheritdoc />
        public bool PossèdeUnObstacle(Point point) => false;

        public string TypePlanète()
        {
            return "sphèrique";
        }
    }
}
