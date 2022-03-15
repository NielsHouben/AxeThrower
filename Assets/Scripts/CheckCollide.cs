using UnityEngine;
using UnityEngine.Events;

public class CheckCollide : MonoBehaviour
{
  public UnityEvent collideEvent;
  //   public ScoreHandler scoreHandler;

  void OnCollisionEnter(Collision coll)
  {
    collideEvent?.Invoke();

    Destroy(coll.gameObject);
    Destroy(gameObject);
  }
}
