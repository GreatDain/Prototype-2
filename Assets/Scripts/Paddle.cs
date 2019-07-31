using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{

    [SerializeField] KeyCode _ActivateKey;

    [SerializeField] float _MinAngle;
    [SerializeField] float _MaxAngle;

    Quaternion _ActivatedRotation;
    Quaternion _IdleRotation;

    [SerializeField] float RotationSpeed = 10f;
    [SerializeField] Rigidbody _rigidbody;
    [SerializeField] Transform _forcePostion;

    private void Awake()
    {
        _ActivatedRotation = new Quaternion();
        _ActivatedRotation = Quaternion.Euler(0, 0, _MaxAngle);
        _IdleRotation = new Quaternion();
        _IdleRotation = Quaternion.Euler(0, 0, _MinAngle);
    }

    void Start()
    {
        
    }

    void Update()
    {
        ActivatePaddle();
    }

    void ActivatePaddle()
    {
        Quaternion currentRotation = transform.localRotation;
        if (Input.GetKey(_ActivateKey))
        {
            //transform.localRotation = Quaternion.Slerp(currentRotation, _ActivatedRotation, Time.deltaTime * RotationSpeed);
            _rigidbody.AddForceAtPosition(_forcePostion.up * 1000f, _forcePostion.position);
        }
        else
        {
            //transform.localRotation = Quaternion.Slerp(currentRotation, _IdleRotation, Time.deltaTime * RotationSpeed);
        }
    }
}
