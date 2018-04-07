using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingStar : MonoBehaviour
{
   
    Vector3 startingStarPos;
    [SerializeField]  Vector3 destination = new Vector3(1f, 0, 0);
    [SerializeField] float speed = 100f;

    float elapsedTime = 0; 
    

    // Use this for initialization
    void Start()
    {
        startingStarPos = transform.position;
    }
	
	// Update is called once per frame
	void Update()
    {
        elapsedTime += Time.deltaTime;
        print(elapsedTime);
        if ((elapsedTime > 19f && elapsedTime <20f) || (elapsedTime >40 && elapsedTime <41) )
        {
            gameObject.transform.position = new Vector3(-104.6f, -4.4f, 119.17f);
        }

        if (gameObject.transform.position.x <= 129 && (elapsedTime > 10f && elapsedTime < 18f) || (elapsedTime > 32f && elapsedTime < 39f) || (elapsedTime > 44f && elapsedTime < 50f))
        {
            transform.position = Vector3.MoveTowards(transform.position, destination, speed * Time.deltaTime);
        }




    }
}
