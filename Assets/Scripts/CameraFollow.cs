using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform _player;
    private Vector3 _newPosition;
    private void Update()
    {
        _newPosition = new Vector3(_player.position.x, _player.position.y, transform.position.z);
        transform.position = _newPosition;
    }
}
