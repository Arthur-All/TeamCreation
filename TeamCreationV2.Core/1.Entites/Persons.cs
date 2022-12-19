using TeamCreationV2.Domain.Entites.Base;

namespace TeamCreationV2.Core.Entites
{
    public class Persons : BaseEntite
    {
        public string Email { get; set; }
        public string Descrition { get; set; }
        public string Photo { get; set; }
        public string Password { get; set; }
        public bool Adm { get; set; }
       // public virtual List<TeamRegistre> TeamRegistre { get; set; }

    }
}
