using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.WSA;

public class ItemGenerator : MonoBehaviour
{
    public GameObject applePrefab;
    public GameObject bombPrefab;
    float bombRatio = 0.2f;


    float span = 1f;
    float speed = -0.03f;
    float delta = 0f;

public void SetParameter(float span, float speed, float bombratio)
{
    this.span = span;
    this.speed = speed;
    this.bombRatio = bombratio;
}


    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        delta += Time.deltaTime;
        if (delta > span)
        {
            delta = 0;
            GameObject item;
            float dice = Random.Range(0f, 1f);
            if (dice < bombRatio)
            {
                  item = Instantiate(applePrefab, transform.position,
                                                    transform.rotation);
            }
            else
            {
                 item = Instantiate(applePrefab, transform.position,
                                                    transform.rotation);
            }
            float x = Random.Range(-1, 2);
            float z = Random.Range(-1, 2);
            item.transform.position = new Vector3(x, transform.position.y, z);
            item.GetComponent<ItemController>().dropSpeed = speed;


        }
    }
}

