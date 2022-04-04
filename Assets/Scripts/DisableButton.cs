using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableButton : MonoBehaviour
{
    public int i_TimeOut;
    public GameObject t_DisabledButton;

    void Start()
    {
        StartCoroutine(UnlockButton());
    }

    IEnumerator UnlockButton()
    {
        while (true)
        {
            yield return new WaitForSeconds(i_TimeOut);
            t_DisabledButton.SetActive(true);
        }
    }
}
