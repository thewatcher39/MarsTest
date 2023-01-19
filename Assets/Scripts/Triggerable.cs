using System;
using UnityEngine;

namespace WatcherHome
{
    [RequireComponent(typeof(Collider))]
    public abstract class Triggerable : MonoBehaviour
    {
        protected abstract void TriggerEnter(Collider other);
        protected abstract void TriggerExit(Collider other);
        
        private void OnTriggerEnter(Collider other)
        {
            TriggerEnter(other);
        }

        private void OnTriggerExit(Collider other)
        {
            TriggerExit(other);
        }
    }
}