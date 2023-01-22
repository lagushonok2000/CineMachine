using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCutScene : MonoBehaviour
{
    [SerializeField] private GameObject _currentCam;
    [SerializeField] private GameObject _nextCam;
    [SerializeField] private Movement _playerMovement;
    [SerializeField] private Animator _playerAnimator;
    [SerializeField] private Animator _catAnimator;
    [SerializeField] private GameObject _canvas;
    [SerializeField] private GameObject _timeLine2;

    private void OnTriggerEnter(Collider other)
    {
        _currentCam.SetActive(false);
        _nextCam.SetActive(true);
        _playerMovement.enabled = false;
        _playerAnimator.SetBool("run",false);
        _catAnimator.SetTrigger("sit");
        _canvas.SetActive(true);
        _timeLine2.SetActive(true);
    }
}
