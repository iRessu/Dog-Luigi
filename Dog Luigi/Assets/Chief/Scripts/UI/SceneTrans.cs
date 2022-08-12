using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneTrans : MonoBehaviour
{
    
    public string sceneName;
    public PlayerMovement Player;

    GameObject LoadScreen;
    GameObject LoadScreenContainer;

    private void Start()
    {
        LoadScreenContainer = GameObject.FindWithTag("ImageCont");
        LoadScreen = GameObject.FindWithTag("Image");
        LoadScreenContainer.SetActive(false);
        LoadScreen.SetActive(false);

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        Player.gameOver = true;
        SoundManagerScript.VictorySound();
        Invoke("LoadsScreen", 6f);
        Invoke("LoadScene", 8);
    }

    void LoadScene()
    {
        SceneManager.LoadScene(sceneName);
    }

    void LoadsScreen()
    {
        LoadScreenContainer.SetActive(true);
        LoadScreen.SetActive(true);
    }
}
