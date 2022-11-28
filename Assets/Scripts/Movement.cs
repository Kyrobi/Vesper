using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed = 4f;

    public Rigidbody2D rb;
    public Animator animator;
    Vector2 movement;

    private string PrevKey;
    // Update is called once per frame
    void Update()
    {
        //Move Character
       movement.x = Input.GetAxisRaw("Horizontal");
       movement.y = Input.GetAxisRaw("Vertical");


       if (movement.x == 1 || movement.x == -1)
       {
        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", 0);
        movement.y = 0;
        animator.SetFloat("LastX", movement.x);
        animator.SetFloat("LastY", 0);
       }
       else if (movement.y == 1 || movement.y == -1)
       {
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Horizontal", 0);
        movement.x = 0;
        animator.SetFloat("LastY", movement.y);
        animator.SetFloat("LastX", 0);
       }

        animator.SetFloat("Speed", movement.sqrMagnitude);
    }

    void FixedUpdate() {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }

}

