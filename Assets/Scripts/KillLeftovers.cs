using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillLeftovers : MonoBehaviour {

	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Destroy(gameObject);
        }
	}
}
