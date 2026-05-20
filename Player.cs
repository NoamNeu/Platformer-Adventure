using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5f;
    public float jumpForce = 10f;

    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    void Update()
    {
        float moveInput = Input.GetAxis("Horizontal");
        rb.linearVelocity = new Vector2(moveInput * speed, rb.linearVelocity.y);

        if(Input.GetKeyDown(KeyCode.Space)) 
        { 
            rb.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
        }
     }
}
