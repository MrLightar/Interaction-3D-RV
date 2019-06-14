using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchManager : MonoBehaviour
{
    public List<GameObject> lights;

    private bool IsOn = false;

    private void Start()
    {
        
    }

    private void Update()
    {
        if(true)
        {
            SwitchLight();
        }
    }

    public void SwitchLight()
    {
        if (IsOn == false)
        {
            foreach (GameObject light in lights)
            {
                light.SetActive(true);
            }
        }
        else
        {
            foreach (GameObject light in lights)
            {
                light.SetActive(false);
            }
        }

        
    }
}
