using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Birdie.Controllers
{
    public class PlayerController : MonoBehaviour
    {
        InputController _input;
        Rigidbody2D _rigidbody2D;
        JumpAction _jumpAction;
        bool _isJumping;


        [SerializeField] float _jumpPower = 300f;

        private void Awake()
        {
            _input = new InputController();
            _jumpAction = GetComponent<JumpAction>();
            _rigidbody2D = GetComponent<Rigidbody2D>();
        }

        private void Update()
        {
            if (_input.LeftClick)
            {
                _isJumping = true;
            }

            //_vel.Change(_rigidbody2D);
            
        }

        private void FixedUpdate()
        {
            if (_isJumping)
            {
                _jumpAction.Jump(_rigidbody2D, _jumpPower);
                _isJumping = false;
            }
        }

    }



}
