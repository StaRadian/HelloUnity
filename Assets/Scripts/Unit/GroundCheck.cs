using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    [SerializeField] private LayerMask groundMask;
    public bool isGround = false;

    private void OnTriggerStay(Collider collider)
    {
        isGround = ((1 << collider.gameObject.layer) & groundMask) != 0;
    }
    private void OnTriggerExit(Collider collider)
    {
        if(((1 << collider.gameObject.layer) & groundMask) != 0)
        {
            isGround = false;
        }
    }
}
