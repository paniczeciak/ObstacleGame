using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Winner : MonoBehaviour
{
      private void OnCollisionEnter(Collision other) 
   {
      if(other.gameObject.tag == "Player")
      {
         
         GetComponent<MeshRenderer>().material.color = Color.yellow;
         Debug.Log("You won!");
         
      }
        
   }
}
