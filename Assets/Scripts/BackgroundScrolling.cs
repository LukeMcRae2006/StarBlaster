using UnityEngine;

public class BackgroundScrolling : MonoBehaviour
{
    [SerializeField] Vector2 moveSpeed;

    Vector2 offset;
    Material mat;

    void Start()
    {
        mat = GetComponent<SpriteRenderer>().material;
    }

    void Update()
    {
        offset += moveSpeed * Time.deltaTime;
        mat.mainTextureOffset = offset;
    }
}
