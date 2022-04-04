using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuitToOperatingSystem : MonoBehaviour
{
    public Transform t_ButtonText;

    public void Awake()
    {
#if UNITY_EDITOR || UNITY_WEBGL
    // hides this button in the Unity editor and web exports
    gameObject.SetActive(false);
#endif
#if UNITY_STANDALONE_WIN
    t_ButtonText.GetComponent<Text>().text = "Exit to Windows";
#endif
#if UNITY_STANDALONE_OSX
    t_ButtonText.GetComponent<Text>().text = "Exit to macOS";
#endif
#if UNITY_STANDALONE_LINUX
    t_ButtonText.GetComponent<Text>().text = "Exit to Linux desktop";
#endif
    }

    public void QuitToOS()
    {
        Application.Quit();
    }
}
