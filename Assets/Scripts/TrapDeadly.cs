using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapDeadly : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            collision.GetComponent<CharacterHealth>().Kill();
        }
        GetComponent<Collider2D>().isTrigger = false;
    }
}
