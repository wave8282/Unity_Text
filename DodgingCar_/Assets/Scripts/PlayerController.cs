using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10f;
    public float limitX = 7.5f; // 좌우 이동 제한 (화면 끝 경계)

    void Update()
    {
        float h = Input.GetAxis("Horizontal");  // 좌우 화살표 or A/D 키 입력
        Vector3 pos = transform.position;
        pos.x += h * speed * Time.deltaTime;   // 이동 처리
        pos.x = Mathf.Clamp(pos.x, -limitX, limitX);  // 화면 밖으로 나가지 않도록 제한
        transform.position = pos;
    }
}

