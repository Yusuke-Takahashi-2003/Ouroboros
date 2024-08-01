using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void InputByPlayers()
    {

    }

    public void RollTheDice()
    {
        GameManager.rollOfTheDice = Random.Range(1, 7);
    }
}
