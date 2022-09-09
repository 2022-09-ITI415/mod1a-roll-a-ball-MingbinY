using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectionSpawner : MonoBehaviour
{
    [SerializeField]
    GameObject collectionPrefab;
    [SerializeField]
    int numOfCollectible = 5;

    Vector3 leftUp, leftDown, rightUp, rightDown;
    void Start()
    {
        for (int i = 0; i < numOfCollectible; i++)
        {
            Instantiate(collectionPrefab, transform.position, Quaternion.identity);
        }
    }

}
