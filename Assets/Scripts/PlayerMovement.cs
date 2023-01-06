using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    private Rigidbody2D rb;
    public float moveSpeed;

    void Start() {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update() {
        float x = Input.GetAxisRaw("Horizontal") * moveSpeed;
        float y = Input.GetAxisRaw("Vertical") * moveSpeed;
        Vector2 move = rb.position + (new Vector2(x, y));
        rb.MovePosition(move);
    }

}