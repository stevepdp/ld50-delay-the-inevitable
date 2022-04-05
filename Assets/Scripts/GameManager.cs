using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text t_YearsTrying;

    private int i_YearsTrying = 1956;
    private int i_YearsThreshold = 2050;

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

    public void AddYears(int i_YearsToIncrement)
    {
        // Add a year with each shuttle launch
        i_YearsTrying += i_YearsToIncrement;

        // Update canvas readout
        t_YearsTrying.text = "Year: " + i_YearsTrying.ToString();

        // If we haven't backed-up humanity by the next century...
        if (i_YearsTrying == i_YearsThreshold)
        {
            GameOver("99_EndingGood");
        }
    }
}
