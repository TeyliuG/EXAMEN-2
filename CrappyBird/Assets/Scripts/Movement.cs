using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Jump();
        }      
    }





    private void Jump()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
       {
            rb.AddForce(Vector2.up * 5, ForceMode2D.Impulse);
       }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision != null)
        {
            Destroy(gameObject);
            SceneManager.LoadScene("JustScene");
        }
    }
}

