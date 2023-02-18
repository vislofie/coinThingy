using UnityEngine;
using TMPro;

public class VictoryTextToggle : MonoBehaviour
{
    private TMP_Text _victoryText;

    private void Awake()
    {
        _victoryText = GetComponent<TMP_Text>();
        _victoryText.enabled = false;

        ScoreManager.Instance.OnReachingGoalScore += ToggleVictoryText;
    }

    /// <summary>
    /// Toggles text that congratulates a player of their victory
    /// </summary>
    private void ToggleVictoryText()
    {
        _victoryText.enabled = true;
    }
}
