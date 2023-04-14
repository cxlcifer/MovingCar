using System;
using UnityEngine;
public class Camera : MonoBehaviour
{
    private CarMovement car;
    [SerializeField] private Vector3 _offset;

    private void Start()
    {
        car = FindObjectOfType<CarMovement>();
    }

    private void LateUpdate()
    {
        transform.position = car.transform.position + _offset;
    }
}