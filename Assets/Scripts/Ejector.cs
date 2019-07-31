using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejector : MonoBehaviour
{

    private Transform _ball;
    private Rigidbody2D _rb;

    [SerializeField] KeyCode _ejectKey = KeyCode.Space;

    [SerializeField] float _maxForce = 500f;
    [SerializeField] float _minForce = 400f;

    bool ejected = false;

    void Start()
    {
        _ball = FindObjectOfType<Ball>().transform;
        _rb = _ball.GetComponent<Rigidbody2D>();
        RetrieveBall();
    }

    public void RetrieveBall()
    {
        _ball.position = transform.position;
        _ball.rotation = transform.rotation;
        ejected = false;
    }

    void EjectBall()
    {
        if (!ejected)
        {
            if (Input.GetKeyDown(_ejectKey))
            {
                float force = UnityEngine.Random.Range(_minForce, _maxForce);
                _rb.AddForce(Vector2.up * force);
                ejected = true;
            }
            else
            {
                _ball.position = transform.position;
            }
        }
    }

    void Update()
    {
        EjectBall();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        RetrieveBall();        
    }
}
