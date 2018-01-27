using UnityEngine;

public class CharacterMovement : MonoBehaviour {
    private Rigidbody2D rb;
    public float movementSpeed = 0.1f;
    public float jumpForce = 8f;
    public bool isGrounded = false;
    public float maxSpeed = 8f;
    public bool jump = false;
    public Transform groundCheck;
    
    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D>();

	}
    private void Update()
    {
        Debug.Log("Velocity: " + rb.velocity.x);
        isGrounded = Physics2D.Linecast(transform.position, groundCheck.position, 1 << LayerMask.NameToLayer("Ground"));

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            jump = true;
        }
    }
    // Update is called once per frame
    void FixedUpdate () {
        // if (isGrounded)//(rb.velocity.y < 0.5f && rb.velocity.y > -0.5f) { 
        //  { 
        float inputHorizontal = Input.GetAxis("Horizontal");
        if(inputHorizontal * rb.velocity.x < maxSpeed)
        {
            rb.AddForce(Vector2.right * inputHorizontal * movementSpeed);
        }
        if (Mathf.Abs(rb.velocity.x) > maxSpeed)
            rb.velocity = new Vector2(Mathf.Sign(rb.velocity.x) * maxSpeed, rb.velocity.y);
        // rb.velocity += Input.GetAxisRaw("Horizontal") * Vector2.right * movementSpeed * Time.deltaTime + Vector2.up * Time.deltaTime * 0.1f ;
        // rb.velocity += new Vector2(Input.GetAxisRaw("Horizontal") * movementSpeed * Time.deltaTime,rb.velocity.y);
        
        if (jump)
        {
            rb.AddForce(new Vector2(0f, jumpForce));
            jump = false;
        }
      //  }
	}

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            isGrounded = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            isGrounded = false;
        }
    }
}
