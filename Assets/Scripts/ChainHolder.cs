using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChainHolder : MonoBehaviour
{
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if (Input.GetKey(KeyCode.E))
            {
                collision.transform.position = transform.position;
            }
        }
    }
}
