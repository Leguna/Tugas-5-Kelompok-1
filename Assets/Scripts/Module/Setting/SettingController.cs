using System.Collections;
using Agate.MVC.Base;
using TankU.Message;
using TankU.Sound;
using UnityEngine.Events;

namespace TankU.Setting
{
    public class SettingController : ObjectController<SettingController, SettingModel, ISettingModel, SettingView>
    {
        public void Init(SettingModel model, SettingView settingView)
        {
            _model = model;
            SetView(settingView);
        }

        public override IEnumerator Initialize()
        {
            return base.Initialize();
        }

        public void ShowSettingPanel(ShowSettingMessage msg)
        {
            _view.Show();
        }

        public void OnTurnSFX()
        {
            _model.SetSfxToggle();
            Publish(new SoundSettingsUpdateMessage(false));
        }

        public void OnTurnBGM()
        {
            _model.SetBgmToggle();
            Publish(new SoundSettingsUpdateMessage(true));
        }

        public void BackToMainMenu()
        {
            _view.Close();
        }

        public override void SetView(SettingView view)
        {
            base.SetView(view);
            _view.SetCallback(OnTurnSFX, OnTurnBGM, BackToMainMenu);
        }

        public void SetClickListener(UnityAction onMatchHistory, UnityAction onExit)
        {
            _view.SetClickListener(onMatchHistory, onExit);
        }
    }
}