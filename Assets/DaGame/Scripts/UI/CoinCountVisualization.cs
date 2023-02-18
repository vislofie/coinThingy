using UnityEngine;
using TMPro;

public class CoinCountVisualization : MonoBehaviour
{
    private TMP_Text _coinCount;

    private void Awake()
    {
        _coinCount = GetComponent<TMP_Text>();

        ScoreManager.Instance.OnCoinRegister += OnCoinUpdate;
        ScoreManager.Instance.OnReachingGoalScore += OnCoinGoalReached;
        
    }

    private void OnCoinUpdate()
    {
        _coinCount.text = ScoreManager.Instance.Score.ToString() + "/10";
    }

    private void OnCoinGoalReached()
    {
        _coinCount.enabled = false;
    }
}
