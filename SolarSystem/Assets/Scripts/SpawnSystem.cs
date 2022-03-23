using System.Collections.Generic;
using UnityEngine;

public class SpawnSystem : MonoBehaviour
{
     [SerializeField] private List<GameObject> Models;
     public List<GameObject> planets;
     
    void Start()
    {
        foreach ( GameObject model in Models)
        {
             planets.Add(Instantiate(model));

        }
    }
}
