using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterMovement : MonoBehaviour
{
    [SerializeField] private float speed = 10f;
    [SerializeField] private float jumpForce = 100f;
    [SerializeField] private GameObject water;
    [SerializeField] private float waterBuffer = 0.2f;
    [SerializeField] private float waterPowerSide = 100f;
    [SerializeField] private float waterPowerDown = 100f;

    public Rigidbody2D controller;
    private float _velocityX;
    private float _velocityY;
    private bool _shootingRight;
    private float waterCheck;
    private bool _isShooting = false;

    private void Awake()
    {
        if (!controller) controller = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        controller.velocity = new Vector2(_velocityX, controller.velocity.y + _velocityY);
        _velocityY = 0f;
        
        if (waterCheck + waterBuffer <= Time.time && _isShooting)
        {
            GameObject newWater = Instantiate(water, transform.position, Quaternion.identity);
            newWater.GetComponent<Rigidbody2D>().velocity =
                (CheckGrounded() ? (_shootingRight ? Vector2.right : Vector2.left) * waterPowerSide : Vector2.down * waterPowerDown);
            waterCheck = Time.time;
        }
    }

    [UsedImplicitly]
    void OnMove(InputValue value)
    {
        _velocityX = value.Get<float>() * speed;
        if (_velocityX > 0f)
        {
            _shootingRight = true;
        }
        else if (_velocityX < 0f)
        {
            _shootingRight = false;
        }
    }

    [UsedImplicitly]
    void OnJump()
    {
        if (CheckGrounded())
            controller.AddForce(new Vector2(0f, jumpForce));
    }

    [UsedImplicitly]
    void OnSpray()
    {
        _isShooting = !_isShooting;
        if (_isShooting && !CheckGrounded())
        {
            if (controller.velocity.y >= 1f)
                controller.velocity = Vector2.up * 10f;
            else
                controller.velocity = Vector2.up;
        }
    }

    bool CheckGrounded()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position + (Vector3.down * 1.1f), Vector2.down, 0.1f);
        if (hit.transform != null)
            if (hit.transform.CompareTag("Water")) return false;
            else return true;
        return false;
    }
}
