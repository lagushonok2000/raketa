using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{
    [SerializeField] private PlayerMovement _playerMovement;
    [SerializeField] private FuelProgressBar _progressBar;
    private bool _isPressed;

    private void Update()
    {
        Vertical(Input.GetAxisRaw("Vertical"));
        Horizontal(Input.GetAxisRaw("Horizontal"));
        if (Input.GetMouseButtonDown(0)) LKM();
        if (Input.GetMouseButtonDown(1)) PKM();
        if (Input.GetKeyDown(KeyCode.Space)) Space();

    }
    public void Vertical (float value)
    {
        if (_isPressed == false && value != 0)
        {
            _progressBar.Move();
            _playerMovement.MoveVertical(value);
        }
        if (value != 0) _isPressed = true;
        if (value == 0) _isPressed = false;
    }

    private void Horizontal(float value)
    {
        //_playerMovement.Rotate(value);
        _playerMovement.MoveHorizontal(value);
    }

    private void LKM()
    {
        
    }

    private void PKM()
    {
        
    }

    private void Space()
    {
        _playerMovement.SetStop();
    }
}
