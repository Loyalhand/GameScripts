// for platformer type games

using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;

    Vector2 movement;
    public float moveSpeed;
    public float jump;
    private bool isGrounded;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // player input 
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = 0;
       
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);

        if (Input.GetKey(KeyCode.Space))
        {
            if (isGrounded == true)                        
            {
                rb.AddForce(new Vector2(0,1) * jump, ForceMode2D.Force);
                Debug.Log(isGrounded);
            } 
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isGrounded = true;
        }

    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isGrounded = false;
        }
    }
}
