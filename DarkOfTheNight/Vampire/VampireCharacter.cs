// Jake Huxell 2018

using StardewModdingAPI.Events;
using StardewValley;

namespace DarkOfTheNight.Vampire
{
    internal class VampireCharacter
    {
        public float SunDamagePerCycle { get; private set; }

        private readonly StardewValley.Farmer _underlyingCharacter;
        private bool _outside;

        public VampireCharacter(StardewValley.Farmer inCharacter, float inSunDamagePerCycle)
        {
            _underlyingCharacter = inCharacter;
            _outside = false;
            SunDamagePerCycle = inSunDamagePerCycle;

            LocationEvents.CurrentLocationChanged += OnLocationChanged;
            TimeEvents.TimeOfDayChanged += OnTimeOfDayChanged;
        }

        private bool IsDarkness()
        {
            return Game1.isDarkOut();
        }

        private void OnLocationChanged(object sender, EventArgsCurrentLocationChanged eventArgs)
        {
            _outside = eventArgs.NewLocation.isOutdoors;
        }

        private void OnTimeOfDayChanged(object sender, EventArgsIntChanged inTime)
        {
            if (_outside && !IsDarkness())
            {
                _underlyingCharacter.Stamina -= SunDamagePerCycle;
            }
        }
    }
}
