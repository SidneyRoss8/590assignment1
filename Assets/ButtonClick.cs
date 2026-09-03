using UnityEngine;
using UnityEngine.InputSystem;

public class ButtonClick : MonoBehaviour
{
    public BallPrefab ballPrefab;

    void Update()
    {
        bool pressed = false;

        if (Touchscreen.current != null)
            pressed = Touchscreen.current.press.wasPressedThisFrame;
        else if (Mouse.current != null)
            pressed = Mouse.current.leftButton.wasPressedThisFrame;

        if (pressed)
        {
            BallPrefab ball = Instantiate<BallPrefab>(ballPrefab);
            ball.transform.position = transform.position;

            Rigidbody rb = ball.GetComponent<Rigidbody>();
            if (rb != null)
                rb.AddForce(Camera.main.transform.forward * UnityEngine.Random.Range(10, 20), ForceMode.Impulse);
        }
    }
}