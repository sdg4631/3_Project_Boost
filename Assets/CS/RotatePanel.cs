using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePanel : MonoBehaviour
{
    [SerializeField] float rotationSpeed = 10;

    // Use this for initialization
    void Start()
    {
		
	}
	
	// Update is called once per frame
	void Update()
    {
        float rotationThisFrame = rotationSpeed * Time.deltaTime;
        transform.Rotate(Vector3.forward * rotationThisFrame);
    }
}
