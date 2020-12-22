using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OffSound : MonoBehaviour
{
    [SerializeField] 
    public Button soundOff;       

    int i;

    void Start()
    {
        Button btn = soundOff.GetComponent<Button>();
                btn.onClick.AddListener(TaskOffClick);
    }

    void TaskOffClick()
    {
        i = 0;
        PlayerPrefs.SetInt("sound", i);
        Debug.Log("Не робит");
    }
}
