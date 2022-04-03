using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManagerGameStateClean : MonoBehaviour
{
    void Start()
    {
#if UNITY_EDITOR
        Debug.unityLogger.logEnabled = true;
#else
        Debug.unityLogger.logEnabled = false;
#endif
        Debug.Log("Init game...");

        GameObject[] Objs = GameObject.FindGameObjectsWithTag("ManagerFullscreen");
        if (Objs.Length > 0)
        {
            Destroy(Objs[0]);
            Debug.Log("Destroyed old fullscreen manager");
        }

        //Objs = GameObject.FindGameObjectsWithTag("");
        /*if (Objs.Length > 0)
        {
            Destroy(Objs[0]);
            Debug.Log("");
        }*/

        // Switch to start menu scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1, LoadSceneMode.Single);
        Debug.Log("Leaving init...");
    }
}
