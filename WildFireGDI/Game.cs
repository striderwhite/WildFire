using System;
using System.Collections.Generic;
using System.Threading;
using System.Linq;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;
using GDIDrawer;
using System.Drawing;

namespace WildFireGDI
{
    public class Game
    {

        //private MainForm form;
        private const bool DEBUG_FLAG = true;
        private const int MAXSIZE = 500;
        private int TREESONFIRE = 0;
        public CDrawer _Canvas;
        private Random _RNG;
        private List<Entity> _Entities;
        List<Ember> _Embers = new List<Ember>();
        List<Entity> _EmbersToRemove = new List<Entity>();
        private static Point WIND;
        public bool RANDOM_WIND = true;
        private MainForm _Form;
        public bool RUN = true;

        private List<List<Entity>> _Snapshot;
       
        public Point _WIND
        {
            get
            {
                return WIND;
            }
            set
            {
                Console.WriteLine("x: {0} y: {1}", value.X, value.Y);
                WIND = value;
            }
        }

        internal void Restart()
        {
            _Canvas.Close();
            _Canvas = null;
            _Embers.Clear();
            _EmbersToRemove.Clear();


            _Canvas = new CDrawer(MAXSIZE, MAXSIZE, false);
            Generate(1500);
            Display();
        }

        public static void setWind(Point p)
        {
            WIND = p;
        }
   

        public Game(MainForm form)
        {
            _Form = form;
        }

        private void Load()
        {
            _Canvas = new CDrawer(MAXSIZE, MAXSIZE, false);
            _RNG = new Random();
            _Entities = new List<Entity>();
            _Snapshot = new List<List<Entity>>();

            Generate(1500);
            Display();
        }


        public void GameThread()
        {
            Load();

            List<Tree> _TreesToLightOnFire = new List<Tree>();
            List<Entity> _RemoveEntities = new List<Entity>();
            _Embers = new List<Ember>();

            WIND = new Point(_RNG.Next(-5, 5), _RNG.Next(-5, 5));

            while (RUN)
            {

                //--------------- WIND -------------------------
                if(RANDOM_WIND)
                {
                    if (_RNG.NextDouble() < 0.1)
                    {
                        Point NewWind = new Point(_RNG.Next(-1, 1), _RNG.Next(-1, 1));
                        WIND = new Point(WIND.X + NewWind.X, WIND.Y + NewWind.Y);
                    }
                }
                _Canvas.AddText(String.Format("WIND: X: {0}, Y: {1}", WIND.X, WIND.Y), 10, 0, 10, 150, 10, Color.White);
                _Snapshot.Add(_Entities);


                //-------------- MAIN GAME LOGIC---------------------------------
                foreach (Tree current in _Entities)
                {

                    if (current.onFire)
                    {
                        //project a radius and determine if any tree is within its range
                        /*
                        foreach(Tree other in _Entities)
                        {
                            //do not compare same tree
                            if (current.Equals(other) || other.onFire)
                                continue;


                            //if "other" tree is within distance of current tree                            
                            if (Tree.Distance(current, other) <= current.radiusOfFire/2)
                            {
                                //OTHER has a % chance of catching fire
                                if (_RNG.NextDouble() < 0.005)
                                {
                                    _TreesToLightOnFire.Add(other);
                                }
                            }
                        }

                        */

                        
                        // 0.5% chance to Spawn an "Ember"
                        if(_RNG.NextDouble() < 0.05)
                        {
                            //spawn ember
                            _Embers.Add(new Ember(current.pos));
                        }

                        if(current.life <= 0)
                        {
                            _RemoveEntities.Add(current);
                        }
                        else
                        {
                            current.life = current.life - 1;
                        }
                    }
                
                }


                foreach (Ember e in _Embers)
                {
                    e.Move(WIND);
                    foreach(Tree t in _Entities)
                    {
                        //if tree is within distance of ember                           
                        if (Tree.Distance(e, t) <= t.size)
                        {
                            //OTHER has a % chance of catching fire
                            if (_RNG.NextDouble() < 0.05)
                            {
                                _TreesToLightOnFire.Add(t);
                                _RemoveEntities.Add(e);

                            }
                        }
                        if(e.life<=0)
                            _EmbersToRemove.Add(e);
                    }
                }

                foreach(Tree t in _TreesToLightOnFire)
                {
                    t.onFire = true;
                    TREESONFIRE++ ;
                }

                foreach(Entity e in _RemoveEntities)
                {
                    _Entities.Remove(e);
                }


                foreach (Ember e in _EmbersToRemove)
                {
                    _Embers.Remove(e);
                }

                //Console.WriteLine("trees on fire {0}", TREESONFIRE);

                _TreesToLightOnFire.Clear();
                _RemoveEntities.Clear();
                _EmbersToRemove.Clear();


                Thread.Sleep(100);
                Display();

            }


            
        }

        private void Generate(int amount)
        {
            int generations = amount;
            bool treeonfire = false;
            do
            {
                Tree t = new Tree(new Point(_RNG.Next(0, MAXSIZE), _RNG.Next(0, MAXSIZE)));

                //make sure only one tree is on fire
                if (!treeonfire) {  treeonfire = t.onFire = true; }

                _Entities.Add(t);
                  generations--;

            } while (generations != 0);
        }

        private void Display()
        {
            _Canvas.Clear();
        
            foreach (Tree e in _Entities)
            {
                if (DEBUG_FLAG)
                {
                    if(e.onFire)
                    {
                        Color redtransparent;
                        if (_RNG.Next(0,100) < 50)
                            redtransparent = Color.FromArgb(40, Color.Red);
                        else
                            redtransparent = Color.FromArgb(40, Color.Orange);

                        _Canvas.AddCenteredEllipse(e.pos.X, e.pos.Y, e.radiusOfFire, e.radiusOfFire, redtransparent);
                    }
                }
                _Canvas.AddCenteredEllipse(e.pos.X, e.pos.Y, e.size, e.size, e.color);

            }

            foreach(Ember e in _Embers)
            {
                _Canvas.AddCenteredEllipse(e.pos.X, e.pos.Y, e.size,e.size, e.color);
            }

            _Canvas.Render();

            
        }
    }
}
