using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour,IFollowCamera
{
  [SerializeField] private Transform _playerTransform;

  private Transform _cachedTransform;
  
  private void Start()
  {
    _cachedTransform = transform;
  }

  private void Update()
  {
    _cachedTransform.position = new Vector3(_playerTransform.position.x, _playerTransform.position.y, transform.position.z);
  }
}
