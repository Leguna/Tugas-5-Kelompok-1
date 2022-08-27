using System.Collections;
using Agate.MVC.Base;
using Agate.MVC.Core;
using SpacePlan.Module.SaveGame;
using TankU.Sound;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem.UI;
using TankU.Setting;
using TankU.Main;
using TankU.Gameplay;
using UnityEngine.SceneManagement;

namespace TankU.Boot
{
    public class GameMain : BaseMain<GameMain>, IMain
    {
        protected override IController[] GetDependencies()
        {
            return new IController[]
            {
                new SaveDataController(),
                new SettingController(),
                new SoundController()
            };
        }

        protected override IEnumerator StartInit()
        {
            CreateEventSystem();
            //SpawnSetting();
            yield return null;
        }

        protected override IConnector[] GetConnectors()
        {
            return new IConnector[]
            {
                new SettingConnector()
            };
        }

        private void CreateEventSystem()
        {
            GameObject obj = new GameObject("Event System");
            obj.AddComponent<EventSystem>();
            obj.AddComponent<InputSystemUIInputModule>();
            DontDestroyOnLoad(obj);
        }

        public void SpawnSetting()
        {
            GameObject prefab = Resources.Load<GameObject>("Prefabs/SettingPanel");
            Transform canvas = GameObject.Find("Canvas").transform;
            SettingView settingView = Instantiate(prefab, canvas.position, Quaternion.identity).GetComponent<SettingView>();
        
            if (canvas)
            {
                settingView.transform.SetParent(canvas);
            }
        
            MainView mainView = FindObjectOfType<MainView>().GetComponent<MainView>();
            mainView._settingView = settingView;
            
            SettingModel settingModel = new SettingModel();
            SettingController settingController = new SettingController();
            settingController.Init(settingModel);
        }
    }
}