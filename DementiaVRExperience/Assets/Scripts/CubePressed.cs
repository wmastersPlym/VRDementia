using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubePressed : MonoBehaviour
{
    // This script will alert the game manager that one of the noughts/naughts and crosses cubes was "clicked" on

    public int cubeNumber = 0;

    public void OnSelected() // when this cube is interacted with 
    {
        GameObject.Find("GameManager").SendMessage("CubePressed", gameObject);
        Destroy(this); // so we can't repeatedly run this script
    }
}
