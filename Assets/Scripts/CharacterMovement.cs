using UnityEngine;

public class CharacterMovement : MonoBehaviour {
    private Rigidbody rb;
    public float movementSpeed = 0.1f;
    public float jumpForce = 8f;
    public bool isGrounded = false;
    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();

	}
	
	// Update is called once per frame
	void Update () {
        if (rb.velocity.y < 0.5f && rb.velocity.y > -0.5f) { 
            rb.velocity += Input.GetAxisRaw("Horizontal") * Vector3.right * movementSpeed;
        
            if (Input.GetButtonDown("Jump"))
            {
                rb.velocity += Vector3.up * jumpForce;
            }
        }
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
