namespace Assets.Scripts.Estructura._1_Aplication.Weapon.Entity
{
    public class Weapon
    {
        private string id;
        private string nombre;
        private float danyo;

        public string Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public float Danyo { get => danyo; set => danyo = value; }
    }
}
