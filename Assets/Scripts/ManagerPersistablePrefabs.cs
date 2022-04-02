using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerPersistablePrefabs : MonoBehaviour
{
    public Transform managerFullscreen;

    void Awake()
    {
#if UNITY_EDITOR
        Debug.unityLogger.logEnabled = true;
#else
        Debug.unityLogger.logEnabled = false;
#endif
        GameObject[] Instances = GameObject.FindGameObjectsWithTag("ManagerFullscreen");
        if (Instances.Length == 0)
        {
            Instantiate(managerFullscreen);
            Debug.Log("Created new ManagerFullscreen instance");
        }

        //Instances = GameObject.FindGameObjectsWithTag("");
    }
}
