using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    [SerializeField] private float _speed;
    
    
    void Update()
    {
        var position = transform.position;
        var step = _speed * Time.deltaTime;
        
        
        if (Input.GetKey(KeyCode.W))
        {
            position.z += step;
        }
        if (Input.GetKey(KeyCode.A))
        {
            position.x -= step;
        }
        if (Input.GetKey(KeyCode.D))
        {
            position.x += step;
        }

        if (Input.GetKey(KeyCode.S))
        {
            position.z -= step;
        }
        
        transform.position = position;
    }
}
