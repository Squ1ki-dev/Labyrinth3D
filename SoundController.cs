using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    [SerializeField] 
    public GameObject soundController;

    int i;

    void Start()
    {
        i = PlayerPrefs.GetInt("sound", i);

        if(i == 1)
        {
            soundController.SetActive(true);
        }    
        if(i == 0)
        {
            soundController.SetActive(false);
        }
    }

    void Update()
    {
        i = PlayerPrefs.GetInt("sound", i);

        if(i == 1)
        {
            soundController.SetActive(true);
        }    
        if(i == 0)
        {
            soundController.SetActive(false);
        }
    }
}
