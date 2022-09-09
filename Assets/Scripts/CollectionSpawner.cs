using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectionSpawner : MonoBehaviour
{
    [SerializeField]
    GameObject collectionPrefab;
    void Start()
    {
        Instantiate(collectionPrefab, transform.position, Quaternion.identity);
    }

}
