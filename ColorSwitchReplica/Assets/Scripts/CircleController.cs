using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleController : MonoBehaviour
{
 [SerializeField] private float speed; //Float tipinde bir değişken oluşturduk ve speed adını verdik

 [SerializeField] private bool direction; //bool tipinde bir değişken oluşturduk ve direciton adını verdik

 private void Update()
 {
  if (direction == false) //direction false ise;
  {
   transform.Rotate(0,0, speed * Time.deltaTime);
   //x ve y 0 olarak kalsın z pozisyosnu hız ve zamanla çarpıp. Rotate edilsin
  }
  else
  {
   transform.Rotate(0,0, -1 * speed * Time.deltaTime);
   //x ve y 0 olarak kalsın z pozisyosnu hız ve zamanla çarpıp. Rotate edilsin. -1 girmemizin nedeni tam tersine dönmesi için.
  }
 }
}
