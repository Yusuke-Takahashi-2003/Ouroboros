using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Field : MonoBehaviour
{

    private int numOfTiles = 28;
    private GameObject[] tiles;
    [SerializeField]
    private GameObject tile;

    // Start is called before the first frame update
    void Start()
    {
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
                tiles[i] = Instantiate(tile, new Vector3(7, 0, i - 7), Quaternion.identity);
                tiles[i].transform.parent = this.gameObject.transform;
            }
            else if(i <= (numOfTiles / 4) * 3)
            {
                tiles[i] = Instantiate(tile, new Vector3(7 - i + 14, 0, 7), Quaternion.identity);
                tiles[i].transform.parent = this.gameObject.transform;
            }
            else
            {
                tiles[i] = Instantiate(tile, new Vector3(0, 0, 7 - i + 21), Quaternion.identity);
                tiles[i].transform.parent = this.gameObject.transform;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
