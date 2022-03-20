using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RadarMVC.Models
{
  public class Palindrome
  {
    // use capital letters for public properties of a class
    public string InputWord { get; set; }
    public string RevWord { get; set; }
    public bool IsPalindrome { get; set; }
    public string Message { get; set; }

  }
}
