using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // 이동 속도
    Rigidbody2D rb;              // 물리 컴포넌트 담는 통
    Vector2 moveInput;           // 입력값 저장용

    void Start()
    {
        // 시작할 때 내 몸에 붙은 Rigidbody 2D를 찾아온다
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // 매 프레임마다 키보드 입력을 체크 (WASD, 방향키)
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        // 입력받은 방향 정보를 저장
        moveInput = new Vector2(x, y).normalized;
    }

    void FixedUpdate()
    {
        // 실제 물리적인 이동은 여기서 처리 (속도 = 방향 * 속력)
        rb.linearVelocity = moveInput * moveSpeed;
    }
}