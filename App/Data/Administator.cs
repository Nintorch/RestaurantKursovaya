using System;
using System.Collections.Generic;

namespace App.Data
{
    public partial class Administator
    {
        public string Login { get; set; } = null!;
        public string? Passwordhash { get; set; }
    }
}
