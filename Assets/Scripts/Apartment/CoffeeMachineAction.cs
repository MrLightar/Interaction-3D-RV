using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoffeeMachineAction : MonoBehaviour
{
    private AudioSource audioSource;
    private bool playerIn;
    private bool actionDone;


    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        actionDone = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (playerIn && (OVRInput.GetDown(OVRInput.Button.Two) || OVRInput.GetDown(OVRInput.Button.Four)))
        {
            if (GameManager.Instance.coffeeCupPut && !actionDone)
            {
                Action();
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

    private void Action()
    {
        audioSource.Play();
        actionDone = true;
        StartCoroutine("makingCoffee");
    }


    IEnumerator makingCoffee()
    {
        yield return new WaitForSeconds(5.5f);
        audioSource.Stop();
        GameManager.Instance.setCoffeeMadeTrue();
    }
}
