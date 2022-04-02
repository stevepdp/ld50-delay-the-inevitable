using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartWindowed : MonoBehaviour
{
    private void Awake()
    {
        Screen.fullScreen = false;
    }
}
