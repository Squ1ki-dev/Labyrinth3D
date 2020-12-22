using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{
    public static LevelController instance = null;
    int sceneIndex;
    int levelComplete;

    void Start()
    {
        if(instance == null)
        {
            instance = this;
        }
        sceneIndex = SceneManager.GetActiveScene().buildIndex;
        levelComplete = PlayerPrefs.GetInt("Level Complete");
    }

    public void IsEndGame()
    {
        if(sceneIndex == 3)
        {
            Invoke("Load Main Menu", 1f);
        }
        else
        {
            if(levelComplete < sceneIndex)
                PlayerPrefs.SetInt("LevelComplete", sceneIndex);
            Invoke("Next Level", 1f);
        }
    }

    public void NextLevel()
    {
        SceneManager.LoadScene(sceneIndex + 1);
    }
}
