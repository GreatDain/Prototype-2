using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{

    [SerializeField] public AudioClip wall;
    [SerializeField] public AudioClip paddle;
    [SerializeField] public AudioClip heart;
    [SerializeField] public AudioClip gameOver;

    [SerializeField] AudioSource source;

    public static SoundManager Manager { get; private set; }

    private void Awake()
    {
        if(Manager == null)
            Manager = this;
    }

    public void PlaySound(AudioClip clip)
    {
        source.PlayOneShot(clip);
    }
    
}
