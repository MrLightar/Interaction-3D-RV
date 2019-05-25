﻿using UnityEngine;
using System.Collections;

[RequireComponent(typeof (CharacterController))]
public class WheelchairController : MonoBehaviour {

	public float moveSpeed = 0.65f;

	[SerializeField] private float turnSpeed = 2.5f;
	[SerializeField] private float slopeResistance = 25;
	[SerializeField] private float stickToGroundForce = 10;
    [SerializeField] private Rigidbody rightWheel;
    [SerializeField] private Rigidbody leftWheel;

    private CharacterController cc;

	private Vector3 velocity;


	// Use this for initialization
	void Start () {
		cc = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {

        //transform.Rotate(0, Input.GetAxis("Horizontal") * turnSpeed, 0);

        //Vector3 desiredMove = transform.forward * Input.GetAxis("Vertical") * moveSpeed;

        //RaycastHit hitInfo;
        //Physics.SphereCast(transform.position, cc.radius, Vector3.down, out hitInfo, cc.height / 2f);
        //desiredMove = Vector3.ProjectOnPlane(desiredMove, hitInfo.normal);

        //// Slide down slopes
        //float hitAngle = Vector3.Angle(hitInfo.normal, Vector3.up);
        //float slopeEffect = Mathf.Clamp01((hitAngle - slopeResistance) / cc.slopeLimit);
        //Vector3 slideForce = new Vector3(hitInfo.normal.x, -hitInfo.normal.y, hitInfo.normal.z) * slopeEffect;
        //velocity += Physics.gravity * Time.deltaTime;

        //cc.Move((velocity + desiredMove + slideForce) * Time.deltaTime);


        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");



        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        Debug.Log(movement);
        rightWheel.AddForce(movement * 100.0f);
        leftWheel.AddForce(movement * 100.0f);
    }

}
