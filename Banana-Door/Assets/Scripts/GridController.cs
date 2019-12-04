using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridController : MonoBehaviour
{
    //Declare user controlled variables
    private GameObject[][] gridPos = new GameObject[8][]; 


    //test variables
    public GameObject test;
    public GameObject test2;

    GridController()
    {
        gridPos[0] = new GameObject[8];
        gridPos[1] = new GameObject[8];
        gridPos[2] = new GameObject[8];
        gridPos[3] = new GameObject[8];
        gridPos[4] = new GameObject[8];
        gridPos[5] = new GameObject[8];
        gridPos[6] = new GameObject[8];
        gridPos[7] = new GameObject[8];
    }

    // Start is called before the first frame update
    void Start()
    {
        /*gridPos[0] = new GameObject[7];
        gridPos[1] = new GameObject[7];

        gridPos[1][3] = test;*/

    }

    // Update is called once per frame
    void Update()
    {
         test = gridPos[5][3];
       // Debug.Log(gridPos[0][0]);
    }

    public void setPositionOnGrid(int posX, int posY, GameObject gridObject)
    {
        
        //gridPos[prevPosX][prevPosY] = null; //makes the previous grid position null
        

        gridPos[posX][posY] = gridObject;//GameObject.Find(gridObjectName); //GameObject.Find(gridObjectName)
        //Debug.Log("setpositiononGridCalled" + posX + posY);
    }

    public GameObject getObjectByPos(int posX, int posY)
    {
        if(gridPos[posX][posY] != null)
        {
            return gridPos[posX][posY];
        }
        else
        {
            return null;
        }
    }

    public int getNextEmptyX(int ypos)
    {
        //maybe do a for loop here to iterate through the array
        return 0;
    }
   
    public bool HasDoor(int posX, int posY)
    {
        GameObject gridPosObject = getObjectByPos(posX, posY);
        if(gridPosObject != null)
        {
            PositionController positionController = gridPosObject.GetComponent<PositionController>();
            if (positionController.returnHasDoor())
            {
                return true;
            }
            else return false;
        }

        return false;
    }
}
