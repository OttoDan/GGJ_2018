using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClimbTrigger : MonoBehaviour {
    public Transform destination;
    public bool climb;
    
    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            if (Input.GetKey(KeyCode.E))
            {

                //collision.transform.position = destination.position;
                collision.GetComponent<Animator>().SetBool("climb", climb);
                climb = true;
                collision.GetComponent<Animator>().Play ("Billy Bob Climb",-1,0f  );

            }
            
        }
        
    }
    
}
