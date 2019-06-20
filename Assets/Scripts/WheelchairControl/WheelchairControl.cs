using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelchairControl : MonoBehaviour
{

    public bool vrControl = false;

    public float velocityTweak = 100.0f;

    public GameObject rightHand;
    public GameObject leftHand;

    public GameObject rightWheel;
    public GameObject leftWheel;

    private Rigidbody rb;

    public void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void FixedUpdate()
    {
        Vector3 forceRight = new Vector3();
        Vector3 forceLeft = new Vector3();
        if (!vrControl)
        {
            float rightForce = Input.GetAxis("Vertical");
            float leftForce = Input.GetAxis("Horizontal");
            
            if (rightForce != 0)
            {
                forceRight = transform.forward * 50.0f * rightForce;
                rb.AddForceAtPosition(new Vector3(forceRight.x, 0, forceRight.z), new Vector3(rightWheel.transform.position.x, rb.position.y, rightWheel.transform.position.z));
                Debug.DrawRay(rightWheel.transform.position, forceRight, Color.blue);
            }
            if (leftForce != 0)
            {
                forceLeft = transform.forward * 50.0f * leftForce;
                rb.AddForceAtPosition(forceLeft, leftWheel.transform.position);

                Debug.DrawRay(leftWheel.transform.position, forceLeft, Color.red);
            }

        } else
        {
            Vector3 rightLocalVelocity = transform.InverseTransformDirection(rightHand.GetComponent<Rigidbody>().velocity);
            Vector3 leftLocalVelocity = transform.InverseTransformDirection(leftHand.GetComponent<Rigidbody>().velocity);
            //Debug.Log("right : " + rightHand.GetComponent<Rigidbody>().velocity);
            //Debug.Log("left : " + leftHand.GetComponent<Rigidbody>().velocity);
            //main droite
            if (OVRInput.Get(OVRInput.Button.One))
            {
                forceRight = transform.forward * velocityTweak * rightLocalVelocity.z;
                rb.AddForceAtPosition(new Vector3(forceRight.x, 0, forceRight.z), new Vector3(rightWheel.transform.position.x, rb.position.y, rightWheel.transform.position.z));
            }
            //main gauche
            if (OVRInput.Get(OVRInput.Button.Three))
            {
                forceLeft = transform.forward * velocityTweak * leftLocalVelocity.z;
                rb.AddForceAtPosition(new Vector3(forceLeft.x, 0, forceLeft.z), new Vector3(leftWheel.transform.position.x, rb.position.y, leftWheel.transform.position.z));
            }
            rb.velocity.Set(rb.velocity.x,0, rb.velocity.z) ;
        }

       // this.transform.localRotation = Quaternion.Euler(0, this.transform.localRotation.eulerAngles.y, 0);



    }
}



