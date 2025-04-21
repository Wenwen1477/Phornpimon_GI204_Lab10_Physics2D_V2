using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float Speed = 5f; // ��Ѻ�������Ǩҡ Inspector

    private Rigidbody2D rb2d;
    private float move;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>(); // �֧ Rigidbody2D �Ҩҡ����Ф�
    }

    void Update()
    {
        move = Input.GetAxis("Horizontal"); // �Ѻ��� A/D ���� ?? (��Ҩ����������ҧ -1 �֧ 1)
    }

    void FixedUpdate()
    {
        // ����͹���੾����᡹ X ������� Y �繤�һѨ�غѹ
        rb2d.velocity = new Vector2(move * Speed, rb2d.velocity.y);
    }
}
