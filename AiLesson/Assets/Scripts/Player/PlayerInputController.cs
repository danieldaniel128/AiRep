using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputController : MonoBehaviour
{
    const string HORIZONTAL_AXIS="Horizontal";
    const string VERTICAL_AXIS = "Vertical";
    [SerializeField] Rigidbody _playerRb;
    [SerializeField] int speed;
    [SerializeField] float forcePower;
    bool pressedJump=false;
    // Update is called once per frame
    void Update()
    {
        float horizontalAxis = Input.GetAxis(HORIZONTAL_AXIS);
        float verticalAxis = Input.GetAxis(VERTICAL_AXIS);
        
            if (Mathf.Abs(horizontalAxis) != 0) 
            {
                transform.Translate(Vector3.right * Time.deltaTime* horizontalAxis * speed);
            }
            if (Mathf.Abs(verticalAxis) != 0)
            {
                transform.Translate(Vector3.forward * Time.deltaTime* verticalAxis * speed);
            }
            if (Input.GetKeyDown("joystick button 1"))
            {
            pressedJump = true;
                Debug.Log("jumping");
            }
    }
    private void FixedUpdate()
    {
        if (pressedJump)
        { 
            _playerRb.AddForce(Vector3.up * forcePower * Time.deltaTime, ForceMode.Impulse);
            pressedJump = false;
        }
    }
}
