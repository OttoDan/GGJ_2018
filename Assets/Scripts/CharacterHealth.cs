using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//REFERENCE https://unity3d.com/de/learn/tutorials/topics/2d-game-creation/creating-basic-platformer-game
public class CharacterHealth : MonoBehaviour
{
    public bool dead = false;
    public GameObject characterPrefab;
    public Transform safeSpot;
    Transform[] allChildren;
    private void Update()
    {
        if (dead)
        {
            if (Input.GetKeyUp(KeyCode.Space))
            {
<<<<<<< HEAD
                Destroy(gameObject);
                respawn();
=======
                
                if (safeSpot != null)
                {
                    GameObject.Instantiate(characterPrefab, safeSpot.position,Quaternion.identity);//, Quaternion.identity);
                    Destroy(gameObject);
                }
>>>>>>> 6fbeeb33af7b3f15d0db81e257afddde5578245d
            }
        }
    }
    public void Kill()
    {
        //GameObject parent = gameObject;
        allChildren = GetComponentsInChildren<Transform>();
        Destroy(GetComponent<playerMoveFinish>());
        foreach (Transform child in allChildren)
        {
            
            if (child.gameObject.GetComponent<SpriteRenderer>() != null)
            {
                
                child.gameObject.AddComponent<BoxCollider2D>();
                child.gameObject.AddComponent<Rigidbody2D>();
                child.gameObject.GetComponent<Rigidbody2D>().velocity += Vector2.up *  Random.Range(2f, 12f);
                child.gameObject.GetComponent<Rigidbody2D>().velocity += Vector2.right * Random.Range(-12f,12f);
<<<<<<< HEAD
               // Destroy(GetComponent<CharacterMovementAnimation>());
=======

>>>>>>> 6fbeeb33af7b3f15d0db81e257afddde5578245d
                child.parent = null;
            }
            else
            {
                child.gameObject.AddComponent<KillLeftovers>();
            }
            
        }
        dead = true;
    }
    private void respawn()
    {
        if (safeSpot != null)
        {
            

            GameObject character = Instantiate(characterPrefab, safeSpot.position, Quaternion.identity);

            GameObject dynamicObjects = GameObject.Find("DynamicObjects");

            //no DynamicObjects? create it!
            if (dynamicObjects == null)
            {
                dynamicObjects = new GameObject("DynamicObjects");
            }

            //parent instantiated object to DynamicObjects gameobject
            character.transform.parent = dynamicObjects.transform.parent;
            dead = false;
        }
    }
    
}
