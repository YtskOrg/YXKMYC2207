﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YT.Suofeiya.Menu
{
    public interface IMenuAppService
    {
        Task<MenuDto> GetMenu();
    }
}
