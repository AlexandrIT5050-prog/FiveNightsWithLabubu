using UnityEngine;

public class ToggleDoorAnimation : InterectObject
{
    public AudioClip openDoorAudio;
    public AudioClip closeDoorAudio;
    public PlaySoundEffects playSoundEffects;

    private string nameOpenAnimation = "Close";
    private Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
       
    }

    private void OnMouseDown() {

        if (ChekInterect() == false) return;

        IsActive = !IsActive;
        animator.SetBool(nameOpenAnimation, IsActive);

        if (IsActive == false) playSoundEffects.PlayEffect(openDoorAudio);
        else playSoundEffects.PlayEffect(closeDoorAudio);
    }
}
