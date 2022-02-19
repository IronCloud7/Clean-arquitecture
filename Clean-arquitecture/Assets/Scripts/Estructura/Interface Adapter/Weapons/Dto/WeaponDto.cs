namespace Assets.Scripts.Estructura.Interface_Adapter.Dto.Weapons
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
