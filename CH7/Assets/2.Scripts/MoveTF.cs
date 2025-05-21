using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTF : MonoBehaviour
{
    public float moveSpeed = 1f;
    public float rotationSpeed = 1f;
    // Start is called before the first frame update
   

    // Update is called once per frame
    void Update()
    {
        float xInput = Input.GetAxis("horizontal");
        float zInput = Input.GetAxis("Vertical");

        float move = zInput * moveSpeed * Time.deltaTime;
        float rotate = xInput * rotationSpeed * zInput;
        transform.Translate(0, 0, move);
    }
}