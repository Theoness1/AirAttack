using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpitFire : MonoBehaviour
{
    [SerializeField] private int _health;
    [SerializeField] private int _coin;
    [SerializeField] private int _ammo = 50;
    public Score Score;

    private void OnTriggerEnter(Collider other)
    {
        Bomb bomb = other.gameObject.GetComponent<Bomb>();
        if (bomb)
        {
            _health -= 1;
            GameOver();
            bomb.Die();
            bomb.PlayEffect();
        }

        Enemy enemy = other.gameObject.GetComponent<Enemy>();
        if (enemy)
        {
            _health -= 2;
            GameOver();
            enemy.Die();
            enemy.PlayEffect();
        }

        Coin coin = other.gameObject.GetComponent<Coin>();
        if(coin)
        {
            Score.AddCoin();
            coin.Die();
        }

        MedKit medkit = other.gameObject.GetComponent<MedKit>();
        if (medkit)
        {
            _health += 2;

            medkit.Die();
        }

        AmmoBox ammoBox = other.gameObject.GetComponent<AmmoBox>();
        if (ammoBox)
        {
            _ammo += 25;
            ammoBox.Die();
        }
    }

    private void GameOver()
    {
        if(_health <= 0)
            Destroy(gameObject);
    }
}
