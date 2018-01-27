using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapTestScript2 : MonoBehaviour {
    public Rigidbody2D rb;
	// Use this for initialization
	void Start () {
        rb.simulated = false;
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        rb.simulated = true;
    }
}
