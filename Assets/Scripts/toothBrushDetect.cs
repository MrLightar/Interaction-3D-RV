using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toothBrushDetect : MonoBehaviour
{
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
        if(other.tag == "toothBrush")
        {
            if(!GameManager.Instance.toothWash)
            {
                this.GetComponent<AudioSource>().Play();
                GameManager.Instance.toothWash = true;
            }
            

        }
    }
}
