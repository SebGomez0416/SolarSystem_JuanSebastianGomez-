using System;
using UnityEngine;

public class MyCamera : MonoBehaviour
{
  [SerializeField] private float transitionSpeed;
  private Transform currentView;
  private Transform mainView;
  [SerializeField] private SpawnSystem planets;  

  private void Start()
  {
      mainView = transform;
      currentView = transform;
      Debug.Log(mainView.position.x);
  }

  private void Update()
  {
      Debug.Log(mainView.position.x);

      if (Input.GetKeyDown(KeyCode.Alpha1))
      {   
          currentView = mainView;
         
      }
      if (Input.GetKeyDown(KeyCode.Alpha2))
      {
          currentView = planets.planets[1].transform;
      }
      if (Input.GetKeyDown(KeyCode.Alpha3))
      {
          currentView = planets.planets[2].transform;
      }
      if (Input.GetKeyDown(KeyCode.Alpha4))
      {
          currentView = planets.planets[3].transform;
      }
      if (Input.GetKeyDown(KeyCode.Alpha5))
      {
          currentView = planets.planets[4].transform;
      }
      if (Input.GetKeyDown(KeyCode.Alpha6))
      {
          currentView = planets.planets[5].transform;
      }
      if (Input.GetKeyDown(KeyCode.Alpha7))
      {
          currentView = planets.planets[6].transform;
      }
      if (Input.GetKeyDown(KeyCode.Alpha8))
      {
          currentView = planets.planets[7].transform;
      }
      if (Input.GetKeyDown(KeyCode.Alpha9))
      {
          currentView = planets.planets[8].transform;
      }
  }

  private void LateUpdate()
  {
      transform.position= Vector3.Lerp(transform.position, currentView.position , transitionSpeed*Time.deltaTime);
  }
}
