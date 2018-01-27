using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimation : MonoBehaviour {
    Animator anim;
    int jumpHash = Animator.StringToHash("jump");
    // Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        float move = GetComponent<Rigidbody2D>().velocity.x;
        anim.SetFloat("speed", Mathf.Abs(move));
        if (Input.GetButtonDown("Jump") && GetComponent<CharacterMovement>().isGrounded)
        {
            anim.SetTrigger(jumpHash);
        }
	}
    
}
