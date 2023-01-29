namespace MarsRover.Test.Utilities
{
    internal class PlanèteBuilder
    {
        private ushort? _tailleTorique;
        private ushort? _tailleSphèrique;
        private Point? _obstacleEventuel;
        private IPlanète? _planète;

        public PlanèteBuilder ToriqueDeTailleX(ushort taille)
        {
            _tailleTorique = taille;
            return this;
        }

        public PlanèteBuilder SphériqueDeTailleX(ushort taille)
        {
            _tailleSphèrique = taille;
            return this;
        }

        public IPlanète Build()
        {
            _planète = new PlanèteStub();

            if (_tailleTorique.HasValue)
            {
                _planète = new Tore(_tailleTorique.Value);
            }

            if (_tailleSphèrique.HasValue)
            {
                _planète = new Sphèrique(_tailleSphèrique.Value);
            }

            if (_obstacleEventuel is not null) _planète = new PlanèteObstacleDecorator(_planète, _obstacleEventuel);
            return _planète;
        }

        public PlanèteBuilder AyantUnObstacle(ushort x, ushort y)
        {
            _obstacleEventuel = new Point(x, y);
            return this;
        }
    }
}
