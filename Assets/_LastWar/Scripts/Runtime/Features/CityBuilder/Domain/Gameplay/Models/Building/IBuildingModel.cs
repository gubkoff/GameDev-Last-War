using System;

namespace LastWar.CityBuilder.Domain.Gameplay.Models.Building
{
    public interface IBuildingModel
    {
        Guid Id { get; }
        BuildingType Type { get; }
        BuildingRotateType RotateType { get; }
        int Level { get; }
    }
}