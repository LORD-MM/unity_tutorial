using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class BallImpactSound : MonoBehaviour
{
    [Tooltip("The sound clip to play on impact.")]
    [SerializeField] private AudioClip impactClip;

    [Tooltip("Minimum collision speed required to trigger the sound.")]
    [SerializeField] private float minVelocityThreshold = 0.5f;

    private AudioSource audioSource;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Ignore tiny resting vibrations/jitters
        if (collision.relativeVelocity.magnitude >= minVelocityThreshold)
        {
            if (impactClip != null)
            {
                // PlayOneShot lets rapid impacts overlap without cutting each other off
                audioSource.PlayOneShot(impactClip);
            }
        }
    }
}