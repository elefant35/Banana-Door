using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionController : MonoBehaviour
{
    //Declare User controlled variables
    [SerializeField] private int positionX; //horizontal position of the spot on the grid
    [SerializeField] private int positionY; //horizontal position of the spot on the grid
    [SerializeField] private GameObject[] adjacentObjects;

    //Declare code controlled variables
    [SerializeField] private GameObject currentDoor;

    //test variables
    // Start is called before the first frame update
    void Start()
    {
        //get grid controller
        GridController gridController = GameObject.Find("Grid").GetComponent<GridController>();
        gridController.setPositionOnGrid(positionX, positionY, gameObject); //sets the position of the grid object on the grid   
    }

    // Update is called once per frame
    void Update()
    {
        
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
            if (positionX + 1 <= 8)
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
            adjacentObjects[3] = null;
        }
        //get mid objects
        if (positionX - 1 >= 0)
        {
            //getMidLeft
            adjacentObjects[3] = gridController.getObjectByPos(positionX - 1, positionY);
        }
        if (positionX + 1 <= 8)
        {
            //getMidRight
            adjacentObjects[5] = gridController.getObjectByPos(positionX + 1, positionY);
        }
  
        //get lower objects
        if (positionY + 1 <= 7) //make sure the lower adjacent objects are not out of grid bounds
        {
            if (positionX - 1 >= 0)
            {
                //getLowerLeft
                adjacentObjects[6] = gridController.getObjectByPos(positionX - 1, positionY + 1);
            }
            if (positionX + 1 <= 8)
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



}
