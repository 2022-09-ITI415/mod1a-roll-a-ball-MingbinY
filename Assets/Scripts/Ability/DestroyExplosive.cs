using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class DestroyExplosive : Ability
{
    public float radius = 5f;
    public GameObject VFX;
    public override void Activate(GameObject parent)
    {
        Instantiate(VFX, parent.transform.position, Quaternion.identity);
        Collider[] hits = Physics.OverlapSphere(parent.transform.position, radius);
        foreach (Collider col in hits)
        {
            CollectionController cc = col.gameObject.GetComponent<CollectionController>();
            if (cc != null)
            {
                if (cc.pickupType == PickupType.explosion)
                {
                    Destroy(cc.gameObject);
                }
            }
        }
    }
}
