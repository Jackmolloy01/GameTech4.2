using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public CharacterController controller;
    public Vector3 MovementDirection;
    public int MoveSpeed = 2;
    public float MouseSpeed = 2f;

    // Update is called once per frame
    void Update()
    {
        #region BasicMovement
        if (Input.GetKey(KeyCode.LeftShift))
        {
            MoveSpeed = 4;
        }
        else
        {
            MoveSpeed = 2;
        }
        MovementDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

        //controller.SimpleMove(MovementDirection * MoveSpeed);
        #endregion
        #region Rotation

        transform.Rotate(Vector3.up * Input.GetAxis("Mouse X") * MouseSpeed);
        #endregion
    }
}
