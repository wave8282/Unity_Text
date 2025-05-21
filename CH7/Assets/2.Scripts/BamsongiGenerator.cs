using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.WSA;

public class BamsongiGenerator : MonoBehaviour
{
    public GameObject bamsongiPrefab;
    float power = 0f;
    float startVal = 0f;
    public float throwforce = 10;



    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            startVal = Input.mousePosition.y;
        }
        if(Input.GetMouseButtonUp(0))
        {
            power = Input.mousePosition.y - startVal;
            GameObject bamsongi = Instantiate(bamsongiPrefab,transform.position,
                transform.rotation);
            
            bamsongi.transform.position = new Vector3(transform.position.x,
                                                        transform.position.y + 1,
                                                        transform.position.z + 1);

                                                        

            //Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            //Vector3 worldDir = ray.direction;
            
            // bamsongi.GetComponent<BamsongiController>(). Shoot(new Vector3(0, 200, 2000));
            //bamsongi.GetComponent<BamsongiController>().Shoot(worldDir.normalized * 2000);
            bamsongi.GetComponent<BamsongiController>().
                Shoot((transform.forward + transform.up) *  power * throwforce);


        }
    }
}
