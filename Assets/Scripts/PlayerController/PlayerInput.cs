using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public float horizontalInput = 0;
    public float verticalInput = 0;

    [SerializeField] private Joystick joystick;

    private void Update()
    {
        InputForPhone();
    }

    public void InputForPhone()
    {
        horizontalInput = joystick.Horizontal;
        verticalInput = joystick.Vertical;
    }
}
