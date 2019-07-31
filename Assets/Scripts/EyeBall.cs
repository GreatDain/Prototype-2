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

    private void OnTriggerEnter(Collider col)
    {
        int multi = Mathf.Max(1,(int)col.GetComponent<Rigidbody>().velocity.magnitude / _PlayerSpeedMultierThreshHold);
        ScoreManager._ScoreManager.AddScore(_Score, multi);
    }
}
