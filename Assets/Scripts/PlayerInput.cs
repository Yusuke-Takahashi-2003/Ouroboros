using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    [SerializeField]
    Field field;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        InputByPlayers();
    }

    private void InputByPlayers()
    {
        if (GameManager.isPlayable)
        {
            if(Input.GetMouseButtonDown(0))
            {
                RollTheDice();
            }
        }
    }

    public void RollTheDice()
    {
        GameManager.isPlayable = false;

        GameManager.rollOfDice = Random.Range(1, 7);

        field.MakeAMove(GameManager.rollOfDice, GameManager.whichPlayer);

        Debug.Log(GameManager.rollOfDice);
    }
}
