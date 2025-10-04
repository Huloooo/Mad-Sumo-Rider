using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;            // The player
    public Vector3 offset = new Vector3(0, 10, -10);
    public float smoothSpeed = 5f;      // Higher = snappier, Lower = smoother

    void LateUpdate()
    {
        if (!target) return;

        // Desired camera position
        Vector3 desiredPos = target.position + offset;

        // Smoothly interpolate between current and desired position
        transform.position = Vector3.Lerp(transform.position, desiredPos, smoothSpeed * Time.deltaTime);

        // Always look at the player
        transform.LookAt(target.position);
    }
}
