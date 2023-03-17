using UnityEngine;
using System.Collections;

public class AudioManager : MonoBehaviour {

    private AudioSource audioSrc;

    void Start() {
        audioSrc = GetComponent<AudioSource>();
        if (audioSrc == null) {
            Debug.LogError("Aucun AudioSource trouvé sur cet objet!");
        }
    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.Space)) {
            if (audioSrc != null) {
                if (audioSrc.isPlaying) {
                    audioSrc.Pause();
                } else {
                    audioSrc.Play();
                }
            }
        }

        if (Input.GetKeyDown(KeyCode.Escape)) {
            if (audioSrc != null) {
                audioSrc.Stop();
            }
        }
    }
}
