
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstPWA.Services
{
    public interface IPasswordService
    {
        public string GeneratePassword(int passwordLength);
    }
}
