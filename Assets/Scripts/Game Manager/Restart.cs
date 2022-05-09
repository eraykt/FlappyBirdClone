using Birdie.ui;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Birdie.Gamemanager
{
    public class Restart : MonoBehaviour
    {

        Panel _panel;

        private void Awake()
        {
            _panel = GetComponent<Panel>();
        }

        public void RestartEvent()
        {
            Time.timeScale = 1;
            GameManager.Instance.RestartGame();
            _panel.ClosePanel();
        }
    }
}

