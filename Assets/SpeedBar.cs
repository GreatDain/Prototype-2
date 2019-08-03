using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBar : MonoBehaviour
{

    [SerializeField] float _force = 50f;
    [SerializeField] bool _perSecond = false;
    [SerializeField] float timeBetween = 0.5f;

    private float nextTrigger = 0;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            other.GetComponent<Rigidbody>().AddForce(transform.up * _force);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (_perSecond)
        {
            if (other.gameObject.tag == "Player" && Time.timeSinceLevelLoad > nextTrigger)
            {
                other.GetComponent<Rigidbody>().AddForce(transform.up * _force);
                nextTrigger = Time.timeSinceLevelLoad + timeBetween;
            }
        }
    }
}
