using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// When the player presses raise/lower, a message needs to be sent to hexState to check that the hex can complete the players' raise/lower command
/// Then, hexState should record the new hexState and manage moving the hex up/down as needed
/// Finally hexState should message the playerController back to advise that the player's health needs to be decremented IF the raise/lower is successful
/// </summary>
public class HexState : MonoBehaviour {

    public enum ElevationState { down, neut, up };
    public ElevationState elevation;
    private int yPos;
    private Vector3 curPos;

    private float hexTranslate = 1f; //the amount the hex moves up and down 
    public float healthChange = -1f; //if player interacts (raises/lowers the hex) they lose this much health

    void Start ()
    {

	}

	void Update ()
    {
        hexStateChange();
	}

    public void hexStateChange()
    {

        switch (elevation)
        {
            case ElevationState.down:
                yPos = -1; 
                break;

            case ElevationState.neut:
                yPos = 0; 
                break;

            case ElevationState.up:
                yPos = 1; 
                break;
        }

        curPos = this.transform.position;
        this.transform.position = new Vector3(curPos.x, yPos, curPos.z);

        //    //every frame if raycast is hit on that hex
        //    //if state = down or neut then we can raise, if state = neut or up then we can lower
        //    //if player presses button
        //    //if we raise / lower, apply position change
    }

}
