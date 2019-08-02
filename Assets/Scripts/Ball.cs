using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "Background")
        {
            if (collision.gameObject.tag == "Heart" || collision.gameObject.tag == "Eye")
                SoundManager.Manager.PlaySound(SoundManager.Manager.heart);
            else if (collision.gameObject.tag == "Paddle")
                SoundManager.Manager.PlaySound(SoundManager.Manager.paddle);
            else
                SoundManager.Manager.PlaySound(SoundManager.Manager.wall);
        }
    }
}
