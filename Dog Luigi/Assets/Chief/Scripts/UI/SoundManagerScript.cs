using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{
    public static AudioClip jumpSFX, pauseOn, victorySFX, BGM, itemFound;
    static AudioSource audioSrc;


   public static GameObject Bgm;


    void Start()
    {
        

        pauseOn = Resources.Load<AudioClip>("PauseOn");
        jumpSFX = Resources.Load<AudioClip>("JumpSFX");
        victorySFX = Resources.Load<AudioClip>("VictorySFX");
        itemFound = Resources.Load<AudioClip>("ItemKey");

        
        
        audioSrc = GetComponent<AudioSource>();

        Bgm = GameObject.FindWithTag("BGM");
       
    }

  

    public static void PlayJumpSound()
    {
        audioSrc.PlayOneShot(jumpSFX);
    }

    public static void PlayPauseOn()
    {
        Bgm.SetActive(false);
        audioSrc.PlayOneShot(pauseOn);
        
    }

    public static void VictorySound()
    {
        Bgm.SetActive(false);
        audioSrc.PlayOneShot(victorySFX);
    }
    
    public static void ItemFound()
    {
        audioSrc.PlayOneShot(itemFound);
    }
    

}
