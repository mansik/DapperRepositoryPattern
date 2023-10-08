using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperRepositoryPattern
{
    /// <summary>
    /// internal 접근 지정자를 사용하면 메서드의 인자로 클래스를 전달할 수 없어서 public로 하였음
    /// </summary>
    public class Product
    {
        public required string ProductId { get; set; }
        public string? ProductName { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
