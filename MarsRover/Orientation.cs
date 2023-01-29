using System;

namespace MarsRover
{
    public class Orientation
    {
        public static Orientation Nord = new ("nord");
        public static Orientation Est = new ("est");
        public static Orientation Sud = new("sud");
        public static Orientation Ouest = new("ouest");

        private Orientation(string orientation)
        {
            Value = orientation;
        }
        public String Value { get; set; }

        public Orientation MouvementDextrogyre
        {
            get
            {
                if (this == Nord) return Est;
                if (this == Est) return Sud;
                if (this == Sud) return Ouest;
                if (this == Ouest) return Nord;

                throw new NotSupportedException();
            }
        }

        public Orientation MouvementSinistrogyre
        {
            get
            {
                if (this == Nord) return Ouest;
                if (this == Est) return Nord;
                if (this == Sud) return Est;
                if (this == Ouest) return Sud;

                throw new NotSupportedException();
            }
        }

    }
}