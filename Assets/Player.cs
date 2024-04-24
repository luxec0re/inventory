using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{
  
    bool inRange = false;
    GameObject Player;
    public ItemPickup IsItem;

    Rigidbody2D rb;
    public float speed = 5f;
    float Horizontal;
    float Vertical;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void Update()
    {
        Horizontal = Input.GetAxisRaw("Horizontal");
        Vertical = Input.GetAxisRaw("Vertical");


        if (inRange == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                IsItem.PickUpItem();
            }

        }


    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(Horizontal * speed, rb.velocity.y);
        rb.velocity = new Vector2(rb.velocity.x, Vertical * speed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Item"))
        {
            inRange = true;
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Item"))
        {
            inRange = false;
        }
    }
}
