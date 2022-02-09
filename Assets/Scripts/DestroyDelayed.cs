using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyDelayed : MonoBehaviour
{
  [SerializeField]
  private float lifetime = 20;

  void Start()
  {
    // destroys the object after a set time
    Destroy(gameObject, lifetime);
  }


}
