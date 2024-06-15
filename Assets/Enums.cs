using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enums : MonoBehaviour {


    enum PlayerState
    {
        PlayerIdle,
        PlayerWalk,
        PlayerJump,
        PlayerRun,
        PlayerShoot,

    }

    PlayerState state;

    

    // Use this for initialization
    void Start ()
    {
        state = PlayerState.PlayerIdle;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {


            switch (state)
            {

                case PlayerState.PlayerIdle:
                    {
                        Debug.Log(state);
                    }
                    break;
                case PlayerState.PlayerWalk:
                    {
                        Debug.Log(state);
                    }
                    break;

                case PlayerState.PlayerJump:
                    {
                        Debug.Log(state);
                    }
                    break;
                case PlayerState.PlayerRun:
                    {
                        Debug.Log(state);
                    }
                    break;
                case PlayerState.PlayerShoot:
                    {
                        Debug.Log(state);
                    }
                    break;
                default:
                    {
                        Debug.Log("No State");

                    }
                    break;

            }


            state++;
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            state = PlayerState.PlayerIdle;
        }
    }
}
