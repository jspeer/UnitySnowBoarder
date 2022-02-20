using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnscaledTimeParticle : MonoBehaviour
{
    private void Update()
    {
        // If timescale is 0, then we're paused, trigger the attached particle effect
        if (Time.timeScale < 0.01f) {
            GetComponent<ParticleSystem>().Simulate(Time.unscaledDeltaTime, true, false);
        }
    }
}
