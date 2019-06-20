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
            other.gameObject.GetComponent<MeshCollider>().enabled= false;
            other.gameObject.GetComponent<Rigidbody>().useGravity = false;
			other.gameObject.GetComponent<OVRGrabbable>().enabled = false;

            other.transform.localPosition = new Vector3(15.835f, 0.22f, 18.74f);
			other.transform.eulerAngles = new Vector3(-90, 0, -60);
			other.gameObject.isStatic = true;
		}
	}
}
