using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapTrigger : MonoBehaviour {
    public GameObject Ball;

    private void OnTriggerEnter2D(Collider other)
    {
        Ball.SetActive(true);
    }

    private void Awake()
    {
        Ball.SetActive(false);
    }
}
