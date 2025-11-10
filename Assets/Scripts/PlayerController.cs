using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public InputActionReference moveAction;
    public Vector3 moveVector;
    public float playerSpeed;

    void Update()
    {
        Move();
    }

    void Move()
    {
        moveVector = moveAction.action.ReadValue<Vector2>();
        transform.position += moveVector * playerSpeed * Time.deltaTime;
    }
}
