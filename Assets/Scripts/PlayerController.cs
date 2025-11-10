using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public InputActionReference moveAction;
    public Vector3 moveVector;
    public float playerSpeed;
    Vector2 minBounds, maxBounds;
    [SerializeField] private float leftPadding, rightPadding, upPadding, downPadding;

    void Start()
    {
        Camera mainCamera = Camera.main;
        minBounds = mainCamera.ViewportToWorldPoint(new Vector2(0, 0));
        maxBounds = mainCamera.ViewportToWorldPoint(new Vector2(1, 1));
    }

    void Update()
    {
        Move();
    }

    void Move()
    {
        moveVector = moveAction.action.ReadValue<Vector2>();
        Vector3 newPos = transform.position + moveVector * playerSpeed * Time.deltaTime;
        newPos.x = Math.Clamp(newPos.x, minBounds.x + leftPadding, maxBounds.x - rightPadding);
        newPos.y = Math.Clamp(newPos.y, minBounds.y + downPadding, maxBounds.y - upPadding);
        transform.position = newPos;
    }
}
