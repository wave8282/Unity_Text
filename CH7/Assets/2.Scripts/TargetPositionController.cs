using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetPositionController : MonoBehaviour
{
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(transform.position, 1.0f);

    }   // Start is called before the first frame update
    
}
