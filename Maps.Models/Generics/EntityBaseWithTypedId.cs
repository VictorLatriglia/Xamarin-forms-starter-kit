namespace Maps.Models.Generics
{
    public class EntityBaseWithTypedId<Tid> : IEntityWithTypedId<Tid>
    {
        public Tid Id { get; set; }
    }
}
