using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeOnButtonPress : MonoBehaviour
{
    public void LoadScene(string s_SceneName)
    {
        SceneManager.LoadScene(s_SceneName, LoadSceneMode.Single);
    }
}
