using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    [SerializeField] 
    private GameObject choosePanel;
    [SerializeField] 
    private GameObject menuPanel;

	public void ShowPanel (GameObject obj) 
    {
		obj.SetActive(true);
	}

	public void HidePanel (GameObject obj) 
    {
		obj.SetActive(false);
	}
    public void Exit()
    {
        Application.Quit();
    }

}
