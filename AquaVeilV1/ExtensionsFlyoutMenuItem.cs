using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquaVeilV1
{
    public class ExtensionsFlyoutMenuItem
    {
        public ExtensionsFlyoutMenuItem()
        {
            TargetType = typeof(ExtensionsFlyoutMenuItem);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}