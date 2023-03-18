using MedSoftDashboard.DbContexts;
using MedSoftDashboard.MVVM.Services.ConflictValidators;
using MedSoftDashboard.MVVM.Services.DataEditors;
using MedSoftDashboard.MVVM.Services.DataErasers;
using MedSoftDashboard.MVVM.Services.DataProviders;
using MedSoftDashboard.MVVM.Services.EntityCreators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedSoftDashboard.MVVM.Services
{
    public class DatabaseServices
    {
        #region Fields

        private readonly IDataProvider dataProvider;
        private readonly IDataCreator dataCreator;
        private readonly IDataEraser dataEraser;
        private readonly IDataEditor dataEditor;
        private readonly IDataConflictValidator dataConflictValidator;

        #endregion


        #region Properties

        public IDataProvider DataProvider => dataProvider;

        public IDataCreator DataCreator => dataCreator;

        public IDataEraser DataEraser => dataEraser;

        public IDataEditor DataEditor => dataEditor;

        public IDataConflictValidator DataConflictValidator => dataConflictValidator;

        #endregion


        #region Constructors

        public DatabaseServices(MedSoftDbContextFactory medSoftDbContextFactory)
        {
            dataProvider = new DatabaseDataProvider(medSoftDbContextFactory);
            dataCreator = new DataBaseDataCreator(medSoftDbContextFactory);
            dataEraser = new DatabaseEraser(medSoftDbContextFactory);
            dataEditor = new DatabaseDataEditor(medSoftDbContextFactory);
            dataConflictValidator = new DatabaseDataConflictValidator(medSoftDbContextFactory);
        }

        #endregion
    }
}
