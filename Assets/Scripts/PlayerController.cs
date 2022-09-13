using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField]
    float moveForce = 1f;
    Vector2 movementVector = Vector2.zero;
    public int score = 0;

    void Start()
    {
        score = 0;
        rb = GetComponent<Rigidbody>();
    }

    public void OnMovement(InputValue movementValue)
    {
        movementVector = movementValue.Get<Vector2>();
    }

   

    private void FixedUpdate()
    {
        Vector3 movement = new Vector3(movementVector.x, 0, movementVector.y);
        rb.AddForce(movement * moveForce);
    }
}
