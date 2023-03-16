using UnityEngine;
using System.Collections;

public class AudioManager : MonoBehaviour {

    private AudioSource audioSrc;

    void Start() {
        audioSrc = GetComponent<AudioSource>();
    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.Space)) {
            if (audioSrc.isPlaying) {
                audioSrc.Pause();
            } else {
                audioSrc.Play();
            }
        }

        if (Input.GetKeyDown(KeyCode.Escape)) {
            audioSrc.Stop();
        }
    }
}