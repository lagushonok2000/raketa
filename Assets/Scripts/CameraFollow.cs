using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform _player;
    private Vector3 _newPosition;
    private Transform _camera;

    private void Start()
    {
        _camera = Camera.main.transform;
    }
    private void Update()
    {
        _newPosition = new Vector3(_player.position.x, _player.position.y, _camera.position.z);
        _camera.position = _newPosition;
    }
}
