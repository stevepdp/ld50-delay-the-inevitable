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
        if (Input.GetKey(KeyCode.LeftAlt) && Input.GetKeyDown(KeyCode.Return))
        {
            if (Screen.fullScreen)
            {
                Screen.SetResolution(640, 460, false);
            }
            else
            {
                Screen.SetResolution(Screen.currentResolution.width, Screen.currentResolution.height, true);
            }
        }
    }
}
