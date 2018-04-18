using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float forwardSpeed = 20f;
    public float backSpeed = 15f;
    public float turnSpeed = 200f;

    private float verticalCurrentFrame = 0;
    private float horizontalCurrentFrame = 0;

    private HexState targetState;
    private HexState.ElevationState targetHexElevation;

    private bool fwdLastMove = true;
    private bool canMove = true;
    private bool RaiseOrLower = true;

    public enum hexChange { raise, lower };

    void Update()
    {
        InputUpdate();
        DoRay();
        DoMove();        
        hexMove();
    }

    void InputUpdate()
    {
        verticalCurrentFrame = Input.GetAxis("Vertical");
        horizontalCurrentFrame = Input.GetAxis("Horizontal");

        if (verticalCurrentFrame >= 0)
        {
            fwdLastMove = true;
        }
        else if (verticalCurrentFrame < 0)
        {
            fwdLastMove = false;
        }
    }

    private void DoRay()
    {
        RaycastHit hitInfo;
        if (fwdLastMove)
        {
            Vector3 fwdDir = transform.forward - transform.up;
            Debug.DrawRay(transform.position, fwdDir, Color.red);
            if (Physics.Raycast(transform.position, fwdDir, out hitInfo, 5))
            {
                targetState = hitInfo.transform.gameObject.GetComponent<HexState>();
                targetHexElevation = targetState.elevation;

                //TODO
                // serialisable movementRules [] = {up, down} 
                // for each m in movementRules
                // run the if statement below
                // if(movementRules == targetHexElevation) {canMove = true}
                if (targetHexElevation == HexState.ElevationState.neut) //if elevation in HexState.class is neut
                {
                    canMove = true;
                }
                else
                {
                    canMove = false;
                }
            }
            else
            {
                canMove = false;
            }
        }
        else
        {
            Vector3 bckDir = -transform.forward - transform.up;
            Debug.DrawRay(transform.position, bckDir, Color.red);
            if (Physics.Raycast(transform.position, bckDir, out hitInfo, 5))
            {
                targetState = hitInfo.transform.gameObject.GetComponent<HexState>();
                targetHexElevation = targetState.elevation;

                if (targetHexElevation == HexState.ElevationState.neut) //if elevation in HexState.class is neut
                {
                    canMove = true;
                }
                else
                {
                    canMove = false;
                }
            }
            else
            {
                canMove = false;
            }
        }

        //if (targetHexElevation == HexState.ElevationState.down || targetHexElevation == HexState.ElevationState.neut)
        //{
        //    canRaise = true;
        //}
        //else if (targetHexElevation == HexState.ElevationState.up || targetHexElevation == HexState.ElevationState.neut)
        //{
        //    canLower = true;
        //}

    }

    void DoMove()
    {
        if (verticalCurrentFrame > 0 && canMove)
        {
            transform.position += transform.forward * verticalCurrentFrame * forwardSpeed * Time.deltaTime;
        }
        else if (verticalCurrentFrame < 0 && canMove)
        {
            transform.position += transform.forward * verticalCurrentFrame * backSpeed * Time.deltaTime;
        }

        if (horizontalCurrentFrame != 0)
        {
            transform.Rotate(0f, horizontalCurrentFrame * turnSpeed * Time.deltaTime, 0f);
        }        
    }

    void hexMove()
    {
        if (Input.GetKeyDown("Raise"))
        {
            RaiseOrLower = true;
        }
        else if (Input.GetKeyDown("Lower"))
        {
            RaiseOrLower = false;
        }

        switch (targetHexElevation)
        {
            case HexState.ElevationState.up:
                if (!RaiseOrLower)
                {
                    targetState.elevation = HexState.ElevationState.neut;
                }
                break;
            case HexState.ElevationState.neut:
                if (RaiseOrLower)
                {
                    targetState.elevation = HexState.ElevationState.up;
                }
                else
                {
                    targetState.elevation = HexState.ElevationState.down;
                }
                break;
            case HexState.ElevationState.down:
                if (RaiseOrLower)
                {
                    targetState.elevation = HexState.ElevationState.neut;
                }
                break;
        }
        print("State: " + (int)targetState.elevation + "RaiseOrLower: " + RaiseOrLower);
    }
}
