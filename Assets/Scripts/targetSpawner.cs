using UnityEngine;

public class TargetSpawner : MonoBehaviour
{
  public GameObject targetPrefab;
  public ScoreHandler scoreHandler;

  public void SpawnTarget()
  {
    // GameObject go = Instantiate(targetPrefab, transform.position + transform.up * -0.3f + transform.right * 0.1f, Quaternion.Euler(new Vector3(0, 0, 0)));
    GameObject go = Instantiate(targetPrefab, transform.position + transform.up * -0.3f + transform.right * 0.1f + transform.forward * 3.0f, Quaternion.identity);
    go.GetComponent<CheckCollide>().collideEvent.AddListener(this.scoreHandler.addScore);
    go.GetComponent<CheckCollide>().collideEvent.AddListener(this.SpawnTarget);
    go.transform.forward = -transform.right;
  }
}
