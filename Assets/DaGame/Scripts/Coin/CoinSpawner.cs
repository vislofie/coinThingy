using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject _coinPrefab;
    [SerializeField]
    private GameObject _badCoinPrefab;
    [SerializeField]
    private Transform _spawnPointsHolder;

    private void Start()
    {
        Transform[] spawnPoints = new Transform[_spawnPointsHolder.childCount]; // gets all predefined spawn points from a transform parent of those points
        for (int i = 0; i < spawnPoints.Length; i++)
        {
            spawnPoints[i] = _spawnPointsHolder.GetChild(i).transform;
        }

        ObjectSpawner.Instance.SpawnObjectsRandomly(ref spawnPoints, _coinPrefab, 10);
        ObjectSpawner.Instance.SpawnObjectsRandomly(ref spawnPoints, _badCoinPrefab, 3);
    }
}
