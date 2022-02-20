namespace Assets.Scripts.Estructura._1_Aplication.Hero.Models
{
    public class HeroInputData
    {
        private float _horizontalAxis;
        private float _verticalAxis;

        public HeroInputData(float horizontalAxis, float verticalAxis)
        {
            _horizontalAxis = horizontalAxis;
            _verticalAxis = verticalAxis;
        }

        public float HorizontalAxis { get => _horizontalAxis; set => _horizontalAxis = value; }
        public float VerticalAxis { get => _verticalAxis; set => _verticalAxis = value; }
    }
}
