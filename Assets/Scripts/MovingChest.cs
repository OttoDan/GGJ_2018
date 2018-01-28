using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingChest : MonoBehaviour {
    public Vector3 scale;
    public Vector3 direction;
    public Collider2D wer;
    private void Start()
    {
        scale = transform.localScale;
        wer = GetComponent<Collider2D>();


    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
           
            direction = transform.position - collision.transform.position;
            direction.Normalize();
            if (Input.GetKey(KeyCode.E))
            {
                wer.enabled = false;
                transform.position = collision.transform.position+ direction * 1f;
                
               // gameObject.layer = 11;
            }
            else
            {
                transform.parent = null;
                wer.enabled = true;
              //  gameObject.layer = 9;
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
