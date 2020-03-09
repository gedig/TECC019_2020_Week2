using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Characters.FirstPerson;

public class PauseController : MonoBehaviour
{
    [SerializeField] private GameObject _pausePanel = null;
    private FirstPersonController _fpsController = null;
    [SerializeField] private string _menuScene = null;
    [SerializeField] AudioMixer _bgmMixer = null;
    [SerializeField] AudioMixer _sfxMixer = null;

    private bool _paused = false;

    void Awake()
    {
        _fpsController = GameObject.FindGameObjectWithTag("Player")?.GetComponent<FirstPersonController>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            TogglePause();
        }
    }

    public void TogglePause()
    {
        _paused = !_paused;
        _pausePanel.SetActive(_paused);
        if (_fpsController != null)
        {
            _fpsController.enabled = !_paused;
        }

        Cursor.visible = _paused;
        Cursor.lockState = _paused ? CursorLockMode.Confined : CursorLockMode.Locked;
        Time.timeScale = _paused ? 0.0f : 1.0f;
    }

    public void Restart()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Quit()
    {
        SceneManager.LoadScene(_menuScene);
    }

    public void UpdateBGM(float val)
    {
        _bgmMixer?.SetFloat("BGMVol", Mathf.Log10(val) * 20);
    }

    public void UpdateSFX(float val)
    {
        _sfxMixer?.SetFloat("SFXVol", Mathf.Log10(val) * 20);
    }
}
