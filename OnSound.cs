using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnSound : MonoBehaviour
{
    [SerializeField] 
    public Button soundOn;       

    int i;
    
    void Start()
    {
        Button btn = soundOn.GetComponent<Button>();
                btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        i = 1;
        PlayerPrefs.SetInt("sound", i);
        Debug.Log("Работает");
    }
}
