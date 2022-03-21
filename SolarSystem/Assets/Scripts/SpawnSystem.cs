using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSystem : MonoBehaviour
{
     [SerializeField] List<GameObject> planets;
     
    void Start()
    {
        foreach ( GameObject planet in planets)
        {
            Instantiate(planet);
        }
    }
}
