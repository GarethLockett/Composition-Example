using UnityEngine;

/*
    Script: SimpleSinScale
    Author: Gareth Lockett
    Version: 1.0
    Description:    Simple script for scaling a game object uniformly using a sine wave.
*/

public class SimpleSinScale : MonoBehaviour
{
    // Properties
    public float scaleSpeed = 1f;    // Speed at which this GameObject will scale (eg factor per second. Higher values will move faster)
    public float maxScale = 0.01f;   // Maximum scale amount (NOTE: Cumlative per Update())

    // Methods
    private void Update()
    {
        // Do the movement using a sine wave.
        this.transform.localScale += Vector3.one * Mathf.Sin( Time.time * this.scaleSpeed ) * this.maxScale;
    }
}
