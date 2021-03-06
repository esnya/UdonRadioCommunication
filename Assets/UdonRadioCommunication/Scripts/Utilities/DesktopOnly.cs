using UdonSharp;
using UnityEngine;
using VRC.SDKBase;

namespace UdonRadioCommunication
{
    [UdonBehaviourSyncMode(BehaviourSyncMode.None)]
    public class DesktopOnly : UdonSharpBehaviour
    {
        private void Start()
        {
            if (Networking.LocalPlayer.IsUserInVR()) gameObject.SetActive(false);
        }
    }
}
