
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour

{
    public delegate void StartTouchEvent(Vector2 position, float time);
    public event StartTouchEvent OnStartTouch;
    public delegate void EndTouchEvent(Vector2 position, float time);
    public event StartTouchEvent OnEndTouch;

    private TouchControllers touchControllers;

    private void Awake()
    {
        touchControllers =  new TouchControllers();

    }

    private void OnEnable()
    {
        touchControllers.Enable();
    }

    private void OnDisable()
    {
        touchControllers.Disable();
    }

    private void Start()
    {
        touchControllers.Touch.TouchPress.started += ctx => StartTouch(ctx);
        touchControllers.Touch.TouchPress.canceled += ctx => EndTouch(ctx);
    }

    private void StartTouch(InputAction.CallbackContext context)
    {
        Debug.Log("Touch Started" + touchControllers.Touch.TouchPosition.ReadValue<Vector2>());
        if (OnStartTouch != null) OnStartTouch(touchControllers.Touch.TouchPosition.ReadValue<Vector2>(), (float)context.startTime);
    }
    private void EndTouch(InputAction.CallbackContext context)
    {
        Debug.Log("Touch ended");
        if (OnEndTouch != null) OnEndTouch(touchControllers.Touch.TouchPosition.ReadValue<Vector2>(), (float)context.time);
    }

}
