using UnityEngine;

/*
    Script: SimpleSinMove
    Author: Gareth Lockett
    Version: 1.0
    Description:    Simple script for moving a game object along a local axis using a sine wave.
*/

public class SimpleSinMove : MonoBehaviour
{
    // Enumerators
    public enum Axis { xAxis, yAxis, zAxis }

    // Properties
    public Axis axis;				// The axis to rotate around.
    public float moveSpeed = 2f;    // Speed at which this GameObject will move (eg units per second. Higher values will move faster)
    public float distance = 0.05f;     // Maximum distance to move (NOTE: Cumlative per Update())

    // Methods
    private void Update()
    {
        // Get move direction.
        Vector3 moveDirection = Vector3.zero;
        switch( this.axis )
        {
            case Axis.xAxis:
                moveDirection = this.transform.right;
                break;

            case Axis.yAxis:
                moveDirection = this.transform.up;
                break;

            case Axis.zAxis:
                moveDirection = this.transform.forward;
                break;
        }

        // Do the movement using a sine wave.
        this.transform.position += moveDirection * Mathf.Sin( Time.time * this.moveSpeed ) * this.distance;
    }
}
