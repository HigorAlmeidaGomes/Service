using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ServiceSearchActions.Core.Entites
{
    //Classe abstrata você não consegue instanciala apenas para conter informações que serão reutilizadas.
    public abstract class BaseEntity
    {
        public int Id { get; private set; }
        public BaseEntity()
        {

        }
    }
}
