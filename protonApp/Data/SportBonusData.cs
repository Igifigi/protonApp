using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace protonApp.Data
{
    public class SportBonusData
    {
        internal static readonly int[,] bonusByPlace = new int[,]
        {
            { 50,42,36,34,29,26,23,21,19,17,15,13,11,9,7,5,4,3 },
            { 45,36,28,22,17,13,10,9,8,7,6,5,0,0,0,0,0,0 },
            { 40,33,26,20,15,11,9,7,4,3,0,0,0,0,0,0,0,0 },
            { 25,20,17,14,13,10,8,6,3,0,0,0,0,0,0,0,0,0 },
            { 20,17,14,12,10,8,6,4,0,0,0,0,0,0,0,0,0,0 }
        };
    }
}
