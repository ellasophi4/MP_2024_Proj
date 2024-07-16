using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartupUIController : MonoBehaviour
{
    public GameObject uiPanel;
    void Start()
    {
        if (uiPanel != null){
            uiPanel.SetActive(true);
        } else {
            Debug.Log("UI Panel missing");
        }
    }

}
