using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Models.Domain;

public class Stats
{
    public int Start { get; set; }

    public int End { get; set; }

    public object Items { get; set; }

    public int To {  get; set; }
}
