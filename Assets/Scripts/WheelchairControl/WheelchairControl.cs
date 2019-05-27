using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelchairControl : MonoBehaviour
{
    public WheelInfo motorWheel; // the information about each individual axle
    public float maxMotorTorque; // maximum torque the motor can apply to wheel
    public float maxSteeringAngle; // maximum steer angle the wheel can have

    private Rigidbody rb;

    public void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void FixedUpdate()
    {
        float motor = maxMotorTorque * Input.GetAxis("Vertical");
        float steering = maxSteeringAngle * Input.GetAxis("Horizontal");

        //foreach (WheelInfo wheelInfo in wheelInfos)
        //{
        //    if (wheelInfo.steering)
        //    {
        //        wheelInfo.leftWheel.steerAngle = steering;
        //        wheelInfo.rightWheel.steerAngle = steering;
        //    }
        //    if (wheelInfo.motor)
        //    {
        //        wheelInfo.leftWheel.motorTorque = motor;
        //        wheelInfo.rightWheel.motorTorque = motor;
        //    }
        //}
        if(motor != 0)
        {
            motorWheel.rightWheel.motorTorque = motor;
            motorWheel.leftWheel.motorTorque = motor;
        }

        //if(steering > 0)
        //{
        //    motorWheel.rightWheel.motorTorque = steering;
        //}
        //else
        //{
        //    if(steering < 0)
        //    {
        //        motorWheel.leftWheel.motorTorque = steering;
        //    } else
        //    {
        //    }
        //}

        if(Input.GetKeyDown(KeyCode.Space))
        {
            //rb.velocity = Vector3.zero;
            //motorWheel.rightWheel.motorTorque = -motorWheel.rightWheel.motorTorque;
            //motorWheel.leftWheel.motorTorque = -motorWheel.rightWheel.motorTorque;
        }

        
    }
}

[System.Serializable]
public class WheelInfo
{
    public WheelCollider leftWheel;
    public WheelCollider rightWheel;
    public bool motor; // is this wheel attached to motor?
    public bool steering; // does this wheel apply steer angle?
    public bool rightWheelMotor = false;
    public bool leftWheelMotor = false;
}


