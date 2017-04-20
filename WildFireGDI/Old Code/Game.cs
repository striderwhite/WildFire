//using System;
//using System.Collections.Generic;
//using System.Threading;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using GDIDrawer;
//using System.Drawing;

//namespace WildFireGDI
//{
//    public class Game
//    {
//        //private MainForm form;
//        private const bool DEBUG_FLAG = true;
//        private const int MAXSIZE = 500;
//        private int TREESONFIRE = 0;
//        private CDrawer _Canvas;
//        private Random _RNG;
//        private List<Entity> _Entities;

//        private List<List<Entity>> _Snapshot;
       

//        private void Load()
//        {
//            _Canvas = new CDrawer(MAXSIZE, MAXSIZE, false);
//            _RNG = new Random();
//            _Entities = new List<Entity>();
//            _Snapshot = new List<List<Entity>>();


//            Generate(1000);
//            Display();
//        }

//        public void GameThread()
//        {
//            Load();

//            List<Tree> _TreesToLightOnFire = new List<Tree>();
//            List<Tree> _TreesDead = new List<Tree>();

//            while (true)
//            {

//                _Snapshot.Add(_Entities);

//                //DO LOGIC
//                foreach(Tree current in _Entities)
//                {
//                    if(current.onFire)
//                    {
//                        //project a radius and determine if any tree is within its range
//                        foreach(Tree other in _Entities)
//                        {
//                            //do not compare same tree
//                            if (current.Equals(other) || other.onFire)
//                                continue;


//                            //if "other" tree is within distance of current tree                            
//                            if (Tree.Distance(current, other) <= current.radiusOfFire/2)
//                            {
//                                //OTHER has a % chance of catching fire
//                                if (_RNG.NextDouble() < 0.005)
//                                {
//                                    _TreesToLightOnFire.Add(other);
//                                }
//                            }
//                        }

//                        if(current.life <= 0)
//                        {
//                            _TreesDead.Add(current);
//                        }
//                        else
//                        {
//                            current.life = current.life - 1;
//                        }
//                    }
                
//}


//                foreach(Tree t in _TreesToLightOnFire)
//                {
//                    t.onFire = true;
//                    TREESONFIRE++ ;
//                }

//                foreach(Tree t in _TreesDead)
//                {
//                    _Entities.Remove(t);
//                }

//                //Console.WriteLine("trees on fire {0}", TREESONFIRE);

//                _TreesToLightOnFire.Clear();
//                _TreesDead.Clear();


//                Thread.Sleep(0);
//                Display();

//            }
            
//        }

//        private void Generate(int amount)
//        {
//            int generations = amount;
//            bool treeonfire = false;
//            do
//            {
//                Tree t = new Tree(new Point(_RNG.Next(0, MAXSIZE), _RNG.Next(0, MAXSIZE)));

//                //make sure only one tree is on fire
//                if (!treeonfire) {  treeonfire = t.onFire = true; }

//                _Entities.Add(t);
//                  generations--;

//            } while (generations != 0);
//        }

//        private void Display()
//        {
//            _Canvas.Clear();
        
//            foreach (Tree e in _Entities)
//            {
//                if (DEBUG_FLAG)
//                {
//                    if(e.onFire)
//                    {
//                        Color redtransparent;
//                        if (_RNG.Next(0,100) < 50)
//                            redtransparent = Color.FromArgb(15, Color.Red);
//                        else
//                            redtransparent = Color.FromArgb(15, Color.Orange);

//                        _Canvas.AddCenteredEllipse(e.pos.X, e.pos.Y, e.radiusOfFire, e.radiusOfFire, redtransparent);
//                    }
//                }
//                _Canvas.AddCenteredEllipse(e.pos.X, e.pos.Y, e.size, e.size, e.color);

//            }
//            _Canvas.Render();
//        }
//    }
//}
