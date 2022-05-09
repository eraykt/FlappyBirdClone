using Birdie.ui;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Birdie.Obstacles
{
    public class Dead : MonoBehaviour
    {
        [SerializeField] Panel _panel;

        private void Awake()
        {
            //_panel = GetComponent<Panel>();
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            Debug.Log("dead");
            Time.timeScale = 0f;
            _panel.OpenPanel();
        }
    }

}
