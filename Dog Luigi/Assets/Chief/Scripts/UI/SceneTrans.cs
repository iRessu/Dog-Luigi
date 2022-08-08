using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTrans : MonoBehaviour
{
    
    public string sceneName;
    public PlayerMovement Player;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        Player.gameOver = true;
        Invoke("LoadScene", 6);
    }

    void LoadScene()
    {

        SoundManagerScript.VictorySound();
        SceneManager.LoadScene(sceneName);
    }
}
