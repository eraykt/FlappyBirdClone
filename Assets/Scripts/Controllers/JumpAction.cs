using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Birdie.Controllers
{
    public class JumpAction : MonoBehaviour
    {
        public void Jump(Rigidbody2D rigidbody2D, float jumpPower)
        {
            rigidbody2D.velocity = Vector2.zero;
            rigidbody2D.AddForce(Vector2.up * jumpPower);
        }
    }

}
