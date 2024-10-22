using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class IngameUi : MonoBehaviour
{
    Input _input;

    InputAction _tab;
    InputAction _esc;
    InputAction _map;

    public GameObject _helpTab;
    public GameObject _settings;
    public GameObject _mapS;

    public AudioMixer _sfxMixer, _musicMixer;

    private float sfxVolume, musicVolume;
    public Slider sfxSlider, musicSlider;

    Movement _movement;


    private void Awake()
    {
        _input = new Input();
    }

    private void Start()
    {
        _movement = GetComponent<Movement>();
    }

    private void OnEnable()
    {
        _input.Enable();

        _tab = _input.Ui.Tab;
        _esc = _input.Ui.Esc;
        _map = _input.Ui.Map;

        _tab.started += Tab;

        _map.started += Map;

        _esc.started += Esc;
    }

    private void OnDisable()
    {
        _input.Disable();

        _tab = null;
        _esc = null;
        _map = null;
    }

    public void Tab(InputAction.CallbackContext context)
    {
        if(context.started && _helpTab.activeInHierarchy)
        {
            _helpTab.SetActive(false);
        }

        else if (context.started && !_helpTab.activeInHierarchy)
        {
            _helpTab.SetActive(true);
        }
    }

    public void Map(InputAction.CallbackContext context)
    {
        //if (context.started && _mapS.activeInHierarchy)
        //{
        //    _mapS.SetActive(false);
        //}

        //else if (context.started && !_mapS.activeInHierarchy)
        //{
        //    _mapS.SetActive(true);
        //}
    }

    public void Esc(InputAction.CallbackContext context)
    {
        if (context.started && _settings.activeInHierarchy)
        {
            _settings.SetActive(false);
            _sfxMixer.SetFloat("Volume", 0);
            _movement.enabled = true;
        }

        else if (context.started && !_settings.activeInHierarchy)
        {
            _settings.SetActive(true);
            _sfxMixer.SetFloat("Volume", -100);
            _movement.enabled = false;
        }
    }

    public void EscBack()
    {
        _settings.SetActive(false);
        _sfxMixer.SetFloat("Volume", 0);
        _movement.enabled = true;
    }
}
