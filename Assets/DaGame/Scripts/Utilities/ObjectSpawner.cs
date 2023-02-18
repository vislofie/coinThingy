using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    private static ObjectSpawner _instance;
    public static ObjectSpawner Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<ObjectSpawner>();
            }
            return _instance;
        }
    }


    /// <summary>
    /// Spawns given object randomly at given points at given amount
    /// </summary>
    /// <param name="points">points to spawn on. outs the remaining points that were not used</param>
    /// <param name="objToSpawn">obj prefab to spawn</param>
    /// <param name="amountOfObjs">amount of instances of objs to spawn</param>
    public void SpawnObjectsRandomly(ref Transform[] points, GameObject objToSpawn, int amountOfObjs)
    {
        System.Random rnd = new System.Random();
        rnd.Shuffle(points); // shuffles spawn points randomly

        Stack<Transform> pointStack = new Stack<Transform>(points); // creates a stack that consists of randomly sorted spawn points

        Transform spawnPoint = pointStack.Pop();

        for (int i = 0; i < amountOfObjs; i++)
        {
            Instantiate(objToSpawn, spawnPoint); // spawn coin on a point from stack

            spawnPoint = pointStack.Pop();
        }

        points = pointStack.ToArray();
    }
}
