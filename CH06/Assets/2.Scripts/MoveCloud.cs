using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCloud : MonoBehaviour
{
    public float moveSpeed = 0.05f;
    public float maxWidth = 10f;

    int direction = 1;



    // Update is called once per frame
    void Update()
    {
        if(transform.position.x > maxWidth)
        {
            direction = -1;
        }
        if(transform.position.x < maxWidth)
        {
            direction = 1;
        }
    }
}
