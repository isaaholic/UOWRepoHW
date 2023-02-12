using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UOWRepoHW.Models;

public class Faculty : BaseEntity
{
    public string? Name { get; set; }

    public List<Group>? Groups { get; set; }
}