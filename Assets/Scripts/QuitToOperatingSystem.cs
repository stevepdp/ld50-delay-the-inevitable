using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuitToOperatingSystem : MonoBehaviour
{
    public Transform buttonText;

    public void Awake()
    {
#if UNITY_EDITOR || UNITY_WEBGL
        gameObject.SetActive(false);
#endif
#if UNITY_STANDALONE_WIN
    buttonText.GetComponent<Text>().text = "Exit to Windows";
#endif
#if UNITY_STANDALONE_OSX
    buttonText.GetComponent<Text>().text = "Exit to macOS";
#endif
#if UNITY_STANDALONE_LINUX
    buttonText.GetComponent<Text>().text = "Exit to Linux desktop";
#endif
    }

    public void QuitToOS()
    {
        Application.Quit();
    }
}
