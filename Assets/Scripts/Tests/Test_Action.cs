using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_Action : MonoBehaviour
{
	public GameObject prefabTest;

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
		if (other.gameObject.layer == 10) {
			Debug.Log("Touched " + name);		
			if (OVRInput.GetDown(OVRInput.Button.One)) {
				Instantiate(prefabTest);
			}
		}
	}
}
