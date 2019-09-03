using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sy.Core.Abstracts
{
    public interface IEntity1<TKey>
    {
        TKey Id
        { get; set; }
    }
} 
