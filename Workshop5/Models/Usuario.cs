using System.Collections.Generic;

namespace Workshop5.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public virtual ICollection<Nota> Notas { get; set; }
    }

  
}
