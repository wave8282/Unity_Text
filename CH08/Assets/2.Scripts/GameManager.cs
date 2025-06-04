using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{

    public GameObject timerText;
    public GameObject pointText;

    ItemGenerator generator;

    float time = 30.0f;
    int point = 0;


    // Start is called before the first frame update
    

    public void GetApple()
    {
        point += 100;
       
    }

    public void GetBomb()
    {
        point /= 2;
    }

    void Start()
    {
        generator = GameObject.Find("ItemGenerator").GetComponent<ItemGenerator>();

        
        // this.timerText = GameObject.Find("Time");
    }
    // Update is called once per frame
    void Update()
    {
        this.time -= Time.deltaTime;

        if (time < 0 )
        {
            time = 0;
            generator.SetParameter(10000.0f, 0, 0);
    }
        else if ( 0 < time && time <= 5)
        {
            generator.SetParameter(0.9f, -0.04f, 0.3f);
        }
        else if ( 5 < time && time <= 10)
        {
            generator.SetParameter(0.4f, -0.06f, 0.6f);
        }

        else if ( 10 < time && time <= 20)
        {
            generator.SetParameter(0.7f, -0.04f, 0.4f);
        }
        else if ( 20 < time && time <= 30)
        {
            generator.SetParameter(1.0f, -0.03f, 0.2f);
        }




        this.timerText.GetComponent<TextMeshProUGUI>().text = this.time.ToString("F1");
        pointText.GetComponent<TextMeshProUGUI>().text = point.ToString() + "point";
    }
}
