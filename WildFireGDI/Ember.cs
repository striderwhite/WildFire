using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WildFireGDI
{
    class Ember : Entity
    {
        public int life = 10;
        bool OUTOFBOUNDS = false;
        Random RNG = new Random();
        public int size = 5;
        //Color color = Color.Red;
        Color border = Color.Orange;

        public Ember(Point p) : base(p)
        {
        }

        public void Move(Point wind)
        {
            life--;
            pos.X += wind.X;
            pos.Y += wind.Y;

            //pos.X += RNG.Next(-3, 3);
            //pos.Y += RNG.Next(-3, 3);

            if (pos.X > MAXSIZE || pos.X < 0 || pos.Y > MAXSIZE || pos.Y < 0)
                OUTOFBOUNDS = true;

            if (RNG.Next(0, 100) < 50)
                color = Color.Orange;
            else
                color = Color.Red;

        }
    }
}
