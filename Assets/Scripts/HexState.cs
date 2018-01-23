using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// When the player presses raise/lower, a message needs to be sent to hexState to check that the hex can complete the players' raise/lower command
/// Then, hexState should record the new hexState and manage moving the hex up/down as needed
/// Finally hexState should message the playerController back to advise that the player's health needs to be decremented IF the raise/lower is successful
/// </summary>
public class HexState : MonoBehaviour {

    public enum hexState { up, down, neut }; //whether the hex is raised, lowered or neutral
    public hexState state;
    private float hexTranslate = 1f; //the amount the hex moves up and down 
    public float healthChange = -1f;
    
    void Start ()
    {
        state = hexState.neut;
        //TODO create an array of the hexes and set them (with procedural algo) to neut, up, down

	}

	void Update ()
    {
        //hexMove();
	}

    public void hexStateChange()
    {
        //switch (state)
        //{
            //case hexState.up:
            //    gameObject.transform.position += new Vector3(0f, 1f, 0f);
            //    break;
            //case hexState.neut:
            //    transform.position.y = 0f;
            //    break;
            //case hexState.down:
            //    transform.position.y = -1f;
            //default:
            //    break;

            //    //every frame if raycast is hit on that hex
            //    //if state = down or neut then we can raise, if state = neut or up then we can lower
            //    //if player presses button
            //    //if we raise / lower, apply position change
        }

    //void checkMessage()
    //{

    //}

    //void hexMove()
    //{

    //}
}
