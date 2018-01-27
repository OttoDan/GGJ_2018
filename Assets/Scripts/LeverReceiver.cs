using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverReceiver : MonoBehaviour {
    public bool leverOn = false;
    public MonoBehaviour actionScript;
    private void Start()
    {
        actionScript.enabled = false;
    }
    public void LeverActivated()
    {
        leverOn = true;
        actionScript.enabled = true;
    }
}
