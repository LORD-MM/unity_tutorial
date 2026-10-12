using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    [Header("Cycle Settings")]
    [Tooltip("Total duration of a full 360° day/night cycle in real-time seconds.")]
    [Min(0.1f)]
    [SerializeField] private float dayDurationInSeconds = 120f;

    [Tooltip("Axis of rotation. Vector3.right rotates around local X (pitch).")]
    [SerializeField] private Vector3 rotationAxis = Vector3.right;

    [Tooltip("Space to apply the rotation.")]
    [SerializeField] private Space rotationSpace = Space.Self;

    private void Update()
    {
        if (dayDurationInSeconds <= 0f) return;

        // A full day is a 360-degree rotation
        float degreesPerSecond = 360f / dayDurationInSeconds;

        transform.Rotate(rotationAxis, degreesPerSecond * Time.deltaTime, rotationSpace);
    }
}