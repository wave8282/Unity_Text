using System.Collections;
using System.Collections.Generic;
using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    public GameObject hpGuage;
    // Start is called before the first frame update
    void Start()
    {
        //hpGuage = GameObject.Find("Hp Guage");
    }

    // Update is called once per frame
    public void DecreasHp()
    {
        hpGuage.GetComponent<Image>().fillAmount -= 0.1f;
    }
}
