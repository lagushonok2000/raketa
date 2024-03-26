using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rigidBody;
    [SerializeField] private float _speed;
    [SerializeField] private float _stopSpeed;
    [SerializeField] private float _speedRotate;
    [SerializeField] private float _speedLimit;
    [SerializeField] private Transform _body;
    [SerializeField] private ExhauatAnimation _flames;
    private bool _fuelStop;
    private bool _stop;
    private float _step;
    private int _backpressed;
    private Vector3 _rotate;

    private void Start()
    {
        _speedRotate/= 100;
        _rotate = new Vector3(0, 0, _speedRotate); 
    }

    private void FixedUpdate()
    {
        Stop();
    }
    public void SetFuelStop(bool value)
    {
        _fuelStop = value;
        SetStop();
    }
    public void Move(float value)
    {
        if (_fuelStop) return;
        ResetStop();

        _rigidBody.AddForce(_body.up * value * _speed, ForceMode2D.Impulse);

        var x = Mathf.Clamp(_rigidBody.velocity.x, -_speedLimit, _speedLimit);
        var y = Mathf.Clamp(_rigidBody.velocity.y, -_speedLimit, _speedLimit);

        _rigidBody.velocity = new Vector2(x, y);
        _flames.Flames();
    }
    
    public void Rotate(float value)
    {
        if (value == 0) return;
        _rigidBody.AddTorque(value * -1 * _speedRotate);
        //_body.Rotate(_rotate * value * -1);
        //_rigidBody.angularVelocity = 0;
    }

    public void SetStop()
    {
        _stop = true;
        _backpressed++;
    }

    private void Stop()
    {
        if (_stop == false) return;

        _step += Time.fixedDeltaTime * _stopSpeed * _backpressed;
        _rigidBody.velocity = Vector2.MoveTowards(_rigidBody.velocity, Vector2.zero, _step);

        if (_step >= 1) ResetStop();
    }

    private void ResetStop()
    {
        _step = 0;
        _stop = false;
        _backpressed = 0;
    }
}
