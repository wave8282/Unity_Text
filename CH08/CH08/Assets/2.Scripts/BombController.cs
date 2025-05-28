using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class BombController : MonoBehaviour
{
    public float dropSpeed = -0.03f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, dropSpeed, 0);

        if(transform.position.y < -2f)
        {
            Destroy(gameObject);
        }
    }
}
