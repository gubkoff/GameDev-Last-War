using System.Collections.Generic;
using UnityEngine;

namespace _LastWar.CityBuilder.Repositories.Gameplay.Buildings
{
    [CreateAssetMenu (menuName = "City Builder/Gameplay/Buildings", fileName = "BuildingsRepository")]
    public class BuildingsRepository : ScriptableObject
    {
        [SerializeField] private List<BuildingData> _buildingsData;

        public List<BuildingData> BuildingsData => _buildingsData;
    }
}