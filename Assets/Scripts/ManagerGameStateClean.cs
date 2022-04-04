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

        // Find an old persisting instance and destroy it so that we can start anew
        GameObject[] o_GameObjects = GameObject.FindGameObjectsWithTag("ManagerFullscreen");
        if (o_GameObjects.Length > 0)
        {
            Destroy(o_GameObjects[0]);
            Debug.Log("Destroyed old fullscreen manager");
        }

        // With the old game cleared up...proceed to the start menu
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1, LoadSceneMode.Single);
        Debug.Log("Leaving init...");
    }
}
