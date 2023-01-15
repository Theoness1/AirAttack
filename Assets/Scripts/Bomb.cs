using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    [SerializeField] private GameObject _dieEffectPrefab;
    public void Die()
    {
        Destroy(gameObject);
    }
    public void PlayEffect()
    {
        Instantiate(_dieEffectPrefab, transform.position, Quaternion.identity);
    }
}
