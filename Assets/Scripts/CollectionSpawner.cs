using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectionSpawner : MonoBehaviour
{
    [SerializeField]
    GameObject collectionPrefab;
    [SerializeField]
    int numOfCollectible = 5;

    public Transform topTrans, downTrans, leftTrans, rightTrans;
    float maxZ, minZ, maxX, minX;
    void Start()
    {
        maxZ = topTrans.position.z;
        minZ = downTrans.position.z;
        maxX = rightTrans.position.x;
        minX = leftTrans.position.x;
    }

    private void Update()
    {
        if (numOfCollectible > 0)
        {
            SpawnCollectible();
            numOfCollectible--;
        }
    }

    public void SpawnCollectible()
    {
        Vector3 pos = new Vector3(Random.Range(minX, maxX), 10, Random.Range(minZ, maxZ));
        Instantiate(collectionPrefab, pos, Quaternion.identity);
    }
}
