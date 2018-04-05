﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Rocket : MonoBehaviour {

    [SerializeField]float rcsThrust = 100f;
    [SerializeField]float mainThrust = 2000f;
    Rigidbody rigidBody;
    AudioSource audioSource;

	// Use this for initialization
	void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update()
    {
        Thrust();
        Rotate();
	}

    void OnCollisionEnter(Collision collision)
    {
        switch(collision.gameObject.tag)
        {
            case "Friendly":
                // do nothing               
                break;
            case "Finish":
                print("Hit Finish");
                SceneManager.LoadScene(1);
                break;
            default:
                // kill player
                print("DEAD");
                SceneManager.LoadScene(0);
                break;
        }
    }

    private void Thrust()
    {
        if (Input.GetKey(KeyCode.Space)) // Can thrust while rotating
        {
            float thrustThisFrame = mainThrust * Time.deltaTime; 
            rigidBody.AddRelativeForce(Vector3.up * thrustThisFrame);
            if (!audioSource.isPlaying) // so the audio doesnt layer on top of each other
            {
                audioSource.Play();
            }
        }
        else
        {
            audioSource.Stop();
        }
    }

    private void Rotate()
    {
        rigidBody.freezeRotation = true; // take manual control of rotation
        float rotationThisFrame = rcsThrust * Time.deltaTime;

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.forward * rotationThisFrame);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(-Vector3.forward * rotationThisFrame);
        }

        rigidBody.freezeRotation = false; // resume physics control of rotation
    }
}

