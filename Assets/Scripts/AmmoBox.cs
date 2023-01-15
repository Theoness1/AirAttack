using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoBox : MonoBehaviour
{
    [SerializeField] private float _ammoBoxYRotationSpeed;
    [SerializeField] private GameObject _ammoBoxPrefab;

    private void Update()
    {
        transform.Rotate(0f, _ammoBoxYRotationSpeed * Time.deltaTime, 0f);
    }

    public void Die()
    {
        Destroy(gameObject);
    }
}
