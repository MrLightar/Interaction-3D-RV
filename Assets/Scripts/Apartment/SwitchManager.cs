using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchManager : MonoBehaviour
{
    public List<GameObject> lights;
    public GameObject onButton;
    public GameObject offButton;

    private bool IsOn = false;
    private bool playerIn = false;


    private void Update()
    {
        if (playerIn && (OVRInput.GetDown(OVRInput.Button.Two) || OVRInput.GetDown(OVRInput.Button.Four)))
        {
            SwitchLight();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Hand")
        {
            playerIn = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Hand")
        {
            playerIn = false;
        }
    }

    public void SwitchLight()
    {
        if (IsOn == false)
        {
            foreach (GameObject light in lights)
            {
                light.SetActive(true);
                onButton.SetActive(true);
                offButton.SetActive(false);
            }
        }
        else
        {
            foreach (GameObject light in lights)
            {
                light.SetActive(false);
                onButton.SetActive(false);
                offButton.SetActive(true);
            }
        }

        IsOn = !IsOn;
    }
}
