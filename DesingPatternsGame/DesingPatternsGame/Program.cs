using DesingPatternsGame.Common;
using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Reflection;

namespace DesingPatternsGame
{
#if WINDOWS || XBOX

    static class Program
    {
        static void Main(string[] args)
        {
            using (var game = new StrategyGame())
            {
                game.Run();
            }
        }
    }
#endif
}

