using System;
using System.Drawing;
using GDIDrawer;

namespace WildFireGDI
{
    public class Entity
    {
        public Point pos;
        public Color color;
        public bool NEEDS_UPDATE = true;
        public const int MAXSIZE = 500;


        public Entity(Point pos)
        {
            this.pos = pos;
        }

        public static int Distance(Entity a, Entity b)
        {
            return (int)Math.Sqrt(Math.Pow((a.pos.X - b.pos.X), 2) + Math.Pow((a.pos.Y - b.pos.Y), 2));
        }

    }
}
