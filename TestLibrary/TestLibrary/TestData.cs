using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLibrary
{
  public class TestData
  {
    public int Key { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }

    public TestData()
    {
      Key = 25;
      Name = "Test Data 1";
      Description = "Test Default Data Item";
    }
  }
}
