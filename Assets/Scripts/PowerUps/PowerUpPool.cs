using System;
using CosmicCuration.Utilities;

namespace CosmicCuration.PowerUps
{
    public class PowerUpPool : GenericObjectPool<IPowerUp>
    {
        private PowerUpData powerUpData;

        public IPowerUp GetPowerUp<T>(PowerUpData powerUpData) where T : IPowerUp
        {
            this.powerUpData = powerUpData;
            return GetItem<T>();
        }

        protected override IPowerUp CreateItem<T>()
        {
            if (typeof(T) == typeof(Shield))
                return new Shield(powerUpData);
            else if (typeof(T) == typeof(RapidFire))
                return new RapidFire(powerUpData);
            else if (typeof(T) == typeof(DoubleTurret))
                return new DoubleTurret(powerUpData);
            else
                throw new NotSupportedException($"Power-up type '{typeof(T)}' is not supported.");
        }
    }
}