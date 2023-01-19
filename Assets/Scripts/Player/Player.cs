using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WatcherHome
{
    [RequireComponent(typeof(Rigidbody), typeof(Animator))]
    public class Player : MonoBehaviour
    {
        [SerializeField] private Joystick _joystick;
        
        public PlayerInventory playerInventory;
        private PlayerMovement _playerMovement;
        private PlayerAnimator _playerAnimator;

        private Action OnUpdate;
        private Action OnFixedUpdate;

        private void Start()
        {
            _playerMovement = new PlayerMovement(_joystick, gameObject, 2, ref OnFixedUpdate);
            _playerAnimator = new PlayerAnimator(_joystick, gameObject.GetComponent<Animator>(), ref OnUpdate);
            playerInventory = new PlayerInventory();
        }

        private void FixedUpdate()
        {
            OnFixedUpdate?.Invoke();
        }

        private void Update()
        {
            OnUpdate?.Invoke();
        }
    }
}