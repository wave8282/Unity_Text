using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrow2controller : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D other){
    Destroy(gameObject);
   }
}
