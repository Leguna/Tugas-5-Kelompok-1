using System.Collections;
using Agate.MVC.Base;
using TankU.Gameplay;
using TankU.Message;
using TankU.Sound;
using UnityEngine;

namespace TankU.Module.PlayerSpawner.Player
{
    public class PlayerController : ObjectController<PlayerController, PlayerModel, IPlayerModel, PlayerView>
    {
        private Rigidbody _rg;
        private const float CoolDownBombMax = 5f;
        private float _coolDownBomb;

        public override void SetView(PlayerView view)
        {
            view.SetCallbacks(Move, Rotate, Init, OnMove, CoolDownTimer, OnTakeDamageEvent, OnUpdate,
                OnGetPowerUpBounce, OnGetPowerUpHealth, UpdateDataPlayer);
            view.TryGetComponent(out _rg);
            base.SetView(view);
            _model.SetHead(_view.transform.GetChild(0));
        }

        private void OnUpdate(float deltaTime)
        {
            _model.OnTick(deltaTime);
        }

        private void OnTakeDamageEvent(int damage)
        {
            if (!_model.CanMove) return;
            _model.TakeDamage(damage);
            if (_model.Health <= 0)
            {
                Publish(new PlayerDeadMessage(_model.PlayerNumber));
                _view.gameObject.SetActive(false);
            }

            UpdateDataPlayer();
            Publish(new PlaySoundEffectMessage(SoundEffectName.Hit));
            Publish(new UpdatePlayerHealth(_model.Health, _model.PlayerNumber));
        }

        public override IEnumerator Initialize()
        {
            yield return base.Initialize();
            _model.SetPosition(new Vector3(0, 0.3f, 0));
        }

        private void Move()
        {
            if (!_model.CanMove) return;
            if (_model.Health <= 0) return;

            _rg.velocity = _model.Velocity * _model.Speed;
            _model.SetPosition(_rg.velocity);
            Publish(new TankMoveMessage(_view.transform));
        }
          
        internal void OnBomb(int playerNumber)
        {
            if (!_model.CanMove) return;
            if (_model.Health <= 0) return;
            if (_coolDownBomb <= 0f)
            {
                if (_model.PlayerNumber != playerNumber) return;
                Transform bulletSpawner = _model.Head.GetChild(0);
                Publish(new BombSpawnMessage(bulletSpawner.transform));
                // TODO @Leguna: Choose this or From Bomb Pool
                // Transform bombPool = _model.Head.GetChild(2);
                // Publish(new SpawnBombMessage(bombPool.transform));

                Debug.Log($"Boomb...! {playerNumber + 1}");
                _coolDownBomb = CoolDownBombMax;
            }
        }

        public void CoolDownTimer()
        {
            if (_coolDownBomb >= 0) _coolDownBomb -= 1f * Time.deltaTime;
        }

        private void Rotate()
        {
            if (!_model.CanMove) return;

            if (_model.Health <= 0) return;

            _model.Head.transform.Rotate(0, _model.RotateDirec.x, _model.RotateDirec.y, Space.Self);
        }

        public void OnMove(Vector3 direction, int playerNumber)
        {
            if (_model.Health <= 0) return;

            if (_model.PlayerNumber != playerNumber) return;
            _model.Move(direction);
        }

        internal void OnRotate(Vector2 direction, int playerNumber)
        {
            if (_model.Health <= 0) return;

            if (_model.PlayerNumber != playerNumber) return;
            _model.Rotate(direction);
        }

        public void OnGetPowerUpBounce(float duration)
        {
            _model.SetDurationPowerUp(duration);
            Publish(new PlaySoundEffectMessage(SoundEffectName.PowerUpBounce));
            UpdateDataPlayer();
        }

        public void OnGetPowerUpHealth(int health)
        {
            _model.AddHealth(health);
            Publish(new PlaySoundEffectMessage(SoundEffectName.PowerUpHealth));
            UpdateDataPlayer();
        }

        public void OnFire(int playerNumber)
        {
            if (!_model.CanMove) return;
            if (_model.CurrentFireCoolDown > 0) return;
            if (_model.Health <= 0) return;
            if (_model.PlayerNumber != playerNumber) return;
            _model.SetFireCooldown(_model.FireRate);
            Transform bulletSpawner = _model.Head.GetChild(0);
            Publish(new SpawnBulletMessage(bulletSpawner.transform, _model.PowerUpDuration, _model.PowerUpIsActive));
        }

        public void Init(PlayerModel model, PlayerView view)
        {
            _model.SetCanMove(false);
            _model = model;
            SetView(view);
            _model.SetPosition(new Vector3(0, 0.3f, 0));
            _model.SetHead(_view.transform.GetChild(0));
            view.gameObject.SetActive(false);
        }

        public void SetCanMove(bool value)
        {
            _model.SetCanMove(value);
        }

        private void UpdateDataPlayer()
        {
            Publish(new PlayerStatusMessage(_model.Health, _model.PowerUpIsActive, _model.PlayerNumber));
        }

        public void SpawnPlayer(Transform transform, int index)
        {
            _model.SetPosition(transform.position);
            _model.Name = ($"player{index}");
            _model.SetRotateDirec(new Vector2(transform.localRotation.x, transform.localRotation.y));
        }

        public void ChangeMaterial(Material material)
        {
            _model.SetMaterialColor(material);
        }

        public void ShowPlayer()
        {
            _view.gameObject.SetActive(true);
        }
    }
}