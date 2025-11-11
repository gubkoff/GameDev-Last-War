using System;

namespace LastWar.CityBuilder.Domain.Gameplay.Models.Building
{
    public class BuildingModel : IBuildingModel
    {
        public Guid Id { get; private set; }
        public BuildingType Type { get; private set; }
        public BuildingRotateType RotateType { get; private set; }
        public int Level { get; private set; }
        
        public BuildingModel(Guid id, BuildingType type, BuildingRotateType rotateType, int level = 1)
        {
            Id = id;
            Type = Type;
            RotateType = rotateType;
            Level = level;
        }
    }
}