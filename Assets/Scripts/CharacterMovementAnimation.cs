using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovementAnimation : MonoBehaviour {
    private Rigidbody2D rb;
    public float movementSpeed = 0.1f;
    public float jumpForce = 8f;
    public bool isGrounded = false;
    public float maxSpeed = 8f;
    public bool jump = false;
    public Transform groundCheck;
    public bool facingRight = true;
    public float distanceY;
    public float oldY;
    //animation
    Animator anim;
    int jumpHash = Animator.StringToHash("jump");

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        oldY = transform.position.y;
    }
    private void Update()
    {
        

        if (transform.position.y != oldY)
        {
            distanceY = Mathf.Abs(oldY - transform.position.y);
            oldY = transform.position.y;
        }

        anim.SetFloat("movementY", distanceY*2f);

        Debug.Log("distY:" +distanceY);

        isGrounded = Physics2D.Linecast(transform.position, groundCheck.position, 1 << LayerMask.NameToLayer("Ground"));

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            //anim.SetTrigger(jumpHash);
            jump = true;
            isGrounded = false;
        }
        if (isGrounded)
        {
            anim.ResetTrigger(jumpHash);
        }


    }
    // Update is called once per frame
    void FixedUpdate()
    {

        //float move = GetComponent<Rigidbody2D>().velocity.x;

        // if (isGrounded)//(rb.velocity.y < 0.5f && rb.velocity.y > -0.5f) { 
        //  { 
        float inputHorizontal = Input.GetAxis("Horizontal");
        if (inputHorizontal * rb.velocity.x < maxSpeed)
        {
            rb.AddForce(Vector2.right * inputHorizontal * movementSpeed);
            //if(Input.GetKeyDown(KeyCode.LeftShift))
        }
        if (Mathf.Abs(rb.velocity.x) > maxSpeed)
            rb.velocity = new Vector2(Mathf.Sign(rb.velocity.x) * maxSpeed, rb.velocity.y);
        // rb.velocity += Input.GetAxisRaw("Horizontal") * Vector2.right * movementSpeed * Time.deltaTime + Vector2.up * Time.deltaTime * 0.1f ;
        // rb.velocity += new Vector2(Input.GetAxisRaw("Horizontal") * movementSpeed * Time.deltaTime,rb.velocity.y);

        if (inputHorizontal > 0 && !facingRight)
            Flip();
        else if (inputHorizontal < 0 && facingRight)
            Flip();

        anim.SetFloat("speed", Mathf.Abs(rb.velocity.x));

        if (jump)
        {
            rb.AddForce(new Vector2(0f, jumpForce));
            jump = false;
        }
        //  }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isGrounded = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isGrounded = false;
        }
    }
    void Flip()
    {
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }

}
