﻿using EntitiesLayer.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IDevicesRepository : IGenericRepostory<Devices>
    {
        IQueryable<Devices> GetDevices(int id, bool trackchanges);
    }
}
