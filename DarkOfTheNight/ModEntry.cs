// Jake Huxell 2018

using System;
using DarkOfTheNight.Vampire;
using StardewModdingAPI;
using StardewModdingAPI.Events;
using StardewValley;

namespace DarkOfTheNight
{
    internal class ModEntry
        : Mod
    {
        private VampireCharacter _currentVampire;

        public override void Entry(IModHelper helper)
        {
            ModLogging.SetLogger(Monitor);
            ModLogging.Log("Mod has started");

            SaveEvents.AfterLoad += OnAfterLoad;
        }

        private void OnAfterLoad(object inSender, EventArgs inEventArgs)
        {
            _currentVampire = new VampireCharacter(Game1.player, DarkOfTheNightConstants.StartingSunDamage);
        }
    }
}
