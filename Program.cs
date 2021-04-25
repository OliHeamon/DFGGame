using ECS.Utilities;
using System;
using System.IO;

namespace DFGame
{
    public class Program
    {
        private static readonly string NativeReferencesDirectory = Path.Combine("References", "Native");

        [STAThread]
        public static void Main(string[] args)
        {
            Utils.SetDllImportResolver(NativeReferencesDirectory);

            using DFGame game = new DFGame();

            game.Run();
        }
    }
}
