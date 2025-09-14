using UnityEngine;

public class Pendulum : MonoBehaviour
{
    [SerializeField] float maxAngle = 45f;
    [SerializeField] float speed = 2f;

    void Update()
    {
        float angle = maxAngle * Mathf.Sin(Time.time * speed);
        transform.localRotation = Quaternion.Euler(0, 0, angle);
    }
}
