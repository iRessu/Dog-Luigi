using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{
    public static AudioClip jumpSFX, pauseOn, pauseOff;
    static AudioSource audioSrc;

    

    void Start()
    {
        pauseOn = Resources.Load<AudioClip>("PauseOn");
        pauseOff = Resources.Load<AudioClip>("PauseOff");
        jumpSFX = Resources.Load<AudioClip>("JumpSFX");
        audioSrc = GetComponent<AudioSource>();
    }

    public static void PlayJumpSound()
    {
        audioSrc.PlayOneShot(jumpSFX);  
    }

    public static void PlayPauseOn()
    {
        audioSrc.PlayOneShot(pauseOn);
    }
    

}
