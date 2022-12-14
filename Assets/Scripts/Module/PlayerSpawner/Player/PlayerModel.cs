using Agate.MVC.Base;
using UnityEngine;

namespace TankU.Gameplay
{
    public class PlayerModel : BaseModel, IPlayerModel
    {
        public string Name { get; set; }
        public int Speed { get; set; }
        public int Health { get; protected set; }
        public bool PowerUpIsActive { get; protected set; }
        public float PowerUpDuration { get; protected set; }
        public int PlayerNumber { get; private set; }

        public Vector3 Position { get; set; } = new Vector3(0, 0.3f, 0);
        public Vector3 Velocity { get; protected set; }
        public Vector2 RotateDirec { get; protected set; }
        public Transform Head { get; protected set; }

        public Material MaterialColor { get; private set; }
        public float CoolDownPowerUpShoot { get; private set; }

        public void SetFireCooldown(float coolDown)
        {
            CurrentFireCoolDown = coolDown;
        }

        public void OnTick(float deltaTime)
        {
            PowerUpDuration -= deltaTime;
            CurrentFireCoolDown -= deltaTime;
            if (PowerUpDuration <= 0f)
            {
                PowerUpIsActive = false;
            }

            SetDataAsDirty();
        }

        public float CurrentFireCoolDown { get; private set; }
        public float FireRate => 1f;

        public PlayerModel()
        {
            Speed = 2;
            Name = "player";
            Health = 5;
        }

        public PlayerModel(int playerNumber, Material material) : this()
        {
            PlayerNumber = playerNumber;
            MaterialColor = material;
        }

        public void SpawnPlayer(Vector3 position, Vector2 direction)
        {
            Position = position;
            RotateDirec = direction;
            SetDataAsDirty();
        }

        public void SetPosition(Vector3 vector)
        {
            Position = vector;
            SetDataAsDirty();
        }

        public void SetSpeed(int speed)
        {
            Speed = speed;
            SetDataAsDirty();
        }

        public virtual void Move(Vector3 moveVelocity)
        {
            SetVelocity(moveVelocity);
            SetDataAsDirty();
        }

        private void SetVelocity(Vector3 moveVelocity)
        {
            Velocity = moveVelocity;
            SetDataAsDirty();
        }

        public virtual void Rotate(Vector2 rotate)
        {
            SetRotateDirec(rotate);
            SetDataAsDirty();
        }

        public void SetRotateDirec(Vector2 rotateDirec)
        {
            RotateDirec = rotateDirec;
            SetDataAsDirty();
        }

        public void SetHead(Transform transform)
        {
            Head = transform;
            SetDataAsDirty();
        }

        public void TakeDamage(int damage)
        {
            Health -= damage;
            SetDataAsDirty();
        }

        public void SetDurationPowerUp(float duration)
        {
            PowerUpDuration = duration;
            PowerUpIsActive = true;
            SetDataAsDirty();
        }

        public void SetHealth(int health)
        {
            Health = health;
            SetDataAsDirty();
        }

        public void AddHealth(int i)
        {
            if (Health >= 5) return;
            Health += i;
            SetDataAsDirty();
        }

        public void SetMaterialColor(Material material)
        {
            MaterialColor = material;
            SetDataAsDirty();
        }

        public void SetCanMove(bool value)
        {
            CanMove = value;
        }

        public bool CanMove { get; private set; }
    }
}