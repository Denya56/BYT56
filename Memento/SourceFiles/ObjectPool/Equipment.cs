using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.SourceFiles.ObjectPool
{
    class Equipment
    {
        public static int equipmentMaxSize = 3;
        public static int equipmentCounter = 0;
        public Equipment()
        {
            Console.WriteLine("Active equipment was created.");
            ++equipmentCounter;
        }
        public Equipment(String equipmentForPool)
        {
            Console.WriteLine("Equipment was added to pool.");
        }
    }
}
