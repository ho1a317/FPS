using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiController: MonoBehaviour
{
    [SerializeField]
    private GameObject[] enemyPrefab;
    private GameObject enemy;

    private void Update()
    {
        if(enemy == null)
        {
            int rendEnemy = Random.Range(1, enemyPrefab.Length);

            enemy = Instantiate(enemyPrefab[rendEnemy]) as GameObject;
            enemy.transform.position = new Vector3(0,3,0);

            float angle = Random.Range(0, 360);
            enemy.transform.Rotate(0,angle,0);
        }
    }

}
