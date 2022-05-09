using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Birdie.Spawners;

namespace Birdie.Controllers
{
    public class TrophyController : Mover
    {
        private void Awake()
        {
            _rigidbody2D = GetComponent<Rigidbody2D>();
        }

        private void Start()
        {
            _speed = 3f;
        }

        private void Update()
        {
            if (this.transform.position.x < -3)
            {
                Destroy(this.gameObject);
            }
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            Debug.Log("abi bana bast?n az önce");
            Destroy(this.gameObject);
        }
    }

}
