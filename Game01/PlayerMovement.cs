using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;

    Vector2 movement;

    private Rigidbody2D rb;

    private Animator animator;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }
    

    // Update is called once per frame
    void Update()
    {
        // player input 
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        // movement animation 
        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);
       
        // handles player direction
        if (movement != Vector2.zero)
        {
            float angle = getAxis(movement);
            
            if (angle == 0)
            {
                animator.SetBool("East", true);
                animator.SetBool("South", false);
                animator.SetBool("North", false);
                animator.SetBool("West", false);
                transform.localScale = new Vector3(-1f, 1f, 1f);
            }
            if (angle == Mathf.PI/2)
            {
                animator.SetBool("East", false);
                animator.SetBool("South", false);
                animator.SetBool("North", true);
                animator.SetBool("West", false);
                transform.localScale = new Vector3(1f, 1f, 1f);
            }
            if (angle == Mathf.PI)
            {
                animator.SetBool("East", false);
                animator.SetBool("South", false);
                animator.SetBool("North", false);
                animator.SetBool("West", true);
                transform.localScale = new Vector3(1f, 1f, 1f);
            }
            if (angle == -Mathf.PI / 2)
            {
                animator.SetBool("East", false);
                animator.SetBool("South", true);
                animator.SetBool("North", false);
                animator.SetBool("West", false);
                transform.localScale = new Vector3(1f, 1f, 1f);
            }
        }
        

    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement*moveSpeed*Time.fixedDeltaTime);
    }

    // gets the position angle 
    // east = 0 rad
    public float getAxis(Vector2 position)
    {
        float direction = Mathf.Atan2(position.y, position.x);

        return direction;
    }

    public Vector2 playerMovement()
    {
        Vector2 movement;

        // player input 
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        return movement;
    }
}
