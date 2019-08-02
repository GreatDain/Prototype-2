using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EyeBall : MonoBehaviour
{

    [SerializeField] int _Score = 10;
    [SerializeField] int _PlayerSpeedMultierThreshHold = 2;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
            int multi = Mathf.Max(1, (int)col.gameObject.GetComponent<Rigidbody>().velocity.magnitude / _PlayerSpeedMultierThreshHold);
            ScoreManager._ScoreManager.AddScore(_Score, multi);
        }
    }
}
