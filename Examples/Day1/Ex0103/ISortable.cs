using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex0103 {
  internal interface ISortable {
    bool Swap(object obj, object sortCriteria);
  }
}
