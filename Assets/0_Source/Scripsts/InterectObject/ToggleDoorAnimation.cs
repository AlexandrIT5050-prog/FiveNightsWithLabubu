using UnityEngine;

public class ToggleDoorAnimation : InterectObject
{
    public AudioClip openDoorAudio;
    public AudioClip closeDoorAudio;
    public PlaySoundEffects playSoundEffects;

    private string nameOpenAnimation = "Open";
    private bool isActive;
    private Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
       
    }

    private void OnMouseDown() {

        if (ChekInterect() == false) return;

        isActive = !isActive;
        animator.SetBool(nameOpenAnimation, isActive);

        if (isActive == true) playSoundEffects.PlayEffect(openDoorAudio);
        else playSoundEffects.PlayEffect(closeDoorAudio);
    }
}
