using UnityEngine;
using System.Collections;

public class RestrictLook: MonoBehaviour {

	[SerializeField] float sensitivity = 5f;
	[SerializeField] float minX = -50f;
	[SerializeField] float maxX = +50f;
    [SerializeField] float minY = -90f;
    [SerializeField] float maxY = +90f;



    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		float rotY = Input.GetAxis ("Mouse Y") * sensitivity;
        float rotX = Input.GetAxis("Mouse X") * sensitivity;

		transform.Rotate(-rotY, rotX, 0f);

		//transform.localRotation = ClampRotationAroundXAxis(transform.localRotation);

		//Quaternion.Euler (new Vector3(Mathf.Clamp(transform.localRotation.x, minX, maxX), 0, 0));
	}

	Quaternion ClampRotationAroundXAxis(Quaternion q)
	{
		q.x /= q.w;
		q.y /= q.w;
		q.z /= q.w;
		q.w = 1.0f;
		
		float angleX = 2.0f * Mathf.Rad2Deg * Mathf.Atan (q.x);		
		angleX = Mathf.Clamp (angleX, minX, maxX);

        float angleY = 2.0f * Mathf.Rad2Deg * Mathf.Atan(q.y);
        angleY = Mathf.Clamp(angleY, minY, maxY);

        q.x = Mathf.Tan (0.5f * Mathf.Deg2Rad * angleX);
        q.y = Mathf.Tan(0.5f * Mathf.Deg2Rad * angleY);

        return q;
	}
}
