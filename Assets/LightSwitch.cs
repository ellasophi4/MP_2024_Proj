
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch : MonoBehaviour
{
    public GameObject intIcon, lightOn, lightOff, switchOn, switchOff;
    public bool toggle;
    public AudioSource switchSound;


    void OnTriggerEnter(Collider other){


        Debug.Log("Enter");
    }

    void OnTriggerStay(Collider other)
    {

        Debug.Log("Stay");

        if (other.CompareTag("MainCamera"))
        {
            intIcon.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                if(toggle == true)
                {
                    lightOn.SetActive(true);
                    lightOff.SetActive(false);
                    switchOn.SetActive(true);
                    switchOff.SetActive(false);
                    //switchSound.Play();
                }
                if (toggle == false)
                {
                    lightOn.SetActive(false);
                    lightOff.SetActive(true);
                    switchOn.SetActive(false);
                    switchOff.SetActive(true);
                    //switchSound.Play();
                }
            }
        }
    }
    void OnTriggerExit(Collider other)
    {

        Debug.Log("Exit");
        if (other.CompareTag("MainCamera"))
        {
            intIcon.SetActive(false);
        }
    }
}
