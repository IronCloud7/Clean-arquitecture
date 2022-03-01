using Assets.Scripts.Utils;
using UnityEngine;

namespace Assets.Scripts.Estructura._3_Framework
{
    public class UnityInputAdapter : Input
    {
        public bool Button1() => UnityEngine.Input.GetKey(KeyCode.Keypad0);
        public bool Button2() => UnityEngine.Input.GetKey(KeyCode.Keypad1);
        public bool Button3() => UnityEngine.Input.GetKey(KeyCode.Keypad2);
        public bool Button4() => UnityEngine.Input.GetKey(KeyCode.Keypad3);
        public bool Button5() => UnityEngine.Input.GetKey(KeyCode.Keypad4);
        public bool Button6() => UnityEngine.Input.GetKey(KeyCode.Keypad5);
        public bool Button7() => UnityEngine.Input.GetKey(KeyCode.Keypad6);
        public bool Button8() => UnityEngine.Input.GetKey(KeyCode.Escape);
        public float HAxis() => UnityEngine.Input.GetAxisRaw("Horizontal");
        public float VAxis() => UnityEngine.Input.GetAxisRaw("Vertical");
    }
}
