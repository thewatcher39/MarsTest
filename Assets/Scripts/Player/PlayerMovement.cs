using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WatcherHome
{
    public class PlayerMovement
    {
        private readonly Joystick _joystick;

        private readonly float _speed;

        private readonly GameObject player;
        private readonly Rigidbody _rigidbody;

        private float _prevRotation;

        public PlayerMovement(Joystick joystick, GameObject player, float speed, ref Action OnFixedUpdate)
        {
            _joystick = joystick;
            this.player = player;
            _speed = speed;
            _rigidbody = player.GetComponent<Rigidbody>();
            OnFixedUpdate += Move;
            OnFixedUpdate += Rotate;
        }

        private void Move()
        {
            Vector3 direction = new Vector3(_joystick.Horizontal * _speed, 0, _joystick.Vertical * _speed);
            _rigidbody.AddForce(direction, ForceMode.VelocityChange);
        }

        private void Rotate()
        {
            if (_joystick.IsDraging)
            {
                float turnY = _prevRotation;
                turnY = Mathf.Atan2(_joystick.Vertical, _joystick.Horizontal) * Mathf.Rad2Deg;
                turnY -= 90;
                Quaternion rotation =
                    Quaternion.Euler(player.transform.rotation.x, (turnY * -1), player.transform.rotation.z);
                _rigidbody.MoveRotation(rotation);
                _prevRotation = turnY;
            }
        }
    }
}