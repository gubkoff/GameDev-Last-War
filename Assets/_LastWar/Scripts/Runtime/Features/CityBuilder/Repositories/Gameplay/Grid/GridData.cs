using _LastWar.CityBuilder.Domain.Gameplay.Models.Grid;
using UnityEngine;

namespace _LastWar.CityBuilder.Repositories.Gameplay.Grid
{
    [CreateAssetMenu (fileName = "GridData", menuName = "City Builder/GridData")]
    public class GridData : ScriptableObject
    {
        [SerializeField] private GridType _gridType;
        [SerializeField] private Vector2 _gridSize;
        [SerializeField] private GameObject _prefab;

        public GridType GridType => _gridType;
        public Vector2 GridSize => _gridSize;
        public GameObject Prefab => _prefab;
    }
}