using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchemaStore
{
    class ProductDto
    {
        public string productNN { get; set; }
        public string productName { get; set; }
        public int ostatok { get; set; }
        public int order { get; set; }
        public int preorder { get; set; }
        public int virtualOstatok { get; set; }
        public int orderedCount { get; set; }
        public double orderedSum { get; set; }
        public int deliveredCount { get; set; }
        public double deliveredSum { get; set; }

        public ProductDto(
            string productNN,
            string productName,
            int ostatok,
            int order,
            int preorder,
            int virtualOstatok,
            int orderedCount,
            double orderedSum,
            int deliveredCount,
            double deliveredSum)
        {
            this.ostatok = ostatok;
            this.order = order;
            this.preorder = preorder;
            this.virtualOstatok = virtualOstatok;
            this.orderedCount = orderedCount;
            this.orderedSum = orderedSum;
            this.deliveredCount = deliveredCount;
            this.deliveredSum = deliveredSum;
        }
    }
}
