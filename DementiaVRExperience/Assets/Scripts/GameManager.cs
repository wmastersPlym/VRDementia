using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{ // may rename this scrpt if needed
    int currentTurn = 1; // O = 1 and X = 2
    Vector3 pos;

    int[] cubes = new int[9];

    public Image winUI;
    public TextMeshProUGUI winText;
    

    private void Start()
    {
        // anyone think of a cleaner way to do this
        winUI.enabled = false;
        winText.enabled = false;
    }

    public void CubePressed(GameObject cube)
    {
        int cubeNumber = cube.GetComponent<CubePressed>().cubeNumber;
        pos = new Vector3(0, 0, 1);

        RotateCube(cube);
        //Assign the cubes to the grid
        cubes[cubeNumber] = currentTurn;

        CheckForWinner();

        NextTurn();
    }

    void RotateCube(GameObject cube)
    {
        // Rotate the cube based on what turn it is 
        if (currentTurn == 1)
        {
            cube.transform.Rotate(pos, 90f);
        }
        else if (currentTurn == 2)
        {
            cube.transform.Rotate(pos, -90f);
        }

    }

    void CheckForWinner()
    {
        for (int player = 1; player <= 2; player++)
        {
            if (cubes[0] == player && cubes[1] == player && cubes[2] == player) // top row
            {
                DisableCubes();
                print(player + " wins");
                winUI.enabled = true; 
                winText.enabled = true;

                winText.SetText(player + " wins");
            }
            else if (cubes[3] == player && cubes[4] == player && cubes[5] == player) // middle row
            {
                DisableCubes();
                print(player + " wins");
                winUI.enabled = true;
                winText.enabled = true;

                winText.SetText(player + " wins");
            }
            else if (cubes[6] == player && cubes[7] == player && cubes[8] == player) // bottom row
            {
                DisableCubes();
                print(player + " wins");
                winUI.enabled = true;
                winText.enabled = true;

                winText.SetText(player + " wins");
            }
            else if (cubes[0] == player && cubes[3] == player && cubes[6] == player) // left col
            {
                DisableCubes();
                print(player + " wins");
                winUI.enabled = true;
                winText.enabled = true;

                winText.SetText(player + " wins");
            }
            else if (cubes[1] == player && cubes[4] == player && cubes[7] == player)  // middle col
            {
                DisableCubes();
                print(player + " wins");
                winUI.enabled = true;
                winText.enabled = true;

                winText.SetText(player + " wins");
            }
            else if (cubes[2] == player && cubes[5] == player && cubes[8] == player) // right col
            {
                DisableCubes();
                print(player + " wins");
                winUI.enabled = true;
                winText.enabled = true;

                winText.SetText(player + " wins");
            }
            else if (cubes[0] == player && cubes[4] == player && cubes[8] == player) // left diagonal
            {
                DisableCubes();
                print(player + " wins");
                winUI.enabled = true;
                winText.enabled = true;

                winText.SetText(player + " wins");
            }
            else if (cubes[2] == player && cubes[4] == player && cubes[6] == player) // right diagonal
            {
                DisableCubes();
                print(player + " wins");
                winUI.enabled = true;
                winText.enabled = true;

                winText.SetText(player + " wins");
            }
        }
    }

    void DisableCubes()
    {
        // disallow users from selecting cubes after a win condition
        foreach (CubePressed cube in FindObjectsOfType<CubePressed>())
        {
            Destroy(cube);
        }
    }

    void NextTurn()
    {
        currentTurn += 1;

        if (currentTurn == 3)
        {
            currentTurn = 1; // loop back around
        }
    }


}

