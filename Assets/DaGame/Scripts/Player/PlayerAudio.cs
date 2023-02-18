using UnityEngine;

public class PlayerAudio : MonoBehaviour
{
    [SerializeField]
    private AudioClip _badCoinPickup;
    [SerializeField]
    private AudioClip _goodCoinPickup;

    private AudioSource _audioSource;

    private void Awake()
    {
        ScoreManager.Instance.OnCoinRegister += OnGoodCoinPickup;
        ScoreManager.Instance.OnBadCoinRegister += OnBadCoinPickup;

        _audioSource = GetComponent<AudioSource>();
    }

    /// <summary>
    /// Plays an audio clip of a coin that was picked up
    /// </summary>
    private void OnGoodCoinPickup()
    {
        _audioSource.Stop();
        _audioSource.clip = _goodCoinPickup;

        _audioSource.Play();
    }

    /// <summary>
    /// Plays an audio clip of a bad red coin that was picked up
    /// </summary>
    private void OnBadCoinPickup()
    {
        _audioSource.Stop();
        _audioSource.clip = _badCoinPickup;

        _audioSource.Play();
    }

    
}
