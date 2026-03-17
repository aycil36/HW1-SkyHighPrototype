using UnityEngine;
using UnityEngine.InputSystem;

public class FlightController : MonoBehaviour
{
    public float pitchSpeed = 60f;
    public float yawSpeed = 60f;
    public float rollSpeed = 60f;
    public float thrust = 10f;

    void Update()
    {
        if (Keyboard.current == null)
            return;

        float pitch = 0f;
        float yaw = 0f;
        float roll = 0f;

        if (Keyboard.current.upArrowKey.isPressed)
            pitch = -1f;

        if (Keyboard.current.downArrowKey.isPressed)
            pitch = 1f;

        if (Keyboard.current.leftArrowKey.isPressed)
            yaw = -1f;

        if (Keyboard.current.rightArrowKey.isPressed)
            yaw = 1f;

        if (Keyboard.current.qKey.isPressed)
            roll = 1f;

        if (Keyboard.current.eKey.isPressed)
            roll = -1f;

        transform.Rotate(Vector3.right * pitch * pitchSpeed * Time.deltaTime, Space.Self);
        transform.Rotate(Vector3.up * yaw * yawSpeed * Time.deltaTime, Space.Self);
        transform.Rotate(Vector3.forward * roll * rollSpeed * Time.deltaTime, Space.Self);

        if (Keyboard.current.spaceKey.isPressed)
        {
            transform.Translate(Vector3.forward * thrust * Time.deltaTime, Space.Self);
        }
    }
}