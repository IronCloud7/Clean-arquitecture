using Assets.Scripts.Utils;

namespace Assets.Scripts.Estructura._2_Interface_Adapter
{
    public class HeroViewModel
    {
        private HeroConfiguration _configuration;

        private bool _isGround;
        private bool _isRunning;
        private float _deltaTime;

        private ReactiveProperty<float> _hAxisPressed;
        private ReactiveProperty<float> _vAxisPressed;
        private readonly ReactiveCommand _button1Pressed;
        private readonly ReactiveCommand _button2Pressed;
        private readonly ReactiveCommand _button3Pressed;
        private readonly ReactiveCommand _button4Pressed;
        private readonly ReactiveCommand _button5Pressed;
        private readonly ReactiveCommand _button6Pressed;
        private readonly ReactiveCommand _button7Pressed;
        private readonly ReactiveCommand _button8Pressed;

        public HeroViewModel(HeroConfiguration configuration)
        {
            _configuration = configuration;

            _hAxisPressed = new ReactiveProperty<float>(default);
            _vAxisPressed = new ReactiveProperty<float>(default);

            _button1Pressed = new ReactiveCommand();
            _button2Pressed = new ReactiveCommand();
            _button3Pressed = new ReactiveCommand();
            _button4Pressed = new ReactiveCommand();
            _button5Pressed = new ReactiveCommand();
            _button6Pressed = new ReactiveCommand();
            _button7Pressed = new ReactiveCommand();
            _button8Pressed = new ReactiveCommand();

            _movement = new ReactiveProperty<float>(default);
            _jumpVelocity = new ReactiveProperty<float>(default);
            _doAttack = new ReactiveProperty<bool>(default);

        }

        
        public string Id => _configuration.Id;
        public string Name => _configuration.HeroData.Name;
        public int MaxHealth => _configuration.HeroData.Attributes.Health;
        public string WeaponId => _configuration.HeroData.Attributes.Weapon;

        public ReactiveProperty<float> HAxisPressed { get => _hAxisPressed; set => _hAxisPressed = value; }
        public ReactiveProperty<float> VAxisPressed { get => _vAxisPressed; set => _vAxisPressed = value; }

        public ReactiveCommand Button1Pressed => _button1Pressed;
        public ReactiveCommand Button2Pressed => _button2Pressed;
        public ReactiveCommand Button3Pressed => _button3Pressed;
        public ReactiveCommand Button4Pressed => _button4Pressed;
        public ReactiveCommand Button5Pressed => _button5Pressed;
        public ReactiveCommand Button6Pressed => _button6Pressed;
        public ReactiveCommand Button7Pressed => _button7Pressed;
        public ReactiveCommand Button8Pressed => _button8Pressed;

        public bool IsGrounded { get => _isGround; set => _isGround = value; }
        public float DeltaTime { get => _deltaTime; set => _deltaTime = value; }

        private ReactiveProperty<float> _movement;
        private ReactiveProperty<float> _jumpVelocity;
        private ReactiveProperty<bool> _doAttack;

        public ReactiveProperty<float> Movement { get => _movement; set => _movement = value; }
        public ReactiveProperty<float> JumpVelocity { get => _jumpVelocity; set => _jumpVelocity = value; }
        public ReactiveProperty<bool> DoAttack { get => _doAttack; set => _doAttack = value; }
        public bool IsRunning { get => _isRunning; set => _isRunning = value; }


     
    }
}

