using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Bomb bomb = other.gameObject.GetComponent<Bomb>();
        Enemy enemy = other.gameObject.GetComponent<Enemy>();

        if (bomb)
        {
            bomb.Die();
            Destroy(gameObject);
            bomb.PlayEffect();
        }

        if(enemy)
        {
            enemy.Die();
            Destroy(gameObject);
            enemy.SpawnMedKitOrAmmo();
            enemy.PlayEffect();
        }
    }

    public void Die()
    {
        Destroy(gameObject);
    }
}
