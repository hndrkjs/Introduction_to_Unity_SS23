using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField]
    private WheelCollider frontRight;
    [SerializeField]
    private WheelCollider frontLeft;
    [SerializeField]
    private WheelCollider rearRight;
    [SerializeField]
    private WheelCollider rearLeft;

    [SerializeField]
    private Transform frontRightMesh;
    [SerializeField]
    private Transform frontLeftMesh;
    [SerializeField]
    private Transform rearRightMesh;
    [SerializeField]
    private Transform rearLeftMesh;

    [SerializeField]
    private UI_Manager uiManager;

    [SerializeField]
    private float forwardSpeed = 4000f;
    [SerializeField]
    private float reverseSpeed = 3500f;
    [SerializeField]
    private float maxTurnAngle = 45f;
    [SerializeField]
    private float breakingForce = 300f;

    private float speedInput, turnInput, currentBreakForce;

    public int lives = 3;

    private void FixedUpdate()
    { 

        // Allowing the player to brake because this allows better handling of the car
        if (Input.GetKey(KeyCode.Space)){
            currentBreakForce = breakingForce;
        } else {
            currentBreakForce = 0;
        }
        
        if (Input.GetAxis("Vertical") > 0){
            // the user wants to move forward
            speedInput = Input.GetAxis("Vertical") * forwardSpeed;

        } else if (Input.GetAxis("Vertical") < 0){
            // the user wants to move backward
            speedInput = Input.GetAxis("Vertical") * reverseSpeed;
        }

        turnInput = maxTurnAngle * Input.GetAxis("Horizontal");
        
        // Applying movement and turning
        frontRight.motorTorque = speedInput;
        frontLeft.motorTorque = speedInput;
        rearRight.motorTorque = speedInput;
        rearLeft.motorTorque = speedInput;

        frontRight.brakeTorque = currentBreakForce;
        frontLeft.brakeTorque = currentBreakForce;
        rearRight.brakeTorque = currentBreakForce;
        rearLeft.brakeTorque = currentBreakForce;

        frontLeft.steerAngle = turnInput;
        frontRight.steerAngle = turnInput;

        


        // Move Wheel Meshes
        MoveWheel(frontRight, frontRightMesh);
        MoveWheel(frontLeft, frontLeftMesh);
        MoveWheel(rearRight, rearRightMesh);
        MoveWheel(rearLeft, rearLeftMesh);


    }

    void MoveWheel(WheelCollider collider, Transform transform) {

        // Get the collider world state
        Vector3 position;
        Quaternion rotation;

        collider.GetWorldPose(out position, out rotation);

        // Apply the collider's world's state to the wheel
        transform.position = position;
        transform.rotation = rotation;

    }

    public void Damage() {
        lives--;
        uiManager.UpdateLives(lives);
        Debug.Log("Damage"+ lives);
    }


}
