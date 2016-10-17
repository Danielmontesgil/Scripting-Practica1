using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {


    [SerializeField]
    private EnemyFactory factory;
    private GameObject enemy;
    private float lastCar;

    private void Update()
    {
        if (lastCar < 2)
            GetNewCar();
    }

    private void GetNewCar()
    {
        enemy = factory.BuildEnemy();
        lastCar += 1;
        enemy.transform.position = new Vector3(Random.Range(-9, 8), 0.5f, Random.Range(-10, 31));
    }
}
