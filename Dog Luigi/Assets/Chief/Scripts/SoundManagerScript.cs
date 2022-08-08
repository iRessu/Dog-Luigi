using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{
    public static AudioClip jumpSFX, pauseOn, pauseOff, victorySFX, BGM;
    static AudioSource audioSrc;

    
    


    void Start()
    {
        pauseOn = Resources.Load<AudioClip>("PauseOn");
        pauseOff = Resources.Load<AudioClip>("PauseOff");
        jumpSFX = Resources.Load<AudioClip>("JumpSFX");
        victorySFX = Resources.Load<AudioClip>("VictorySFX");
        
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

    public static void VictorySound()
    {
        audioSrc.PlayOneShot(victorySFX);
    }
    

}
