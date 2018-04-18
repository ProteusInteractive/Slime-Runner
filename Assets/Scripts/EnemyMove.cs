using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
	
        //TODO:
        //1. Refactor Player Move code to allow:
        //  a. movementRules array to pass into DoRay
        //  b. encapsulate DoMove
        //  c. bool for canMoveHexes, if true, run HexMove()

        //TO IMPLEMENT ENEMY AI THAT WORKS FOR MULTIPLE ENEMY TYPES
        //Analyse enemy and player positions, process AI decisions
        //Follow Players DORAY stuff
        //some enemies shoot, allow them to shoot
        //Follow Players DOMOVE stuff (but passing in input from AI decisions, above)
        //(if enemy can hexmove) pass in AI decisions for hexmoving
	}
}
