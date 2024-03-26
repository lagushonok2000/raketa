using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMove : MonoBehaviour
{
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private Material _backgroundMaterial;
    [SerializeField] private float _backgroundMoveSpeed;

    private void Update()
    {
        _backgroundMaterial.mainTextureOffset = _backgroundMoveSpeed * _playerTransform.position;
    }
}
