using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowControler : MonoBehaviour
{
    public float movestep = 1f;
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        player = GameObject.Find("player");
    }

    // Update is called once per frame
    void Update()
    {   
        // 프레임마다 등속으로 낙하
        transform.Translate(0, - 0.1f, 0);

        // 화면 밖으로 나오면 오브젝트를 삭제
        if (transform.position.y < -5.0f)
        {
            Destroy(gameObject);
        }

        // 충돌 판정
        Vector2 p1 = transform.position;
        Vector2 p2 = this.player.transform.position;
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float r1 = 0.5f;
        float r2 = 1.0f;

        if (d < r1 + r2)
        {
            // 충돌한 경우는 화살을 지움
            GameObject gd = GameObject.Find("GameDirector");
            gd.GetComponent<GameDirector>().DecreasHp();
            
            Destroy(gameObject);
        }
    }
}
