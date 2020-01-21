using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField]

    Color rayColor = Color.magenta;
    [SerializeField, Range(0.1f, 200f)]

    float rayDistance = 20f;
    [SerializeField]
    LayerMask targetLayer;

    void Update()
    {
        if(rayHit)
        {
            Debug.Log("target touched");
        }
    }

    bool rayHit
    {
        get => Physics.RayCast(transform.position, transform.forward, rayDistance, targetLayer);
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = rayColor;
        Gizmos.DrawRay(transform.position, transform.forward * rayDistance);
    }
}
