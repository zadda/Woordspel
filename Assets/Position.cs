using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Position : MonoBehaviour 
{
    [SerializeField]
    bool isFree;

    void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, 40);
    }
}