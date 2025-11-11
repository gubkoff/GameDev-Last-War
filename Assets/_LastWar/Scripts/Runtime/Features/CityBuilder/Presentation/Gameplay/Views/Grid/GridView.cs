using System;
using System.Collections.Generic;
using _LastWar.CityBuilder.Repositories.Gameplay.Grid;
using UnityEngine;

namespace _LastWar.CityBuilder.Presentation.Gameplay.Views
{
    public class GridView : MonoBehaviour
    {
        [SerializeField] private GridRepository _gridRepository;
        
        private List<GameObject> _gridObjects;

        private void Start()
        {
            CreateGrid();
        }

        private void CreateGrid()
        {
            _gridObjects = new();
            
            for (int i = 0 - 1; i < _gridRepository.GridSize.x; i++)
            {
                for (int j = 0 - 1; j < _gridRepository.GridSize.y; j++)
                {
                    var grid = _gridRepository.GetGrid();
                    float positionX = i * grid.GridSize.x;
                    float positionZ = j * grid.GridSize.y;
                    
                    var gridObject = Instantiate(grid.Prefab, new Vector3(positionX, 0, positionZ), Quaternion.identity, transform);
                    grid.name = $"Grid_{i}_{j}";
                    _gridObjects.Add(gridObject);
                }
            }
        }
    }
}