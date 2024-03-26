using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FuelProgressBar : MonoBehaviour
{
    [SerializeField] private Image _fuelProgressBar;
    [SerializeField,Range(0,100)] private float _percentOfConsumption;
    [SerializeField] private PlayerMovement _playerMovement;
    private float _subvalue;
    private bool _endFuel;

    private void Start()
    {
        _subvalue = _percentOfConsumption / 100;
    }
    public void Move()
    {
        if (_endFuel) return;
        _fuelProgressBar.fillAmount -= _subvalue;

        if (_fuelProgressBar.fillAmount == 0)
        {
            _playerMovement.SetFuelStop(true);
            _endFuel = true;
        }
    }
}
