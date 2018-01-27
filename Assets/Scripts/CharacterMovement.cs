using UnityEngine;

<<<<<<< HEAD
public class CharacterMovement : MonoBehaviour
{

=======
public class CharacterMovement : MonoBehaviour {
    private Rigidbody2D rb;
    public float movementSpeed = 0.1f;
    public float jumpForce = 8f;
    public bool isGrounded = false;
    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D>();

	}
	
	// Update is called once per frame
	void Update () {
        // if (isGrounded)//(rb.velocity.y < 0.5f && rb.velocity.y > -0.5f) { 
        //  { 
        rb.velocity += Input.GetAxisRaw("Horizontal") * Vector2.right * movementSpeed * Time.deltaTime + Vector2.up * 0.05f;
        
            if (Input.GetButtonDown("Jump"))
            {
                rb.velocity += Vector2.up * jumpForce;
            }
      //  }
	}
>>>>>>> 690ad7eeb62955b564eda69ec65538e5e6bf3285


}
