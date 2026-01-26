using UnityEngine;

public class ToggleLight : MonoBehaviour
{
    public AudioClip lightOnAudio;
    public AudioClip lightOffAudio;
    public PlaySoundEffects playSoundEffects;
    public GameObject light;

    private bool isActive;

    private void Start()
    {
        light.SetActive(false);
    }

    private void OnMouseDown()
    {
        isActive = !isActive;
        light.SetActive(isActive);

        if (isActive == true) playSoundEffects.PlayEffect(lightOnAudio);
        else playSoundEffects.PlayEffect(lightOffAudio);
    }
}
