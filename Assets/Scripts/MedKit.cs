using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MedKit : MonoBehaviour
{
    [SerializeField] private float _medkitYRotationSpeed;
    [SerializeField] private GameObject _medkitPrefab;

    private void Update() 
    {
        transform.Rotate(0f, _medkitYRotationSpeed * Time.deltaTime, 0f);
    }

    public void SpawnMedKit()
    {
        Instantiate(_medkitPrefab, transform.position, Quaternion.identity);
    }

    public void PlaySound()
    {

    }

    public void Die()
    {
        Destroy(gameObject);
    }
}
