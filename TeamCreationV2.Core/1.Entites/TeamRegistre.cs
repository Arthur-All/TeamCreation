using TeamCreationV2.Domain.Entites.Base;

namespace TeamCreationV2.Core.Entites
{
    public class TeamRegistre : BaseEntite
    {
        public string TeamDescription { get; set; }
        public string Photo { get; set; }

       // public virtual List<Persons> Persons { get; set; } /*In progress*/
    }
}
