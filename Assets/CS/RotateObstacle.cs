using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObstacle : MonoBehaviour
{
    [SerializeField] float rotationSpeed = 10;

	void Update()
    {
        Rotate();
    }

    private void Rotate()
    {
        float rotationThisFrame = rotationSpeed * Time.deltaTime;
        transform.Rotate(Vector3.forward * rotationThisFrame);
        transform.Rotate(Vector3.down * rotationThisFrame);
    }
}
