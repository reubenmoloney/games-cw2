using ImprovedTimers;
using UnityEngine;
using TMPro; 

public class Timer : MonoBehaviour
{
    private StopwatchTimer _timer = new StopwatchTimer();
    public StopwatchTimer GameTimer => _timer;

    [SerializeField] private TMP_Text timerText;

    void Start()
    {
        _timer.OnTimerStart += () => Debug.Log("Timer started");
        _timer.OnTimerStop += () => Debug.Log("Timer stopped");
        _timer.Start();
    }

    void Update()
    {
        // Update UI TextMeshPro text
        if (timerText != null)
        {
            timerText.text = $"{_timer.CurrentTime:F2} sec"; //
        }
    }

    void OnDestroy()
    {
        _timer.Dispose();
    }
}