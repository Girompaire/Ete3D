using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public void LoadTP01()
    {
        SceneManager.LoadScene("TP01_Build", LoadSceneMode.Single);
    }
}

