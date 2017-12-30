using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace XF_ListView9
{
    public class Agrupamento<TK, T> : ObservableCollection<T>
    {
        public TK Grupo { get; private set; }

        public Agrupamento(TK grupo, IEnumerable<T> items)
        {
            Grupo = grupo;
            foreach (var item in items)
                Items.Add(item);
        }
    }
}
