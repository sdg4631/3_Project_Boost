using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObstacle : MonoBehaviour
{
    [SerializeField] float rotationSpeed = 10;

	// Use this for initialization
	void Start()
    {
		
	}
	
	// Update is called once per frame
	void Update()
    {
        Rotate();
    }

    void Rotate()
    {
        float rotationThisFrame = rotationSpeed * Time.deltaTime;
        transform.Rotate(Vector3.forward * rotationThisFrame);
        transform.Rotate(Vector3.down * rotationThisFrame);
    }
}
