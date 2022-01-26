
    using System;
    using UnityEngine;
    using Zenject;

    public class PlayerController:MonoBehaviour,IPlayerController
    {

        [Inject] private ICharacterStats _playerDefaultStats;
        [Inject] private ICharacterStats _playerCurrentStats;
        
        
        public void ApplyBaseDamage()
        {
            
        }
    }


