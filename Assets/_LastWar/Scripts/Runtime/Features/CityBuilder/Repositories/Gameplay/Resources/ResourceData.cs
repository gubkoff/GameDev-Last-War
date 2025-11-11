using System;
using _LastWar.CityBuilder.Domain.Gameplay.Models.Resources;

namespace _LastWar.CityBuilder.Repositories.Gameplay.Resources
{
    [Serializable]
    public struct ResourceData
    {
        public ResourceType ResourceType;
        public int Amount;
    }
}