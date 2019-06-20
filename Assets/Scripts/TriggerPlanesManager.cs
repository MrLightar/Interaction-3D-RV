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
        if(this.tag == "Trigger1")
        {
            manageCanvas();
        }
        if (this.tag == "Trigger2")
        {
            manageCanvas();
        }
        if (this.tag == "Trigger3" && GameManager.Instance.coffeeMade == false && GameManager.Instance.isToasted == false)
        {
            manageCanvas();
        }
        if (this.tag == "Trigger4" && GameManager.Instance.coffeeMade == false && GameManager.Instance.isToasted == false)
        {
            manageCanvas();
        }
        if (this.tag == "Trigger5" && GameManager.Instance.coffeeMade == true && GameManager.Instance.isToasted == true)
        {
            manageCanvas();
        }
        if (this.tag == "Trigger6" && GameManager.Instance.coffeeMade == true && GameManager.Instance.isToasted == true)
        {
            manageCanvas();
        }
        if (this.tag == "Trigger7" && GameManager.Instance.coffeeMade == true && GameManager.Instance.isToasted == true && GameManager.Instance.toothWash == true)
        {
            manageCanvas();
        }

    }

    private void manageCanvas()
    {
        if (beenActivated == false)
        {
            beenActivated = true;

            foreach (GameObject canvas in activateCanvas)
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
