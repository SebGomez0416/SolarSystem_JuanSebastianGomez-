using System;
using UnityEngine;

public class shipCamera : MonoBehaviour
{
   [SerializeField] private GameObject spaceCam;

   private void Update()
   {
       if (Input.GetKeyDown(KeyCode.Alpha0))
       {
           gameObject.SetActive(false);
           spaceCam.SetActive(true);
       }
          
   }

   
}
