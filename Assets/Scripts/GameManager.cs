using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{

    public static GameManager Instance;

    public bool toastPlaced = false;
    public bool isToasted = false;

    public bool coffeeCupPut = false;
    public bool coffeeMade = false;

    public bool toothWash = false;

    private AudioSource[] audiosources;
    public GameObject VRCamera;

    public GameObject[] breadSlice = new GameObject[2];

    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
        audiosources = GetComponents<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void setCoffeeMadeTrue()
    {
        coffeeMade = true;
        if (isToasted == true)
        {
            FadeBreakfirst();
        }
    }

    public void setIsToastedTrue()
    {
        isToasted = true;
        if (coffeeMade == true)
        {
            FadeBreakfirst();
        }
    }

    public void FadeBreakfirst()
    {
        audiosources[0].Play();
        VRCamera.GetComponent<OVRScreenFade>().FadeOut();
        StartCoroutine("SecondSound");

    }



    IEnumerator SecondSound()
    {
        yield return new WaitForSeconds(3.5f);
        breadSlice[0].SetActive(false);
        breadSlice[1].SetActive(false);
        audiosources[1].Play(4);
        VRCamera.GetComponent<OVRScreenFade>().FadeIn();
    }


}
