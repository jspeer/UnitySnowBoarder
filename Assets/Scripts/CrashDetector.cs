using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrashDetector : MonoBehaviour
{
    [Header("Crash Settings")]
    [SerializeField] string groundTag;
    [SerializeField] string sceneToLoad = "Game";
    [SerializeField] float reloadSceneTimeout = 1f;
    [SerializeField] AudioClip crashSoundSfx;
    [SerializeField] float crashSoundVolume = .5f;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == groundTag) {
            // Play the SFX
            GetComponent<AudioSource>().PlayOneShot(crashSoundSfx, crashSoundVolume);
            // Pause game and call reload scene
            StartCoroutine(FindObjectOfType<GameManager>().LoadSceneWithTimer(sceneToLoad, reloadSceneTimeout));
        }
    }
}
