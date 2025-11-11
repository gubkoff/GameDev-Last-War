using UnityEngine;

namespace _LastWar.CityBuilder.Repositories.Gameplay.Grid
{
    [CreateAssetMenu (fileName = "GridData", menuName = "Cities/GridData")]
    public class GridData : ScriptableObject
    {
        [SerializeField] private GameObject _prefab;
    }
}