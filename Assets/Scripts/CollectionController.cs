using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectionController : MonoBehaviour
{
    public int score = 1;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.tag);
        if (other.tag == "Player")
        {
            other.GetComponent<PlayerController>().score += score;
            Destroy(gameObject);
        }
    }
}
