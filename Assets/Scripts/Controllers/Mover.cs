using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Birdie.Controllers
{
    public class Mover : MonoBehaviour
    {
        protected Rigidbody2D _rigidbody2D;
        [SerializeField] protected float _speed;

        private void Awake()
        {
            _rigidbody2D = GetComponent<Rigidbody2D>();
        }

        private void FixedUpdate()
        {
            _rigidbody2D.velocity = Vector2.left * _speed;
        }
    }

}
