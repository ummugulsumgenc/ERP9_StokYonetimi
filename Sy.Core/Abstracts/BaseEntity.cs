using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sy.Core.Abstracts
{
    public abstract class BaseEntity<TKey> : IEntity1<TKey>
    {
        public TKey Id { get; set; }
    }
}
