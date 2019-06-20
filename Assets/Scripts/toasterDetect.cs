using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toasterDetect : MonoBehaviour
{

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
            other.gameObject.isStatic = true;
            if (toastUsed == 0)
            {
                other.gameObject.transform.SetPositionAndRotation(new Vector3(16.15f, 2.325f, 14.35f), Quaternion.Euler(90,0,0));
            } else
            {
                other.gameObject.transform.SetPositionAndRotation(new Vector3(16.15f, 2.325f, 14.45f), Quaternion.Euler(90, 0, 0));
                GameManager.Instance.isToasted = true;
            }
            toastUsed++;
        }
    }

}
