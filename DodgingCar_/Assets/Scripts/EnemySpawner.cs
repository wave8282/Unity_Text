using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;  // 프리팹 연결용 변수
    public int enemyCount = 5;      // 생성할 적 자동차 개수
    public float spawnY = 10f;      // 스폰 높이
    public float limitX = 7.5f;     // X 좌표 제한

    void Start()
    {
        for (int i = 0; i < enemyCount; i++)
        {
            float randomX = Random.Range(-limitX, limitX);
            Vector3 spawnPos = new Vector3(randomX, spawnY + i * 3, 0); // 간격 두고 배치
            Instantiate(enemyPrefab, spawnPos, Quaternion.identity);
        }
    }
}
