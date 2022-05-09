using Birdie.Controllers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Birdie.Spawners
{
    public class TrophySpawner : MonoBehaviour
    {
        [SerializeField] TrophyController _trophy;

        protected float _timer;
        int luckynumber;

        private void Update()
        {
            _timer += Time.deltaTime;
            SpawnChance();
        }

        void SpawnChance()
        {
            if (_timer > 5f)
            {
                luckynumber = Random.Range(1, 11);
                if (luckynumber < 10)//4)
                {
                    Spawn();
                    _timer = 0f;
                }
                else
                    _timer = 0f;
            }
        }

        void Spawn()
        {
            Instantiate(_trophy, new Vector3(this.transform.position.x, Random.Range(-1.4f, 3.6f), transform.position.z), Quaternion.identity, this.transform);
        }



    }

}
