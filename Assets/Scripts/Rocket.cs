using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    public float Power;
    public float TorquePower;


    private Rigidbody rocketRigidbody;
    private bool movingUp;
    private int rotateDir;

    void Start()
    {
        rocketRigidbody = GetComponent<Rigidbody>();
        rocketRigidbody.maxAngularVelocity = 10;
    }

    // Update input
    void Update()
    {
        movingUp = Input.GetKey(KeyCode.Space);
        rotateDir = 0;
        
        if (Input.GetKey(KeyCode.LeftArrow))
            rotateDir--;
        
        if (Input.GetKey(KeyCode.RightArrow))
            rotateDir++;
    }

    // Update physics
    void FixedUpdate()
    {
        if (movingUp)
            rocketRigidbody.AddRelativeForce(Vector3.up * Power);

        // multiple by -1 to fix left/right
        rocketRigidbody.AddRelativeTorque(new Vector3(0, 0, rotateDir*TorquePower*-1));
    }
}
