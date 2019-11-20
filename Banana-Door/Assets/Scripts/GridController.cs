using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridController : MonoBehaviour
{
    //Declare user controlled variables
    private GameObject[][] gridPos = new GameObject[7][];


    //test variables
    public GameObject test;

    // Start is called before the first frame update
    void Start()
    {
        gridPos[0] = new GameObject[7];
    

        gridPos[4][3] = test;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setPositionOnGrid(int posX, int posY, GameObject gridObject)
    {
        gridPos[posX][posY] = gridObject;
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
