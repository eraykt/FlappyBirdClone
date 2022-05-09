using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Birdie.ui
{
    public class Panel : MonoBehaviour
    {
        public void OpenPanel()
        {
            gameObject.SetActive(true);
        }

        public void ClosePanel()
        {
            gameObject.SetActive(false);
        }
    }

}
