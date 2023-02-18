using System;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public event Action OnCoinRegister = delegate { };
    public event Action OnReachingGoalScore = delegate { };
    public event Action OnBadCoinRegister = delegate { };

    private static ScoreManager _instance;
    public static ScoreManager Instance
    {
        get
        {
            if (_instance == null)
                _instance = FindObjectOfType<ScoreManager>();
            return _instance;
        }
    }

    [SerializeField]
    [Tooltip("How much score is needed to complete the game")]
    private int _scoreGoal = 10;

    public int Score { get; private set; }

    private void Start()
    {
        Score = 0;
    }

    /// <summary>
    /// Registers picking up coin
    /// </summary>
    public void RegisterCoin()
    {
        Score++;
        OnCoinRegister();

        if (Score >= _scoreGoal)
        {
            OnReachingGoalScore();
            SceneLoadManager.Instance.LoadSceneAfterGivenTime(SceneLoadManager.Instance.CurrentSceneIndex, 5.0f);
        }
    }

    /// <summary>
    /// Registers picking up bad red coin
    /// </summary>
    public void RegisterBadCoin()
    {
        OnBadCoinRegister();

        SceneLoadManager.Instance.LoadSceneAfterGivenTime(SceneLoadManager.Instance.CurrentSceneIndex, 1.0f);
    }

    
}
