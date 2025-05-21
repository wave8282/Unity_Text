using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class TargetController : MonoBehaviour
{
    Transform playerTR;
    Generatetraget gt;

    // Start is called before the first frame update
    void Start()
    {
        playerTR = GameObject.Find("player").transform;
        gt = GameObject.FindAnyObjectByType<Generatetraget>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(playerTR);
    }


    private void OnCollisionEnter(Collision collision)
     {
        Destroy(gameObject);
        Destroy(collision.gameObject);
        // gt.GenerateTragetObject();
    }
}
