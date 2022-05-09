using Birdie.Controllers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Birdie.Spawners
{
    public class ObstacleSpawner : MonoBehaviour
    {
        //[Header("Time")]
        //[Range(0f, 2f)]
        //[SerializeField] float _minTime = 2f;
        //[Range(0f, 6f)]
        //[SerializeField] float _maxTime = 5f;
        float currentTime;
        float timeBoundary;
        [SerializeField] EnemyController[] _enemy;


        private void Update()
        {
            timeBoundary = 2f; //Random.Range(_minTime, _maxTime);
            currentTime += Time.deltaTime;

            if (currentTime > timeBoundary)
            {
                EnemyController e = Instantiate(_enemy[Random.Range(0, 3)], transform.position, transform.rotation);
                e.transform.parent = this.transform;
                currentTime = 0f;
            }
        }

    }

}
