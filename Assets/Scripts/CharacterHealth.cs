using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//REFERENCE https://unity3d.com/de/learn/tutorials/topics/2d-game-creation/creating-basic-platformer-game
public class CharacterHealth : MonoBehaviour
{
    public bool dead = false;
    public GameObject characterPrefab;
    public Transform safeSpot;
    private void Update()
    {
        if (dead)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (safeSpot != null)
                {
                    Instantiate(characterPrefab, safeSpot.position, Quaternion.identity);
                    Destroy(gameObject);
                }
            }
        }
    }
    public void Kill()
    {
        GameObject parent = gameObject;

        Transform[] allChildren = GetComponentsInChildren<Transform>();
        foreach (Transform child in allChildren)
        {
            if(child.gameObject.GetComponent<SpriteRenderer>() != null)
            {
                child.gameObject.AddComponent<BoxCollider2D>();
                child.gameObject.AddComponent<Rigidbody2D>();
                child.gameObject.GetComponent<Rigidbody2D>().velocity += Vector2.up *  Random.Range(2f, 12f);
                child.gameObject.GetComponent<Rigidbody2D>().velocity += Vector2.right * Random.Range(-12f,12f);
                Destroy(GetComponent<CharacterMovement>());
                child.parent = null;
            }
            
        }
        dead = true;
    }
}
