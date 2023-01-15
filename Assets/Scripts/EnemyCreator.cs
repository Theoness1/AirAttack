using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCreator : MonoBehaviour
{
    [SerializeField] private GameObject _enemyPrefab;

    [SerializeField] private float _spawnPeriod = 4;
    private float _timer;
    void Update()
    {
        _timer += Time.deltaTime;
        if(_timer > _spawnPeriod)
        {
            _timer = 0;
            CreateEnemy();
        }
    }

    private void CreateEnemy()
    {
        GameObject newEnemy = Instantiate(_enemyPrefab, transform.position, transform.rotation);
    }
}
