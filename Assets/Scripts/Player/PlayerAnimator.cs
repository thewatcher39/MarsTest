using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using UnityEngine;

namespace WatcherHome
{
    public class PlayerAnimator
    {
        private readonly Joystick _joystick;
        
        private readonly Animator _animator;

        public PlayerAnimator(Joystick joystick, Animator animator, ref Action OnUpdate)
        {
            _joystick = joystick;
            _animator = animator;
            OnUpdate += ExecuteAnimation;
        }

        private void ExecuteAnimation()
        {
            if (_joystick.Vertical == 0)
                _animator.SetInteger("AnimationPar", 0);
            else
                _animator.SetInteger("AnimationPar", 1);   
        }
    }
}