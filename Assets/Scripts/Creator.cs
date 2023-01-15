using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creator : MonoBehaviour
{
    public GameObject CoinPrefab;
    public GameObject BombPrefab;
    public GameObject MedKitPrefab;

    // сделать настраиваемый спавн префабов и просто рандомное их расположение.

    private void Start()
    {
        for (int i = 0; i < 40; i++)
        {
                Vector3 position = new Vector3(Random.Range(-200f, 200f), Random.Range(-50f, 50f), 0f);

                if(Random.Range(0, 2) == 0)
                {
                    Instantiate(BombPrefab, position, Quaternion.identity);
                }
                else
                {
                    Instantiate(CoinPrefab, position, Quaternion.identity);
                }
        }
    }
}
