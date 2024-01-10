using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sandbox
{
    public class GameManager : MonoBehaviour
    {
        private static GameManager _instance;

        public static GameManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    SetupInstance();
                }
                return _instance;
            }
        }

        public GameUIManager GameUIManager { get; private set; }

        private void Awake()
        {
            // if this is the first instance, make this the persistent singleton
            if (_instance == null)
            {
                _instance = this;
                DontDestroyOnLoad(this.gameObject);
            }
            // otherwise, remove any duplicates
            else
            {
                Destroy(gameObject);
            }
        }

        private static void SetupInstance()
        {
            // lazy instantiation
            _instance = FindObjectOfType<GameManager>();

            if (_instance == null)
            {
                GameObject gameObj = new GameObject();
                gameObj.name = "GameManager";
                DontDestroyOnLoad(gameObj);
                _instance = gameObj.AddComponent<GameManager>();
                _instance.InitManagers();
            }
        }

        private void InitManagers()
        {
            GameUIManager = new GameUIManager();
        }
    }
}
