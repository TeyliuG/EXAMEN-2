using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Jump();
        }      
    }





    private void Jump()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.AddForce(Vector2.up);
    }

}

