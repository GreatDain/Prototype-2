using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lung : MonoBehaviour
{
    [SerializeField] float _force = 100f;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            other.GetComponent<Rigidbody>().AddForce(transform.right * _force);
        }
    }
}
