using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridController : MonoBehaviour
{
    //Declare user controlled variables
    private GameObject[][] gridPos = new GameObject[7][];


    //test variables
    public GameObject test;
    public GameObject test2;

    GridController()
    {
        gridPos[0] = new GameObject[7];
        gridPos[1] = new GameObject[7];
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
         //test = gridPos[0][0];
       // Debug.Log(gridPos[0][0]);
    }

    public void setPositionOnGrid(int posX, int posY, GameObject gridObject)
    {
        gridPos[posX][posY] = gridObject;//GameObject.Find(gridObjectName); //GameObject.Find(gridObjectName)
        Debug.Log("setpositiononGridCalled" + posX + posY);

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
   
}
