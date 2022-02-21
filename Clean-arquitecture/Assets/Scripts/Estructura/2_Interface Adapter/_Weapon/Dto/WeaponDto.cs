namespace Assets.Scripts.Estructura._2_Interface_Adapter
{
    public class WeaponDto
    {
        private string id;
        private string nombre;
        private float danyo;

        public string Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public float Danyo { get => danyo; set => danyo = value; }
    }
}
