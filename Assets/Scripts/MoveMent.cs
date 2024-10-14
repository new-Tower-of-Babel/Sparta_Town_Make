using System;
using Unity.VisualScripting;
using UnityEngine;

public class MoveMent : MonoBehaviour
{
    [SerializeField] private SpriteRenderer characterRenderer;
    private Controller controller;
    private Rigidbody2D movementRigidbody2D;


    private Vector2 movementDirection = Vector2.zero;

    private void Awake()
    {
        controller = GetComponent<Controller>();
        movementRigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        controller.OnMoveEvent += Move;
        controller.OnLookEvent += OnLookAim;
    }

    private void OnLookAim(Vector2 vector)
    {
        RotateLook(vector);
    }

    private void RotateLook(Vector2 vector)
    {
        float rotZ = Mathf.Atan2(vector.y, vector.x) * Mathf.Rad2Deg;
        characterRenderer.flipX = Mathf.Abs(rotZ) > 90f;
    }

    private void FixedUpdate()
    {
        ApplyMovement(movementDirection);
    }

    private void Move(Vector2 direction)
    {
        movementDirection = direction;
    }
    private void ApplyMovement(Vector2 direction)
    {
        direction = direction *5;
        movementRigidbody2D.velocity = direction;
    }
}
