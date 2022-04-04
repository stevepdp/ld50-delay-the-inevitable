using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void GameOver(string s_SceneToLoad)
    {
        // Determine which ending scene to transition to
        switch (s_SceneToLoad) {

            case "98_EndingBad":
                SceneManager.LoadScene(s_SceneToLoad);
                break;

            case "99_EndingGood":
                SceneManager.LoadScene(s_SceneToLoad);
                break;

            default:
                break;
        }
    }
}
