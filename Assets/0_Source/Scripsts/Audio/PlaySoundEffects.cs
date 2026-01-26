using UnityEngine;

public class PlaySoundEffects : MonoBehaviour
{
    private AudioSource audioSource;

    private void Start() {
        audioSource = GetComponent<AudioSource>();
    }
    public void PlayEffect(AudioClip audio) {
        audioSource.PlayOneShot(audio);
    }
}
