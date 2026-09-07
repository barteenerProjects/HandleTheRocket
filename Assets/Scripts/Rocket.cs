using UnityEngine;
using UnityEngine.InputSystem;

public class Rocket : MonoBehaviour
{
    private Rigidbody2D rocketRigidBody2D;

    private void Awake() {
        rocketRigidBody2D = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate() {
        if (Keyboard.current.upArrowKey.isPressed || Keyboard.current.wKey.isPressed) {
            float force = 700f;
            rocketRigidBody2D.AddForce(force * transform.up * Time.deltaTime );
        }
        if (Keyboard.current.leftArrowKey.isPressed || Keyboard.current.aKey.isPressed) {
            float turnSpeed = +100;
            rocketRigidBody2D.AddTorque(turnSpeed * Time.deltaTime);
        }
        if (Keyboard.current.rightArrowKey.isPressed || Keyboard.current.dKey.isPressed) {
            float turnSpeed = -100;
            rocketRigidBody2D.AddTorque(turnSpeed * Time.deltaTime);
        }
    }
}
