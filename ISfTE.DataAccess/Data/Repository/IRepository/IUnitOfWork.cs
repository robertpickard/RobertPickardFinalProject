using System;
using System.Collections.Generic;
using System.Text;

namespace ISfTE.DataAccess.Data.Repository.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        IAbstractRepository Abstract { get;  }
        IAbstractRatingRepository AbstractRating { get;  }
        IApplicationUserRepository ApplicationUser { get;  }
        ICountryRepository Country { get;  }
        ICountryTypeRepository CountryType { get;  }
        IGuestRepository Guest { get;  }
        IRegistrationRepository Registration { get;  }
        void Save();
    }
}
