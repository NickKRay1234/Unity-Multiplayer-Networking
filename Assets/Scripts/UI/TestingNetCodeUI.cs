﻿using Unity.Netcode;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    public class TestingNetCodeUI : MonoBehaviour
    {
        [SerializeField] private Button _startHostButton;
        [SerializeField] private Button _startClientButton;

        private void Awake()
        {
            _startHostButton.onClick.AddListener(() =>
            {
                Debug.Log("HOST");
                NetworkManager.Singleton.StartHost();
                Hide();
            });
            
            _startClientButton.onClick.AddListener(() =>
            {
                Debug.Log("CLIENT");
                NetworkManager.Singleton.StartClient();
                Hide();
            });
        }

        private void Hide()
        {
            gameObject.SetActive(false);
        }
    }
}