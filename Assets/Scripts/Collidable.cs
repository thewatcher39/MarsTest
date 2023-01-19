using System;
using UnityEngine;

namespace WatcherHome
{
    [RequireComponent(typeof(Collider))]
    public abstract class Collidable : MonoBehaviour
    {
        protected abstract void ColliderEnter(Collision other);
        protected abstract void ColliderExit(Collision other);
        
        private void OnCollisionEnter(Collision other)
        {
            ColliderEnter(other);
        }

        private void OnCollisionExit(Collision other)
        {
            ColliderExit(other);
        }
    }
}