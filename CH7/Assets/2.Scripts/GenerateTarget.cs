using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Generatetraget : MonoBehaviour
{
    public GameObject targetPrefab;

    Transform[] destinations;

    Transform player;
    float minDistance = 10;
    
    // Start is called before the first frame update
    void Start()
    {
        destinations = GetComponentsInChildren<Transform>();
        Debug.Log("Num of children : " + destinations.Length);
    }

    public void GenerateTargetObject(Vector3 Plate)
    {
        int index;
        Vector3 position;


        do
        {
            index = Random.Range(1, destinations.Length);
            position = destinations[index].position;
        } while (Vector3.Distance(position, player.position) < minDistance);
        
        index = Random.Range(1, destinations.Length);

        GameObject target = Instantiate(targetPrefab, 
            destinations[index].position,
            Quaternion.identity);
        target.transform.SetParent(destinations[index]);

    }

    // Update is called once per frame
}
