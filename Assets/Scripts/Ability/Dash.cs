using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[CreateAssetMenu]
public class Dash : Ability
{
    public float dashForce;

    public override void Activate(GameObject parent)
    {
        Debug.Log("Dash");
        Rigidbody rb = parent.GetComponent<Rigidbody>();
        PlayerController pc = parent.GetComponent<PlayerController>();
        rb.velocity = pc.movementVector.normalized * dashForce;
    }

}
