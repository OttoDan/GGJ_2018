using UnityEngine;

public class CharacterMovement : MonoBehaviour {
    private Rigidbody rb;
    public float movementSpeed = 0.1f;
    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();

	}
	
	// Update is called once per frame
	void Update () {
        rb.velocity += Input.GetAxis("Horizontal") * Vector3.right * movementSpeed;
	}
}
