using System;
using System.Collections.Generic;
using _LastWar.CityBuilder.Repositories.Gameplay.Resources;

namespace _LastWar.CityBuilder.Repositories.Gameplay.Buildings
{
    [Serializable]
    public struct BuildingLevelData
    {
        public int Level;
        public ResourceData UpdateCost;
        public List<ResourceData> GeneratedResource;
        public float GeneratedPerSeconds;
    }
}