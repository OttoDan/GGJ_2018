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
                
                if (safeSpot != null)
                {
                    GameObject.Instantiate(characterPrefab, safeSpot.position,Quaternion.identity);//, Quaternion.identity);
                    Destroy(gameObject);
                }
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

                child.parent = null;
            }
            else
            {
                child.gameObject.AddComponent<KillLeftovers>();
            }
            
        }
        dead = true;
    }
}
