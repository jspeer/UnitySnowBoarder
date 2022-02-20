using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLine : MonoBehaviour
{
    [Header("Win Settings")]
    [SerializeField] string sceneToLoad = "Game";
    [SerializeField] string playerTag = "Player";
    [SerializeField] float reloadSceneTimeout = 1f;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == playerTag) {
            // Play the SFX
            GetComponent<AudioSource>().Play();
            // Pause game and call reload scene
            StartCoroutine(FindObjectOfType<GameManager>().LoadSceneWithTimer(sceneToLoad, reloadSceneTimeout));
        }
    }
}
