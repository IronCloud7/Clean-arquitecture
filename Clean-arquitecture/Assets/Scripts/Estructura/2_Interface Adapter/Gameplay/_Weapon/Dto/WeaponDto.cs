namespace Assets.Scripts.Estructura._2_Interface_Adapter
{
    public class WeaponDto
    {
        private string _id;
        private string _name;
        private int _damage;
        private float attackRange;
        private float secondsBetweenAttacks;
        public string Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public int Damage { get => _damage; set => _damage = value; }
        public float AttackRange { get => attackRange; set => attackRange = value; }
        public float SecondsBetweenAttacks { get => secondsBetweenAttacks; set => secondsBetweenAttacks = value; }
    }
}
