/**
 * The HiNet License
 *
 * Copyright HiNet. All rights reserved.
 * Use is subject to license terms.
 */

/** 
* @author  NAMDV
*/

using Model.eAita;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class VaitroThaotacRepository : GenericRepository<VAITRO_THAOTAC>
    {
        public VaitroThaotacRepository() : base()
        {
        }
        public VaitroThaotacRepository(Entities context)
            : base(context)
        {
        }
    }
}