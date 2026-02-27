using UnityEngine;

public class ToggleLight : InterectObject
{
    public AudioClip lightOnAudio;
    public AudioClip lightOffAudio;
    public PlaySoundEffects playSoundEffects;
    public GameObject light;


    private void Start()
    {
        light.SetActive(false);
    }

    private void OnMouseDown()
    {
        if (ChekInterect() == false) return;

        IsActive = !IsActive;
        light.SetActive(IsActive);

        if (IsActive == true) playSoundEffects.PlayEffect(lightOnAudio);
        else playSoundEffects.PlayEffect(lightOffAudio);
    }
}
