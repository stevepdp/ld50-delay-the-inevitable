using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerSFX : MonoBehaviour
{
    public static AudioClip a_Hit;
    public static AudioClip a_Powerup;
    public static AudioClip a_Shoot;

    static AudioSource a_AudioSource;

    void Start()
    {
        a_Hit = Resources.Load<AudioClip>("SFX/hit4");
        a_Powerup = Resources.Load<AudioClip>("SFX/powerup");
        a_Shoot = Resources.Load<AudioClip>("SFX/shoot3");///3, 5
        a_AudioSource = GetComponent<AudioSource>();
    }

    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "hit":
                a_AudioSource.PlayOneShot(a_Hit);
                break;

            case "powerup":
                a_AudioSource.PlayOneShot(a_Powerup);
                break;

            case "shoot":
                a_AudioSource.PlayOneShot(a_Shoot);
                break;
        }
    }
}
