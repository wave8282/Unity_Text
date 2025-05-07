using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class ArrowGenarator : MonoBehaviour
{
    public GameObject arrowPrefab;
    float span = 1.0f;
    float delta = 0f;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        delta += Time.deltaTime;
        if(delta > span)
        {
        this.delta = 0;
        GameObject go = Instantiate(arrowPrefab);
        int px = Random.Range(-6, 7);
        go.transform.position = new Vector3Int(px, 7, 0);
        }
    }
}
