using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toasterDetect : MonoBehaviour
{


    public GameObject rightGrabber;
    public GameObject leftGrabber;

    private int toastUsed = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "bread")
        {
            rightGrabber.GetComponent<OVRGrabber>().GrabVolumeEnableUse(true);
            leftGrabber.GetComponent<OVRGrabber>().GrabVolumeEnableUse(true);
            other.gameObject.isStatic = true;
            other.gameObject.GetComponent<Rigidbody>().useGravity = false;
            other.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
            other.gameObject.GetComponent<Rigidbody>().freezeRotation = true;
            other.gameObject.GetComponent<BoxCollider>().enabled = false;

            if (toastUsed == 0)
            {
                other.gameObject.transform.SetPositionAndRotation(new Vector3(16.15f, 2.425f, 14.32f), Quaternion.Euler(90,0,0));

            } else
            {
                other.gameObject.transform.SetPositionAndRotation(new Vector3(16.15f, 2.425f, 14.42f), Quaternion.Euler(90, 0, 0));
                GameManager.Instance.toastPlaced = true;
            }
            
            toastUsed++;
        }
    }

}
