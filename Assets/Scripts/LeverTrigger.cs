using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverTrigger : MonoBehaviour {
    public bool On = false;
    public Transform HandTransform;
   // public GameObject relatedObject;
    public LeverReceiver leverReceiver;
    private void Start()
    {
        
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                On = true;
                leverReceiver.LeverActivated();
            }
        }
    }
}
