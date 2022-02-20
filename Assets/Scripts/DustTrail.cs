using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustTrail : MonoBehaviour
{
    [SerializeField] string groundTag;
    [SerializeField] ParticleSystem snowParticles;

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == groundTag) {
            snowParticles.Play();
        }
    }

    void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.tag == groundTag) {
            snowParticles.Stop();
        }
    }
}
