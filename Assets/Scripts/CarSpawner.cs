using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class  CarSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _car;

    void Awake()
    {
        Instantiate(_car);
    }
    
}
