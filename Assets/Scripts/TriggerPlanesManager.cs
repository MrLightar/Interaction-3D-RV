using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerPlanesManager : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> activateCanvas;
    [SerializeField]
    private List<GameObject> deactivateCanvas;

    private bool beenActivated = false;

    private void OnTriggerEnter(Collider other)
    {
        if(beenActivated == false)
        {
            beenActivated = true;

            foreach(GameObject canvas in activateCanvas)
            {
                canvas.SetActive(true);
            }

            foreach (GameObject canvas in deactivateCanvas)
            {
                canvas.SetActive(false);
            }
        }
    }
}
