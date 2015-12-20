using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlkonostXNAGame.XNAData.GameGraphic
{
    class MapPoint
    {
        protected int pointy;
        protected int pointX;

       
        public MapPoint(int ppx, int ppy)
        {
            this.PointX = ppx;
            this.PointY = ppy;
        }
         
        public int PointX
        {
            get { return pointX; }
            set { this.pointX=value;}
        }
        public int PointY
        {
            get { return pointX; }
            set { this.pointX=value;} 
        }



    }
}
