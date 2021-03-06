using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerFullscreen : MonoBehaviour
{
    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (Screen.fullScreen)
            {
                Screen.SetResolution(640, 360, false);
            }
            else
            {
                Screen.SetResolution(Screen.currentResolution.width, Screen.currentResolution.height, true);
            }
        }
    }
}
