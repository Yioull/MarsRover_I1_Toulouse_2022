namespace MarsRover.Commandes
{
    public class AvancerCommande : IRoverCommande
    {
        private Point positionFinale;

        /// <inheritdoc />
        public (Orientation Orientation, Point Position, Point? ObstacleEventuel) Traiter(
            Orientation orientation, Point positionInitiale, IPlanète planète)
        {
            if (planète.TypePlanète() == "tore" || planète.TypePlanète() == "")
            {
                positionFinale = positionInitiale + new Point(0, 1);
            }

            if (planète.TypePlanète() == "sphèrique")
            {
                switch (orientation.Value)
                {
                    case "nord":
                        positionFinale = positionInitiale + new Point(0, 1);
                        break;
                    case "sud":
                        positionFinale = positionInitiale + new Point(0, -1);
                        break;
                    case "est":
                        positionFinale = positionInitiale + new Point(1, 0);
                        break;
                    case "ouest":
                        positionFinale = positionInitiale + new Point(-1, 0);
                        break;
                }
            }   

            positionFinale = planète.Canoniser(positionFinale);

            if (planète.PossèdeUnObstacle(positionFinale)) 
                return (orientation, positionInitiale, positionFinale);
            else return (orientation, positionFinale, default);
        }
    }
}
