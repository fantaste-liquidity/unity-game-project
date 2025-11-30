using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;


public class FlapyFollow : MonoBehaviour
{
    [SerializeField] private float followSpeed = 5f;

    private Camera _cam;
    private Rigidbody2D _rb;
    private Vector2 _targetPos;

    private void Start()
    {
        _cam = Camera.main;
        _rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        // mouse ekran pozisyonu
        Vector2 mouseScreenPos = Mouse.current.position.ReadValue();

        Vector3 mouseWorldPos3 = _cam.ScreenToWorldPoint(new Vector3(mouseScreenPos.x, mouseScreenPos.y, 0f));

        _targetPos = new Vector2(mouseWorldPos3.x, mouseWorldPos3.y);
    }

    private void FixedUpdate()
    {
        Vector2 newPos = Vector2.Lerp(_rb.position, _targetPos, followSpeed * Time.fixedDeltaTime);
        _rb.MovePosition(newPos);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log($"Collision -> temas edilen obje: {collision.gameObject.name}, tag: {collision.gameObject.tag}");

        // temas yakalama
        if (collision.gameObject.CompareTag("Ground") || collision.gameObject.CompareTag("Engel"))
        {
            Debug.Log("Ground veya Engel'e çarptım, GameOver!");
            GameManager.Instance?.GameOver();
        }
    }
}

