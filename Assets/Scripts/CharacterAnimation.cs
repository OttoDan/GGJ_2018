using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimation : MonoBehaviour {
    Animator anim;
    int jumpHash = Animator.StringToHash("jump");
    // Use this for initialization
    public Rigidbody2D rb2d;
	void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        
        float move = Input.GetAxis("Horizontal");
        anim.SetFloat("speed", move*1.0f);
        if (Input.GetButtonDown("Jump"))
        {
            anim.SetTrigger(jumpHash);
        }
	}
}
