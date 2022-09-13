using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum pickupType
{
    normal,
    bonus,
    explosion
}
public class CollectionController : MonoBehaviour
{
    public pickupType pickupType;
    public int score = 1;
    CollectionSpawner spawner;

    private void Start()
    {
        spawner = FindObjectOfType<CollectionSpawner>();
        if (pickupType == pickupType.explosion)
        {
            spawner.SpawnPickup();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.tag);
        if (other.tag == "Player")
        {
            if (pickupType == pickupType.normal)
            {
                other.GetComponent<PlayerController>().score += score;
            }else if(pickupType == pickupType.bonus)
            {
                other.GetComponent<PlayerController>().score += 2 * score;
            }
            else if (pickupType == pickupType.explosion)
            {
                other.GetComponent<HealthManager>().TakeDamage();
            }
            spawner.SpawnRandomPickup();
            Destroy(gameObject);
        }
    }
}
