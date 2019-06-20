using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvaManager : MonoBehaviour
{
    public Transform playerHead;
    
    void Update()
    {
        transform.LookAt(playerHead);
    }
}
