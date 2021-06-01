using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public void LoadTP01Bow()
    {
        PlayerPrefs.SetInt("playing_type",0); //Tir à l'arc
        SceneManager.LoadScene("TP01_Build", LoadSceneMode.Single);
    }

    public void LoadTP01Hunting()
    {
        PlayerPrefs.SetInt("playing_type",1); //Tir à l'arc
        SceneManager.LoadScene("TP01_Build", LoadSceneMode.Single);
    }

    public void loadMainMenu()
    {   
        SceneManager.LoadScene("Menu", LoadSceneMode.Single);
    }
}

