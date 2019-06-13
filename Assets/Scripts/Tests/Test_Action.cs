using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_Action : MonoBehaviour
{
	public GameObject prefabTest;
	private bool playerIn;


	private void Update()
	{
		if (playerIn && (OVRInput.GetDown(OVRInput.Button.One) || OVRInput.GetDown(OVRInput.Button.Three))) {
			Instantiate(prefabTest);
		}
	}

	private void OnTriggerEnter(Collider other)
	{
		playerIn = true;
	}

	private void OnTriggerExit(Collider other)
	{
		playerIn = false;
	}
}
