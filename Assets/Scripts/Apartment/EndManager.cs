﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndManager : MonoBehaviour
{
    public GameObject onButton;
    public GameObject offButton;

    public GameObject VRCamera;

    private bool playerIn = false;


    private void Update()
    {
        if (playerIn && (OVRInput.GetDown(OVRInput.Button.Two) || OVRInput.GetDown(OVRInput.Button.Four)))
        {
            if (GameManager.Instance.coffeeCupPut &&
                GameManager.Instance.coffeeMade &&
                GameManager.Instance.isToasted &&
                GameManager.Instance.toastPlaced &&
                GameManager.Instance.toothWash)
            {
                RunEnd();
            }
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

    public void RunEnd()
    {
        this.GetComponent<AudioSource>().Play();
        onButton.SetActive(false);
        offButton.SetActive(true);
        VRCamera.GetComponent<OVRScreenFade>().FadeOut();
        StartCoroutine("Waitingend");
        

    }

    IEnumerator Waitingend()
    {
        yield return new WaitForSeconds(5.0f);
        Debug.Log("mal a la main");
        Application.Quit();
    }
}
