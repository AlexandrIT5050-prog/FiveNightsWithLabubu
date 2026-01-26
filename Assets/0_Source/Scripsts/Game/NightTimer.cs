using System.Collections;
using TMPro;
using UnityEngine;

public class NightTimer : MonoBehaviour
{
    public VictoryCheker victoryCheker;
    public TextMeshProUGUI timerText;
    public int endHour = 6;
    public int secondsPerHour = 30;

    private int currentHour = 0;

    private void Start()
    {
        StartCoroutine(HourTime());
    }

    private IEnumerator HourTime()
    {
        while (currentHour < endHour)
        {
            yield return new WaitForSeconds(secondsPerHour);
            currentHour++;
            RefreshUI();
        }
        victoryCheker.Win();
        
    }

    private void RefreshUI()
    {
        timerText.text = $"{currentHour:00}:00 Am";
    }
}
