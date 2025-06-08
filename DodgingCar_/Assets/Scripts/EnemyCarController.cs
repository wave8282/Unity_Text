using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCarController : MonoBehaviour
{
    public float speed = 4f;
    public float resetY = 10f;  // 다시 스폰되는 위치 Y값
    public float destroyY = -10f; // 화면 아래 위치
    public float limitX = 7.5f;

    private GameManager gameManager;

    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();  // GameManager 찾기
    }

    void Update()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);

        if (transform.position.y < destroyY)
        {
            // 점수 1점 추가
            gameManager.AddScore(1);

            // X 위치 랜덤 변경, Y 위치 초기화
            float randomX = Random.Range(-limitX, limitX);
            transform.position = new Vector3(randomX, resetY, 0);
        }
    }
}

