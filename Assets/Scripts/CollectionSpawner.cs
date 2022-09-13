using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectionSpawner : MonoBehaviour
{
    [SerializeField]
    GameObject[] collectionPrefab;

    public Transform topTrans, downTrans, leftTrans, rightTrans;
    float maxZ, minZ, maxX, minX;
    void Start()
    {
        maxZ = topTrans.position.z;
        minZ = downTrans.position.z;
        maxX = rightTrans.position.x;
        minX = leftTrans.position.x;
    }

    public void SpawnRandomPickup()
    {
        Vector3 pos = new Vector3(Random.Range(minX, maxX), 1, Random.Range(minZ, maxZ));
        Instantiate(collectionPrefab[Random.Range(0,collectionPrefab.Length)], pos, Quaternion.identity);
    }

    public void SpawnPickup()
    {
        Vector3 pos = new Vector3(Random.Range(minX, maxX), 1, Random.Range(minZ, maxZ));
        Instantiate(collectionPrefab[0], pos, Quaternion.identity);
    }
}
