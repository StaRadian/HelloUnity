using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootCheck : MonoBehaviour
{
    [SerializeField] private LayerMask groundMask;
    public bool isFoot = false;

    private void OnTriggerStay(Collider collider)
    {
        isFoot = ((1 << collider.gameObject.layer) & groundMask) != 0;
    }
    private void OnTriggerExit(Collider collider)
    {
        if(((1 << collider.gameObject.layer) & groundMask) != 0)
        {
            isFoot = false;
        }
    }
}
