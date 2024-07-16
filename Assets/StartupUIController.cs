using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartupUIController : MonoBehaviour
{
    public GameObject uiPanel;
    public Button closeButton;

    void Start()
    {
        if (uiPanel != null){
            uiPanel.SetActive(true);
        } else {
            Debug.Log("UI Panel missing");
        }
    }

void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        { HideUIPanel();}
        }
        

    void HideUIPanel(){
        if (uiPanel != null)
   {uiPanel.SetActive(false);}
 } 
}
