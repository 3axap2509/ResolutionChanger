using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResolutionChanger.Classes
{
    public class DisplayFormat
    {
        public DisplayFormat(byte NW, byte NH)
        {
            this.NWidth = NW;
            this.NHeight = NH;
        }
        public byte NWidth { get; set; }
        public byte NHeight { get; set; }

        public ushort HfromW(ushort Width)
        {
            return (ushort)(Width / NWidth * NHeight);
        }
        public ushort WfromH(ushort Height)
        {
            return (ushort)(Height / NHeight * NWidth);
        }
    }
}
