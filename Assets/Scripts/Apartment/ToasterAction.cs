using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToasterAction : MonoBehaviour
{
	private AudioSource audioSource;
	private bool playerIn;


	private void Start()
	{
		audioSource = GetComponent<AudioSource>();
	}

	// Update is called once per frame
	void Update()
	{
		if (playerIn && (OVRInput.GetDown(OVRInput.Button.Two) || OVRInput.GetDown(OVRInput.Button.Four))) {
			if (GameManager.Instance.toastPlaced) {
				Action();
			}
		}
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Hand") {
			playerIn = true;
		}
	}

	private void OnTriggerExit(Collider other)
	{
		if (other.tag == "Hand") {
			playerIn = false;
		}
	}

	private void Action()
	{
		audioSource.Play();
		GameManager.Instance.isToasted = true;
	}
}
