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
        DoRay();
    }

    private void DoRay()
    {
        if (fwdLastMove)
        {
            Vector3 fwdDir = Quaternion.Euler(0, -45f, 0) * transform.forward;
            //if (Physics.Raycast(transform.position, fwdDir, out RaycastHit hitInfo, 5))
            //{
            //    Vector3 RayTile = hitInfo.collider.transform.position;
                
            //}
        }
        else
        {
            Vector3 bckDir = Quaternion.Euler(0, -45f, 0) * -transform.forward;
            //if (Physics.Raycast(transform.position, bckDir, out RaycastHit hitInfo, 5))
            //{
            //    Vector3 RayTile = hitInfo.collider.transform.position;

            //}
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
