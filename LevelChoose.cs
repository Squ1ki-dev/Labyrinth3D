using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelChoose : MonoBehaviour
{
	[SerializeField]
	Button level2B;
    [SerializeField]
	Button level3C;

    int levelComplete;

    void Start()
    {
        levelComplete = PlayerPrefs.GetInt("Level Complete");
        level2B.interactable = false;
        level3C.interactable = false;

        switch (levelComplete)
        {
            case 1:
                level2B.interactable = true;
                break;
            case 2:
                level2B.interactable = true;
                level3C.interactable = true;
                break;
        }
    }

    public void LoadTo(int loadLevel)
    {
        SceneManager.LoadScene(loadLevel);
    }
}
