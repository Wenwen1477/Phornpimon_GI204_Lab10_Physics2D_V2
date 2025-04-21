using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float Speed = 5f; // ปรับความเร็วจาก Inspector

    private Rigidbody2D rb2d;
    private float move;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>(); // ดึง Rigidbody2D มาจากตัวละคร
    }

    void Update()
    {
        move = Input.GetAxis("Horizontal"); // รับค่า A/D หรือ ?? (ค่าจะอยู่ระหว่าง -1 ถึง 1)
    }

    void FixedUpdate()
    {
        // เคลื่อนที่เฉพาะแนวแกน X โดยให้แนว Y เป็นค่าปัจจุบัน
        rb2d.velocity = new Vector2(move * Speed, rb2d.velocity.y);
    }
}
