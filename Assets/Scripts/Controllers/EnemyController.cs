using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Birdie.Controllers
{
    public class EnemyController : MonoBehaviour
    {
        float _lifeTime = 2.5f;
        float _currentTime;

        private void Update()
        {
            _currentTime += Time.deltaTime;
            if (_currentTime > _lifeTime)
            {
                Destroy(this.gameObject);
            }
        }
    }

}
