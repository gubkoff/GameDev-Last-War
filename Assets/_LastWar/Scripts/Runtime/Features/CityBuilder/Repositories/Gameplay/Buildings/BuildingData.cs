using System.Collections.Generic;
using _LastWar.CityBuilder.Repositories.Gameplay.Resources;
using LastWar.CityBuilder.Domain.Gameplay.Models.Building;
using UnityEngine;

namespace _LastWar.CityBuilder.Repositories.Gameplay.Buildings
{
    [CreateAssetMenu(menuName = "City Builder/Gameplay/BuildingData", fileName = "BuildingData")]
    public class BuildingData : ScriptableObject
    {
        [SerializeField] private string _name;
        [SerializeField] private BuildingType _buildingType;
        [SerializeField] private Sprite _preview;
        [SerializeField] private ResourceData _cost;
        [SerializeField] private GameObject _prefab;
        [SerializeField] private int _baseLevel;
        [SerializeField] private List<BuildingLevelData> _levelsData;

        public string Name => _name;
        public BuildingType BuildingType => _buildingType;
        public Sprite Preview => _preview;
        public ResourceData Cost => _cost;
        public GameObject Prefab => _prefab;
        public int BaseLevel => _baseLevel;

        public BuildingLevelData GetLevelData(int level)
        {
            return _levelsData[level];
        }

        public BuildingLevelData GetNextLevelData(int level)
        {
            return GetLevelData(level + 1);
        }
    }
}