using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WildFireGDI
{
    public class Tree : Entity
    {
        private const int DEFAULT_SIZE = 10;
        private const int DEFAULT_DRYNESS = 1; //fresh tree
        private const int DEFAULT_LIFE = 100;
        public const int DEFAULT_RADIUS_OF_FIRE = 30;

        private int _treeID = 0;

        public int dryness; //controls how fast this tree will burn.
        public int size; //diameter of tree
        public int radiusOfFire = DEFAULT_RADIUS_OF_FIRE;
        private bool _onFire = false;
        public int life;

        public bool onFire
        {
            get
            {
                return _onFire;
            }
            set
            {
                if (value)
                    color = Color.Red;
                else
                    color = Color.DarkGreen;

                _onFire = value;
            }
        }

        public Tree(Point pos) : base(pos)
        {
            color = Color.Green;
            size = DEFAULT_SIZE;
            dryness = DEFAULT_DRYNESS;
            life = DEFAULT_LIFE;
        }

        public Tree(Point pos, int size, int dryness) : base(pos)
        {
            this.dryness = dryness;
            color = Color.Green;
            size = this.size;
            life = DEFAULT_LIFE;
        }

        public Tree(Point pos, int dryness) : base(pos)
        {
            this.dryness = dryness;
            color = Color.Green;
            size = DEFAULT_SIZE;
            life = DEFAULT_LIFE;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Tree))
                return false;
            Tree other = (Tree)obj;
            return (pos.X == other.pos.X && pos.Y == other.pos.Y);
        }

        public override int GetHashCode()
        {
            return 1;
        }
    }
}
