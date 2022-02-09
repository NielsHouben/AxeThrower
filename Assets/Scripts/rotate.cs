using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class rotate : MonoBehaviour
{
  // Start is called before the first frame update
  public float torque;
  private Rigidbody rb;

  void Start()
  {
    rb = GetComponent<Rigidbody>();
  }

  void FixedUpdate()
  {
    float turn = Input.GetAxis("Horizontal");
    rb.AddTorque(transform.up * torque * turn);
  }

  // Update is called once per frame
  void Update()
  {

  }
}
