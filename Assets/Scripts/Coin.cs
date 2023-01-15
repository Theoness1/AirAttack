using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private float _coinYRotationSpeed;
    private void Update()
    {
        transform.Rotate(0, _coinYRotationSpeed * Time.deltaTime, 0);
    }

    public void Die()
    {
        Destroy(gameObject);
    }
}
