
using Agate.MVC.Base;
using TankU.Message;
using TankU.Module.ColourPicker;

namespace TankU.Gameplay
{
    public class GameplayConnector : BaseConnector
    {
        private PlayerController _player;
        //private SFXController _sfx;

        private void OnMoveInput(InputMoveMessage message)
        {
            _player.OnMove(message.Direction);
        }

        private void OnRotatedInput(InputRotateMessage message)
        {
            _player.OnRotate(message.Direction);
        }

        private void OnFire(FireMessage message)
        {
            _player.OnFire();
        }

        private void OnBomb(BombMessage message)
        {
            _player.OnBomb();
        }

        protected override void Connect()
        {
            Subscribe<InputMoveMessage>(OnMoveInput);
            Subscribe<InputRotateMessage>(OnRotatedInput);
            Subscribe<FireMessage>(OnFire);
            Subscribe<BombMessage>(OnBomb);
        }

        protected override void Disconnect()
        {
            Unsubscribe<InputMoveMessage>(OnMoveInput);
            Unsubscribe<InputRotateMessage>(OnRotatedInput);
            Unsubscribe<FireMessage>(OnFire);
            Unsubscribe<BombMessage>(OnBomb);
        }
    }
}