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
            var container = new CompositionContainer(new AssemblyCatalog(Assembly.GetExecutingAssembly()));
            container.ComposeParts(GameIndex.Instance);

            BaseGame game = null;
            try
            {
                game = GameIndex.Instance[args[0]];
            }
            catch
            {
                game = new CompositeGame();
            }

            try
            {
                game.Run();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debugger.Break();
                game.Dispose();
            }
        }
    }
#endif

    public class GameIndex
    {
        [ImportMany(typeof(BaseGame))]
        private IEnumerable<BaseGame> games = null;

        public BaseGame this[string itemName]
        {
            get
            {
                return games.FirstOrDefault(o => o.GetType().Name.Equals(itemName, StringComparison.OrdinalIgnoreCase));
            }
        }

        private GameIndex()
        {

        }

        private static GameIndex instance;
        public static GameIndex Instance
        {
            get
            {
                return instance ?? (instance = new GameIndex());
            }
        }
    }
}

