using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    private float rotationSpeed = 50;

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up, horizontalInput * rotationSpeed * Time.deltaTime);
    }
}
