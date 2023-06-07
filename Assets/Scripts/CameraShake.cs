using UnityEngine;

public class CameraShake : MonoBehaviour
{
    public Transform cameraTransform;

    private float shakeDuration = 0f;
    private float shakeMagnitude = 0.1f;
    private float dampingSpeed = 1.0f;
    private Vector3 initialPosition;

    private void Awake()
    {
        if (cameraTransform == null)
        {
            cameraTransform = GetComponent(typeof(Transform)) as Transform;
        }
    }

    private void OnEnable()
    {
        initialPosition = cameraTransform.localPosition;
    }

    private void Update()
    {
        if (shakeDuration > 0)
        {
            cameraTransform.localPosition = initialPosition + Random.insideUnitSphere * shakeMagnitude;

            shakeDuration -= Time.deltaTime * dampingSpeed;
        }
        else
        {
            shakeDuration = 0f;
            cameraTransform.localPosition = initialPosition;
        }
    }

    public void Shake()
    {
        shakeDuration = 0.1f;
    }
}