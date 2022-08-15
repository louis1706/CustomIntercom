using Exiled.API.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomIntercom
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = false;

        public string CustomText { get; set; } = string.Empty;
    }
}
