using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveHandPush : MonoBehaviour
{
	public GameObject LeftHand;
	public GameObject RightHand;

	public float threshold = 0.2f;

	private CapsuleCollider LHColl;
	private CapsuleCollider RHColl;

	// Start is called before the first frame update
	void Start()
    {
		LHColl = LeftHand.GetComponent<CapsuleCollider>();
		RHColl = RightHand.GetComponent<CapsuleCollider>();
    }

    // Update is called once per frame
    void Update()
    {
		float trigger = OVRInput.Get(OVRInput.Axis1D.PrimaryIndexTrigger) + OVRInput.Get(OVRInput.Axis1D.SecondaryIndexTrigger);

		if (trigger > threshold) {
			LHColl.enabled = true;
			RHColl.enabled = true;
		} else {
			LHColl.enabled = false;
			RHColl.enabled = false;
		}
    }
}
