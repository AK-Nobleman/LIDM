using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float timeScaleIncrease = 2.0f;
    public Boolean onColl =false;
    public GameObject Player;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q) && onColl == true)
        {
            TimeManager.Instance.skipTimeStamp();
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Player")
        {
            onColl = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        onColl = false;
    }
}
