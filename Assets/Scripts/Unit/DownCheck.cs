using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownCheck : MonoBehaviour
{
    public bool fallDown;
    private void FixedUpdate()
    {
        if(transform.eulerAngles.x < 50)
        {
            if(transform.eulerAngles.z < 50) fallDown = false; 
            else if(transform.eulerAngles.z > 310) fallDown = false;
            else fallDown = true; 
        }
        else if(transform.eulerAngles.x > 310)
        {
            if(transform.eulerAngles.z < 50) fallDown = false; 
            else if(transform.eulerAngles.z > 310) fallDown = false;
            else fallDown = true; 
        }
        else fallDown = true; 
    }
}