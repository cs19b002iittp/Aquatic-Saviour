using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    [SerializeField]
    private GameObject[] enemyReference;
    private GameObject spawnedEnemy;
    
    [SerializeField]
    private Transform anchorPos, minePos;

    private int randomIndex;
    private int randomSide;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnEnemies());
    }

    // Update is called once per frame

    IEnumerator SpawnEnemies(){
        yield return new WaitForSeconds(Random.Range(1,3)*2);
        randomIndex = 1;
//        Random.Range(0,enemyReference.Length);
        randomSide = Random.Range(0,2);
        //spawnedEnemy = Instantiate(enemyReference[randomIndex]);
        spawnedEnemy = Instantiate(enemyReference[randomIndex]);

        if(randomIndex==0){
            spawnedEnemy.transform.position = anchorPos.position;
            spawnedEnemy.GetComponent<Anchor>().speed = -2f;
        }
        else{
            spawnedEnemy.transform.position = minePos.position;
            spawnedEnemy.GetComponent<Mine>().speed = -2f;
        }
    }
}