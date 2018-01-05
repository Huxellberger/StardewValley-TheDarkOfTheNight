// Jake Huxell 2018

using DarkOfTheNight.Vampire;
using StardewModdingAPI;
using StardewValley;

namespace DarkOfTheNight
{
    public class ModEntry
        : Mod
    {
        private VampireCharacter _currentVampire;

        public override void Entry(IModHelper helper)
        {
            Monitor.Log("Mod has loaded");

            _currentVampire = new VampireCharacter(Game1.player, DarkOfTheNightConstants.StartingSunDamage);
        }
    }
}
