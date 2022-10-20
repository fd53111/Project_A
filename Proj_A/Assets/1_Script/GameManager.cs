using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private Transform[] enemyZones;
    [SerializeField]
    private GameObject[] monsters;
    [SerializeField]
    private bool istutorial;
    [SerializeField]
    private int maxSpawnMonster;
    [SerializeField]
    private int curSpawnMonster;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (istutorial && curSpawnMonster < maxSpawnMonster)
        {
            StartCoroutine(SpawnEnemy());
        }
            
    } 

    IEnumerator SpawnEnemy()
    {
        //소환될 몬스터
        int ranEnemy = Random.Range(0, 3);
        //소환될 위치
        int ranPoint = Random.Range(0, 4);
        Instantiate(monsters[ranEnemy],
                    enemyZones[ranPoint].position,
                    enemyZones[ranPoint].rotation);
        curSpawnMonster++;

        yield return new WaitForSeconds(2);
    }
    

}
