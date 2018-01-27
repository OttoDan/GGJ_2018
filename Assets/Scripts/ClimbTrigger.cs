using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClimbTrigger : MonoBehaviour {
    public Transform destination;
    public bool climbing = false;
    
    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            if (climbing)
            {
                Debug.Log(collision.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).length);
                collision.GetComponent<Animator>().SetBool("climb", false);
                
                if (collision.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).length > 1.1f
                    )
                {
                    // collision.transform.position = destination.position;
                    climbing = false;
                }
            }
            else if (Input.GetKeyDown(KeyCode.E))
            {
                collision.GetComponent<Rigidbody2D>().AddForce(Vector2.up*12f);
                collision.GetComponent<Animator>().SetBool("climb",true);
                //collision.GetComponent<Animator>().Play("climb", -1, 0f);
                climbing = true;
            }

        }
    }
}
