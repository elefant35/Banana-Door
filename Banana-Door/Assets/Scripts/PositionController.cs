using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class PositionController : MonoBehaviour
{
    //Declare User controlled variables
    [SerializeField] private int positionX; //new/current horizontal position of the spot on the grid
    [SerializeField] private int positionY; //new/current vertical position of the spot on the grid
    
    private GameObject[] adjacentObjects = new GameObject[9];

    //Declare code controlled variables
    [SerializeField] private GameObject currentDoor;

    private bool hasDoor;

    //Below is used to ensure grids are marked as NULL after the position on the grid is changed
    //[SerializeField] private int prevPositionX; //previous/current horizontal position of the spot on the grid DESERIALIZE
    //[SerializeField] private int prevPositionY; //previous/current horizontal position of the spot on the grid DESERIALIZE

    //test variables
    // Start is called before the first frame update
    void Start()
    {
        //get grid controller
        //prevPositionX = positionX;
        //prevPositionY = positionY;
        GridController gridController = GameObject.Find("Grid").GetComponent<GridController>();
        gridController.setPositionOnGrid(positionX, positionY,gameObject); //sets the position of the grid object on the grid   
    }

    // Update is called once per frame
    void Update()
    {
        GridController gridController = GameObject.Find("Grid").GetComponent<GridController>();
        gridController.setPositionOnGrid(positionX, positionY, gameObject); //sets the position of the grid object on the grid  
        getAndSetAdjacentObjects();   //this probably shouldn't be in update it should be used right before adjacent objects are used

    }
    
    public int getPositionX()
    {
        return positionX;
    }

    public int getPositionY()
    {
        return positionY;
    }

    private void getAndSetAdjacentObjects()
    {
        /*0 1 2
         *3   5
         *6 7 8
         */
        GridController gridController = GameObject.Find("Grid").GetComponent<GridController>();

        //get lower objects
        if (positionY -1 >= 0) //make sure the upper adjacent objects are not out of grid bounds
        {
            if(positionX -1 >= 0)
            {
                //getUpperLeft
                adjacentObjects[0] = gridController.getObjectByPos(positionX -1, positionY - 1);
            }
            if (positionX + 1 <= 7)
            {
                //getUpperRight
                adjacentObjects[2] = gridController.getObjectByPos(positionX + 1, positionY - 1);
            }
            

            //getUpperCenter
            adjacentObjects[1] = gridController.getObjectByPos(positionX, positionY - 1); 
           
        }
        else
        {
            adjacentObjects[0] = null;
            adjacentObjects[1] = null;
            adjacentObjects[2] = null;
        }
        //get mid objects
        if (positionX - 1 >= 0)
        {
            //getMidLeft
            adjacentObjects[3] = gridController.getObjectByPos(positionX - 1, positionY);
        }
        else
        {
            adjacentObjects[3] = null;
        }
        if (positionX + 1 <= 7)
        {
            //getMidRight
            adjacentObjects[5] = gridController.getObjectByPos(positionX + 1, positionY);
        }
        else
        {
            adjacentObjects[5] = null;
        }
  
        //get lower objects
        if (positionY + 1 <= 7) //make sure the lower adjacent objects are not out of grid bounds
        {
            if (positionX - 1 >= 0)
            {
                //getLowerLeft
                adjacentObjects[6] = gridController.getObjectByPos(positionX - 1, positionY + 1);
            }
            if (positionX + 1 <= 7)
            {
                //getLowerRight
                adjacentObjects[8] = gridController.getObjectByPos(positionX + 1, positionY + 1);
            }


            //getLowerCenter
            adjacentObjects[7] = gridController.getObjectByPos(positionX, positionY + 1);
        }
        else
        {
            adjacentObjects[6] = null;
            adjacentObjects[7] = null;
            adjacentObjects[8] = null;
        }

        
    }

    public void setDoor(GameObject door)
    {
        currentDoor = door;
        hasDoor = true;
        /*DoorController doorController = door.GetComponent<DoorController>();
        doorController.setPositionObject(gameObject);*/
    }
    public void removeDoor()
    {
        currentDoor = null;
        hasDoor = false;
    }




}
