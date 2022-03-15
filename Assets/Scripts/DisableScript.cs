using UnityEngine;

public class DisableScript : MonoBehaviour
{
  public GameObject obj;
  public void Disable()
  {
    obj.SetActive(false);
  }
}
