using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{
    public static AudioClip jumpSFX;
    static AudioSource audioSrc;

    

    void Start()
    {
        jumpSFX = Resources.Load<AudioClip>("JumpSFX");
        audioSrc = GetComponent<AudioSource>();
    }

    public static void PlaySound()
    {
        audioSrc.PlayOneShot(jumpSFX);          
    }
}
