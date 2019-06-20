using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceMug : MonoBehaviour
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
		if (other.tag == "Mug") {
			other.gameObject.GetComponent<OVRGrabbable>().enabled = false;
			other.gameObject.isStatic = true;

			other.transform.position = new Vector3(15.8f, 20.22f, 18.7f);
			other.transform.eulerAngles = new Vector3(-90, 0, -90);
		}
	}
}
