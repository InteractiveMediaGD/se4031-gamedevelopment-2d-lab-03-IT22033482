using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [Header("Movement")]
    public float speed = 5f;

    private float _timer = 0f;

    private void Update()
    {
        // Lab sheet: timer to gradually increase speed
        _timer += Time.deltaTime;

        // Get input from new Input System (works with WASD/Arrow keys)
        float x = 0f;
        float y = 0f;

        if (Keyboard.current != null)
        {
            if (Keyboard.current.aKey.isPressed || Keyboard.current.leftArrowKey.isPressed) x -= 1f;
            if (Keyboard.current.dKey.isPressed || Keyboard.current.rightArrowKey.isPressed) x += 1f;
            if (Keyboard.current.sKey.isPressed || Keyboard.current.downArrowKey.isPressed) y -= 1f;
            if (Keyboard.current.wKey.isPressed || Keyboard.current.upArrowKey.isPressed) y += 1f;
        }

        Vector2 move = new Vector2(x, y);

        float currentSpeed = speed + _timer * 0.3f;

        transform.Translate(move * currentSpeed * Time.deltaTime);
    }
}


