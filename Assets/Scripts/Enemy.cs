using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Enemy : MonoBehaviour
{
    [SerializeField] private GameObject _dieEffectPrefab;
    [SerializeField] private float _speed = 15f;
    [SerializeField] private GameObject _enemyPrefab;
    [SerializeField] private GameObject _medkitPrefab;
    [SerializeField] private GameObject _ammoBoxPrefab;
    private GameObject _player;
    private Transform _enemy;

    private void Start()
    {
        _player = GameObject.Find("Spitfire"); // Проблема с родительским объектом, не могу через публичную переменную перенести что-нибудь от этого объекта.
        _enemy = GetComponent<Transform>();
    }

    void Update()
    {
        float step = _speed * Time.deltaTime;
        Vector3 playerPosition = new Vector3(_player.transform.position.x, _player.transform.position.y, 0);
        transform.position = Vector3.MoveTowards(transform.position, playerPosition, step);
        CheckDirectionAndRotateIt(transform.position.x, _player.transform.position.x);
    }

    private void CheckDirectionAndRotateIt(float xPosEnemy, float xPosPlayer)
    {
        if (xPosPlayer < xPosEnemy)
            _enemy.transform.rotation = Quaternion.Euler(0f, -180f, 0);
        else
            _enemy.transform.rotation = Quaternion.Euler(0f, 0f, 0);
    }

    public void SpawnMedKitOrAmmo()
    {
            float randomNumber = (int)Random.Range(0, 8);
            if (randomNumber == 5)
            {
                _medkitPrefab.transform.position = _enemy.position;
                Instantiate(_medkitPrefab);
            }
            else if(randomNumber == 3)
            {
                _ammoBoxPrefab.transform.position = _enemy.position;
                Instantiate(_ammoBoxPrefab);
            }
    }

    public void PlayEffect()
    {
        Instantiate(_dieEffectPrefab, transform.position, Quaternion.identity);
    }

    public void Die()
    {
        Destroy(gameObject);
    }
}
