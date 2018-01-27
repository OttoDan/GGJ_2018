using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorPlatform : MonoBehaviour {

    public Transform[] toTransform;
    public float speed = 2.0f;
    public Transform nextTransform;
    public int nexTransformIndex = 0;

	// Use this for initialization
	void OnEnable () {
        nexTransformIndex = 0;
        nextTransform = toTransform[0];
    }
	
	// Update is called once per frame
	void Update () {
        Debug.Log("Distanz:"+Vector3.Distance(transform.position, nextTransform.position));
		if(Vector3.Distance(transform.position,nextTransform.position)< 0.2f)
        {
            nexTransformIndex++;
            if (nexTransformIndex < toTransform.Length)
            {
                nextTransform = toTransform[nexTransformIndex];
            }
            else
            {
                nexTransformIndex = 0;
                nextTransform = toTransform[nexTransformIndex];
            }
        }
        if(nextTransform != null)
        {
            Vector3 directionVelocity = nextTransform.position - transform.position;
            directionVelocity.Normalize();
            transform.Translate(directionVelocity*speed*Time.deltaTime);
        }
	}
}
