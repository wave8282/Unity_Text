using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BamsongiController : MonoBehaviour
{
    public void Shoot(Vector3 dir)
    {
        GetComponent<Rigidbody>().AddForce(dir);
    }
    // Start is called before the first frame update

    // Update is called once per frame
    void OnCollisionEnter(Collision other) 
    {
        GetComponent<Rigidbody>().isKinematic = true;
        GetComponent<ParticleSystem>().Play();
    }
    public void Start()
    {
        Application.targetFrameRate = 60;
        
        Shoot(new Vector3(0, 200, 2000));
    }
}
