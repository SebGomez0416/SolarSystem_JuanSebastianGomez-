using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TranslatePlanet: MonoBehaviour
{
    [SerializeField]float speed;
    [SerializeField] private GameObject target;

    void Update()
    {
        transform.RotateAround(target.transform.position,transform.up,speed);
    }
}
