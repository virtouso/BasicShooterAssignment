
    using System;
    using UnityEngine;
    using Zenject;

    public class PlayerController:MonoBehaviour,IPlayerController
    {

        [Inject] private ICharacterStats _playerDefaultStats;
        [Inject] private ICharacterStats _playerCurrentStats;

        [SerializeField] private float _moveSpeed;
        [SerializeField] private Camera _camera;
        [SerializeField] private Rigidbody2D _rigidBody;
        
        
        
        public void ApplyBaseDamage()
        {
            
        }



        private void Move()
        {
            float horizontal = Input.GetAxis("Horizontal");
            float vertical = Input.GetAxis("Vertical");

            Vector3 finalMovement = new Vector3(horizontal,vertical).normalized*_moveSpeed;
            transform.Translate(finalMovement);
            
        }

        private void Look()
        {
            Vector3 position = Input.mousePosition;
            Vector3 mouseWorldPosition = _camera.ScreenToWorldPoint(position);
            Vector3 lookDirection = mouseWorldPosition - transform.position;
            float angle = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg- 90f;
            _rigidBody.rotation = angle;
        }

        private void Update()
        {
            Move();
            Look();
        }


        private void OnTriggerExit2D(Collider2D other)
        {
            throw new NotImplementedException();
        }
    }


