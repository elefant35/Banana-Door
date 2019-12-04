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
    [SerializeField] private float speed;

    private GameObject gridPositionObject;

    private bool doorOpen = false;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        getPositionObject();
        moveToPosition(gridPositionObject.transform);
        CheckEmptyBelow();
    }
    private void FixedUpdate()
    {
        
    }
    private void moveToPosition(Transform target)
    {
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);
    }

    private void setPositionObject(GameObject gridPosObject)
    {
        if(gridPositionObject != null)
        {
            PositionController positionControllerOld = gridPositionObject.GetComponent<PositionController>();
            positionControllerOld.removeDoor();
        }
        gridPositionObject = gridPosObject;
        PositionController positionController = gridPositionObject.GetComponent<PositionController>();
        positionController.setDoor(gameObject);
    }

    private void getPositionObject()
    {
        GridController gridController = GameObject.Find("Grid").GetComponent<GridController>();
        setPositionObject(gridController.getObjectByPos(positionX, positionY));
    }

    private void CheckEmptyBelow()
    {       
        if (positionX < 7)
        {
            GridController gridController = GameObject.Find("Grid").GetComponent<GridController>();
            if(!gridController.HasDoor(positionX + 1, positionY))
            {
                positionX++;
            }
        }
    }
}
