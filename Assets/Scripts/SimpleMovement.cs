using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    public FixedJoystick joystick;
    void Start()
    {
        
    }

    void Update()
    {
        Vector3 input = new Vector3(joystick.Direction.x, 0, joystick.Direction.y);
        Vector3 direction = input.normalized;
        Vector3 velocity = direction * speed * Time.deltaTime;

        transform.Translate(velocity);
    }
}
