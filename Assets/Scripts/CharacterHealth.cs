using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterHealth : MonoBehaviour {

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
                child.parent = null;

            }
            
        }

        //for(int i=0; i< transform.childCount; i++)
        //{
        //    transform.GetChild(i).gameObject.AddComponent<BoxCollider2D>();
        //    transform.GetChild(i).gameObject.AddComponent<Rigidbody2D>();
        //}
        //Transform[] allChildren = GetComponentsInChildren<Transform>();
        //foreach (Transform child in allChildren)
        //{
        //    child.gameObject.AddComponent<BoxCollider2D>();
        //    child.gameObject.AddComponent<Rigidbody2D>();
        //}
        //foreach (Transform child in transform)
        //{
        //    child.gameObject.AddComponent<BoxCollider2D>();
        //    child.gameObject.AddComponent<Rigidbody2D>();
        //}
        //Destroy(gameObject);
    }
}
