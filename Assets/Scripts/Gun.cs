using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField] private GameObject _bulletPrefab;
    [SerializeField] private float _bulletSpeed;
    [SerializeField] private AudioSource _shotSound;
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            CreateBullet();
        }
    }

    void CreateBullet()
    {
        GameObject newBullet = Instantiate(_bulletPrefab, transform.position, transform.rotation);
        newBullet.GetComponent<Rigidbody>().velocity = transform.forward * _bulletSpeed;
        _shotSound.pitch = Random.Range(0.8f, 1.2f);
        _shotSound.Play();
    }
}
