using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndManager : MonoBehaviour
{
    public GameObject onButton;
    public GameObject offButton;

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
        onButton.SetActive(false);
        offButton.SetActive(true);

    }
}
