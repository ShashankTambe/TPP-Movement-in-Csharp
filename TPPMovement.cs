using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonMovement: Monobehaviour
{
   
   public CharacterController controller;

   public float speed = 6f;

   void Update()
   {
       float horizontal = Input.GetAxisRaw("Horizontal");
       float vertical = Input.GetAxisRaw("Vertical");
       Vector3 direction = new Vector3(horizontal, 0f, vertical)
   }



}