using System.Collections;
using UnityEngine;

public class BoxSpawner : MonoBehaviour
{
  /// <summary>
  /// The object to be created and thrown
  /// The SerializeField property is used to access the variable from the editor (can also be done by making it public)
  /// Using SerializeField is best practice as it means that the variable is meant to be set from the editor
  /// </summary>
  [SerializeField]
  GameObject boxPrefab;

  bool coolDown;

  /// <summary>
  /// Method to create and propel a box
  /// </summary>
  public void ThrowBox()
  {
    if (!coolDown)
    {
      // coolDown = true; uncomment for coldown

      // transform.position - transform.up * 0.33f Gives us the camera height - 0.33 meters
      // GameObject go = Instantiate(boxPrefab, transform.position - transform.up * 0.33f, transform.rotation);
      // GameObject go = Instantiate(boxPrefab, transform.position + transform.up * -0.5f, Quaternion.Euler(new Vector3(0, 270, 90)));
      GameObject go = Instantiate(boxPrefab, transform.position + transform.up * -0.3f + transform.right * 0.1f, transform.rotation);
      // go.GetComponent<Rigidbody>().maxAngularVelocity = 100;

      // transform.forward + transform.up * 0.5f is the direction of the force. In this case its slightly angled up (transform.up * 0.5f) and away from the camera (transform.forward)
      // go.GetComponent<Rigidbody>().AddForce((transform.forward + transform.up * 0.5f) * 5, ForceMode.Impulse);
      go.GetComponent<Rigidbody>().AddForce((transform.forward * 1 + transform.up * 0.9f) * 5, ForceMode.Impulse);
      Vector3 torque = go.transform.right * 10;
      // go.GetComponent<Rigidbody>().AddTorque(10, 0, 0, ForceMode.Impulse);
      go.GetComponent<Rigidbody>().AddTorque(torque, ForceMode.Impulse);

      StartCoroutine(CoolDownRoutine());
    }
  }

  // IEnumerators are routines which will run over several frames
  // In this case the function will check every frame if it has waited for longer than 0.33 seconds and then set cooldown to false
  IEnumerator CoolDownRoutine()
  {
    WaitForSeconds waitForSeconds = new WaitForSeconds(0.33f);

    yield return waitForSeconds;
    coolDown = false;
  }
}
