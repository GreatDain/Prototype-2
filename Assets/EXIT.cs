﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class EXIT : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape)) {

            SceneManager.LoadScene(2);

        }

        if (Input.GetKey(KeyCode.R)) {

            SceneManager.LoadScene(1);
        }

        if (Input.GetKey(KeyCode.Backspace)) {
            SceneManager.LoadScene("Menu");

        }
    }
}