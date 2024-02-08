using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SoulSystem.Business.Core.Models
{
    public abstract class Entity
    {
        protected Entity()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public Guid CriadoPor { get; set; }
        public DateTime CriadoEm {  get; set; }
        public Guid AlteradoPor { get; set; }
        public DateTime AlteradoEm { get; set; }
    
    }
}