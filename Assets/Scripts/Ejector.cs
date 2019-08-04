﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejector : MonoBehaviour
{

    private Transform _ball;
    private Rigidbody _rb;

    [SerializeField] KeyCode _ejectKey = KeyCode.Space;

    [SerializeField] float _maxForce = 500f;
    [SerializeField] float _minForce = 400f;

    bool ejected = false;

    void Start()
    {
        _ball = FindObjectOfType<Ball>().transform;
        _rb = _ball.GetComponent<Rigidbody>();
        RetrieveBall();
    }

    public void RetrieveBall()
    {
        ScoreManager._ScoreManager.ResetScore();
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
                _rb.velocity = Vector3.zero;
                _rb.AddForce(transform.up * force);
                ejected = true;
            }
            else
            {
                _ball.position = transform.position;
                _ball.rotation = transform.rotation;
            }
        }
    }

    void Update()
    {
        EjectBall();
    }

    private void OnTriggerEnter(Collider collision)
    {
        RetrieveBall();        
    }
}
