using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class M_RANDOM : MonoBehaviour
{
    float delayTime = 5f;
    public bool enableSpawn = false;
    public GameObject Enemy; //Prefab을 받을 public 변수 입니다.

    void SpawnEnemy()
    {
        float randomX = Random.Range(-10f, 10f); //적이 나타날 X좌표를 랜덤으로 생성해 줍니다.
        float randomZ = Random.Range(-10f, 10f); //적이 나타날 X좌표를 랜덤으로 생성해 줍니다.
        float randomY = Random.Range(6f, 8f);
        if (enableSpawn)
        {
            GameObject enemy = (GameObject)Instantiate(Enemy, new Vector3(randomX, randomY, randomZ), Quaternion.identity); //랜덤한 위치와, 화면 제일 위에서 Enemy를 하나 생성해줍니다.
        }
    }

    void Start()
    {
        InvokeRepeating("SpawnEnemy", 1.3f, 1); //3초후 부터, SpawnEnemy함수를 1초마다 반복해서 실행 시킵니다.
        InvokeRepeating("SpawnEnemy", 0.8f, 1);
        InvokeRepeating("SpawnEnemy", 1.9f, 1);

    }
    void Update()
    {
        delayTime -= Time.deltaTime;
        if (delayTime <= 0)
        {
            delayTime = 5f;
            InvokeRepeating("SpawnEnemy", 0.6f, 1);
            InvokeRepeating("SpawnEnemy", 0.5f, 1);
        }
    }
  
}