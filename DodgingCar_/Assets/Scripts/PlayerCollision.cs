using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private GameManager gameManager;

    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("EnemyCar"))
        {
            gameManager.LoseLife();

            // 충돌 시 피드백으로 잠깐 플레이어 무적 상태 만들거나 색깔 변화 등 추가 가능
        }
    }
}
