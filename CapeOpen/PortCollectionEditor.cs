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
            return new UnitPort("输入端口1", "输入端口1", CapePortDirection.CAPE_INLET, CapePortType.CAPE_MATERIAL);
        }

        protected override CollectionForm CreateCollectionForm()
        {
            return base.CreateCollectionForm();
        }

        protected override Type[] CreateNewItemTypes()
        {
            return base.CreateNewItemTypes();
        }
    }
}
