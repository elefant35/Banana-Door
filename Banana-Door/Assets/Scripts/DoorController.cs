using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    //Declare User controlled variables
    [SerializeField] private int bananaValue; //typically 1-4 depending on door

    //Declare Code Controlled Variables
    [SerializeField] private int positionX; //used to keep track of the x position of the door on the grid//unserialize this field
    [SerializeField] private int positionY; //used to keep track of the y position of the door on the grid//unserialize this field

    private bool doorOpen = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
