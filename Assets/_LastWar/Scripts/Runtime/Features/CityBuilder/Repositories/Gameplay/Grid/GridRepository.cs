using System.Collections.Generic;
using UnityEngine;

namespace _LastWar.CityBuilder.Repositories.Gameplay.Grid
{
    [CreateAssetMenu(fileName = "GridRepository", menuName = "City Builder/Grid Repository")]
    public class GridRepository : ScriptableObject
    {
        [SerializeField] private Vector2 _gridSize = new Vector2(32, 32);
        [SerializeField] private Color _hoverColor = Color.white;
        [SerializeField] private Color _canPlaceColor = Color.green;
        [SerializeField] private Color _wrongPlaceColor = Color.red;
        [SerializeField] private List<GridData> _grids;

        public Vector2 GridSize => _gridSize;
        public Color HoverColor => _hoverColor;
        public Color CanPlaceColor => _canPlaceColor;
        public Color WrongPlaceColor => _wrongPlaceColor;

        public GridData GetGrid()
        {
            //Некторая логика получения клетки при необходимости
            return _grids[0];
        }
    }
}