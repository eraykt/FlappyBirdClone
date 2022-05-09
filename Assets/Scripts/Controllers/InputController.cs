using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Birdie.Controllers
{
    public class InputController
    {
        public bool LeftClick => Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space);
       
    }

}
