using UnityEngine;
using TMPro;

public class ScoreHandler : MonoBehaviour
{
  private TMP_Text text;

  private int score = -1;

  void Awake()
  {
    text = GetComponent<TextMeshProUGUI>();
  }

  void Start()
  {
    this.addScore();
  }

  public void addScore()
  {
    text.SetText("Score: {0}", ++score);
  }
}
