using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private Rigidbody _playerRigidBody;
    [SerializeField] private Animator _playerAnimator;
    [SerializeField] private float _speed;

    private float _horizontal;
    private float _vertical;
    private Vector3 _velocity;

    private void FixedUpdate()
    {
        InputMethod();
        PlayerMove();
        PlayerAnimator();
    }

    private void InputMethod()
    {
        _horizontal = Input.GetAxisRaw("Horizontal");
        _vertical = Input.GetAxisRaw("Vertical");
    }

    private void PlayerMove()
    {
        _velocity = new Vector3(_horizontal, 0, _vertical) * _speed;

        _velocity = Vector3.ClampMagnitude(_velocity, _speed);
        _velocity = transform.TransformDirection(_velocity);
        _velocity.y = _playerRigidBody.velocity.y;
        _playerRigidBody.velocity = _velocity;
    }
    private void PlayerAnimator()
    {
        if (_horizontal != 0 || _vertical != 0)
        {
            _playerAnimator.SetBool("run", true);
        }
        else
        {
            _playerAnimator.SetBool("run", false);
        }
    }
}