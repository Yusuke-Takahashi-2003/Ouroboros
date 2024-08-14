using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int rollOfDice = 0;
    public static int whichPlayer = 0;

    public static bool isPlayable = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void ChangePlayer()
    {
        whichPlayer++;
        if(whichPlayer == 4)
        {
            whichPlayer = 0;
        }
    }
}
