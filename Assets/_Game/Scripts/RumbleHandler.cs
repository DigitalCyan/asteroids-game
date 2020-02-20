using UnityEngine;
using System.Collections;
using XInputDotNetPure;

class RumbleHandler{
    static public IEnumerator Rumble(float t, float s){
        GamePad.SetVibration(0, s, s);
        yield return new WaitForSeconds(t);
        GamePad.SetVibration(0, 0, 0);
    }
}