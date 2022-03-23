using UnityEngine;

public class MyCamera : MonoBehaviour
{
  [SerializeField] private float transitionSpeed;
  [SerializeField] private Vector3 offSet;
  private  Vector3 currentView;
  private Vector3 mainView;
  [SerializeField] private SpawnSystem p;
  private enum Planets {SUN,MERCURY,VENUS,EARTH,MARS,JUPITER,SATURN,URANUS,NEPTUNE}
  private Planets planet;
  private void Start()
  {
      planet = Planets.SUN;
      mainView = transform.position;
      currentView = transform.position;
  }

  private void Update()
  {
      cameraInput();
  }
  private void LateUpdate()
  {
    transform.position = currentView-offSet;
  }

   private void cameraInput()
  {
      if (Input.GetKeyDown(KeyCode.Alpha2))
          planet = Planets.MERCURY;
      
      if (Input.GetKeyDown(KeyCode.Alpha3))
          planet = Planets.VENUS;
      
      if (Input.GetKeyDown(KeyCode.Alpha4))
          planet = Planets.EARTH;
      
      if (Input.GetKeyDown(KeyCode.Alpha5))
          planet = Planets.MARS;
      
      if (Input.GetKeyDown(KeyCode.Alpha6))
          planet = Planets.JUPITER;
      
      if (Input.GetKeyDown(KeyCode.Alpha7))
          planet = Planets.SATURN;
      
      if (Input.GetKeyDown(KeyCode.Alpha8))
          planet = Planets.URANUS;
      
      if (Input.GetKeyDown(KeyCode.Alpha9))
          planet = Planets.NEPTUNE;
      
      if (Input.GetKeyDown(KeyCode.Alpha1))
          planet = Planets.SUN;
      
      currentView = planet == Planets.SUN ? mainView : p.planets[(int)planet].transform.position;
      
  }
  
  
}
