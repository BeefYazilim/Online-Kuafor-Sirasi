﻿using BeefKuaforSiram.Core.Domain;
using BeefKuaforSiram.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BeefKuaforSiram.Persistence.Repositories
{
    public class KuaforTrasSaatiAralikRepository : Repository<KuaforTrasSaatiAralik>, IKuaforTrasSaatiAralikRepository
    {
        public KuaforTrasSaatiAralikRepository(PlutoContext context) : base(context)
        {
        }
        public PlutoContext PlutoContext
        {
            get { return Context as PlutoContext; }
        }
    }
}