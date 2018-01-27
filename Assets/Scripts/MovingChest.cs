using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingChest : MonoBehaviour {
    public Vector3 scale;
    public Vector3 direction;
    private void Start()
    {
        scale = transform.localScale;
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            direction = transform.position - collision.transform.position;
            direction.Normalize();
            if (Input.GetKey(KeyCode.E))
            {
                transform.position = collision.transform.position+ direction * 2f;
            }
            else
            {
                transform.parent = null;
            }
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            transform.parent = null;
        }
    }
}
