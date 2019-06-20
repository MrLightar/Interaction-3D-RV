using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager Instance;

    public bool toastPlaced = false;
    public bool isToasted = false;

    public bool coffeeCupPut = false; 
    public bool coffeeMade = false;

    public bool toothWash = false;

    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
}
