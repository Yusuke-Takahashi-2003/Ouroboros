using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Field : MonoBehaviour
{
    private int[] playerPosition;
    private int numOfTiles = 48;

    [SerializeField]
    private GameObject tile;
    private GameObject[] tiles;

    [SerializeField]
    private GameObject[] playerSpheres;

    // Start is called before the first frame update
    void Start()
    {
        playerPosition = new int[numOfTiles];

        playerPosition[0] = 0;
        playerSpheres[0] = Instantiate(playerSpheres[0], new Vector3(0, 0.55f, 0), Quaternion.identity);

        playerPosition[1] = numOfTiles / 4;
        playerSpheres[1] = Instantiate(playerSpheres[1], new Vector3(numOfTiles / 4, 0.55f, 0), Quaternion.identity);

        playerPosition[2] = (numOfTiles / 4) * 2;
        playerSpheres[2] = Instantiate(playerSpheres[2], new Vector3(numOfTiles / 4, 0.55f, numOfTiles / 4), Quaternion.identity);

        playerPosition[3] = (numOfTiles / 4) * 3;
        playerSpheres[3] = Instantiate(playerSpheres[3], new Vector3(0, 0.55f, numOfTiles / 4), Quaternion.identity);


        tiles = new GameObject[numOfTiles];

        for (int i = 0; i < numOfTiles; i++)
        {
            if (i <= numOfTiles / 4)
            {
                tiles[i] = Instantiate(tile, new Vector3(i, 0, 0), Quaternion.identity);
                tiles[i].transform.parent = this.gameObject.transform;
            }
            else if (i <= (numOfTiles / 4) * 2)
            {
                tiles[i] = Instantiate(tile, new Vector3(numOfTiles/4, 0, i - numOfTiles/4), Quaternion.identity);
                tiles[i].transform.parent = this.gameObject.transform;
            }
            else if(i <= (numOfTiles / 4) * 3)
            {
                tiles[i] = Instantiate(tile, new Vector3(numOfTiles / 4 - i + numOfTiles/2, 0, numOfTiles / 4), Quaternion.identity);
                tiles[i].transform.parent = this.gameObject.transform;
            }
            else
            {
                tiles[i] = Instantiate(tile, new Vector3(0, 0, numOfTiles / 4 - i + (numOfTiles*3/4)), Quaternion.identity);
                tiles[i].transform.parent = this.gameObject.transform;
            }
        }

        GameManager.isPlayable = true;
    }

    public void MakeAMove(int dice, int player)
    {
        playerPosition[player] += dice;
        if (playerPosition[player] >= numOfTiles)
        {
            playerPosition[player] -= numOfTiles;
        }

        playerSpheres[player].transform.position = tiles[playerPosition[player]].transform.position + new Vector3(0, 0.55f, 0);

        GameManager.ChangePlayer();
        GameManager.isPlayable = true;
    }
}
