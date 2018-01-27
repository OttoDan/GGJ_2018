using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClimbTrigger : MonoBehaviour {
    public Transform destination;
<<<<<<< HEAD
    public bool climb;
=======
    public bool climbing = false;
>>>>>>> 6fbeeb33af7b3f15d0db81e257afddde5578245d
    
    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            if (climbing)
            {
<<<<<<< HEAD

                //collision.transform.position = destination.position;
                collision.GetComponent<Animator>().SetBool("climb", climb);
                climb = true;
                collision.GetComponent<Animator>().Play ("Billy Bob Climb",-1,0f  );

            }
            
=======
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

>>>>>>> 6fbeeb33af7b3f15d0db81e257afddde5578245d
        }
        
    }
    
}
