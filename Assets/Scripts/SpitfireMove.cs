using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpitfireMove : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private float _constantForceValue = 0.2f;
    [SerializeField] private float _forceValue = 10f;
    [SerializeField] private float _torqueValue;

    private void FixedUpdate()
    {
        _rigidbody.AddForce(transform.forward * _constantForceValue, ForceMode.VelocityChange);

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            _rigidbody.AddForce(transform.forward * _forceValue, ForceMode.VelocityChange);
        }
        float horizontalInput = Input.GetAxis("Horizontal");
        _rigidbody.AddTorque(transform.right * _torqueValue * horizontalInput, ForceMode.VelocityChange);
    }
}
