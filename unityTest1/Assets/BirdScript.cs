using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
Purpose:
    Move bird object when spacebar is pressed
*/
public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody; //Create a reference to the Rigidbody component of the bird object
    public float flapStrength; //Create a reference to a flapStrength variable in the Unity Inspector window to allow changes to velocity while game is running (for testing)
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if statement to run code only when space bar is pressed on the keyboard
        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            myRigidbody.velocity = Vector2.up * flapStrength; //This code makes the rigidbody (object) move upwards a custom amount that is dependednt on what we set flapStrength to
        }
        
    }
}
