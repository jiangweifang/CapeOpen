using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapeOpen
{
    internal class PortCollectionEditor : CollectionEditor
    {
        public PortCollectionEditor(Type type) : base(type)
        {
        }

        protected override object CreateInstance(Type itemType)
        {
            return new UnitPort("新建端口", "备注", CapePortDirection.CAPE_INLET, CapePortType.CAPE_MATERIAL);
        }
    }
}
