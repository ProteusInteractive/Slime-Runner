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
    private float hexTranslate = 2f; //the amount the hex moves up and down 
    public string change;
    
    void Start ()
    {	
	}

	void Update ()
    {
        hexMove();
	}

    public void hexStateChange()
    {
       
    }

    void checkMessage()
    {

    }

    void hexMove()
    {

    }
}
