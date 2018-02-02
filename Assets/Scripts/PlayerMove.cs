using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float forwardSpeed = 20f;
    public float backSpeed = 15f;
    public float turnSpeed = 200f;

    public bool fwdLastMove = true;
    public enum hexChange { raise, lower };

    void Update()
    {
        Move();
		DoRay();
        hexMove();
    }

    void Move()
    {
        if (Input.GetAxis("Vertical") > 0)
        {
            transform.position += transform.forward * Input.GetAxis("Vertical") * forwardSpeed * Time.deltaTime;
            fwdLastMove = true;
        }
        else if (Input.GetAxis("Vertical") < 0)
        {
            transform.position += transform.forward * Input.GetAxis("Vertical") * backSpeed * Time.deltaTime;
            fwdLastMove = false;
        }

        if (Input.GetAxis("Horizontal") != 0)
        {
            transform.Rotate(0f, Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime, 0f);
        }        
    }

    private void DoRay()
    {
		RaycastHit hitInfo;
        if (fwdLastMove)
        {
			Vector3 fwdDir = transform.forward - transform.up;
			Debug.DrawRay (transform.position, fwdDir, Color.red);
			if (Physics.Raycast(transform.position, fwdDir, out hitInfo, 5))
            {
				Vector3 RayTile = hitInfo.point;
				print (RayTile);
            }
        }
		else 
        {
			Vector3 bckDir = -transform.forward - transform.up;
			Debug.DrawRay (transform.position, bckDir, Color.red);
			if (Physics.Raycast(transform.position, bckDir, out hitInfo, 5))
            {
				Vector3 RayTile = hitInfo.point;
            }
        }
    }

    void hexMove()
    {
        if (Input.GetKeyDown("Raise"))
        {

        }

        if (Input.GetKeyDown("Lower"))
        {

        }


    }
}
