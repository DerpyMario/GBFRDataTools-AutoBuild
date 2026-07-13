using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Entities;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field)]
public class GameSupportAttribute : Attribute
{
    public string Text { get; set; }

    public GameSupportAttribute(string version)
    {
        Text = version;
    }
}
