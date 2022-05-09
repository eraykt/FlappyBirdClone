using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Birdie.visual
{
    public abstract class VisualMoving : MonoBehaviour
    {
        Rigidbody2D _rig;
        [SerializeField] protected Transform _teleportTransform;
        [SerializeField] protected Transform _endTransform;
        [SerializeField] protected float _speed;

        private void Awake()
        {
            _rig = GetComponent<Rigidbody2D>();
        }

        private void Start()
        {
            _rig.velocity = Vector2.left * _speed;
        }

        private void FixedUpdate()
        {
            if (this.gameObject.transform.position.x < _endTransform.position.x)
            {
                this.gameObject.transform.position = _teleportTransform.position;
            }
        }
    }

}
